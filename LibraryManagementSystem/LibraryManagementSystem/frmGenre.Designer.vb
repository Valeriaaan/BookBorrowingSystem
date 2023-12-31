<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenres
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
        Dim Label12 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.GenreViewPanel = New System.Windows.Forms.Panel()
        Me.ExportBtn = New System.Windows.Forms.Button()
        Me.GenreDGV = New System.Windows.Forms.DataGridView()
        Me.GenreAddPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AGenreNameTextBox = New System.Windows.Forms.TextBox()
        Me.GenreAddBtn = New System.Windows.Forms.Button()
        Me.GenreUpdatePanel = New System.Windows.Forms.Panel()
        Me.UGenreIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UGenreNameTextBox = New System.Windows.Forms.TextBox()
        Me.GenreUpdateBtn = New System.Windows.Forms.Button()
        Me.GenreDeletePanel = New System.Windows.Forms.Panel()
        Me.DGenreIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DGenreNameTextBox = New System.Windows.Forms.TextBox()
        Me.GenreDeleteBtn = New System.Windows.Forms.Button()
        Label7 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GenreViewPanel.SuspendLayout()
        CType(Me.GenreDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GenreAddPanel.SuspendLayout()
        Me.GenreUpdatePanel.SuspendLayout()
        Me.GenreDeletePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Label7.Location = New System.Drawing.Point(448, 163)
        Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label7.Size = New System.Drawing.Size(88, 28)
        Label7.TabIndex = 59
        Label7.Text = "Genre ID"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Label12.Location = New System.Drawing.Point(448, 163)
        Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label12.Size = New System.Drawing.Size(88, 28)
        Label12.TabIndex = 59
        Label12.Text = "Genre ID"
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
        Me.TitleLabel.Location = New System.Drawing.Point(592, 16)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(81, 28)
        Me.TitleLabel.TabIndex = 14
        Me.TitleLabel.Text = "Genres"
        '
        'GenreViewPanel
        '
        Me.GenreViewPanel.Controls.Add(Me.ExportBtn)
        Me.GenreViewPanel.Controls.Add(Me.GenreDGV)
        Me.GenreViewPanel.Location = New System.Drawing.Point(12, 82)
        Me.GenreViewPanel.Name = "GenreViewPanel"
        Me.GenreViewPanel.Size = New System.Drawing.Size(1242, 533)
        Me.GenreViewPanel.TabIndex = 14
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
        'GenreDGV
        '
        Me.GenreDGV.AllowUserToAddRows = False
        Me.GenreDGV.AllowUserToDeleteRows = False
        Me.GenreDGV.AllowUserToResizeColumns = False
        Me.GenreDGV.AllowUserToResizeRows = False
        Me.GenreDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GenreDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GenreDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GenreDGV.Location = New System.Drawing.Point(89, 27)
        Me.GenreDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.GenreDGV.Name = "GenreDGV"
        Me.GenreDGV.ReadOnly = True
        Me.GenreDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GenreDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GenreDGV.RowTemplate.Height = 24
        Me.GenreDGV.Size = New System.Drawing.Size(1065, 432)
        Me.GenreDGV.TabIndex = 41
        '
        'GenreAddPanel
        '
        Me.GenreAddPanel.Controls.Add(Me.Label3)
        Me.GenreAddPanel.Controls.Add(Me.AGenreNameTextBox)
        Me.GenreAddPanel.Controls.Add(Me.GenreAddBtn)
        Me.GenreAddPanel.Location = New System.Drawing.Point(12, 82)
        Me.GenreAddPanel.Name = "GenreAddPanel"
        Me.GenreAddPanel.Size = New System.Drawing.Size(1242, 533)
        Me.GenreAddPanel.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(448, 195)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(64, 28)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Name"
        '
        'AGenreNameTextBox
        '
        Me.AGenreNameTextBox.Location = New System.Drawing.Point(453, 233)
        Me.AGenreNameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.AGenreNameTextBox.Name = "AGenreNameTextBox"
        Me.AGenreNameTextBox.Size = New System.Drawing.Size(342, 34)
        Me.AGenreNameTextBox.TabIndex = 52
        '
        'GenreAddBtn
        '
        Me.GenreAddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GenreAddBtn.FlatAppearance.BorderSize = 0
        Me.GenreAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GenreAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenreAddBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GenreAddBtn.ForeColor = System.Drawing.Color.White
        Me.GenreAddBtn.Location = New System.Drawing.Point(453, 298)
        Me.GenreAddBtn.Name = "GenreAddBtn"
        Me.GenreAddBtn.Size = New System.Drawing.Size(342, 40)
        Me.GenreAddBtn.TabIndex = 51
        Me.GenreAddBtn.Text = "Add Genre"
        Me.GenreAddBtn.UseVisualStyleBackColor = False
        '
        'GenreUpdatePanel
        '
        Me.GenreUpdatePanel.Controls.Add(Label7)
        Me.GenreUpdatePanel.Controls.Add(Me.UGenreIDComboBox)
        Me.GenreUpdatePanel.Controls.Add(Me.Label5)
        Me.GenreUpdatePanel.Controls.Add(Me.UGenreNameTextBox)
        Me.GenreUpdatePanel.Controls.Add(Me.GenreUpdateBtn)
        Me.GenreUpdatePanel.Location = New System.Drawing.Point(12, 82)
        Me.GenreUpdatePanel.Name = "GenreUpdatePanel"
        Me.GenreUpdatePanel.Size = New System.Drawing.Size(1242, 533)
        Me.GenreUpdatePanel.TabIndex = 21
        '
        'UGenreIDComboBox
        '
        Me.UGenreIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UGenreIDComboBox.FormattingEnabled = True
        Me.UGenreIDComboBox.Location = New System.Drawing.Point(453, 195)
        Me.UGenreIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UGenreIDComboBox.Name = "UGenreIDComboBox"
        Me.UGenreIDComboBox.Size = New System.Drawing.Size(342, 36)
        Me.UGenreIDComboBox.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(448, 235)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(64, 28)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Name"
        '
        'UGenreNameTextBox
        '
        Me.UGenreNameTextBox.Location = New System.Drawing.Point(453, 273)
        Me.UGenreNameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UGenreNameTextBox.Name = "UGenreNameTextBox"
        Me.UGenreNameTextBox.Size = New System.Drawing.Size(342, 34)
        Me.UGenreNameTextBox.TabIndex = 52
        '
        'GenreUpdateBtn
        '
        Me.GenreUpdateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GenreUpdateBtn.FlatAppearance.BorderSize = 0
        Me.GenreUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GenreUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenreUpdateBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GenreUpdateBtn.ForeColor = System.Drawing.Color.White
        Me.GenreUpdateBtn.Location = New System.Drawing.Point(453, 329)
        Me.GenreUpdateBtn.Name = "GenreUpdateBtn"
        Me.GenreUpdateBtn.Size = New System.Drawing.Size(342, 40)
        Me.GenreUpdateBtn.TabIndex = 51
        Me.GenreUpdateBtn.Text = "Update Genre"
        Me.GenreUpdateBtn.UseVisualStyleBackColor = False
        '
        'GenreDeletePanel
        '
        Me.GenreDeletePanel.Controls.Add(Label12)
        Me.GenreDeletePanel.Controls.Add(Me.DGenreIDComboBox)
        Me.GenreDeletePanel.Controls.Add(Me.Label13)
        Me.GenreDeletePanel.Controls.Add(Me.DGenreNameTextBox)
        Me.GenreDeletePanel.Controls.Add(Me.GenreDeleteBtn)
        Me.GenreDeletePanel.Location = New System.Drawing.Point(12, 82)
        Me.GenreDeletePanel.Name = "GenreDeletePanel"
        Me.GenreDeletePanel.Size = New System.Drawing.Size(1242, 533)
        Me.GenreDeletePanel.TabIndex = 23
        '
        'DGenreIDComboBox
        '
        Me.DGenreIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DGenreIDComboBox.FormattingEnabled = True
        Me.DGenreIDComboBox.Location = New System.Drawing.Point(453, 195)
        Me.DGenreIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DGenreIDComboBox.Name = "DGenreIDComboBox"
        Me.DGenreIDComboBox.Size = New System.Drawing.Size(342, 36)
        Me.DGenreIDComboBox.TabIndex = 58
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(448, 235)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(64, 28)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Name"
        '
        'DGenreNameTextBox
        '
        Me.DGenreNameTextBox.Enabled = False
        Me.DGenreNameTextBox.Location = New System.Drawing.Point(453, 273)
        Me.DGenreNameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DGenreNameTextBox.Name = "DGenreNameTextBox"
        Me.DGenreNameTextBox.Size = New System.Drawing.Size(342, 34)
        Me.DGenreNameTextBox.TabIndex = 52
        '
        'GenreDeleteBtn
        '
        Me.GenreDeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GenreDeleteBtn.FlatAppearance.BorderSize = 0
        Me.GenreDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GenreDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenreDeleteBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GenreDeleteBtn.ForeColor = System.Drawing.Color.White
        Me.GenreDeleteBtn.Location = New System.Drawing.Point(453, 329)
        Me.GenreDeleteBtn.Name = "GenreDeleteBtn"
        Me.GenreDeleteBtn.Size = New System.Drawing.Size(342, 40)
        Me.GenreDeleteBtn.TabIndex = 51
        Me.GenreDeleteBtn.Text = "Delete Genre"
        Me.GenreDeleteBtn.UseVisualStyleBackColor = False
        '
        'frmGenres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 627)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GenreAddPanel)
        Me.Controls.Add(Me.GenreViewPanel)
        Me.Controls.Add(Me.GenreDeletePanel)
        Me.Controls.Add(Me.GenreUpdatePanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmGenres"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "frmGenre"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GenreViewPanel.ResumeLayout(False)
        CType(Me.GenreDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GenreAddPanel.ResumeLayout(False)
        Me.GenreAddPanel.PerformLayout()
        Me.GenreUpdatePanel.ResumeLayout(False)
        Me.GenreUpdatePanel.PerformLayout()
        Me.GenreDeletePanel.ResumeLayout(False)
        Me.GenreDeletePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents GenreViewPanel As System.Windows.Forms.Panel
    Friend WithEvents ExportBtn As System.Windows.Forms.Button
    Friend WithEvents GenreDGV As System.Windows.Forms.DataGridView
    Friend WithEvents GenreAddPanel As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AGenreNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenreAddBtn As System.Windows.Forms.Button
    Friend WithEvents GenreUpdatePanel As System.Windows.Forms.Panel
    Friend WithEvents UGenreIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UGenreNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenreUpdateBtn As System.Windows.Forms.Button
    Friend WithEvents GenreDeletePanel As System.Windows.Forms.Panel
    Friend WithEvents DGenreIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DGenreNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenreDeleteBtn As System.Windows.Forms.Button
End Class
