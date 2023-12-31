<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPublishers
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.PublisherViewPanel = New System.Windows.Forms.Panel()
        Me.ExportBtn = New System.Windows.Forms.Button()
        Me.PublisherDGV = New System.Windows.Forms.DataGridView()
        Me.PublisherDeletePanel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DPublisherIDComboBox = New System.Windows.Forms.ComboBox()
        Me.DPublisherAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DPublisherContactTextBox = New System.Windows.Forms.TextBox()
        Me.DPublisherNameTextBox = New System.Windows.Forms.TextBox()
        Me.PublisherDeleteBtn = New System.Windows.Forms.Button()
        Me.PublisherUpdatePanel = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UPublisherIDComboBox = New System.Windows.Forms.ComboBox()
        Me.UPublisherAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UPublisherContactTextBox = New System.Windows.Forms.TextBox()
        Me.UPublisherNameTextBox = New System.Windows.Forms.TextBox()
        Me.PublisherUpdateBtn = New System.Windows.Forms.Button()
        Me.PublisherAddBtn = New System.Windows.Forms.Button()
        Me.APublisherNameTextBox = New System.Windows.Forms.TextBox()
        Me.APublisherContactTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.APublisherAddressTextBox = New System.Windows.Forms.TextBox()
        Me.PublisherAddPanel = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.PublisherViewPanel.SuspendLayout()
        CType(Me.PublisherDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PublisherDeletePanel.SuspendLayout()
        Me.PublisherUpdatePanel.SuspendLayout()
        Me.PublisherAddPanel.SuspendLayout()
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
        Me.Panel2.TabIndex = 11
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.TitleLabel.Location = New System.Drawing.Point(575, 16)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(115, 28)
        Me.TitleLabel.TabIndex = 14
        Me.TitleLabel.Text = "Publishers"
        '
        'PublisherViewPanel
        '
        Me.PublisherViewPanel.Controls.Add(Me.ExportBtn)
        Me.PublisherViewPanel.Controls.Add(Me.PublisherDGV)
        Me.PublisherViewPanel.Location = New System.Drawing.Point(12, 82)
        Me.PublisherViewPanel.Name = "PublisherViewPanel"
        Me.PublisherViewPanel.Size = New System.Drawing.Size(1242, 533)
        Me.PublisherViewPanel.TabIndex = 12
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
        'PublisherDGV
        '
        Me.PublisherDGV.AllowUserToAddRows = False
        Me.PublisherDGV.AllowUserToDeleteRows = False
        Me.PublisherDGV.AllowUserToResizeColumns = False
        Me.PublisherDGV.AllowUserToResizeRows = False
        Me.PublisherDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PublisherDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.PublisherDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PublisherDGV.Location = New System.Drawing.Point(89, 27)
        Me.PublisherDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.PublisherDGV.Name = "PublisherDGV"
        Me.PublisherDGV.ReadOnly = True
        Me.PublisherDGV.RowHeadersWidth = 21
        Me.PublisherDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PublisherDGV.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.PublisherDGV.RowTemplate.Height = 24
        Me.PublisherDGV.Size = New System.Drawing.Size(1065, 432)
        Me.PublisherDGV.TabIndex = 41
        '
        'PublisherDeletePanel
        '
        Me.PublisherDeletePanel.Controls.Add(Me.Label8)
        Me.PublisherDeletePanel.Controls.Add(Me.DPublisherIDComboBox)
        Me.PublisherDeletePanel.Controls.Add(Me.DPublisherAddressTextBox)
        Me.PublisherDeletePanel.Controls.Add(Me.Label9)
        Me.PublisherDeletePanel.Controls.Add(Me.Label10)
        Me.PublisherDeletePanel.Controls.Add(Me.Label11)
        Me.PublisherDeletePanel.Controls.Add(Me.DPublisherContactTextBox)
        Me.PublisherDeletePanel.Controls.Add(Me.DPublisherNameTextBox)
        Me.PublisherDeletePanel.Controls.Add(Me.PublisherDeleteBtn)
        Me.PublisherDeletePanel.Location = New System.Drawing.Point(12, 81)
        Me.PublisherDeletePanel.Name = "PublisherDeletePanel"
        Me.PublisherDeletePanel.Size = New System.Drawing.Size(1242, 533)
        Me.PublisherDeletePanel.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(448, 77)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(116, 28)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Publisher ID"
        '
        'DPublisherIDComboBox
        '
        Me.DPublisherIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DPublisherIDComboBox.FormattingEnabled = True
        Me.DPublisherIDComboBox.Location = New System.Drawing.Point(453, 109)
        Me.DPublisherIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DPublisherIDComboBox.Name = "DPublisherIDComboBox"
        Me.DPublisherIDComboBox.Size = New System.Drawing.Size(342, 36)
        Me.DPublisherIDComboBox.TabIndex = 58
        '
        'DPublisherAddressTextBox
        '
        Me.DPublisherAddressTextBox.Enabled = False
        Me.DPublisherAddressTextBox.Location = New System.Drawing.Point(453, 346)
        Me.DPublisherAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DPublisherAddressTextBox.Name = "DPublisherAddressTextBox"
        Me.DPublisherAddressTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DPublisherAddressTextBox.TabIndex = 57
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
        'DPublisherContactTextBox
        '
        Me.DPublisherContactTextBox.Enabled = False
        Me.DPublisherContactTextBox.Location = New System.Drawing.Point(453, 270)
        Me.DPublisherContactTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DPublisherContactTextBox.Name = "DPublisherContactTextBox"
        Me.DPublisherContactTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DPublisherContactTextBox.TabIndex = 53
        '
        'DPublisherNameTextBox
        '
        Me.DPublisherNameTextBox.Enabled = False
        Me.DPublisherNameTextBox.Location = New System.Drawing.Point(453, 187)
        Me.DPublisherNameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DPublisherNameTextBox.Name = "DPublisherNameTextBox"
        Me.DPublisherNameTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DPublisherNameTextBox.TabIndex = 52
        '
        'PublisherDeleteBtn
        '
        Me.PublisherDeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PublisherDeleteBtn.FlatAppearance.BorderSize = 0
        Me.PublisherDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.PublisherDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PublisherDeleteBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PublisherDeleteBtn.ForeColor = System.Drawing.Color.White
        Me.PublisherDeleteBtn.Location = New System.Drawing.Point(453, 416)
        Me.PublisherDeleteBtn.Name = "PublisherDeleteBtn"
        Me.PublisherDeleteBtn.Size = New System.Drawing.Size(342, 40)
        Me.PublisherDeleteBtn.TabIndex = 51
        Me.PublisherDeleteBtn.Text = "Delete Publisher"
        Me.PublisherDeleteBtn.UseVisualStyleBackColor = False
        '
        'PublisherUpdatePanel
        '
        Me.PublisherUpdatePanel.Controls.Add(Me.Label7)
        Me.PublisherUpdatePanel.Controls.Add(Me.UPublisherIDComboBox)
        Me.PublisherUpdatePanel.Controls.Add(Me.UPublisherAddressTextBox)
        Me.PublisherUpdatePanel.Controls.Add(Me.Label2)
        Me.PublisherUpdatePanel.Controls.Add(Me.Label5)
        Me.PublisherUpdatePanel.Controls.Add(Me.Label6)
        Me.PublisherUpdatePanel.Controls.Add(Me.UPublisherContactTextBox)
        Me.PublisherUpdatePanel.Controls.Add(Me.UPublisherNameTextBox)
        Me.PublisherUpdatePanel.Controls.Add(Me.PublisherUpdateBtn)
        Me.PublisherUpdatePanel.Location = New System.Drawing.Point(12, 81)
        Me.PublisherUpdatePanel.Name = "PublisherUpdatePanel"
        Me.PublisherUpdatePanel.Size = New System.Drawing.Size(1242, 533)
        Me.PublisherUpdatePanel.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(448, 77)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(116, 28)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Publisher ID"
        '
        'UPublisherIDComboBox
        '
        Me.UPublisherIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UPublisherIDComboBox.FormattingEnabled = True
        Me.UPublisherIDComboBox.Location = New System.Drawing.Point(453, 109)
        Me.UPublisherIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UPublisherIDComboBox.Name = "UPublisherIDComboBox"
        Me.UPublisherIDComboBox.Size = New System.Drawing.Size(342, 36)
        Me.UPublisherIDComboBox.TabIndex = 58
        '
        'UPublisherAddressTextBox
        '
        Me.UPublisherAddressTextBox.Location = New System.Drawing.Point(453, 346)
        Me.UPublisherAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UPublisherAddressTextBox.Name = "UPublisherAddressTextBox"
        Me.UPublisherAddressTextBox.Size = New System.Drawing.Size(342, 34)
        Me.UPublisherAddressTextBox.TabIndex = 57
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
        'UPublisherContactTextBox
        '
        Me.UPublisherContactTextBox.Location = New System.Drawing.Point(453, 270)
        Me.UPublisherContactTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UPublisherContactTextBox.Name = "UPublisherContactTextBox"
        Me.UPublisherContactTextBox.Size = New System.Drawing.Size(342, 34)
        Me.UPublisherContactTextBox.TabIndex = 53
        '
        'UPublisherNameTextBox
        '
        Me.UPublisherNameTextBox.Location = New System.Drawing.Point(453, 187)
        Me.UPublisherNameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UPublisherNameTextBox.Name = "UPublisherNameTextBox"
        Me.UPublisherNameTextBox.Size = New System.Drawing.Size(342, 34)
        Me.UPublisherNameTextBox.TabIndex = 52
        '
        'PublisherUpdateBtn
        '
        Me.PublisherUpdateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PublisherUpdateBtn.FlatAppearance.BorderSize = 0
        Me.PublisherUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.PublisherUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PublisherUpdateBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PublisherUpdateBtn.ForeColor = System.Drawing.Color.White
        Me.PublisherUpdateBtn.Location = New System.Drawing.Point(453, 416)
        Me.PublisherUpdateBtn.Name = "PublisherUpdateBtn"
        Me.PublisherUpdateBtn.Size = New System.Drawing.Size(342, 40)
        Me.PublisherUpdateBtn.TabIndex = 51
        Me.PublisherUpdateBtn.Text = "Update Publisher "
        Me.PublisherUpdateBtn.UseVisualStyleBackColor = False
        '
        'PublisherAddBtn
        '
        Me.PublisherAddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PublisherAddBtn.FlatAppearance.BorderSize = 0
        Me.PublisherAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.PublisherAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PublisherAddBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PublisherAddBtn.ForeColor = System.Drawing.Color.White
        Me.PublisherAddBtn.Location = New System.Drawing.Point(453, 380)
        Me.PublisherAddBtn.Name = "PublisherAddBtn"
        Me.PublisherAddBtn.Size = New System.Drawing.Size(342, 40)
        Me.PublisherAddBtn.TabIndex = 51
        Me.PublisherAddBtn.Text = "Add Publisher"
        Me.PublisherAddBtn.UseVisualStyleBackColor = False
        '
        'APublisherNameTextBox
        '
        Me.APublisherNameTextBox.Location = New System.Drawing.Point(453, 151)
        Me.APublisherNameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.APublisherNameTextBox.Name = "APublisherNameTextBox"
        Me.APublisherNameTextBox.Size = New System.Drawing.Size(342, 34)
        Me.APublisherNameTextBox.TabIndex = 52
        '
        'APublisherContactTextBox
        '
        Me.APublisherContactTextBox.Location = New System.Drawing.Point(453, 234)
        Me.APublisherContactTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.APublisherContactTextBox.Name = "APublisherContactTextBox"
        Me.APublisherContactTextBox.Size = New System.Drawing.Size(342, 34)
        Me.APublisherContactTextBox.TabIndex = 53
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
        'APublisherAddressTextBox
        '
        Me.APublisherAddressTextBox.Location = New System.Drawing.Point(453, 310)
        Me.APublisherAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.APublisherAddressTextBox.Name = "APublisherAddressTextBox"
        Me.APublisherAddressTextBox.Size = New System.Drawing.Size(342, 34)
        Me.APublisherAddressTextBox.TabIndex = 57
        '
        'PublisherAddPanel
        '
        Me.PublisherAddPanel.Controls.Add(Me.APublisherAddressTextBox)
        Me.PublisherAddPanel.Controls.Add(Me.Label1)
        Me.PublisherAddPanel.Controls.Add(Me.Label3)
        Me.PublisherAddPanel.Controls.Add(Me.Label4)
        Me.PublisherAddPanel.Controls.Add(Me.APublisherContactTextBox)
        Me.PublisherAddPanel.Controls.Add(Me.APublisherNameTextBox)
        Me.PublisherAddPanel.Controls.Add(Me.PublisherAddBtn)
        Me.PublisherAddPanel.Location = New System.Drawing.Point(12, 81)
        Me.PublisherAddPanel.Name = "PublisherAddPanel"
        Me.PublisherAddPanel.Size = New System.Drawing.Size(1242, 533)
        Me.PublisherAddPanel.TabIndex = 13
        '
        'frmPublishers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 627)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PublisherAddPanel)
        Me.Controls.Add(Me.PublisherViewPanel)
        Me.Controls.Add(Me.PublisherUpdatePanel)
        Me.Controls.Add(Me.PublisherDeletePanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmPublishers"
        Me.Text = "frmPublishers"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PublisherViewPanel.ResumeLayout(False)
        CType(Me.PublisherDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PublisherDeletePanel.ResumeLayout(False)
        Me.PublisherDeletePanel.PerformLayout()
        Me.PublisherUpdatePanel.ResumeLayout(False)
        Me.PublisherUpdatePanel.PerformLayout()
        Me.PublisherAddPanel.ResumeLayout(False)
        Me.PublisherAddPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents PublisherViewPanel As System.Windows.Forms.Panel
    Friend WithEvents ExportBtn As System.Windows.Forms.Button
    Friend WithEvents PublisherDGV As System.Windows.Forms.DataGridView
    Friend WithEvents PublisherDeletePanel As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DPublisherIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DPublisherAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DPublisherContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DPublisherNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PublisherDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents PublisherUpdatePanel As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UPublisherIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UPublisherAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents UPublisherContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UPublisherNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PublisherUpdateBtn As System.Windows.Forms.Button
    Friend WithEvents PublisherAddBtn As System.Windows.Forms.Button
    Friend WithEvents APublisherNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents APublisherContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents APublisherAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PublisherAddPanel As System.Windows.Forms.Panel
End Class
