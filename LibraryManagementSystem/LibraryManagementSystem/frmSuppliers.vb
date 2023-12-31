Imports Microsoft.Office.Interop

Public Class frmSuppliers
    Dim exFile As Excel.Application
    Dim ProductTable As New DataTable
    Dim row As Integer

    ' View Panel
    Sub DisplaySupplierTable()
        Dim SupplierTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT supplier_ID as 'ID', supplier_Name as 'Name', supplier_Contact as 'Phone Number', supplier_Address as 'Address' FROM supplier"
            adapter.SelectCommand = cmd
            SupplierTable.Clear()

            adapter.Fill(SupplierTable)
            SupplierDGV.DataSource = SupplierTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ExportBtn_Click(sender As Object, e As EventArgs) Handles ExportBtn.Click
        Try
            exFile = New Excel.Application

            Dim workbook As Excel.Workbook = exFile.Workbooks.Open("C:\Users\Acer\OneDrive\Documents\Visual Studio 2013\Projects\LibraryManagementSystem\supplier.xlsx")

            Dim worksheet As Excel.Worksheet = DirectCast(workbook.Sheets(1), Excel.Worksheet)

            For colIndex As Integer = 1 To SupplierDGV.Columns.Count
                worksheet.Cells(2, colIndex).Value = SupplierDGV.Columns(colIndex - 1).HeaderText
            Next

            row = 2
            For rowIndex As Integer = 0 To SupplierDGV.Rows.Count - 1
                For colIndex As Integer = 1 To SupplierDGV.Columns.Count
                    worksheet.Cells(row, colIndex).Value = SupplierDGV.Rows(rowIndex).Cells(colIndex - 1).Value.ToString()
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
        ASupplierNameTextBox.Clear()
        ASupplierContactTextBox.Clear()
        ASupplierAddressTextBox.Clear()
    End Sub

    Private Sub SupplierAddBtn_Click(sender As Object, e As EventArgs) Handles SupplierAddBtn.Click
        If String.IsNullOrWhiteSpace(ASupplierNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(ASupplierContactTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(ASupplierAddressTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO supplier (supplier_Name, supplier_Contact, supplier_Address) VALUES (@ASupplierName, @ASupplierContact, @ASupplierAddress)"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ASupplierName", ASupplierNameTextBox.Text)
            cmd.Parameters.AddWithValue("@ASupplierContact", ASupplierContactTextBox.Text)
            cmd.Parameters.AddWithValue("@ASupplierAddress", ASupplierAddressTextBox.Text)

            If MsgBox("Do you want to save this supplier?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("New Supplier Added!")
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
        USupplierNameTextBox.Clear()
        USupplierContactTextBox.Clear()
        USupplierAddressTextBox.Clear()
    End Sub

    Sub UDisplaySupplierID()
        Dim t1 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM supplier"
            adapter.SelectCommand = cmd
            adapter.Fill(t1)
            USupplierIDComboBox.DataSource = t1
            USupplierIDComboBox.DisplayMember = "supplier_ID"
            USupplierIDComboBox.ValueMember = "supplier_ID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub USupplierIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles USupplierIDComboBox.SelectedIndexChanged
        If USupplierIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM supplier WHERE supplier_ID = '" & USupplierIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    USupplierNameTextBox.Text = reader.GetString("supplier_Name")
                    USupplierContactTextBox.Text = reader.GetString("supplier_Contact")
                    USupplierAddressTextBox.Text = reader.GetString("supplier_Address")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub SupplierUpdateBtn_Click(sender As Object, e As EventArgs) Handles SupplierUpdateBtn.Click
        If String.IsNullOrWhiteSpace(USupplierNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(USupplierContactTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(USupplierAddressTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE supplier SET supplier_Name = @USupplierName, supplier_Contact = @USupplierContact, supplier_Address = @USupplierAddress WHERE supplier_ID = @USupplierID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@USupplierName", USupplierNameTextBox.Text)
            cmd.Parameters.AddWithValue("@USupplierContact", USupplierContactTextBox.Text)
            cmd.Parameters.AddWithValue("@USupplierAddress", USupplierAddressTextBox.Text)
            cmd.Parameters.AddWithValue("@USupplierID", USupplierIDComboBox.SelectedValue)

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
        UDisplaySupplierID()
    End Sub
    ' Update Panel End

    ' Delete Panel
    Sub DDisplaySupplierID()
        Dim t4 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM supplier"
            adapter.SelectCommand = cmd
            adapter.Fill(t4)
            DSupplierIDComboBox.DataSource = t4
            DSupplierIDComboBox.DisplayMember = "supplier_ID"
            DSupplierIDComboBox.ValueMember = "supplier_ID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DSupplierIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DSupplierIDComboBox.SelectedIndexChanged
        If DSupplierIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM supplier WHERE supplier_ID = '" & DSupplierIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    DSupplierNameTextBox.Text = reader.GetString("supplier_Name")
                    DSupplierContactTextBox.Text = reader.GetString("supplier_Contact")
                    DSupplierAddressTextBox.Text = reader.GetString("supplier_Address")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub SupplierDeleteBtn_Click(sender As Object, e As EventArgs) Handles SupplierDeleteBtn.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM supplier WHERE supplier_ID = @DSupplierID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@DSupplierID", DSupplierIDComboBox.Text)

            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Record Has Been Deleted.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        DDisplaySupplierID()
    End Sub
    ' Delete Panel End
    Private Sub USupplierContactTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles USupplierContactTextBox.KeyDown
        ' Check if the pressed key is not a digit, Backspace, or Delete
        If Not Char.IsDigit(ChrW(e.KeyCode)) AndAlso Not e.KeyCode = Keys.Back AndAlso Not e.KeyCode = Keys.Delete Then
            ' Ignore the key press
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub ASupplierContactTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ASupplierContactTextBox.KeyDown
        ' Check if the pressed key is not a digit, Backspace, or Delete
        If Not Char.IsDigit(ChrW(e.KeyCode)) AndAlso Not e.KeyCode = Keys.Back AndAlso Not e.KeyCode = Keys.Delete Then
            ' Ignore the key press
            e.SuppressKeyPress = True
        End If
    End Sub

End Class
