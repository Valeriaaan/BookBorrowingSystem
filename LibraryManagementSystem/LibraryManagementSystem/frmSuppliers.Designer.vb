<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuppliers
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
        Me.SupplierViewPanel = New System.Windows.Forms.Panel()
        Me.ExportBtn = New System.Windows.Forms.Button()
        Me.SupplierDGV = New System.Windows.Forms.DataGridView()
        Me.SupplierUpdatePanel = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.USupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.USupplierAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.USupplierContactTextBox = New System.Windows.Forms.TextBox()
        Me.USupplierNameTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierUpdateBtn = New System.Windows.Forms.Button()
        Me.SupplierDeletePanel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DSupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.DSupplierAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DSupplierContactTextBox = New System.Windows.Forms.TextBox()
        Me.DSupplierNameTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierDeleteBtn = New System.Windows.Forms.Button()
        Me.SupplierAddPanel = New System.Windows.Forms.Panel()
        Me.ASupplierAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ASupplierContactTextBox = New System.Windows.Forms.TextBox()
        Me.ASupplierNameTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierAddBtn = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SupplierViewPanel.SuspendLayout()
        CType(Me.SupplierDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SupplierUpdatePanel.SuspendLayout()
        Me.SupplierDeletePanel.SuspendLayout()
        Me.SupplierAddPanel.SuspendLayout()
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
        Me.Panel2.TabIndex = 12
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
        Me.TitleLabel.Size = New System.Drawing.Size(104, 28)
        Me.TitleLabel.TabIndex = 14
        Me.TitleLabel.Text = "Suppliers"
        '
        'SupplierViewPanel
        '
        Me.SupplierViewPanel.Controls.Add(Me.ExportBtn)
        Me.SupplierViewPanel.Controls.Add(Me.SupplierDGV)
        Me.SupplierViewPanel.Location = New System.Drawing.Point(12, 82)
        Me.SupplierViewPanel.Name = "SupplierViewPanel"
        Me.SupplierViewPanel.Size = New System.Drawing.Size(1242, 533)
        Me.SupplierViewPanel.TabIndex = 13
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
        'SupplierDGV
        '
        Me.SupplierDGV.AllowUserToAddRows = False
        Me.SupplierDGV.AllowUserToDeleteRows = False
        Me.SupplierDGV.AllowUserToResizeColumns = False
        Me.SupplierDGV.AllowUserToResizeRows = False
        Me.SupplierDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SupplierDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.SupplierDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupplierDGV.Location = New System.Drawing.Point(89, 27)
        Me.SupplierDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.SupplierDGV.Name = "SupplierDGV"
        Me.SupplierDGV.ReadOnly = True
        Me.SupplierDGV.RowHeadersWidth = 21
        Me.SupplierDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SupplierDGV.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.SupplierDGV.RowTemplate.Height = 24
        Me.SupplierDGV.Size = New System.Drawing.Size(1065, 432)
        Me.SupplierDGV.TabIndex = 41
        '
        'SupplierUpdatePanel
        '
        Me.SupplierUpdatePanel.Controls.Add(Me.Label7)
        Me.SupplierUpdatePanel.Controls.Add(Me.USupplierIDComboBox)
        Me.SupplierUpdatePanel.Controls.Add(Me.USupplierAddressTextBox)
        Me.SupplierUpdatePanel.Controls.Add(Me.Label2)
        Me.SupplierUpdatePanel.Controls.Add(Me.Label5)
        Me.SupplierUpdatePanel.Controls.Add(Me.Label6)
        Me.SupplierUpdatePanel.Controls.Add(Me.USupplierContactTextBox)
        Me.SupplierUpdatePanel.Controls.Add(Me.USupplierNameTextBox)
        Me.SupplierUpdatePanel.Controls.Add(Me.SupplierUpdateBtn)
        Me.SupplierUpdatePanel.Location = New System.Drawing.Point(12, 82)
        Me.SupplierUpdatePanel.Name = "SupplierUpdatePanel"
        Me.SupplierUpdatePanel.Size = New System.Drawing.Size(1242, 533)
        Me.SupplierUpdatePanel.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(448, 77)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(109, 28)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Supplier ID"
        '
        'USupplierIDComboBox
        '
        Me.USupplierIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.USupplierIDComboBox.FormattingEnabled = True
        Me.USupplierIDComboBox.Location = New System.Drawing.Point(453, 109)
        Me.USupplierIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.USupplierIDComboBox.Name = "USupplierIDComboBox"
        Me.USupplierIDComboBox.Size = New System.Drawing.Size(342, 36)
        Me.USupplierIDComboBox.TabIndex = 58
        '
        'USupplierAddressTextBox
        '
        Me.USupplierAddressTextBox.Location = New System.Drawing.Point(453, 346)
        Me.USupplierAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.USupplierAddressTextBox.Name = "USupplierAddressTextBox"
        Me.USupplierAddressTextBox.Size = New System.Drawing.Size(342, 34)
        Me.USupplierAddressTextBox.TabIndex = 57
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
        'USupplierContactTextBox
        '
        Me.USupplierContactTextBox.Location = New System.Drawing.Point(453, 270)
        Me.USupplierContactTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.USupplierContactTextBox.Name = "USupplierContactTextBox"
        Me.USupplierContactTextBox.Size = New System.Drawing.Size(342, 34)
        Me.USupplierContactTextBox.TabIndex = 53
        '
        'USupplierNameTextBox
        '
        Me.USupplierNameTextBox.Location = New System.Drawing.Point(453, 187)
        Me.USupplierNameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.USupplierNameTextBox.Name = "USupplierNameTextBox"
        Me.USupplierNameTextBox.Size = New System.Drawing.Size(342, 34)
        Me.USupplierNameTextBox.TabIndex = 52
        '
        'SupplierUpdateBtn
        '
        Me.SupplierUpdateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SupplierUpdateBtn.FlatAppearance.BorderSize = 0
        Me.SupplierUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SupplierUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SupplierUpdateBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SupplierUpdateBtn.ForeColor = System.Drawing.Color.White
        Me.SupplierUpdateBtn.Location = New System.Drawing.Point(453, 416)
        Me.SupplierUpdateBtn.Name = "SupplierUpdateBtn"
        Me.SupplierUpdateBtn.Size = New System.Drawing.Size(342, 40)
        Me.SupplierUpdateBtn.TabIndex = 51
        Me.SupplierUpdateBtn.Text = "Update Supplier"
        Me.SupplierUpdateBtn.UseVisualStyleBackColor = False
        '
        'SupplierDeletePanel
        '
        Me.SupplierDeletePanel.Controls.Add(Me.Label8)
        Me.SupplierDeletePanel.Controls.Add(Me.DSupplierIDComboBox)
        Me.SupplierDeletePanel.Controls.Add(Me.DSupplierAddressTextBox)
        Me.SupplierDeletePanel.Controls.Add(Me.Label9)
        Me.SupplierDeletePanel.Controls.Add(Me.Label10)
        Me.SupplierDeletePanel.Controls.Add(Me.Label11)
        Me.SupplierDeletePanel.Controls.Add(Me.DSupplierContactTextBox)
        Me.SupplierDeletePanel.Controls.Add(Me.DSupplierNameTextBox)
        Me.SupplierDeletePanel.Controls.Add(Me.SupplierDeleteBtn)
        Me.SupplierDeletePanel.Location = New System.Drawing.Point(12, 82)
        Me.SupplierDeletePanel.Name = "SupplierDeletePanel"
        Me.SupplierDeletePanel.Size = New System.Drawing.Size(1242, 533)
        Me.SupplierDeletePanel.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(448, 77)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(109, 28)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Supplier ID"
        '
        'DSupplierIDComboBox
        '
        Me.DSupplierIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DSupplierIDComboBox.FormattingEnabled = True
        Me.DSupplierIDComboBox.Location = New System.Drawing.Point(453, 109)
        Me.DSupplierIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DSupplierIDComboBox.Name = "DSupplierIDComboBox"
        Me.DSupplierIDComboBox.Size = New System.Drawing.Size(342, 36)
        Me.DSupplierIDComboBox.TabIndex = 58
        '
        'DSupplierAddressTextBox
        '
        Me.DSupplierAddressTextBox.Enabled = False
        Me.DSupplierAddressTextBox.Location = New System.Drawing.Point(453, 346)
        Me.DSupplierAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DSupplierAddressTextBox.Name = "DSupplierAddressTextBox"
        Me.DSupplierAddressTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DSupplierAddressTextBox.TabIndex = 57
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
        'DSupplierContactTextBox
        '
        Me.DSupplierContactTextBox.Enabled = False
        Me.DSupplierContactTextBox.Location = New System.Drawing.Point(453, 270)
        Me.DSupplierContactTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DSupplierContactTextBox.Name = "DSupplierContactTextBox"
        Me.DSupplierContactTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DSupplierContactTextBox.TabIndex = 53
        '
        'DSupplierNameTextBox
        '
        Me.DSupplierNameTextBox.Enabled = False
        Me.DSupplierNameTextBox.Location = New System.Drawing.Point(453, 187)
        Me.DSupplierNameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DSupplierNameTextBox.Name = "DSupplierNameTextBox"
        Me.DSupplierNameTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DSupplierNameTextBox.TabIndex = 52
        '
        'SupplierDeleteBtn
        '
        Me.SupplierDeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SupplierDeleteBtn.FlatAppearance.BorderSize = 0
        Me.SupplierDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SupplierDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SupplierDeleteBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SupplierDeleteBtn.ForeColor = System.Drawing.Color.White
        Me.SupplierDeleteBtn.Location = New System.Drawing.Point(453, 416)
        Me.SupplierDeleteBtn.Name = "SupplierDeleteBtn"
        Me.SupplierDeleteBtn.Size = New System.Drawing.Size(342, 40)
        Me.SupplierDeleteBtn.TabIndex = 51
        Me.SupplierDeleteBtn.Text = "Delete Supplier"
        Me.SupplierDeleteBtn.UseVisualStyleBackColor = False
        '
        'SupplierAddPanel
        '
        Me.SupplierAddPanel.Controls.Add(Me.ASupplierAddressTextBox)
        Me.SupplierAddPanel.Controls.Add(Me.Label1)
        Me.SupplierAddPanel.Controls.Add(Me.Label3)
        Me.SupplierAddPanel.Controls.Add(Me.Label4)
        Me.SupplierAddPanel.Controls.Add(Me.ASupplierContactTextBox)
        Me.SupplierAddPanel.Controls.Add(Me.ASupplierNameTextBox)
        Me.SupplierAddPanel.Controls.Add(Me.SupplierAddBtn)
        Me.SupplierAddPanel.Location = New System.Drawing.Point(12, 82)
        Me.SupplierAddPanel.Name = "SupplierAddPanel"
        Me.SupplierAddPanel.Size = New System.Drawing.Size(1242, 533)
        Me.SupplierAddPanel.TabIndex = 19
        '
        'ASupplierAddressTextBox
        '
        Me.ASupplierAddressTextBox.Location = New System.Drawing.Point(453, 310)
        Me.ASupplierAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.ASupplierAddressTextBox.Name = "ASupplierAddressTextBox"
        Me.ASupplierAddressTextBox.Size = New System.Drawing.Size(342, 34)
        Me.ASupplierAddressTextBox.TabIndex = 57
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
        'ASupplierContactTextBox
        '
        Me.ASupplierContactTextBox.Location = New System.Drawing.Point(453, 234)
        Me.ASupplierContactTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.ASupplierContactTextBox.Name = "ASupplierContactTextBox"
        Me.ASupplierContactTextBox.Size = New System.Drawing.Size(342, 34)
        Me.ASupplierContactTextBox.TabIndex = 53
        '
        'ASupplierNameTextBox
        '
        Me.ASupplierNameTextBox.Location = New System.Drawing.Point(453, 151)
        Me.ASupplierNameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.ASupplierNameTextBox.Name = "ASupplierNameTextBox"
        Me.ASupplierNameTextBox.Size = New System.Drawing.Size(342, 34)
        Me.ASupplierNameTextBox.TabIndex = 52
        '
        'SupplierAddBtn
        '
        Me.SupplierAddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SupplierAddBtn.FlatAppearance.BorderSize = 0
        Me.SupplierAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SupplierAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SupplierAddBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SupplierAddBtn.ForeColor = System.Drawing.Color.White
        Me.SupplierAddBtn.Location = New System.Drawing.Point(453, 380)
        Me.SupplierAddBtn.Name = "SupplierAddBtn"
        Me.SupplierAddBtn.Size = New System.Drawing.Size(342, 40)
        Me.SupplierAddBtn.TabIndex = 51
        Me.SupplierAddBtn.Text = "Add Supplier"
        Me.SupplierAddBtn.UseVisualStyleBackColor = False
        '
        'frmSuppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 627)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.SupplierAddPanel)
        Me.Controls.Add(Me.SupplierViewPanel)
        Me.Controls.Add(Me.SupplierDeletePanel)
        Me.Controls.Add(Me.SupplierUpdatePanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmSuppliers"
        Me.Text = "frmSuppliers"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.SupplierViewPanel.ResumeLayout(False)
        CType(Me.SupplierDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SupplierUpdatePanel.ResumeLayout(False)
        Me.SupplierUpdatePanel.PerformLayout()
        Me.SupplierDeletePanel.ResumeLayout(False)
        Me.SupplierDeletePanel.PerformLayout()
        Me.SupplierAddPanel.ResumeLayout(False)
        Me.SupplierAddPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents SupplierViewPanel As System.Windows.Forms.Panel
    Friend WithEvents ExportBtn As System.Windows.Forms.Button
    Friend WithEvents SupplierDGV As System.Windows.Forms.DataGridView
    Friend WithEvents SupplierUpdatePanel As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents USupplierIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents USupplierAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents USupplierContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USupplierNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierUpdateBtn As System.Windows.Forms.Button
    Friend WithEvents SupplierDeletePanel As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DSupplierIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DSupplierAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DSupplierContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DSupplierNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents SupplierAddPanel As System.Windows.Forms.Panel
    Friend WithEvents ASupplierAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ASupplierContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ASupplierNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierAddBtn As System.Windows.Forms.Button
End Class
