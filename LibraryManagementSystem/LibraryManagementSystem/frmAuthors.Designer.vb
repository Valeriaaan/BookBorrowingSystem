<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuthors
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.AuthorViewPanel = New System.Windows.Forms.Panel()
        Me.ExportBtn = New System.Windows.Forms.Button()
        Me.AuthorDGV = New System.Windows.Forms.DataGridView()
        Me.AuthorAddPanel = New System.Windows.Forms.Panel()
        Me.AAuthorAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AAuthorContactTextBox = New System.Windows.Forms.TextBox()
        Me.AAuthorNameTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorAddBtn = New System.Windows.Forms.Button()
        Me.AuthorUpdatePanel = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UAuthorIDComboBox = New System.Windows.Forms.ComboBox()
        Me.UAuthorAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UAuthorContactTextBox = New System.Windows.Forms.TextBox()
        Me.UAuthorNameTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorUpdateBtn = New System.Windows.Forms.Button()
        Me.AuthorDeletePanel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DAuthorIDComboBox = New System.Windows.Forms.ComboBox()
        Me.DAuthorAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DAuthorContactTextBox = New System.Windows.Forms.TextBox()
        Me.DAuthorNameTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorDeleteBtn = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.AuthorViewPanel.SuspendLayout()
        CType(Me.AuthorDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AuthorAddPanel.SuspendLayout()
        Me.AuthorUpdatePanel.SuspendLayout()
        Me.AuthorDeletePanel.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel2.TabIndex = 10
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.TitleLabel.Location = New System.Drawing.Point(586, 16)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(92, 28)
        Me.TitleLabel.TabIndex = 14
        Me.TitleLabel.Text = "Authors"
        '
        'AuthorViewPanel
        '
        Me.AuthorViewPanel.Controls.Add(Me.ExportBtn)
        Me.AuthorViewPanel.Controls.Add(Me.AuthorDGV)
        Me.AuthorViewPanel.Location = New System.Drawing.Point(12, 82)
        Me.AuthorViewPanel.Name = "AuthorViewPanel"
        Me.AuthorViewPanel.Size = New System.Drawing.Size(1242, 533)
        Me.AuthorViewPanel.TabIndex = 11
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
        'AuthorDGV
        '
        Me.AuthorDGV.AllowUserToAddRows = False
        Me.AuthorDGV.AllowUserToDeleteRows = False
        Me.AuthorDGV.AllowUserToResizeColumns = False
        Me.AuthorDGV.AllowUserToResizeRows = False
        Me.AuthorDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AuthorDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AuthorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AuthorDGV.Location = New System.Drawing.Point(89, 27)
        Me.AuthorDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.AuthorDGV.Name = "AuthorDGV"
        Me.AuthorDGV.ReadOnly = True
        Me.AuthorDGV.RowHeadersWidth = 21
        Me.AuthorDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AuthorDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AuthorDGV.RowTemplate.Height = 24
        Me.AuthorDGV.Size = New System.Drawing.Size(1065, 432)
        Me.AuthorDGV.TabIndex = 41
        '
        'AuthorAddPanel
        '
        Me.AuthorAddPanel.Controls.Add(Me.AAuthorAddressTextBox)
        Me.AuthorAddPanel.Controls.Add(Me.Label1)
        Me.AuthorAddPanel.Controls.Add(Me.Label3)
        Me.AuthorAddPanel.Controls.Add(Me.Label4)
        Me.AuthorAddPanel.Controls.Add(Me.AAuthorContactTextBox)
        Me.AuthorAddPanel.Controls.Add(Me.AAuthorNameTextBox)
        Me.AuthorAddPanel.Controls.Add(Me.AuthorAddBtn)
        Me.AuthorAddPanel.Location = New System.Drawing.Point(12, 81)
        Me.AuthorAddPanel.Name = "AuthorAddPanel"
        Me.AuthorAddPanel.Size = New System.Drawing.Size(1242, 533)
        Me.AuthorAddPanel.TabIndex = 12
        '
        'AAuthorAddressTextBox
        '
        Me.AAuthorAddressTextBox.Location = New System.Drawing.Point(453, 310)
        Me.AAuthorAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.AAuthorAddressTextBox.Name = "AAuthorAddressTextBox"
        Me.AAuthorAddressTextBox.Size = New System.Drawing.Size(342, 34)
        Me.AAuthorAddressTextBox.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(448, 275)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(82, 28)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(448, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(64, 28)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(448, 193)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(80, 28)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Contact"
        '
        'AAuthorContactTextBox
        '
        Me.AAuthorContactTextBox.Location = New System.Drawing.Point(453, 234)
        Me.AAuthorContactTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.AAuthorContactTextBox.Name = "AAuthorContactTextBox"
        Me.AAuthorContactTextBox.Size = New System.Drawing.Size(342, 34)
        Me.AAuthorContactTextBox.TabIndex = 53
        '
        'AAuthorNameTextBox
        '
        Me.AAuthorNameTextBox.Location = New System.Drawing.Point(453, 151)
        Me.AAuthorNameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.AAuthorNameTextBox.Name = "AAuthorNameTextBox"
        Me.AAuthorNameTextBox.Size = New System.Drawing.Size(342, 34)
        Me.AAuthorNameTextBox.TabIndex = 52
        '
        'AuthorAddBtn
        '
        Me.AuthorAddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.AuthorAddBtn.FlatAppearance.BorderSize = 0
        Me.AuthorAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.AuthorAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AuthorAddBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AuthorAddBtn.ForeColor = System.Drawing.Color.White
        Me.AuthorAddBtn.Location = New System.Drawing.Point(453, 380)
        Me.AuthorAddBtn.Name = "AuthorAddBtn"
        Me.AuthorAddBtn.Size = New System.Drawing.Size(342, 40)
        Me.AuthorAddBtn.TabIndex = 51
        Me.AuthorAddBtn.Text = "Add Author"
        Me.AuthorAddBtn.UseVisualStyleBackColor = False
        '
        'AuthorUpdatePanel
        '
        Me.AuthorUpdatePanel.Controls.Add(Me.Label7)
        Me.AuthorUpdatePanel.Controls.Add(Me.UAuthorIDComboBox)
        Me.AuthorUpdatePanel.Controls.Add(Me.UAuthorAddressTextBox)
        Me.AuthorUpdatePanel.Controls.Add(Me.Label2)
        Me.AuthorUpdatePanel.Controls.Add(Me.Label5)
        Me.AuthorUpdatePanel.Controls.Add(Me.Label6)
        Me.AuthorUpdatePanel.Controls.Add(Me.UAuthorContactTextBox)
        Me.AuthorUpdatePanel.Controls.Add(Me.UAuthorNameTextBox)
        Me.AuthorUpdatePanel.Controls.Add(Me.AuthorUpdateBtn)
        Me.AuthorUpdatePanel.Location = New System.Drawing.Point(12, 80)
        Me.AuthorUpdatePanel.Name = "AuthorUpdatePanel"
        Me.AuthorUpdatePanel.Size = New System.Drawing.Size(1242, 533)
        Me.AuthorUpdatePanel.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(448, 77)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(97, 28)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Author ID"
        '
        'UAuthorIDComboBox
        '
        Me.UAuthorIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UAuthorIDComboBox.FormattingEnabled = True
        Me.UAuthorIDComboBox.Location = New System.Drawing.Point(453, 109)
        Me.UAuthorIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UAuthorIDComboBox.Name = "UAuthorIDComboBox"
        Me.UAuthorIDComboBox.Size = New System.Drawing.Size(342, 36)
        Me.UAuthorIDComboBox.TabIndex = 58
        '
        'UAuthorAddressTextBox
        '
        Me.UAuthorAddressTextBox.Location = New System.Drawing.Point(453, 346)
        Me.UAuthorAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UAuthorAddressTextBox.Name = "UAuthorAddressTextBox"
        Me.UAuthorAddressTextBox.Size = New System.Drawing.Size(342, 34)
        Me.UAuthorAddressTextBox.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(448, 311)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(82, 28)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(448, 149)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(64, 28)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(448, 229)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(80, 28)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Contact"
        '
        'UAuthorContactTextBox
        '
        Me.UAuthorContactTextBox.Location = New System.Drawing.Point(453, 270)
        Me.UAuthorContactTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UAuthorContactTextBox.Name = "UAuthorContactTextBox"
        Me.UAuthorContactTextBox.Size = New System.Drawing.Size(342, 34)
        Me.UAuthorContactTextBox.TabIndex = 53
        '
        'UAuthorNameTextBox
        '
        Me.UAuthorNameTextBox.Location = New System.Drawing.Point(453, 187)
        Me.UAuthorNameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UAuthorNameTextBox.Name = "UAuthorNameTextBox"
        Me.UAuthorNameTextBox.Size = New System.Drawing.Size(342, 34)
        Me.UAuthorNameTextBox.TabIndex = 52
        '
        'AuthorUpdateBtn
        '
        Me.AuthorUpdateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.AuthorUpdateBtn.FlatAppearance.BorderSize = 0
        Me.AuthorUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.AuthorUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AuthorUpdateBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AuthorUpdateBtn.ForeColor = System.Drawing.Color.White
        Me.AuthorUpdateBtn.Location = New System.Drawing.Point(453, 416)
        Me.AuthorUpdateBtn.Name = "AuthorUpdateBtn"
        Me.AuthorUpdateBtn.Size = New System.Drawing.Size(342, 40)
        Me.AuthorUpdateBtn.TabIndex = 51
        Me.AuthorUpdateBtn.Text = "Update Author"
        Me.AuthorUpdateBtn.UseVisualStyleBackColor = False
        '
        'AuthorDeletePanel
        '
        Me.AuthorDeletePanel.Controls.Add(Me.Label8)
        Me.AuthorDeletePanel.Controls.Add(Me.DAuthorIDComboBox)
        Me.AuthorDeletePanel.Controls.Add(Me.DAuthorAddressTextBox)
        Me.AuthorDeletePanel.Controls.Add(Me.Label9)
        Me.AuthorDeletePanel.Controls.Add(Me.Label10)
        Me.AuthorDeletePanel.Controls.Add(Me.Label11)
        Me.AuthorDeletePanel.Controls.Add(Me.DAuthorContactTextBox)
        Me.AuthorDeletePanel.Controls.Add(Me.DAuthorNameTextBox)
        Me.AuthorDeletePanel.Controls.Add(Me.AuthorDeleteBtn)
        Me.AuthorDeletePanel.Location = New System.Drawing.Point(12, 79)
        Me.AuthorDeletePanel.Name = "AuthorDeletePanel"
        Me.AuthorDeletePanel.Size = New System.Drawing.Size(1242, 533)
        Me.AuthorDeletePanel.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(448, 77)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(97, 28)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Author ID"
        '
        'DAuthorIDComboBox
        '
        Me.DAuthorIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DAuthorIDComboBox.FormattingEnabled = True
        Me.DAuthorIDComboBox.Location = New System.Drawing.Point(453, 109)
        Me.DAuthorIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DAuthorIDComboBox.Name = "DAuthorIDComboBox"
        Me.DAuthorIDComboBox.Size = New System.Drawing.Size(342, 36)
        Me.DAuthorIDComboBox.TabIndex = 58
        '
        'DAuthorAddressTextBox
        '
        Me.DAuthorAddressTextBox.Enabled = False
        Me.DAuthorAddressTextBox.Location = New System.Drawing.Point(453, 346)
        Me.DAuthorAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DAuthorAddressTextBox.Name = "DAuthorAddressTextBox"
        Me.DAuthorAddressTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DAuthorAddressTextBox.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(448, 311)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(82, 28)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(448, 149)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(64, 28)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(448, 229)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(80, 28)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Contact"
        '
        'DAuthorContactTextBox
        '
        Me.DAuthorContactTextBox.Enabled = False
        Me.DAuthorContactTextBox.Location = New System.Drawing.Point(453, 270)
        Me.DAuthorContactTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DAuthorContactTextBox.Name = "DAuthorContactTextBox"
        Me.DAuthorContactTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DAuthorContactTextBox.TabIndex = 53
        '
        'DAuthorNameTextBox
        '
        Me.DAuthorNameTextBox.Enabled = False
        Me.DAuthorNameTextBox.Location = New System.Drawing.Point(453, 187)
        Me.DAuthorNameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DAuthorNameTextBox.Name = "DAuthorNameTextBox"
        Me.DAuthorNameTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DAuthorNameTextBox.TabIndex = 52
        '
        'AuthorDeleteBtn
        '
        Me.AuthorDeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.AuthorDeleteBtn.FlatAppearance.BorderSize = 0
        Me.AuthorDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.AuthorDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AuthorDeleteBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AuthorDeleteBtn.ForeColor = System.Drawing.Color.White
        Me.AuthorDeleteBtn.Location = New System.Drawing.Point(453, 416)
        Me.AuthorDeleteBtn.Name = "AuthorDeleteBtn"
        Me.AuthorDeleteBtn.Size = New System.Drawing.Size(342, 40)
        Me.AuthorDeleteBtn.TabIndex = 51
        Me.AuthorDeleteBtn.Text = "Delete Author"
        Me.AuthorDeleteBtn.UseVisualStyleBackColor = False
        '
        'frmAuthors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 627)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.AuthorUpdatePanel)
        Me.Controls.Add(Me.AuthorAddPanel)
        Me.Controls.Add(Me.AuthorViewPanel)
        Me.Controls.Add(Me.AuthorDeletePanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmAuthors"
        Me.Text = "frmAuthors"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.AuthorViewPanel.ResumeLayout(False)
        CType(Me.AuthorDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AuthorAddPanel.ResumeLayout(False)
        Me.AuthorAddPanel.PerformLayout()
        Me.AuthorUpdatePanel.ResumeLayout(False)
        Me.AuthorUpdatePanel.PerformLayout()
        Me.AuthorDeletePanel.ResumeLayout(False)
        Me.AuthorDeletePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents AuthorViewPanel As System.Windows.Forms.Panel
    Friend WithEvents AuthorDGV As System.Windows.Forms.DataGridView
    Friend WithEvents ExportBtn As System.Windows.Forms.Button
    Friend WithEvents AuthorAddPanel As System.Windows.Forms.Panel
    Friend WithEvents AuthorAddBtn As System.Windows.Forms.Button
    Friend WithEvents AAuthorAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AAuthorContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AAuthorNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorUpdatePanel As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UAuthorIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UAuthorAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents UAuthorContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UAuthorNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorUpdateBtn As System.Windows.Forms.Button
    Friend WithEvents AuthorDeletePanel As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DAuthorIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DAuthorAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DAuthorContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DAuthorNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorDeleteBtn As System.Windows.Forms.Button
End Class
