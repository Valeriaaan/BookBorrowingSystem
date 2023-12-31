Imports Microsoft.Office.Interop

Public Class frmStaff
    Dim exFile As Excel.Application
    Dim ProductTable As New DataTable
    Dim row As Integer

    ' View Panel
    Sub DisplayStaffTable()
        Dim StaffTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT staff_ID as 'ID', staff_Name as 'Name', staff_Contact as 'Phone Number', staff_Address as 'Address', staff_Age as 'Age', staff_Position as 'Position' FROM staff"
            adapter.SelectCommand = cmd
            StaffTable.Clear()

            adapter.Fill(StaffTable)
            StaffDGV.DataSource = StaffTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ExportBtn_Click(sender As Object, e As EventArgs) Handles ExportBtn.Click
        Try
            exFile = New Excel.Application

            Dim workbook As Excel.Workbook = exFile.Workbooks.Open("C:\Users\Acer\OneDrive\Documents\Visual Studio 2013\Projects\LibraryManagementSystem\staff.xlsx")

            Dim worksheet As Excel.Worksheet = DirectCast(workbook.Sheets(1), Excel.Worksheet)

            For colIndex As Integer = 1 To StaffDGV.Columns.Count
                worksheet.Cells(2, colIndex).Value = StaffDGV.Columns(colIndex - 1).HeaderText
            Next

            row = 2
            For rowIndex As Integer = 0 To StaffDGV.Rows.Count - 1
                For colIndex As Integer = 1 To StaffDGV.Columns.Count
                    worksheet.Cells(row, colIndex).Value = StaffDGV.Rows(rowIndex).Cells(colIndex - 1).Value.ToString()
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
        AStaffNameTextBox.Clear()
        AStaffContactTextBox.Clear()
        AStaffAddressTextBox.Clear()
        AStaffAgeTextBox.Clear()
        AStaffPositionTextBox.Clear()
    End Sub

    Private Sub StaffAddBtn_Click(sender As Object, e As EventArgs) Handles StaffAddBtn.Click
        If String.IsNullOrWhiteSpace(AStaffNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(AStaffContactTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(AStaffAddressTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(AStaffAgeTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(AStaffPositionTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO staff (staff_Name, staff_Contact, staff_Address, staff_Age, staff_Position) VALUES (@AStaffName, @AStaffContact, @AStaffAddress, @AStaffAge, @AStaffPosition)"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@AStaffName", AStaffNameTextBox.Text)
            cmd.Parameters.AddWithValue("@AStaffContact", AStaffContactTextBox.Text)
            cmd.Parameters.AddWithValue("@AStaffAddress", AStaffAddressTextBox.Text)
            cmd.Parameters.AddWithValue("@AStaffAge", AStaffAgeTextBox.Text)
            cmd.Parameters.AddWithValue("@AStaffPosition", AStaffPositionTextBox.Text)

            If MsgBox("Do you want to save this staff member?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("New Staff Member Added!")
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
        UStaffNameTextBox.Clear()
        UStaffContactTextBox.Clear()
        UStaffAddressTextBox.Clear()
        UStaffAgeTextBox.Clear()
        UStaffPositionTextBox.Clear()
    End Sub

    Sub UDisplayStaffID()
        Dim t1 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM staff"
            adapter.SelectCommand = cmd
            adapter.Fill(t1)
            UStaffIDComboBox.DataSource = t1
            UStaffIDComboBox.DisplayMember = "staff_ID"
            UStaffIDComboBox.ValueMember = "staff_ID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UStaffIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UStaffIDComboBox.SelectedIndexChanged
        If UStaffIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM staff WHERE staff_ID = '" & UStaffIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    UStaffNameTextBox.Text = reader.GetString("staff_Name")
                    UStaffContactTextBox.Text = reader.GetString("staff_Contact")
                    UStaffAddressTextBox.Text = reader.GetString("staff_Address")
                    UStaffAgeTextBox.Text = reader.GetString("staff_Age")
                    UStaffPositionTextBox.Text = reader.GetString("staff_Position")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub StaffUpdateBtn_Click(sender As Object, e As EventArgs) Handles StaffUpdateBtn.Click
        If String.IsNullOrWhiteSpace(UStaffNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UStaffContactTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UStaffAddressTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UStaffAgeTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UStaffPositionTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE staff SET staff_Name = @UStaffName, staff_Contact = @UStaffContact, staff_Address = @UStaffAddress, staff_Age = @UStaffAge, staff_Position = @UStaffPosition WHERE staff_ID = @UStaffID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@UStaffName", UStaffNameTextBox.Text)
            cmd.Parameters.AddWithValue("@UStaffContact", UStaffContactTextBox.Text)
            cmd.Parameters.AddWithValue("@UStaffAddress", UStaffAddressTextBox.Text)
            cmd.Parameters.AddWithValue("@UStaffAge", UStaffAgeTextBox.Text)
            cmd.Parameters.AddWithValue("@UStaffPosition", UStaffPositionTextBox.Text)
            cmd.Parameters.AddWithValue("@UStaffID", UStaffIDComboBox.SelectedValue)

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
        UDisplayStaffID()
    End Sub
    ' Update Panel End

    ' Delete Panel
    Sub DDisplayStaffID()
        Dim t4 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM staff"
            adapter.SelectCommand = cmd
            adapter.Fill(t4)
            DStaffIDComboBox.DataSource = t4
            DStaffIDComboBox.DisplayMember = "staff_ID"
            DStaffIDComboBox.ValueMember = "staff_ID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DStaffIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DStaffIDComboBox.SelectedIndexChanged
        If DStaffIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM staff WHERE staff_ID = '" & DStaffIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    DStaffNameTextBox.Text = reader.GetString("staff_Name")
                    DStaffContactTextBox.Text = reader.GetString("staff_Contact")
                    DStaffAddressTextBox.Text = reader.GetString("staff_Address")
                    DStaffAgeTextBox.Text = reader.GetString("staff_Age")
                    DStaffPositionTextBox.Text = reader.GetString("staff_Position")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub StaffDeleteBtn_Click(sender As Object, e As EventArgs) Handles StaffDeleteBtn.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM staff WHERE staff_ID = @DStaffID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@DStaffID", DStaffIDComboBox.Text)

            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Record Has Been Deleted.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        DDisplayStaffID()
    End Sub
    ' Delete Panel End

    ' Error Handling
    Private Sub AStaffContactTextBox_TextChanged(sender As Object, e As EventArgs) Handles AStaffContactTextBox.TextChanged
        If AStaffContactTextBox.TextLength > 11 Then
            AStaffContactTextBox.Text = AStaffContactTextBox.Text.Substring(0, 11) ' Truncate the text to 11 characters
            AStaffContactTextBox.SelectionStart = 11 ' Move the cursor to the end of the text
        End If
    End Sub

    Private Sub AStaffContactTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AStaffContactTextBox.KeyDown
        If Not Char.IsDigit(ChrW(e.KeyCode)) AndAlso Not e.KeyCode = Keys.Back AndAlso Not e.KeyCode = Keys.Delete Then
            e.SuppressKeyPress = True ' Ignore the key press
        End If
    End Sub

    Private Sub AStaffAgeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AStaffAgeTextBox.KeyDown
        If Not Char.IsDigit(ChrW(e.KeyCode)) AndAlso Not e.KeyCode = Keys.Back AndAlso Not e.KeyCode = Keys.Delete Then
            e.SuppressKeyPress = True ' Ignore the key press
        End If
    End Sub


    Private Sub UStaffContactTextBox_TextChanged(sender As Object, e As EventArgs) Handles UStaffContactTextBox.TextChanged
        If UStaffContactTextBox.TextLength > 11 Then
            UStaffContactTextBox.Text = AStaffContactTextBox.Text.Substring(0, 11) ' Truncate the text to 11 characters
            UStaffContactTextBox.SelectionStart = 11 ' Move the cursor to the end of the text
        End If
    End Sub

    Private Sub UStaffContactTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UStaffContactTextBox.KeyDown
        If Not Char.IsDigit(ChrW(e.KeyCode)) AndAlso Not e.KeyCode = Keys.Back AndAlso Not e.KeyCode = Keys.Delete Then
            e.SuppressKeyPress = True ' Ignore the key press
        End If
    End Sub

    Private Sub UStaffAgeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UStaffAgeTextBox.KeyDown
        If Not Char.IsDigit(ChrW(e.KeyCode)) AndAlso Not e.KeyCode = Keys.Back AndAlso Not e.KeyCode = Keys.Delete Then
            e.SuppressKeyPress = True ' Ignore the key press
        End If
    End Sub

End Class
