<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaff
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
        Me.StaffViewPanel = New System.Windows.Forms.Panel()
        Me.ExportBtn = New System.Windows.Forms.Button()
        Me.StaffDGV = New System.Windows.Forms.DataGridView()
        Me.StaffAddPanel = New System.Windows.Forms.Panel()
        Me.AStaffPositionTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AStaffAgeTextBox = New System.Windows.Forms.TextBox()
        Me.AStaffAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AStaffContactTextBox = New System.Windows.Forms.TextBox()
        Me.AStaffNameTextBox = New System.Windows.Forms.TextBox()
        Me.StaffAddBtn = New System.Windows.Forms.Button()
        Me.StaffUpdatePanel = New System.Windows.Forms.Panel()
        Me.UStaffPositionTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.UStaffAgeTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UStaffIDComboBox = New System.Windows.Forms.ComboBox()
        Me.UStaffAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UStaffContactTextBox = New System.Windows.Forms.TextBox()
        Me.UStaffNameTextBox = New System.Windows.Forms.TextBox()
        Me.StaffUpdateBtn = New System.Windows.Forms.Button()
        Me.StaffDeletePanel = New System.Windows.Forms.Panel()
        Me.DStaffPositionTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DStaffAgeTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DStaffIDComboBox = New System.Windows.Forms.ComboBox()
        Me.DStaffAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DStaffContactTextBox = New System.Windows.Forms.TextBox()
        Me.DStaffNameTextBox = New System.Windows.Forms.TextBox()
        Me.StaffDeleteBtn = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.StaffViewPanel.SuspendLayout()
        CType(Me.StaffDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StaffAddPanel.SuspendLayout()
        Me.StaffUpdatePanel.SuspendLayout()
        Me.StaffDeletePanel.SuspendLayout()
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
        Me.Panel2.TabIndex = 13
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.TitleLabel.Location = New System.Drawing.Point(597, 16)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(70, 28)
        Me.TitleLabel.TabIndex = 14
        Me.TitleLabel.Text = "Staffs"
        '
        'StaffViewPanel
        '
        Me.StaffViewPanel.Controls.Add(Me.ExportBtn)
        Me.StaffViewPanel.Controls.Add(Me.StaffDGV)
        Me.StaffViewPanel.Location = New System.Drawing.Point(12, 82)
        Me.StaffViewPanel.Name = "StaffViewPanel"
        Me.StaffViewPanel.Size = New System.Drawing.Size(1242, 533)
        Me.StaffViewPanel.TabIndex = 14
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
        'StaffDGV
        '
        Me.StaffDGV.AllowUserToAddRows = False
        Me.StaffDGV.AllowUserToDeleteRows = False
        Me.StaffDGV.AllowUserToResizeColumns = False
        Me.StaffDGV.AllowUserToResizeRows = False
        Me.StaffDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StaffDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.StaffDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffDGV.Location = New System.Drawing.Point(89, 27)
        Me.StaffDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.StaffDGV.Name = "StaffDGV"
        Me.StaffDGV.ReadOnly = True
        Me.StaffDGV.RowHeadersWidth = 21
        Me.StaffDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StaffDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.StaffDGV.RowTemplate.Height = 24
        Me.StaffDGV.Size = New System.Drawing.Size(1065, 432)
        Me.StaffDGV.TabIndex = 41
        '
        'StaffAddPanel
        '
        Me.StaffAddPanel.Controls.Add(Me.AStaffPositionTextBox)
        Me.StaffAddPanel.Controls.Add(Me.Label2)
        Me.StaffAddPanel.Controls.Add(Me.Label5)
        Me.StaffAddPanel.Controls.Add(Me.AStaffAgeTextBox)
        Me.StaffAddPanel.Controls.Add(Me.AStaffAddressTextBox)
        Me.StaffAddPanel.Controls.Add(Me.Label1)
        Me.StaffAddPanel.Controls.Add(Me.Label3)
        Me.StaffAddPanel.Controls.Add(Me.Label4)
        Me.StaffAddPanel.Controls.Add(Me.AStaffContactTextBox)
        Me.StaffAddPanel.Controls.Add(Me.AStaffNameTextBox)
        Me.StaffAddPanel.Controls.Add(Me.StaffAddBtn)
        Me.StaffAddPanel.Location = New System.Drawing.Point(12, 82)
        Me.StaffAddPanel.Name = "StaffAddPanel"
        Me.StaffAddPanel.Size = New System.Drawing.Size(1242, 533)
        Me.StaffAddPanel.TabIndex = 20
        '
        'AStaffPositionTextBox
        '
        Me.AStaffPositionTextBox.Location = New System.Drawing.Point(453, 395)
        Me.AStaffPositionTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.AStaffPositionTextBox.Name = "AStaffPositionTextBox"
        Me.AStaffPositionTextBox.Size = New System.Drawing.Size(342, 34)
        Me.AStaffPositionTextBox.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(448, 360)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(82, 28)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Position"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(448, 278)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(47, 28)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Age"
        '
        'AStaffAgeTextBox
        '
        Me.AStaffAgeTextBox.Location = New System.Drawing.Point(453, 319)
        Me.AStaffAgeTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.AStaffAgeTextBox.Name = "AStaffAgeTextBox"
        Me.AStaffAgeTextBox.Size = New System.Drawing.Size(342, 34)
        Me.AStaffAgeTextBox.TabIndex = 58
        '
        'AStaffAddressTextBox
        '
        Me.AStaffAddressTextBox.Location = New System.Drawing.Point(453, 235)
        Me.AStaffAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.AStaffAddressTextBox.Name = "AStaffAddressTextBox"
        Me.AStaffAddressTextBox.Size = New System.Drawing.Size(342, 34)
        Me.AStaffAddressTextBox.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(448, 200)
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
        Me.Label3.Location = New System.Drawing.Point(448, 38)
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
        Me.Label4.Location = New System.Drawing.Point(448, 118)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(80, 28)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Contact"
        '
        'AStaffContactTextBox
        '
        Me.AStaffContactTextBox.Location = New System.Drawing.Point(453, 159)
        Me.AStaffContactTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.AStaffContactTextBox.Name = "AStaffContactTextBox"
        Me.AStaffContactTextBox.Size = New System.Drawing.Size(342, 34)
        Me.AStaffContactTextBox.TabIndex = 53
        '
        'AStaffNameTextBox
        '
        Me.AStaffNameTextBox.Location = New System.Drawing.Point(453, 76)
        Me.AStaffNameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.AStaffNameTextBox.Name = "AStaffNameTextBox"
        Me.AStaffNameTextBox.Size = New System.Drawing.Size(342, 34)
        Me.AStaffNameTextBox.TabIndex = 52
        '
        'StaffAddBtn
        '
        Me.StaffAddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.StaffAddBtn.FlatAppearance.BorderSize = 0
        Me.StaffAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.StaffAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StaffAddBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.StaffAddBtn.ForeColor = System.Drawing.Color.White
        Me.StaffAddBtn.Location = New System.Drawing.Point(453, 454)
        Me.StaffAddBtn.Name = "StaffAddBtn"
        Me.StaffAddBtn.Size = New System.Drawing.Size(342, 40)
        Me.StaffAddBtn.TabIndex = 51
        Me.StaffAddBtn.Text = "Add Staff"
        Me.StaffAddBtn.UseVisualStyleBackColor = False
        '
        'StaffUpdatePanel
        '
        Me.StaffUpdatePanel.Controls.Add(Me.UStaffPositionTextBox)
        Me.StaffUpdatePanel.Controls.Add(Me.Label10)
        Me.StaffUpdatePanel.Controls.Add(Me.Label11)
        Me.StaffUpdatePanel.Controls.Add(Me.UStaffAgeTextBox)
        Me.StaffUpdatePanel.Controls.Add(Me.Label7)
        Me.StaffUpdatePanel.Controls.Add(Me.UStaffIDComboBox)
        Me.StaffUpdatePanel.Controls.Add(Me.UStaffAddressTextBox)
        Me.StaffUpdatePanel.Controls.Add(Me.Label6)
        Me.StaffUpdatePanel.Controls.Add(Me.Label8)
        Me.StaffUpdatePanel.Controls.Add(Me.Label9)
        Me.StaffUpdatePanel.Controls.Add(Me.UStaffContactTextBox)
        Me.StaffUpdatePanel.Controls.Add(Me.UStaffNameTextBox)
        Me.StaffUpdatePanel.Controls.Add(Me.StaffUpdateBtn)
        Me.StaffUpdatePanel.Location = New System.Drawing.Point(12, 81)
        Me.StaffUpdatePanel.Name = "StaffUpdatePanel"
        Me.StaffUpdatePanel.Size = New System.Drawing.Size(1242, 533)
        Me.StaffUpdatePanel.TabIndex = 21
        '
        'UStaffPositionTextBox
        '
        Me.UStaffPositionTextBox.Location = New System.Drawing.Point(453, 432)
        Me.UStaffPositionTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UStaffPositionTextBox.Name = "UStaffPositionTextBox"
        Me.UStaffPositionTextBox.Size = New System.Drawing.Size(342, 34)
        Me.UStaffPositionTextBox.TabIndex = 65
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(448, 397)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(82, 28)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Position"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(448, 315)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(47, 28)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Age"
        '
        'UStaffAgeTextBox
        '
        Me.UStaffAgeTextBox.Location = New System.Drawing.Point(453, 356)
        Me.UStaffAgeTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UStaffAgeTextBox.Name = "UStaffAgeTextBox"
        Me.UStaffAgeTextBox.Size = New System.Drawing.Size(342, 34)
        Me.UStaffAgeTextBox.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(448, 4)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(75, 28)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Staff ID"
        '
        'UStaffIDComboBox
        '
        Me.UStaffIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UStaffIDComboBox.FormattingEnabled = True
        Me.UStaffIDComboBox.Location = New System.Drawing.Point(453, 36)
        Me.UStaffIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UStaffIDComboBox.Name = "UStaffIDComboBox"
        Me.UStaffIDComboBox.Size = New System.Drawing.Size(342, 36)
        Me.UStaffIDComboBox.TabIndex = 58
        '
        'UStaffAddressTextBox
        '
        Me.UStaffAddressTextBox.Location = New System.Drawing.Point(453, 273)
        Me.UStaffAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UStaffAddressTextBox.Name = "UStaffAddressTextBox"
        Me.UStaffAddressTextBox.Size = New System.Drawing.Size(342, 34)
        Me.UStaffAddressTextBox.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(448, 238)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(82, 28)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(448, 76)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(64, 28)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(448, 156)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(80, 28)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Contact"
        '
        'UStaffContactTextBox
        '
        Me.UStaffContactTextBox.Location = New System.Drawing.Point(453, 197)
        Me.UStaffContactTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UStaffContactTextBox.Name = "UStaffContactTextBox"
        Me.UStaffContactTextBox.Size = New System.Drawing.Size(342, 34)
        Me.UStaffContactTextBox.TabIndex = 53
        '
        'UStaffNameTextBox
        '
        Me.UStaffNameTextBox.Location = New System.Drawing.Point(453, 114)
        Me.UStaffNameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UStaffNameTextBox.Name = "UStaffNameTextBox"
        Me.UStaffNameTextBox.Size = New System.Drawing.Size(342, 34)
        Me.UStaffNameTextBox.TabIndex = 52
        '
        'StaffUpdateBtn
        '
        Me.StaffUpdateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.StaffUpdateBtn.FlatAppearance.BorderSize = 0
        Me.StaffUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.StaffUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StaffUpdateBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.StaffUpdateBtn.ForeColor = System.Drawing.Color.White
        Me.StaffUpdateBtn.Location = New System.Drawing.Point(453, 488)
        Me.StaffUpdateBtn.Name = "StaffUpdateBtn"
        Me.StaffUpdateBtn.Size = New System.Drawing.Size(342, 40)
        Me.StaffUpdateBtn.TabIndex = 51
        Me.StaffUpdateBtn.Text = "Update Staff"
        Me.StaffUpdateBtn.UseVisualStyleBackColor = False
        '
        'StaffDeletePanel
        '
        Me.StaffDeletePanel.Controls.Add(Me.DStaffPositionTextBox)
        Me.StaffDeletePanel.Controls.Add(Me.Label12)
        Me.StaffDeletePanel.Controls.Add(Me.Label13)
        Me.StaffDeletePanel.Controls.Add(Me.DStaffAgeTextBox)
        Me.StaffDeletePanel.Controls.Add(Me.Label14)
        Me.StaffDeletePanel.Controls.Add(Me.DStaffIDComboBox)
        Me.StaffDeletePanel.Controls.Add(Me.DStaffAddressTextBox)
        Me.StaffDeletePanel.Controls.Add(Me.Label15)
        Me.StaffDeletePanel.Controls.Add(Me.Label16)
        Me.StaffDeletePanel.Controls.Add(Me.Label17)
        Me.StaffDeletePanel.Controls.Add(Me.DStaffContactTextBox)
        Me.StaffDeletePanel.Controls.Add(Me.DStaffNameTextBox)
        Me.StaffDeletePanel.Controls.Add(Me.StaffDeleteBtn)
        Me.StaffDeletePanel.Location = New System.Drawing.Point(12, 82)
        Me.StaffDeletePanel.Name = "StaffDeletePanel"
        Me.StaffDeletePanel.Size = New System.Drawing.Size(1242, 533)
        Me.StaffDeletePanel.TabIndex = 23
        '
        'DStaffPositionTextBox
        '
        Me.DStaffPositionTextBox.Enabled = False
        Me.DStaffPositionTextBox.Location = New System.Drawing.Point(453, 432)
        Me.DStaffPositionTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DStaffPositionTextBox.Name = "DStaffPositionTextBox"
        Me.DStaffPositionTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DStaffPositionTextBox.TabIndex = 65
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(448, 397)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(82, 28)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Position"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(448, 315)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(47, 28)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Age"
        '
        'DStaffAgeTextBox
        '
        Me.DStaffAgeTextBox.Enabled = False
        Me.DStaffAgeTextBox.Location = New System.Drawing.Point(453, 356)
        Me.DStaffAgeTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DStaffAgeTextBox.Name = "DStaffAgeTextBox"
        Me.DStaffAgeTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DStaffAgeTextBox.TabIndex = 62
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(448, 4)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(75, 28)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "Staff ID"
        '
        'DStaffIDComboBox
        '
        Me.DStaffIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DStaffIDComboBox.FormattingEnabled = True
        Me.DStaffIDComboBox.Location = New System.Drawing.Point(453, 36)
        Me.DStaffIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DStaffIDComboBox.Name = "DStaffIDComboBox"
        Me.DStaffIDComboBox.Size = New System.Drawing.Size(342, 36)
        Me.DStaffIDComboBox.TabIndex = 58
        '
        'DStaffAddressTextBox
        '
        Me.DStaffAddressTextBox.Enabled = False
        Me.DStaffAddressTextBox.Location = New System.Drawing.Point(453, 273)
        Me.DStaffAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DStaffAddressTextBox.Name = "DStaffAddressTextBox"
        Me.DStaffAddressTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DStaffAddressTextBox.TabIndex = 57
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(448, 238)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(82, 28)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Address"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(448, 76)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(64, 28)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(448, 156)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(80, 28)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Contact"
        '
        'DStaffContactTextBox
        '
        Me.DStaffContactTextBox.Enabled = False
        Me.DStaffContactTextBox.Location = New System.Drawing.Point(453, 197)
        Me.DStaffContactTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DStaffContactTextBox.Name = "DStaffContactTextBox"
        Me.DStaffContactTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DStaffContactTextBox.TabIndex = 53
        '
        'DStaffNameTextBox
        '
        Me.DStaffNameTextBox.Enabled = False
        Me.DStaffNameTextBox.Location = New System.Drawing.Point(453, 114)
        Me.DStaffNameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DStaffNameTextBox.Name = "DStaffNameTextBox"
        Me.DStaffNameTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DStaffNameTextBox.TabIndex = 52
        '
        'StaffDeleteBtn
        '
        Me.StaffDeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.StaffDeleteBtn.FlatAppearance.BorderSize = 0
        Me.StaffDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.StaffDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StaffDeleteBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.StaffDeleteBtn.ForeColor = System.Drawing.Color.White
        Me.StaffDeleteBtn.Location = New System.Drawing.Point(453, 488)
        Me.StaffDeleteBtn.Name = "StaffDeleteBtn"
        Me.StaffDeleteBtn.Size = New System.Drawing.Size(342, 40)
        Me.StaffDeleteBtn.TabIndex = 51
        Me.StaffDeleteBtn.Text = "Delete Staff"
        Me.StaffDeleteBtn.UseVisualStyleBackColor = False
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 627)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StaffDeletePanel)
        Me.Controls.Add(Me.StaffUpdatePanel)
        Me.Controls.Add(Me.StaffAddPanel)
        Me.Controls.Add(Me.StaffViewPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmStaff"
        Me.Text = "frmStaff"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StaffViewPanel.ResumeLayout(False)
        CType(Me.StaffDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StaffAddPanel.ResumeLayout(False)
        Me.StaffAddPanel.PerformLayout()
        Me.StaffUpdatePanel.ResumeLayout(False)
        Me.StaffUpdatePanel.PerformLayout()
        Me.StaffDeletePanel.ResumeLayout(False)
        Me.StaffDeletePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents StaffViewPanel As System.Windows.Forms.Panel
    Friend WithEvents ExportBtn As System.Windows.Forms.Button
    Friend WithEvents StaffDGV As System.Windows.Forms.DataGridView
    Friend WithEvents StaffAddPanel As System.Windows.Forms.Panel
    Friend WithEvents AStaffAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AStaffContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AStaffNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StaffAddBtn As System.Windows.Forms.Button
    Friend WithEvents AStaffPositionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AStaffAgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StaffUpdatePanel As System.Windows.Forms.Panel
    Friend WithEvents UStaffPositionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents UStaffAgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UStaffIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UStaffAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents UStaffContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UStaffNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StaffUpdateBtn As System.Windows.Forms.Button
    Friend WithEvents StaffDeletePanel As System.Windows.Forms.Panel
    Friend WithEvents DStaffPositionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DStaffAgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DStaffIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DStaffAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DStaffContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DStaffNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StaffDeleteBtn As System.Windows.Forms.Button
End Class
