Imports Microsoft.Office.Interop

Public Class frmPublishers
    Dim exFile As Excel.Application
    Dim ProductTable As New DataTable
    Dim row As Integer

    ' View Panel
    Sub DisplayPublisherTable()
        ' Display the list of publishers in the DataGridView
        Dim PublisherTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT publisher_ID as 'ID', publisher_Name as 'Name', publisher_Contact as 'Phone Number', publisher_Address as 'Address' FROM publisher"
            adapter.SelectCommand = cmd
            PublisherTable.Clear()

            adapter.Fill(PublisherTable)
            PublisherDGV.DataSource = PublisherTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ExportBtn_Click(sender As Object, e As EventArgs) Handles ExportBtn.Click
        ' Export publisher data to Excel
        Try
            exFile = New Excel.Application

            Dim workbook As Excel.Workbook = exFile.Workbooks.Open("C:\Users\Acer\OneDrive\Documents\Visual Studio 2013\Projects\LibraryManagementSystem\publisher.xlsx")

            Dim worksheet As Excel.Worksheet = DirectCast(workbook.Sheets(1), Excel.Worksheet)

            For colIndex As Integer = 1 To PublisherDGV.Columns.Count
                worksheet.Cells(2, colIndex).Value = PublisherDGV.Columns(colIndex - 1).HeaderText
            Next

            row = 2
            For rowIndex As Integer = 0 To PublisherDGV.Rows.Count - 1
                For colIndex As Integer = 1 To PublisherDGV.Columns.Count
                    worksheet.Cells(row, colIndex).Value = PublisherDGV.Rows(rowIndex).Cells(colIndex - 1).Value.ToString()
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
        ' Clear textboxes in the Add Panel
        APublisherNameTextBox.Clear()
        APublisherContactTextBox.Clear()
        APublisherAddressTextBox.Clear()
    End Sub

    Private Sub PublisherAddBtn_Click(sender As Object, e As EventArgs) Handles PublisherAddBtn.Click
        ' Add a new publisher
        If String.IsNullOrWhiteSpace(APublisherNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(APublisherContactTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(APublisherAddressTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO publisher (publisher_Name, publisher_Contact, publisher_Address) VALUES (@APublisherName, @APublisherContact, @APublisherAddress)"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@APublisherName", APublisherNameTextBox.Text)
            cmd.Parameters.AddWithValue("@APublisherContact", APublisherContactTextBox.Text)
            cmd.Parameters.AddWithValue("@APublisherAddress", APublisherAddressTextBox.Text)

            If MsgBox("Do you want to save this publisher?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("New Publisher Added!")
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
        ' Clear textboxes in the Update Panel
        UPublisherNameTextBox.Clear()
        UPublisherContactTextBox.Clear()
        UPublisherAddressTextBox.Clear()
    End Sub

    Sub UDisplayPublisherID()
        ' Display the list of publisher IDs in the Update Panel
        Dim t1 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM publisher"
            adapter.SelectCommand = cmd
            adapter.Fill(t1)
            UPublisherIDComboBox.DataSource = t1
            UPublisherIDComboBox.DisplayMember = "publisher_ID"
            UPublisherIDComboBox.ValueMember = "publisher_ID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UPublisherIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UPublisherIDComboBox.SelectedIndexChanged
        ' Load publisher details when ID is selected in the Update Panel
        If UPublisherIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM publisher WHERE publisher_ID = '" & UPublisherIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    UPublisherNameTextBox.Text = reader.GetString("publisher_Name")
                    UPublisherContactTextBox.Text = reader.GetString("publisher_Contact")
                    UPublisherAddressTextBox.Text = reader.GetString("publisher_Address")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub PublisherUpdateBtn_Click(sender As Object, e As EventArgs) Handles PublisherUpdateBtn.Click
        ' Update publisher details
        If String.IsNullOrWhiteSpace(UPublisherNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UPublisherContactTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UPublisherAddressTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE publisher SET publisher_Name = @UPublisherName, publisher_Contact = @UPublisherContact, publisher_Address = @UPublisherAddress WHERE publisher_ID = @UPublisherID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@UPublisherName", UPublisherNameTextBox.Text)
            cmd.Parameters.AddWithValue("@UPublisherContact", UPublisherContactTextBox.Text)
            cmd.Parameters.AddWithValue("@UPublisherAddress", UPublisherAddressTextBox.Text)
            cmd.Parameters.AddWithValue("@UPublisherID", UPublisherIDComboBox.SelectedValue)

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
        UDisplayPublisherID()
    End Sub
    ' Update Panel End

    ' Delete Panel
    Sub DDisplayPublisherID()
        ' Display the list of publisher IDs in the Delete Panel
        Dim t4 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM publisher"
            adapter.SelectCommand = cmd
            adapter.Fill(t4)
            DPublisherIDComboBox.DataSource = t4
            DPublisherIDComboBox.DisplayMember = "publisher_ID"
            DPublisherIDComboBox.ValueMember = "publisher_ID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DPublisherIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DPublisherIDComboBox.SelectedIndexChanged
        ' Load publisher details when ID is selected in the Delete Panel
        If DPublisherIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM publisher WHERE publisher_ID = '" & DPublisherIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    DPublisherNameTextBox.Text = reader.GetString("publisher_Name")
                    DPublisherContactTextBox.Text = reader.GetString("publisher_Contact")
                    DPublisherAddressTextBox.Text = reader.GetString("publisher_Address")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub PublisherDeleteBtn_Click(sender As Object, e As EventArgs) Handles PublisherDeleteBtn.Click
        ' Delete a publisher
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM publisher WHERE publisher_ID = @DPublisherID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@DPublisherID", DPublisherIDComboBox.Text)

            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Record Has Been Deleted.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        DDisplayPublisherID()
    End Sub
    ' Delete Panel End

    'Error Handling

    Private Sub UPublisherContactTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UPublisherContactTextBox.KeyDown
        ' Check if the pressed key is not a digit, Backspace, or Delete
        If Not Char.IsDigit(ChrW(e.KeyCode)) AndAlso Not e.KeyCode = Keys.Back AndAlso Not e.KeyCode = Keys.Delete Then
            ' Ignore the key press
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub APublisherContactTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles APublisherContactTextBox.KeyDown
        ' Check if the pressed key is not a digit, Backspace, or Delete
        If Not Char.IsDigit(ChrW(e.KeyCode)) AndAlso Not e.KeyCode = Keys.Back AndAlso Not e.KeyCode = Keys.Delete Then
            ' Ignore the key press
            e.SuppressKeyPress = True
        End If
    End Sub

End Class
