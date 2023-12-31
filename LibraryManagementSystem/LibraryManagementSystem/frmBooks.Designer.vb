<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Label7 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.BookViewPanel = New System.Windows.Forms.Panel()
        Me.ExportBtn = New System.Windows.Forms.Button()
        Me.BookDGV = New System.Windows.Forms.DataGridView()
        Me.BookAddPanel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ABookCopiesTextBox = New System.Windows.Forms.TextBox()
        Me.ABookPublisherComboBox = New System.Windows.Forms.ComboBox()
        Me.ABookAuthorComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ABookTitleTextBox = New System.Windows.Forms.TextBox()
        Me.ABookGenreComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ABookISBNTextBox = New System.Windows.Forms.TextBox()
        Me.BookAddBtn = New System.Windows.Forms.Button()
        Me.BookUpdatePanel = New System.Windows.Forms.Panel()
        Me.UBookISBNComboBox = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.UBookCopiesTextBox = New System.Windows.Forms.TextBox()
        Me.UBookPublisherComboBox = New System.Windows.Forms.ComboBox()
        Me.UBookAuthorComboBox = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.UBookTitleTextBox = New System.Windows.Forms.TextBox()
        Me.UBookGenreComboBox = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.BookUpdateBtn = New System.Windows.Forms.Button()
        Me.BookDeletePanel = New System.Windows.Forms.Panel()
        Me.DBookGenreTextBox = New System.Windows.Forms.TextBox()
        Me.DBookPublisherTextBox = New System.Windows.Forms.TextBox()
        Me.DBookAuthorTextBox = New System.Windows.Forms.TextBox()
        Me.DBookISBNComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DBookCopiesTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DBookTitleTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BookDeleteBtn = New System.Windows.Forms.Button()
        Label7 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.BookViewPanel.SuspendLayout()
        CType(Me.BookDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BookAddPanel.SuspendLayout()
        Me.BookUpdatePanel.SuspendLayout()
        Me.BookDeletePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Label7.Location = New System.Drawing.Point(448, 171)
        Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label7.Size = New System.Drawing.Size(73, 28)
        Label7.TabIndex = 59
        Label7.Text = "Author"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Label2.Location = New System.Drawing.Point(448, 243)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label2.Size = New System.Drawing.Size(92, 28)
        Label2.TabIndex = 63
        Label2.Text = "Publisher"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Label6.Location = New System.Drawing.Point(448, 315)
        Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label6.Size = New System.Drawing.Size(69, 28)
        Label6.TabIndex = 69
        Label6.Text = "Genre "
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Label18.Location = New System.Drawing.Point(448, 315)
        Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label18.Size = New System.Drawing.Size(69, 28)
        Label18.TabIndex = 69
        Label18.Text = "Genre "
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Label20.Location = New System.Drawing.Point(448, 243)
        Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label20.Name = "Label20"
        Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label20.Size = New System.Drawing.Size(92, 28)
        Label20.TabIndex = 63
        Label20.Text = "Publisher"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Label22.Location = New System.Drawing.Point(448, 171)
        Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label22.Name = "Label22"
        Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label22.Size = New System.Drawing.Size(73, 28)
        Label22.TabIndex = 59
        Label22.Text = "Author"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Label3.Location = New System.Drawing.Point(448, 315)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label3.Size = New System.Drawing.Size(69, 28)
        Label3.TabIndex = 69
        Label3.Text = "Genre "
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Label9.Location = New System.Drawing.Point(448, 243)
        Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label9.Size = New System.Drawing.Size(92, 28)
        Label9.TabIndex = 63
        Label9.Text = "Publisher"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Label11.Location = New System.Drawing.Point(448, 171)
        Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label11.Size = New System.Drawing.Size(73, 28)
        Label11.TabIndex = 59
        Label11.Text = "Author"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TitleLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1266, 62)
        Me.Panel2.TabIndex = 14
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.TitleLabel.Location = New System.Drawing.Point(592, 16)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(74, 28)
        Me.TitleLabel.TabIndex = 14
        Me.TitleLabel.Text = "Books"
        '
        'BookViewPanel
        '
        Me.BookViewPanel.Controls.Add(Me.ExportBtn)
        Me.BookViewPanel.Controls.Add(Me.BookDGV)
        Me.BookViewPanel.Location = New System.Drawing.Point(12, 82)
        Me.BookViewPanel.Name = "BookViewPanel"
        Me.BookViewPanel.Size = New System.Drawing.Size(1242, 533)
        Me.BookViewPanel.TabIndex = 15
        '
        'ExportBtn
        '
        Me.ExportBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ExportBtn.FlatAppearance.BorderSize = 0
        Me.ExportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ExportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExportBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ExportBtn.ForeColor = System.Drawing.Color.White
        Me.ExportBtn.Location = New System.Drawing.Point(89, 466)
        Me.ExportBtn.Name = "ExportBtn"
        Me.ExportBtn.Size = New System.Drawing.Size(1065, 40)
        Me.ExportBtn.TabIndex = 51
        Me.ExportBtn.Text = "Export Data to Excel"
        Me.ExportBtn.UseVisualStyleBackColor = False
        '
        'BookDGV
        '
        Me.BookDGV.AllowUserToAddRows = False
        Me.BookDGV.AllowUserToDeleteRows = False
        Me.BookDGV.AllowUserToResizeColumns = False
        Me.BookDGV.AllowUserToResizeRows = False
        Me.BookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BookDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.BookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookDGV.Location = New System.Drawing.Point(89, 27)
        Me.BookDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.BookDGV.Name = "BookDGV"
        Me.BookDGV.ReadOnly = True
        Me.BookDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BookDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BookDGV.RowTemplate.Height = 24
        Me.BookDGV.Size = New System.Drawing.Size(1065, 432)
        Me.BookDGV.TabIndex = 41
        '
        'BookAddPanel
        '
        Me.BookAddPanel.Controls.Add(Label6)
        Me.BookAddPanel.Controls.Add(Me.Label4)
        Me.BookAddPanel.Controls.Add(Me.ABookCopiesTextBox)
        Me.BookAddPanel.Controls.Add(Me.ABookPublisherComboBox)
        Me.BookAddPanel.Controls.Add(Label2)
        Me.BookAddPanel.Controls.Add(Me.ABookAuthorComboBox)
        Me.BookAddPanel.Controls.Add(Me.Label1)
        Me.BookAddPanel.Controls.Add(Me.ABookTitleTextBox)
        Me.BookAddPanel.Controls.Add(Label7)
        Me.BookAddPanel.Controls.Add(Me.ABookGenreComboBox)
        Me.BookAddPanel.Controls.Add(Me.Label5)
        Me.BookAddPanel.Controls.Add(Me.ABookISBNTextBox)
        Me.BookAddPanel.Controls.Add(Me.BookAddBtn)
        Me.BookAddPanel.Location = New System.Drawing.Point(12, 82)
        Me.BookAddPanel.Name = "BookAddPanel"
        Me.BookAddPanel.Size = New System.Drawing.Size(1242, 533)
        Me.BookAddPanel.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(448, 388)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(171, 28)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Number of Copies"
        '
        'ABookCopiesTextBox
        '
        Me.ABookCopiesTextBox.Location = New System.Drawing.Point(453, 426)
        Me.ABookCopiesTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.ABookCopiesTextBox.Name = "ABookCopiesTextBox"
        Me.ABookCopiesTextBox.Size = New System.Drawing.Size(342, 34)
        Me.ABookCopiesTextBox.TabIndex = 65
        '
        'ABookPublisherComboBox
        '
        Me.ABookPublisherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ABookPublisherComboBox.FormattingEnabled = True
        Me.ABookPublisherComboBox.Location = New System.Drawing.Point(453, 275)
        Me.ABookPublisherComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ABookPublisherComboBox.Name = "ABookPublisherComboBox"
        Me.ABookPublisherComboBox.Size = New System.Drawing.Size(342, 36)
        Me.ABookPublisherComboBox.TabIndex = 64
        '
        'ABookAuthorComboBox
        '
        Me.ABookAuthorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ABookAuthorComboBox.FormattingEnabled = True
        Me.ABookAuthorComboBox.Location = New System.Drawing.Point(453, 203)
        Me.ABookAuthorComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ABookAuthorComboBox.Name = "ABookAuthorComboBox"
        Me.ABookAuthorComboBox.Size = New System.Drawing.Size(342, 36)
        Me.ABookAuthorComboBox.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(448, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(49, 28)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Title"
        '
        'ABookTitleTextBox
        '
        Me.ABookTitleTextBox.Location = New System.Drawing.Point(453, 132)
        Me.ABookTitleTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.ABookTitleTextBox.Name = "ABookTitleTextBox"
        Me.ABookTitleTextBox.Size = New System.Drawing.Size(342, 34)
        Me.ABookTitleTextBox.TabIndex = 60
        '
        'ABookGenreComboBox
        '
        Me.ABookGenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ABookGenreComboBox.FormattingEnabled = True
        Me.ABookGenreComboBox.Location = New System.Drawing.Point(453, 347)
        Me.ABookGenreComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ABookGenreComboBox.Name = "ABookGenreComboBox"
        Me.ABookGenreComboBox.Size = New System.Drawing.Size(342, 36)
        Me.ABookGenreComboBox.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(448, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(54, 28)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "ISBN"
        '
        'ABookISBNTextBox
        '
        Me.ABookISBNTextBox.Location = New System.Drawing.Point(453, 56)
        Me.ABookISBNTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.ABookISBNTextBox.Name = "ABookISBNTextBox"
        Me.ABookISBNTextBox.Size = New System.Drawing.Size(342, 34)
        Me.ABookISBNTextBox.TabIndex = 52
        '
        'BookAddBtn
        '
        Me.BookAddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BookAddBtn.FlatAppearance.BorderSize = 0
        Me.BookAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BookAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BookAddBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BookAddBtn.ForeColor = System.Drawing.Color.White
        Me.BookAddBtn.Location = New System.Drawing.Point(453, 475)
        Me.BookAddBtn.Name = "BookAddBtn"
        Me.BookAddBtn.Size = New System.Drawing.Size(342, 40)
        Me.BookAddBtn.TabIndex = 51
        Me.BookAddBtn.Text = "Add Book"
        Me.BookAddBtn.UseVisualStyleBackColor = False
        '
        'BookUpdatePanel
        '
        Me.BookUpdatePanel.Controls.Add(Me.UBookISBNComboBox)
        Me.BookUpdatePanel.Controls.Add(Label18)
        Me.BookUpdatePanel.Controls.Add(Me.Label19)
        Me.BookUpdatePanel.Controls.Add(Me.UBookCopiesTextBox)
        Me.BookUpdatePanel.Controls.Add(Me.UBookPublisherComboBox)
        Me.BookUpdatePanel.Controls.Add(Label20)
        Me.BookUpdatePanel.Controls.Add(Me.UBookAuthorComboBox)
        Me.BookUpdatePanel.Controls.Add(Me.Label21)
        Me.BookUpdatePanel.Controls.Add(Me.UBookTitleTextBox)
        Me.BookUpdatePanel.Controls.Add(Label22)
        Me.BookUpdatePanel.Controls.Add(Me.UBookGenreComboBox)
        Me.BookUpdatePanel.Controls.Add(Me.Label23)
        Me.BookUpdatePanel.Controls.Add(Me.BookUpdateBtn)
        Me.BookUpdatePanel.Location = New System.Drawing.Point(12, 83)
        Me.BookUpdatePanel.Name = "BookUpdatePanel"
        Me.BookUpdatePanel.Size = New System.Drawing.Size(1242, 533)
        Me.BookUpdatePanel.TabIndex = 25
        '
        'UBookISBNComboBox
        '
        Me.UBookISBNComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UBookISBNComboBox.FormattingEnabled = True
        Me.UBookISBNComboBox.Location = New System.Drawing.Point(453, 52)
        Me.UBookISBNComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UBookISBNComboBox.Name = "UBookISBNComboBox"
        Me.UBookISBNComboBox.Size = New System.Drawing.Size(342, 36)
        Me.UBookISBNComboBox.TabIndex = 70
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(448, 388)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(171, 28)
        Me.Label19.TabIndex = 66
        Me.Label19.Text = "Number of Copies"
        '
        'UBookCopiesTextBox
        '
        Me.UBookCopiesTextBox.Location = New System.Drawing.Point(453, 426)
        Me.UBookCopiesTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UBookCopiesTextBox.Name = "UBookCopiesTextBox"
        Me.UBookCopiesTextBox.Size = New System.Drawing.Size(342, 34)
        Me.UBookCopiesTextBox.TabIndex = 65
        '
        'UBookPublisherComboBox
        '
        Me.UBookPublisherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UBookPublisherComboBox.FormattingEnabled = True
        Me.UBookPublisherComboBox.Location = New System.Drawing.Point(453, 275)
        Me.UBookPublisherComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UBookPublisherComboBox.Name = "UBookPublisherComboBox"
        Me.UBookPublisherComboBox.Size = New System.Drawing.Size(342, 36)
        Me.UBookPublisherComboBox.TabIndex = 64
        '
        'UBookAuthorComboBox
        '
        Me.UBookAuthorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UBookAuthorComboBox.FormattingEnabled = True
        Me.UBookAuthorComboBox.Location = New System.Drawing.Point(453, 203)
        Me.UBookAuthorComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UBookAuthorComboBox.Name = "UBookAuthorComboBox"
        Me.UBookAuthorComboBox.Size = New System.Drawing.Size(342, 36)
        Me.UBookAuthorComboBox.TabIndex = 62
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(448, 97)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(49, 28)
        Me.Label21.TabIndex = 61
        Me.Label21.Text = "Title"
        '
        'UBookTitleTextBox
        '
        Me.UBookTitleTextBox.Location = New System.Drawing.Point(453, 132)
        Me.UBookTitleTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UBookTitleTextBox.Name = "UBookTitleTextBox"
        Me.UBookTitleTextBox.Size = New System.Drawing.Size(342, 34)
        Me.UBookTitleTextBox.TabIndex = 60
        '
        'UBookGenreComboBox
        '
        Me.UBookGenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UBookGenreComboBox.FormattingEnabled = True
        Me.UBookGenreComboBox.Location = New System.Drawing.Point(453, 347)
        Me.UBookGenreComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UBookGenreComboBox.Name = "UBookGenreComboBox"
        Me.UBookGenreComboBox.Size = New System.Drawing.Size(342, 36)
        Me.UBookGenreComboBox.TabIndex = 58
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(448, 18)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(54, 28)
        Me.Label23.TabIndex = 55
        Me.Label23.Text = "ISBN"
        '
        'BookUpdateBtn
        '
        Me.BookUpdateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BookUpdateBtn.FlatAppearance.BorderSize = 0
        Me.BookUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BookUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BookUpdateBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BookUpdateBtn.ForeColor = System.Drawing.Color.White
        Me.BookUpdateBtn.Location = New System.Drawing.Point(453, 475)
        Me.BookUpdateBtn.Name = "BookUpdateBtn"
        Me.BookUpdateBtn.Size = New System.Drawing.Size(342, 40)
        Me.BookUpdateBtn.TabIndex = 51
        Me.BookUpdateBtn.Text = "Update Book"
        Me.BookUpdateBtn.UseVisualStyleBackColor = False
        '
        'BookDeletePanel
        '
        Me.BookDeletePanel.Controls.Add(Me.DBookGenreTextBox)
        Me.BookDeletePanel.Controls.Add(Me.DBookPublisherTextBox)
        Me.BookDeletePanel.Controls.Add(Me.DBookAuthorTextBox)
        Me.BookDeletePanel.Controls.Add(Me.DBookISBNComboBox)
        Me.BookDeletePanel.Controls.Add(Label3)
        Me.BookDeletePanel.Controls.Add(Me.Label8)
        Me.BookDeletePanel.Controls.Add(Me.DBookCopiesTextBox)
        Me.BookDeletePanel.Controls.Add(Label9)
        Me.BookDeletePanel.Controls.Add(Me.Label10)
        Me.BookDeletePanel.Controls.Add(Me.DBookTitleTextBox)
        Me.BookDeletePanel.Controls.Add(Label11)
        Me.BookDeletePanel.Controls.Add(Me.Label12)
        Me.BookDeletePanel.Controls.Add(Me.BookDeleteBtn)
        Me.BookDeletePanel.Location = New System.Drawing.Point(12, 83)
        Me.BookDeletePanel.Name = "BookDeletePanel"
        Me.BookDeletePanel.Size = New System.Drawing.Size(1242, 533)
        Me.BookDeletePanel.TabIndex = 27
        '
        'DBookGenreTextBox
        '
        Me.DBookGenreTextBox.Enabled = False
        Me.DBookGenreTextBox.Location = New System.Drawing.Point(453, 349)
        Me.DBookGenreTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DBookGenreTextBox.Name = "DBookGenreTextBox"
        Me.DBookGenreTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DBookGenreTextBox.TabIndex = 73
        '
        'DBookPublisherTextBox
        '
        Me.DBookPublisherTextBox.Enabled = False
        Me.DBookPublisherTextBox.Location = New System.Drawing.Point(453, 273)
        Me.DBookPublisherTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DBookPublisherTextBox.Name = "DBookPublisherTextBox"
        Me.DBookPublisherTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DBookPublisherTextBox.TabIndex = 72
        '
        'DBookAuthorTextBox
        '
        Me.DBookAuthorTextBox.Enabled = False
        Me.DBookAuthorTextBox.Location = New System.Drawing.Point(453, 206)
        Me.DBookAuthorTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DBookAuthorTextBox.Name = "DBookAuthorTextBox"
        Me.DBookAuthorTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DBookAuthorTextBox.TabIndex = 71
        '
        'DBookISBNComboBox
        '
        Me.DBookISBNComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DBookISBNComboBox.FormattingEnabled = True
        Me.DBookISBNComboBox.Location = New System.Drawing.Point(453, 52)
        Me.DBookISBNComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DBookISBNComboBox.Name = "DBookISBNComboBox"
        Me.DBookISBNComboBox.Size = New System.Drawing.Size(342, 36)
        Me.DBookISBNComboBox.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(448, 388)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(171, 28)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Number of Copies"
        '
        'DBookCopiesTextBox
        '
        Me.DBookCopiesTextBox.Enabled = False
        Me.DBookCopiesTextBox.Location = New System.Drawing.Point(453, 426)
        Me.DBookCopiesTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DBookCopiesTextBox.Name = "DBookCopiesTextBox"
        Me.DBookCopiesTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DBookCopiesTextBox.TabIndex = 65
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(448, 97)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(49, 28)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Title"
        '
        'DBookTitleTextBox
        '
        Me.DBookTitleTextBox.Enabled = False
        Me.DBookTitleTextBox.Location = New System.Drawing.Point(453, 132)
        Me.DBookTitleTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DBookTitleTextBox.Name = "DBookTitleTextBox"
        Me.DBookTitleTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DBookTitleTextBox.TabIndex = 60
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(448, 18)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(54, 28)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "ISBN"
        '
        'BookDeleteBtn
        '
        Me.BookDeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BookDeleteBtn.FlatAppearance.BorderSize = 0
        Me.BookDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BookDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BookDeleteBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BookDeleteBtn.ForeColor = System.Drawing.Color.White
        Me.BookDeleteBtn.Location = New System.Drawing.Point(453, 475)
        Me.BookDeleteBtn.Name = "BookDeleteBtn"
        Me.BookDeleteBtn.Size = New System.Drawing.Size(342, 40)
        Me.BookDeleteBtn.TabIndex = 51
        Me.BookDeleteBtn.Text = "Delete Book"
        Me.BookDeleteBtn.UseVisualStyleBackColor = False
        '
        'frmBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 627)
        Me.ControlBox = False
        Me.Controls.Add(Me.BookViewPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BookDeletePanel)
        Me.Controls.Add(Me.BookUpdatePanel)
        Me.Controls.Add(Me.BookAddPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmBooks"
        Me.Text = "frmBooks"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.BookViewPanel.ResumeLayout(False)
        CType(Me.BookDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BookAddPanel.ResumeLayout(False)
        Me.BookAddPanel.PerformLayout()
        Me.BookUpdatePanel.ResumeLayout(False)
        Me.BookUpdatePanel.PerformLayout()
        Me.BookDeletePanel.ResumeLayout(False)
        Me.BookDeletePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents BookViewPanel As System.Windows.Forms.Panel
    Friend WithEvents ExportBtn As System.Windows.Forms.Button
    Friend WithEvents BookDGV As System.Windows.Forms.DataGridView
    Friend WithEvents BookAddPanel As System.Windows.Forms.Panel
    Friend WithEvents ABookGenreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ABookISBNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BookAddBtn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ABookCopiesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ABookPublisherComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ABookAuthorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ABookTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BookUpdatePanel As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents UBookCopiesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UBookPublisherComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UBookAuthorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents UBookTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UBookGenreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents BookUpdateBtn As System.Windows.Forms.Button
    Friend WithEvents UBookISBNComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BookDeletePanel As System.Windows.Forms.Panel
    Friend WithEvents DBookGenreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DBookPublisherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DBookAuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DBookISBNComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DBookCopiesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DBookTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BookDeleteBtn As System.Windows.Forms.Button
End Class
