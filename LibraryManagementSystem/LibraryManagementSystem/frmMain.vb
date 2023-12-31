Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the initial visibility of panels 
        ContentPanel.Visible = True

        BooksPanel.Visible = False
        AuthorPanel.Visible = False
        PublisherPanel.Visible = False
        GenrePanel.Visible = False
        SupplierPanel.Visible = False
        StaffPanel.Visible = False
    End Sub

    ' Function to open the content panel and hide other panels
    Sub OpenContentPanel()
        ContentPanel.Visible = True
        BooksPanel.Visible = False
        AuthorPanel.Visible = False
        PublisherPanel.Visible = False
        GenrePanel.Visible = False
        SupplierPanel.Visible = False
        StaffPanel.Visible = False
    End Sub

    ' Home Button Click Event
    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        ' Open the content panel
        OpenContentPanel()

        ' Shows the home form and perform various actions on it such us showing the tables
        With frmHome
            .TopLevel = False
            ContentPanel.Controls.Add(frmHome)

            .DisplayNumberInDashboard("book", .BooksRegisteredLabel)
            .DisplayNumberInDashboard("transaction", .TransactionsMadeLabel)

            .DisplayTransactionTable()
            .DisplayBorrowerTable()
            .DisplayBookAvailableSum()
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Similar logic as in HomeBtn_Click for other navigation buttons...

    ' Borrow Button Click Event
    Private Sub BorrowBtn_Click(sender As Object, e As EventArgs) Handles BorrowBtn.Click
        OpenContentPanel()
        With frmBorrow
            .TopLevel = False
            ContentPanel.Controls.Add(frmBorrow)

            .DisplayNextBorrowerID()
            .ClearTextboxes()
            .DisplayBookID()
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Books Button Click Event
    Private Sub BooksBtn_Click(sender As Object, e As EventArgs) Handles BooksBtn.Click
        ContentPanel.Visible = False
        BooksPanel.Visible = True
        AuthorPanel.Visible = False
        PublisherPanel.Visible = False
        GenrePanel.Visible = False
        SupplierPanel.Visible = False
        StaffPanel.Visible = False
    End Sub

    ' Authors Button Click Event
    Private Sub AuthorsBtn_Click(sender As Object, e As EventArgs) Handles AuthorsBtn.Click
        ContentPanel.Visible = False
        BooksPanel.Visible = False
        AuthorPanel.Visible = True
        PublisherPanel.Visible = False
        GenrePanel.Visible = False
        SupplierPanel.Visible = False
        StaffPanel.Visible = False
    End Sub

    ' Publisher Button Click Event
    Private Sub PublishersBtn_Click(sender As Object, e As EventArgs) Handles PublishersBtn.Click
        ContentPanel.Visible = False
        BooksPanel.Visible = False
        AuthorPanel.Visible = False
        PublisherPanel.Visible = True
        GenrePanel.Visible = False
        SupplierPanel.Visible = False
        StaffPanel.Visible = False
    End Sub

    ' Genre Button Click Event
    Private Sub GenreBtn_Click(sender As Object, e As EventArgs) Handles GenreBtn.Click
        ContentPanel.Visible = False
        BooksPanel.Visible = False
        AuthorPanel.Visible = False
        PublisherPanel.Visible = False
        GenrePanel.Visible = True
        SupplierPanel.Visible = False
        StaffPanel.Visible = False
    End Sub

    ' Supplier Button Click Event
    Private Sub SuppliersBtn_Click(sender As Object, e As EventArgs) Handles SuppliersBtn.Click
        ContentPanel.Visible = False
        BooksPanel.Visible = False
        AuthorPanel.Visible = False
        PublisherPanel.Visible = False
        GenrePanel.Visible = False
        SupplierPanel.Visible = True
        StaffPanel.Visible = False
    End Sub

    ' Staff Button Click Event
    Private Sub Stafbtn_Click(sender As Object, e As EventArgs) Handles Stafbtn.Click
        ContentPanel.Visible = False
        BooksPanel.Visible = False
        AuthorPanel.Visible = False
        PublisherPanel.Visible = False
        GenrePanel.Visible = False
        SupplierPanel.Visible = False
        StaffPanel.Visible = True
    End Sub

    ' Logout Button Click Event
    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        ' Display a confirmation message before logging out
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ' Close the current form and show the login form
            Dim loginForm As New frmLogin()
            Me.Close()
            loginForm.Show()
        End If
    End Sub

    ' Books Navigation

    Private Sub BookAddBtn_Click(sender As Object, e As EventArgs) Handles BookAddBtn.Click
        OpenContentPanel()
        With frmBooks
            .TopLevel = False
            ContentPanel.Controls.Add(frmBooks)

            .BookViewPanel.Visible = False
            .BookAddPanel.Visible = True
            .BookUpdatePanel.Visible = False
            .BookDeletePanel.Visible = False

            .ADisplayPublisherID()
            .ADisplayAuthorID()
            .ADisplayGenreID()
            .AClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BookUpdateBtn_Click(sender As Object, e As EventArgs) Handles BookUpdateBtn.Click
        OpenContentPanel()
        With frmBooks
            .TopLevel = False
            ContentPanel.Controls.Add(frmBooks)

            .BookViewPanel.Visible = False
            .BookAddPanel.Visible = False
            .BookUpdatePanel.Visible = True
            .BookDeletePanel.Visible = False

            .UDisplayPublisherID()
            .UDisplayPublisherID()
            .UDisplayBookISBN()
            .UDisplayAuthorID()
            .UDisplayGenreID()
            .UClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BookDeleteBtn_Click(sender As Object, e As EventArgs) Handles BookDeleteBtn.Click
        OpenContentPanel()
        With frmBooks
            .TopLevel = False
            ContentPanel.Controls.Add(frmBooks)

            .BookViewPanel.Visible = False
            .BookAddPanel.Visible = False
            .BookUpdatePanel.Visible = False
            .BookDeletePanel.Visible = True

            .DDisplayBookISBN()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BookViewBtn_Click(sender As Object, e As EventArgs) Handles BookViewBtn.Click
        OpenContentPanel()
        With frmBooks
            .TopLevel = False
            ContentPanel.Controls.Add(frmBooks)

            .BookViewPanel.Visible = True
            .BookAddPanel.Visible = False
            .BookUpdatePanel.Visible = False
            .BookDeletePanel.Visible = False

            .DisplayBookTable()
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Books Navigation End

    ' Author Navigation

    Private Sub AuthorAddBtn_Click(sender As Object, e As EventArgs) Handles AuthorAddBtn.Click
        OpenContentPanel()
        With frmAuthors
            .TopLevel = False
            ContentPanel.Controls.Add(frmAuthors)

            .AuthorViewPanel.Visible = False
            .AuthorAddPanel.Visible = True
            .AuthorUpdatePanel.Visible = False
            .AuthorDeletePanel.Visible = False

            .AClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub AuthorUpdateBtn_Click(sender As Object, e As EventArgs) Handles AuthorUpdateBtn.Click
        OpenContentPanel()
        With frmAuthors
            .TopLevel = False
            ContentPanel.Controls.Add(frmAuthors)

            .AuthorViewPanel.Visible = False
            .AuthorAddPanel.Visible = False
            .AuthorUpdatePanel.Visible = True
            .AuthorDeletePanel.Visible = False

            .UDisplayAuthorID()
            .UClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub AuthorDeleteBtn_Click(sender As Object, e As EventArgs) Handles AuthorDeleteBtn.Click
        OpenContentPanel()
        With frmAuthors
            .TopLevel = False
            ContentPanel.Controls.Add(frmAuthors)

            .AuthorViewPanel.Visible = False
            .AuthorAddPanel.Visible = False
            .AuthorUpdatePanel.Visible = False
            .AuthorDeletePanel.Visible = True

            .DDisplayAuthorID()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub AuthorViewBtn_Click(sender As Object, e As EventArgs) Handles AuthorViewBtn.Click
        OpenContentPanel()
        With frmAuthors
            .TopLevel = False
            ContentPanel.Controls.Add(frmAuthors)

            .AuthorViewPanel.Visible = True
            .AuthorAddPanel.Visible = False
            .AuthorUpdatePanel.Visible = False
            .AuthorDeletePanel.Visible = False

            .DisplayAuthorTable()
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Author Navigation End

    ' Publisher Navigation

    Private Sub PublisherAddBtn_Click(sender As Object, e As EventArgs) Handles PublisherAddBtn.Click
        OpenContentPanel()
        With frmPublishers
            .TopLevel = False
            ContentPanel.Controls.Add(frmPublishers)

            .PublisherViewPanel.Visible = False
            .PublisherAddPanel.Visible = True
            .PublisherUpdatePanel.Visible = False
            .PublisherDeletePanel.Visible = False

            .AClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub PublisherUpdateBtn_Click(sender As Object, e As EventArgs) Handles PublisherUpdateBtn.Click
        OpenContentPanel()
        With frmPublishers
            .TopLevel = False
            ContentPanel.Controls.Add(frmPublishers)

            .PublisherViewPanel.Visible = False
            .PublisherAddPanel.Visible = False
            .PublisherUpdatePanel.Visible = True
            .PublisherDeletePanel.Visible = False

            .UDisplayPublisherID()
            .UClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub PublisherDeleteBtn_Click(sender As Object, e As EventArgs) Handles PublisherDeleteBtn.Click
        OpenContentPanel()
        With frmPublishers
            .TopLevel = False
            ContentPanel.Controls.Add(frmPublishers)

            .PublisherViewPanel.Visible = False
            .PublisherAddPanel.Visible = False
            .PublisherUpdatePanel.Visible = False
            .PublisherDeletePanel.Visible = True

            .DDisplayPublisherID()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub PublisherViewBtn_Click(sender As Object, e As EventArgs) Handles PublisherViewBtn.Click
        OpenContentPanel()
        With frmPublishers
            .TopLevel = False
            ContentPanel.Controls.Add(frmPublishers)

            .PublisherViewPanel.Visible = True
            .PublisherAddPanel.Visible = False
            .PublisherUpdatePanel.Visible = False
            .PublisherDeletePanel.Visible = False

            .DisplayPublisherTable()
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Publisher Navigation End

    ' Genre Navigation

    Private Sub GenreAddBtn_Click(sender As Object, e As EventArgs) Handles GenreAddBtn.Click
        OpenContentPanel()
        With frmGenres
            .TopLevel = False
            ContentPanel.Controls.Add(frmGenres)

            .GenreViewPanel.Visible = False
            .GenreAddPanel.Visible = True
            .GenreUpdatePanel.Visible = False
            .GenreDeletePanel.Visible = False

            .AClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GenreUpdateBtn_Click(sender As Object, e As EventArgs) Handles GenreUpdateBtn.Click
        OpenContentPanel()
        With frmGenres
            .TopLevel = False
            ContentPanel.Controls.Add(frmGenres)

            .GenreViewPanel.Visible = False
            .GenreAddPanel.Visible = False
            .GenreUpdatePanel.Visible = True
            .GenreDeletePanel.Visible = False

            .UClearTextboxes()
            .UDisplayGenreID()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GenreDeleteBtn_Click(sender As Object, e As EventArgs) Handles GenreDeleteBtn.Click
        OpenContentPanel()
        With frmGenres
            .TopLevel = False
            ContentPanel.Controls.Add(frmGenres)

            .GenreViewPanel.Visible = False
            .GenreAddPanel.Visible = False
            .GenreUpdatePanel.Visible = False
            .GenreDeletePanel.Visible = True

            .DDisplayGenreID()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GenreViewBtn_Click(sender As Object, e As EventArgs) Handles GenreViewBtn.Click
        OpenContentPanel()
        With frmGenres
            .TopLevel = False
            ContentPanel.Controls.Add(frmGenres)

            .GenreViewPanel.Visible = True
            .GenreAddPanel.Visible = False
            .GenreUpdatePanel.Visible = False
            .GenreDeletePanel.Visible = False

            .DisplayGenreTable()
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Genre Navigation End

    ' Supplier Navigation

    Private Sub SupplierAddBtn_Click(sender As Object, e As EventArgs) Handles SupplierAddBtn.Click
        OpenContentPanel()
        With frmSuppliers
            .TopLevel = False
            ContentPanel.Controls.Add(frmSuppliers)

            .SupplierViewPanel.Visible = False
            .SupplierAddPanel.Visible = True
            .SupplierUpdatePanel.Visible = False
            .SupplierDeletePanel.Visible = False

            .AClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub SupplierUpdateBtn_Click(sender As Object, e As EventArgs) Handles SupplierUpdateBtn.Click
        OpenContentPanel()
        With frmSuppliers
            .TopLevel = False
            ContentPanel.Controls.Add(frmSuppliers)

            .SupplierViewPanel.Visible = False
            .SupplierAddPanel.Visible = False
            .SupplierUpdatePanel.Visible = True
            .SupplierDeletePanel.Visible = False

            .UClearTextboxes()
            .UDisplaySupplierID()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub SupplierDeleteBtn_Click(sender As Object, e As EventArgs) Handles SupplierDeleteBtn.Click
        OpenContentPanel()
        With frmSuppliers
            .TopLevel = False
            ContentPanel.Controls.Add(frmSuppliers)

            .SupplierViewPanel.Visible = False
            .SupplierAddPanel.Visible = False
            .SupplierUpdatePanel.Visible = False
            .SupplierDeletePanel.Visible = True

            .DDisplaySupplierID()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub SupplierViewBtn_Click(sender As Object, e As EventArgs) Handles SupplierViewBtn.Click
        OpenContentPanel()
        With frmSuppliers
            .TopLevel = False
            ContentPanel.Controls.Add(frmSuppliers)

            .SupplierViewPanel.Visible = True
            .SupplierAddPanel.Visible = False
            .SupplierUpdatePanel.Visible = False
            .SupplierDeletePanel.Visible = False

            .DisplaySupplierTable()
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Supplier Navigation End

    ' Staff Navigation

    Private Sub StaffAddBtn_Click(sender As Object, e As EventArgs) Handles StaffAddBtn.Click
        OpenContentPanel()
        With frmStaff
            .TopLevel = False
            ContentPanel.Controls.Add(frmStaff)

            .StaffViewPanel.Visible = False
            .StaffAddPanel.Visible = True
            .StaffUpdatePanel.Visible = False
            .StaffDeletePanel.Visible = False

            .AClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub StaffUpdateBtn_Click(sender As Object, e As EventArgs) Handles StaffUpdateBtn.Click
        OpenContentPanel()
        With frmStaff
            .TopLevel = False
            ContentPanel.Controls.Add(frmStaff)

            .StaffViewPanel.Visible = False
            .StaffAddPanel.Visible = False
            .StaffUpdatePanel.Visible = True
            .StaffDeletePanel.Visible = False

            .UClearTextboxes()
            .UDisplayStaffID()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub StaffDeleteBtn_Click(sender As Object, e As EventArgs) Handles StaffDeleteBtn.Click
        OpenContentPanel()
        With frmStaff
            .TopLevel = False
            ContentPanel.Controls.Add(frmStaff)

            .StaffViewPanel.Visible = False
            .StaffAddPanel.Visible = False
            .StaffUpdatePanel.Visible = False
            .StaffDeletePanel.Visible = True

            .DDisplayStaffID()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub StaffViewBtn_Click(sender As Object, e As EventArgs) Handles StaffViewBtn.Click
        OpenContentPanel()
        With frmStaff
            .TopLevel = False
            ContentPanel.Controls.Add(frmStaff)

            .StaffViewPanel.Visible = True
            .StaffAddPanel.Visible = False
            .StaffUpdatePanel.Visible = False
            .StaffDeletePanel.Visible = False

            .DisplayStaffTable()
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Staff Navigation End
    
End Class
