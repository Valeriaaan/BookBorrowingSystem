Imports Microsoft.Office.Interop

Public Class frmAuthors
    Dim exFile As Excel.Application
    Dim ProductTable As New DataTable
    Dim row As Integer

    ' View Panel
    Sub DisplayAuthorTable()
        Dim AuthorTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT author_ID as 'ID', author_Name as 'Name', author_Contact as 'Phone Number', author_Address as 'Address' FROM author"
            adapter.SelectCommand = cmd
            AuthorTable.Clear()

            adapter.Fill(AuthorTable)
            AuthorDGV.DataSource = AuthorTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ExportBtn_Click(sender As Object, e As EventArgs) Handles ExportBtn.Click
        Try
            exFile = New Excel.Application

            Dim workbook As Excel.Workbook = exFile.Workbooks.Open("C:\Users\Acer\OneDrive\Documents\Visual Studio 2013\Projects\LibraryManagementSystem\author.xlsx")

            Dim worksheet As Excel.Worksheet = DirectCast(workbook.Sheets(1), Excel.Worksheet)

            For colIndex As Integer = 1 To AuthorDGV.Columns.Count
                worksheet.Cells(4, colIndex).Value = AuthorDGV.Columns(colIndex - 1).HeaderText
            Next

            row = 2
            For rowIndex As Integer = 0 To AuthorDGV.Rows.Count - 1
                For colIndex As Integer = 1 To AuthorDGV.Columns.Count
                    worksheet.Cells(row, colIndex).Value = AuthorDGV.Rows(rowIndex).Cells(colIndex - 1).Value.ToString()
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
        AAuthorNameTextBox.Clear()
        AAuthorContactTextBox.Clear()
        AAuthorAddressTextBox.Clear()
    End Sub

    Private Sub AuthorAddBtn_Click(sender As Object, e As EventArgs) Handles AuthorAddBtn.Click
        If String.IsNullOrWhiteSpace(AAuthorNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(AAuthorContactTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(AAuthorAddressTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO author (author_Name, author_Contact, author_Address) VALUES (@AAuthorName, @AAuthorContact, @AAuthorAddress)"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@AAuthorName", AAuthorNameTextBox.Text)
            cmd.Parameters.AddWithValue("@AAuthorContact", AAuthorContactTextBox.Text)
            cmd.Parameters.AddWithValue("@AAuthorAddress", AAuthorAddressTextBox.Text)

            If MsgBox("Do you want to save this author?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("New Author Added!")
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
        UAuthorNameTextBox.Clear()
        UAuthorContactTextBox.Clear()
        UAuthorAddressTextBox.Clear()
    End Sub

    Sub UDisplayAuthorID()
        Dim t1 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM author"
            adapter.SelectCommand = cmd
            adapter.Fill(t1)
            UAuthorIDComboBox.DataSource = t1
            UAuthorIDComboBox.DisplayMember = "author_ID"
            UAuthorIDComboBox.ValueMember = "author_ID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub USupplierIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UAuthorIDComboBox.SelectedIndexChanged
        If UAuthorIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM author WHERE author_ID = '" & UAuthorIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    UAuthorNameTextBox.Text = reader.GetString("author_Name")
                    UAuthorContactTextBox.Text = reader.GetString("author_Contact")
                    UAuthorAddressTextBox.Text = reader.GetString("author_Address")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub AuthorUpdateBtn_Click(sender As Object, e As EventArgs) Handles AuthorUpdateBtn.Click
        If String.IsNullOrWhiteSpace(UAuthorNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UAuthorContactTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UAuthorAddressTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE author SET author_Name = @UAuthorName, author_Contact = @UAuthorContact, author_Address = @UAuthorAddress WHERE author_ID = @UAuthorID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@UAuthorName", UAuthorNameTextBox.Text)
            cmd.Parameters.AddWithValue("@UAuthorContact", UAuthorContactTextBox.Text)
            cmd.Parameters.AddWithValue("@UAuthorAddress", UAuthorAddressTextBox.Text)
            cmd.Parameters.AddWithValue("@UAuthorID", UAuthorIDComboBox.SelectedValue)

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
        UDisplayAuthorID()
    End Sub
    ' Update Panel End

    ' Delete Panel
    Sub DDisplayAuthorID()
        Dim t4 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM author"
            adapter.SelectCommand = cmd
            adapter.Fill(t4)
            DAuthorIDComboBox.DataSource = t4
            DAuthorIDComboBox.DisplayMember = "author_ID"
            DAuthorIDComboBox.ValueMember = "author_ID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DAuthorIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DAuthorIDComboBox.SelectedIndexChanged
        If DAuthorIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM author WHERE author_ID = '" & DAuthorIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    DAuthorNameTextBox.Text = reader.GetString("author_Name")
                    DAuthorContactTextBox.Text = reader.GetString("author_Contact")
                    DAuthorAddressTextBox.Text = reader.GetString("author_Address")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub AuthorDeleteBtn_Click(sender As Object, e As EventArgs) Handles AuthorDeleteBtn.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM author WHERE author_ID = @DAuthorID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@DAuthorID", DAuthorIDComboBox.Text)

            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Record Has Been Deleted.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        DDisplayAuthorID()
    End Sub
    ' Delete Panel End

End Class