Public Class frmBorrow

    ' ClearTextboxes method clears textboxes related to borrower information
    Sub ClearTextboxes()
        BorrowerNameTextBox.Clear()
        BorrowerContactTextBox.Clear()
        BorrowerAddressTextBox.Clear()
    End Sub

    ' DisplayBookID method retrieves available books that has more than 1 availability and populates the BookIDComboBox
    Sub DisplayBookID()
        Dim t4 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM book WHERE book_Available > 1"
            adapter.SelectCommand = cmd
            adapter.Fill(t4)
            BookIDComboBox.DataSource = t4
            BookIDComboBox.DisplayMember = "book_Name"
            BookIDComboBox.ValueMember = "book_ISBN"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' DisplayNextBorrowerID method retrieves the maximum borrower ID and increments it for the next borrower
    Sub DisplayNextBorrowerID()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT MAX(borrower_ID) FROM borrower"
            Dim result As Object = cmd.ExecuteScalar()

            If result Is DBNull.Value Then
                BorrowerIDComboBox.Items.Add("1")
                BorrowerIDComboBox.Text = "1"
            Else
                Dim finalId As Integer = CInt(result) + 1

                ' Add the incremented final id value to the BorrowerIDComboBox items
                BorrowerIDComboBox.Items.Add(finalId.ToString())

                ' Set the BorrowerIDComboBox text to the incremented final id value
                BorrowerIDComboBox.Text = finalId.ToString()
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' BorrowBtn_Click method handles the borrowing process
    Private Sub BorrowBtn_Click(sender As Object, e As EventArgs) Handles BorrowBtn.Click
        ' Check if required fields are filled
        If String.IsNullOrWhiteSpace(BorrowerNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(BorrowerContactTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(BorrowerAddressTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        ' Open database connection
        openCon()
        Try
            cmd.Connection = con

            ' Insert borrower information to database
            cmd.CommandText = "INSERT borrower SET borrower_Name = @BorrowerName, borrower_Contact = @BorrowerContact, borrower_Address = @BorrowerAddress"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@BorrowerName", BorrowerNameTextBox.Text)
            cmd.Parameters.AddWithValue("@BorrowerContact", BorrowerContactTextBox.Text)
            cmd.Parameters.AddWithValue("@BorrowerAddress", BorrowerAddressTextBox.Text)

            ' Confirm borrowing action
            If MsgBox("Are you sure you want to borrow this book?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()

                ' Update book availability from database
                cmd.CommandText = "UPDATE book SET book_Available = book_TotalCopy - '" & 1 & "' WHERE book_ISBN = @BookISBN"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@BookISBN", BookIDComboBox.SelectedValue)
                cmd.ExecuteNonQuery()

                ' Insert transaction record to database
                cmd.CommandText = "INSERT INTO transaction (book_ISBN, borrower_ID) VALUES (@BookISBN, @BorrowerID)"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@BookISBN", BookIDComboBox.SelectedValue)
                cmd.Parameters.AddWithValue("@BorrowerID", BorrowerIDComboBox.Text)
                cmd.ExecuteNonQuery()

                MsgBox("Book has been borrowed!")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            ' Close database connection
            con.Close()
        End Try
    End Sub
End Class
