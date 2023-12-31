Imports Microsoft.Office.Interop

Public Class frmGenres
    Dim exFile As Excel.Application
    Dim ProductTable As New DataTable
    Dim row As Integer

    ' View Panel
    Sub DisplayGenreTable()
        Dim GenreTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT genre_ID as 'ID', genre_Name as 'Name' FROM genre"
            adapter.SelectCommand = cmd
            GenreTable.Clear()

            adapter.Fill(GenreTable)
            GenreDGV.DataSource = GenreTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ExportBtn_Click(sender As Object, e As EventArgs) Handles ExportBtn.Click
        Try
            exFile = New Excel.Application

            Dim workbook As Excel.Workbook = exFile.Workbooks.Open("C:\Users\Acer\OneDrive\Documents\Visual Studio 2013\Projects\LibraryManagementSystem\genre.xlsx")

            Dim worksheet As Excel.Worksheet = DirectCast(workbook.Sheets(1), Excel.Worksheet)

            For colIndex As Integer = 1 To GenreDGV.Columns.Count
                worksheet.Cells(2, colIndex).Value = GenreDGV.Columns(colIndex - 1).HeaderText
            Next

            row = 2
            For rowIndex As Integer = 0 To GenreDGV.Rows.Count - 1
                For colIndex As Integer = 1 To GenreDGV.Columns.Count
                    worksheet.Cells(row, colIndex).Value = GenreDGV.Rows(rowIndex).Cells(colIndex - 1).Value.ToString()
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
        AGenreNameTextBox.Clear()
    End Sub

    Private Sub GenreAddBtn_Click(sender As Object, e As EventArgs) Handles GenreAddBtn.Click
        If String.IsNullOrWhiteSpace(AGenreNameTextBox.Text) Then
            MsgBox("Please fill in the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO genre (genre_Name) VALUES (@AGenreName)"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@AGenreName", AGenreNameTextBox.Text)

            If MsgBox("Do you want to save this genre?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("New Genre Added!")
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
        UGenreNameTextBox.Clear()
    End Sub

    Sub UDisplayGenreID()
        Dim t1 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM genre"
            adapter.SelectCommand = cmd
            adapter.Fill(t1)
            UGenreIDComboBox.DataSource = t1
            UGenreIDComboBox.DisplayMember = "genre_ID"
            UGenreIDComboBox.ValueMember = "genre_ID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UGenreIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UGenreIDComboBox.SelectedIndexChanged
        If UGenreIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM genre WHERE genre_ID = '" & UGenreIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    UGenreNameTextBox.Text = reader.GetString("genre_Name")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub GenreUpdateBtn_Click(sender As Object, e As EventArgs) Handles GenreUpdateBtn.Click
        If String.IsNullOrWhiteSpace(UGenreNameTextBox.Text) Then
            MsgBox("Please fill in the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE genre SET genre_Name = @UGenreName WHERE genre_ID = @UGenreID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@UGenreName", UGenreNameTextBox.Text)
            cmd.Parameters.AddWithValue("@UGenreID", UGenreIDComboBox.SelectedValue)

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
        UDisplayGenreID()
    End Sub
    ' Update Panel End

    ' Delete Panel
    Sub DDisplayGenreID()
        Dim t4 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM genre"
            adapter.SelectCommand = cmd
            adapter.Fill(t4)
            DGenreIDComboBox.DataSource = t4
            DGenreIDComboBox.DisplayMember = "genreID"
            DGenreIDComboBox.ValueMember = "genreID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DGenreIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DGenreIDComboBox.SelectedIndexChanged
        If DGenreIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM genre WHERE genre_ID = '" & DGenreIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    DGenreNameTextBox.Text = reader.GetString("genre_Name")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub GenreDeleteBtn_Click(sender As Object, e As EventArgs) Handles GenreDeleteBtn.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM genre WHERE genre_ID = @DGenreID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@DGenreID", DGenreIDComboBox.Text)

            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Record Has Been Deleted.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        DDisplayGenreID()
    End Sub
    ' Delete Panel End

End Class
