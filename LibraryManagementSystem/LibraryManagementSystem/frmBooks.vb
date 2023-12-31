Imports Microsoft.Office.Interop

Public Class frmBooks
    Dim exFile As Excel.Application
    Dim ProductTable As New DataTable
    Dim row As Integer

    ' View Panel
    Sub DisplayBookTable()
        ' Retrieve book information from the database and display it in the BookDGV DataGridView
        Dim BookTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT b.book_ISBN as 'ISBN', b.book_Title as 'Title', b.book_TotalCopy as 'Total Copies', " &
                              "b.book_Available as 'Available Copies', a.author_Name as 'Author', p.publisher_Name as 'Publisher', " &
                              "g.genre_Name as 'Genre' FROM book b " &
                              "INNER JOIN author a ON b.book_Author = a.author_ID " &
                              "INNER JOIN publisher p ON b.book_Publisher = p.publisher_ID " &
                              "INNER JOIN genre g ON b.book_Genre = g.genre_ID"
            adapter.SelectCommand = cmd
            BookTable.Clear()
            adapter.Fill(BookTable)
            BookDGV.DataSource = BookTable
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub ExportBtn_Click(sender As Object, e As EventArgs) Handles ExportBtn.Click
        ' Export book information to Excel
        Try
            exFile = New Excel.Application
            Dim workbook As Excel.Workbook = exFile.Workbooks.Open("C:\Users\Acer\OneDrive\Documents\Visual Studio 2013\Projects\LibraryManagementSystem\books.xlsx")
            Dim worksheet As Excel.Worksheet = DirectCast(workbook.Sheets(1), Excel.Worksheet)

            ' Write headers to Excel
            For colIndex As Integer = 1 To BookDGV.Columns.Count
                worksheet.Cells(2, colIndex).Value = BookDGV.Columns(colIndex - 1).HeaderText
            Next

            ' Write data to Excel
            row = 2
            For rowIndex As Integer = 0 To BookDGV.Rows.Count - 1
                For colIndex As Integer = 1 To BookDGV.Columns.Count
                    worksheet.Cells(row, colIndex).Value = BookDGV.Rows(rowIndex).Cells(colIndex - 1).Value.ToString()
                Next
                row += 1
            Next

            exFile.Visible = True
            exFile = Nothing
            workbook = Nothing
            worksheet = Nothing

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    ' View Panel End

    ' Add Panel
    Sub AClearTextboxes()
        ' Clear textboxes related to adding books
        ABookISBNTextBox.Clear()
        ABookTitleTextBox.Clear()
        ABookCopiesTextBox.Clear()
        ABookAuthorComboBox.SelectedIndex = -1
        ABookPublisherComboBox.SelectedIndex = -1
        ABookGenreComboBox.SelectedIndex = -1
    End Sub

    Sub ADisplayAuthorID()
        ' Display author IDs in the ABookAuthorComboBox
        Dim t1 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM author"
            adapter.SelectCommand = cmd
            adapter.Fill(t1)
            ABookAuthorComboBox.DataSource = t1
            ABookAuthorComboBox.DisplayMember = "author_Name"
            ABookAuthorComboBox.ValueMember = "author_ID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub ADisplayPublisherID()
        ' Display publisher IDs in the ABookPublisherComboBox
        Dim t2 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM publisher"
            adapter.SelectCommand = cmd
            adapter.Fill(t2)
            ABookPublisherComboBox.DataSource = t2
            ABookPublisherComboBox.DisplayMember = "publisher_Name"
            ABookPublisherComboBox.ValueMember = "publisher_ID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub ADisplayGenreID()
        ' Display genre IDs in the ABookGenreComboBox
        Dim t3 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM genre"
            adapter.SelectCommand = cmd
            adapter.Fill(t3)
            ABookGenreComboBox.DataSource = t3
            ABookGenreComboBox.DisplayMember = "genre_Name"
            ABookGenreComboBox.ValueMember = "genre_ID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BookAddBtn_Click(sender As Object, e As EventArgs) Handles BookAddBtn.Click
        ' Add a new book to the database
        If String.IsNullOrWhiteSpace(ABookISBNTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(ABookTitleTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(ABookCopiesTextBox.Text) OrElse
           ABookAuthorComboBox.SelectedIndex = -1 OrElse
           ABookPublisherComboBox.SelectedIndex = -1 OrElse
           ABookGenreComboBox.SelectedIndex = -1 Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO book (book_ISBN, book_Title, book_TotalCopy, book_Available, book_Author, book_Publisher, book_Genre) " &
                              "VALUES (@ABookISBN, @ABookTitle, @ABookCopies, @ABookCopies, @ABookAuthor, @ABookPublisher, @ABookGenre)"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ABookISBN", ABookISBNTextBox.Text)
            cmd.Parameters.AddWithValue("@ABookTitle", ABookTitleTextBox.Text)
            cmd.Parameters.AddWithValue("@ABookCopies", ABookCopiesTextBox.Text)
            cmd.Parameters.AddWithValue("@ABookAuthor", ABookAuthorComboBox.SelectedValue)
            cmd.Parameters.AddWithValue("@ABookPublisher", ABookPublisherComboBox.SelectedValue)
            cmd.Parameters.AddWithValue("@ABookGenre", ABookGenreComboBox.SelectedValue)

            If MsgBox("Do you want to save this book?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("New Book Added!")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        AClearTextboxes()
    End Sub
    ' Add Panel End

    ' Update Panel
    Sub UClearTextboxes()
        ' Clear textboxes related to updating books
        UBookTitleTextBox.Clear()
        UBookCopiesTextBox.Clear()
        UBookAuthorComboBox.SelectedIndex = -1
        UBookPublisherComboBox.SelectedIndex = -1
        UBookGenreComboBox.SelectedIndex = -1
    End Sub

    Sub UDisplayAuthorID()
        ' Display author IDs in the UBookAuthorComboBox
        Dim t4 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM author"
            adapter.SelectCommand = cmd
            adapter.Fill(t4)
            UBookAuthorComboBox.DataSource = t4
            UBookAuthorComboBox.DisplayMember = "author_Name"
            UBookAuthorComboBox.ValueMember = "author_ID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub UDisplayPublisherID()
        ' Display publisher IDs in the UBookPublisherComboBox
        Dim t5 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM publisher"
            adapter.SelectCommand = cmd
            adapter.Fill(t5)
            UBookPublisherComboBox.DataSource = t5
            UBookPublisherComboBox.DisplayMember = "publisher_Name"
            UBookPublisherComboBox.ValueMember = "publisher_ID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub UDisplayGenreID()
        ' Display genre IDs in the UBookGenreComboBox
        Dim t6 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM genre"
            adapter.SelectCommand = cmd
            adapter.Fill(t6)
            UBookGenreComboBox.DataSource = t6
            UBookGenreComboBox.DisplayMember = "genre_Name"
            UBookGenreComboBox.ValueMember = "genre_ID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub UDisplayBookISBN()
        ' Display book ISBNs in the UBookISBNComboBox
        Dim t7 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT book_ISBN FROM book"
            adapter.SelectCommand = cmd
            adapter.Fill(t7)
            UBookISBNComboBox.DataSource = t7
            UBookISBNComboBox.DisplayMember = "book_ISBN"
            UBookISBNComboBox.ValueMember = "book_ISBN"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UBookISBNComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UBookISBNComboBox.SelectedIndexChanged
        ' Display book information based on the selected book ISBN in UBookISBNComboBox
        If UBookISBNComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM book WHERE book_ISBN = '" & UBookISBNComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    UBookTitleTextBox.Text = reader.GetString("book_Title")
                    UBookCopiesTextBox.Text = reader.GetString("book_TotalCopy")
                    UBookAuthorComboBox.SelectedValue = reader.GetString("book_Author")
                    UBookPublisherComboBox.SelectedValue = reader.GetString("book_Publisher")
                    UBookGenreComboBox.SelectedValue = reader.GetString("book_Genre")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub BookUpdateBtn_Click(sender As Object, e As EventArgs) Handles BookUpdateBtn.Click
        ' Update book information based on user input
        If String.IsNullOrWhiteSpace(UBookTitleTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UBookCopiesTextBox.Text) OrElse
           UBookAuthorComboBox.SelectedIndex = -1 OrElse
           UBookPublisherComboBox.SelectedIndex = -1 OrElse
           UBookGenreComboBox.SelectedIndex = -1 Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE book SET book_Title = @UBookTitle, book_TotalCopy = @UBookCopies, " &
                              "book_Author = @UBookAuthor, book_Publisher = @UBookPublisher, book_Genre = @UBookGenre " &
                              "WHERE book_ISBN = @UBookISBN"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@UBookTitle", UBookTitleTextBox.Text)
            cmd.Parameters.AddWithValue("@UBookCopies", UBookCopiesTextBox.Text)
            cmd.Parameters.AddWithValue("@UBookAuthor", UBookAuthorComboBox.SelectedValue)
            cmd.Parameters.AddWithValue("@UBookPublisher", UBookPublisherComboBox.SelectedValue)
            cmd.Parameters.AddWithValue("@UBookGenre", UBookGenreComboBox.SelectedValue)
            cmd.Parameters.AddWithValue("@UBookISBN", UBookISBNComboBox.Text)

            If MsgBox("Are you sure you want to update this record?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Record Has Been Updated.")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        UClearTextboxes()
        UDisplayBookISBN()
    End Sub
    ' Update Panel End

    ' Delete Panel
    Sub DDisplayBookISBN()
        ' Display book ISBNs in the DBookISBNComboBox
        Dim t8 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT book_ISBN FROM book"
            adapter.SelectCommand = cmd
            adapter.Fill(t8)
            DBookISBNComboBox.DataSource = t8
            DBookISBNComboBox.DisplayMember = "book_ISBN"
            DBookISBNComboBox.ValueMember = "book_ISBN"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DBookISBNComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DBookISBNComboBox.SelectedIndexChanged
        ' Display book information based on the selected book ISBN in DBookISBNComboBox
        If DBookISBNComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM book WHERE book_ISBN = '" & DBookISBNComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    DBookTitleTextBox.Text = reader.GetString("book_Title")
                    DBookCopiesTextBox.Text = reader.GetString("book_TotalCopy")
                    DBookAuthorTextBox.Text = reader.GetString("book_Author")
                    DBookPublisherTextBox.Text = reader.GetString("book_Publisher")
                    DBookGenreTextBox.Text = reader.GetString("book_Genre")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub BookDeleteBtn_Click(sender As Object, e As EventArgs) Handles BookDeleteBtn.Click
        ' Delete a book based on the selected book ISBN in DBookISBNComboBox
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM book WHERE book_ISBN = @DBookISBN"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@DBookISBN", DBookISBNComboBox.Text)

            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Record Has Been Deleted.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        DDisplayBookISBN()
    End Sub
    ' Delete Panel End

    ' Error Handling

    ' UBookCopiesTextBox: Truncate the text to 11 characters and move cursor to the end
    Private Sub UBookCopiesTextBox_TextChanged(sender As Object, e As EventArgs) Handles UBookCopiesTextBox.TextChanged
        If UBookCopiesTextBox.TextLength > 11 Then
            UBookCopiesTextBox.Text = UBookCopiesTextBox.Text.Substring(0, 11) ' Truncate the text to 11 characters
            UBookCopiesTextBox.SelectionStart = 11 ' Move the cursor to the end of the text
        End If
    End Sub

    ' UBookCopiesTextBox: Suppress non-digit key presses, Backspace, and Delete keys
    Private Sub UBookCopiesTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UBookCopiesTextBox.KeyDown
        If Not Char.IsDigit(ChrW(e.KeyCode)) AndAlso Not e.KeyCode = Keys.Back AndAlso Not e.KeyCode = Keys.Delete Then
            e.SuppressKeyPress = True ' Ignore the key press
        End If
    End Sub

    ' ABookCopiesTextBox: Truncate the text to 11 characters and move cursor to the end
    Private Sub ABookCopiesTextBox_TextChanged(sender As Object, e As EventArgs) Handles ABookCopiesTextBox.TextChanged
        If UBookCopiesTextBox.TextLength > 11 Then
            UBookCopiesTextBox.Text = UBookCopiesTextBox.Text.Substring(0, 11) ' Truncate the text to 11 characters
            UBookCopiesTextBox.SelectionStart = 11 ' Move the cursor to the end of the text
        End If
    End Sub

    ' ABookCopiesTextBox: Suppress non-digit key presses, Backspace, and Delete keys
    Private Sub ABookCopiesTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ABookCopiesTextBox.KeyDown
        If Not Char.IsDigit(ChrW(e.KeyCode)) AndAlso Not e.KeyCode = Keys.Back AndAlso Not e.KeyCode = Keys.Delete Then
            e.SuppressKeyPress = True ' Ignore the key press
        End If
    End Sub


End Class
