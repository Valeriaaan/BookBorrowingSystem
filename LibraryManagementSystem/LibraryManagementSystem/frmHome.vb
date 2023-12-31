Imports Microsoft.Office.Interop

Public Class frmHome
    Dim exFile As Excel.Application
    Dim ProductTable As New DataTable
    Dim row As Integer

    ' Handles the click event for the GenerateReportBtn
    Private Sub GenerateReportBtn_Click(sender As Object, e As EventArgs) Handles GenerateReportBtn.Click
        Try
            exFile = New Excel.Application

            Dim workbook As Excel.Workbook = exFile.Workbooks.Open("C:\Users\Acer\OneDrive\Documents\Visual Studio 2013\Projects\LibraryManagementSystem\report.xlsx")

            Dim worksheet As Excel.Worksheet = DirectCast(workbook.Sheets(1), Excel.Worksheet)

            For colIndex As Integer = 1 To TransactionDGV.Columns.Count
                worksheet.Cells(4, colIndex).Value = TransactionDGV.Columns(colIndex - 1).HeaderText
            Next

            row = 5
            For rowIndex As Integer = 0 To TransactionDGV.Rows.Count - 1
                For colIndex As Integer = 1 To TransactionDGV.Columns.Count
                    worksheet.Cells(row, colIndex).Value = TransactionDGV.Rows(rowIndex).Cells(colIndex - 1).Value.ToString()
                Next
                row += 1
            Next

            worksheet.Cells(2, 1) = "As of " & FormatDateTime(Now(), DateFormat.LongDate)

            exFile.Visible = True

            exFile = Nothing
            workbook = Nothing
            worksheet = Nothing

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' Handles the Load event for the frmHome form
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display numbers in the dashboard labels
        DisplayNumberInDashboard("book", BooksRegisteredLabel)
        DisplayNumberInDashboard("transaction", TransactionsMadeLabel)

        ' Display transaction and borrower tables, and the sum of available books
        DisplayTransactionTable()
        DisplayBorrowerTable()
        DisplayBookAvailableSum()
    End Sub

    ' Displays the transaction table in the DataGridView
    Sub DisplayTransactionTable()
        Dim RecentDeliveryTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT transaction_ID as 'ID', borrower_ID as 'Borrower ID', book_ISBN as 'Book ISBN', transaction_Date as 'Date' FROM transaction"
            adapter.SelectCommand = cmd
            RecentDeliveryTable.Clear()

            adapter.Fill(RecentDeliveryTable)
            TransactionDGV.DataSource = RecentDeliveryTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' Displays the borrower table in the DataGridView
    Sub DisplayBorrowerTable()
        Dim RecentPurchasesTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT borrower_ID as 'ID', borrower_Name as 'Name', borrower_Contact as 'Contact', borrower_Address as 'Address' FROM borrower"
            adapter.SelectCommand = cmd
            RecentPurchasesTable.Clear()

            adapter.Fill(RecentPurchasesTable)
            BorrowerDGV.DataSource = RecentPurchasesTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' Displays the count of records in a table in a specified label
    Sub DisplayNumberInDashboard(TableName, LabelName)
        Dim count As Integer = 0
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT COUNT(*) FROM " & TableName
            count = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                LabelName.Text = count.ToString()
            Else
                LabelName.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Displays the sum of available books in the NumberOfBooksLabel
    Sub DisplayBookAvailableSum()
        Dim sum As Object = Nothing
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT COALESCE(SUM(book_TotalCopy), 0) FROM book"
            sum = cmd.ExecuteScalar()

            If sum IsNot Nothing AndAlso sum IsNot DBNull.Value Then
                NumberOfBooksLabel.Text = sum.ToString()
            Else
                NumberOfBooksLabel.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class
