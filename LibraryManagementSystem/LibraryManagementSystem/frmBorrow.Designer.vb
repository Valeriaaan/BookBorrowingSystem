<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrow
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BookIDComboBox = New System.Windows.Forms.ComboBox()
        Me.BorrowerAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BorrowerContactTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowerNameTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowBtn = New System.Windows.Forms.Button()
        Me.BorrowerIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel2.SuspendLayout()
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
        Me.TitleLabel.Location = New System.Drawing.Point(555, 16)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(155, 28)
        Me.TitleLabel.TabIndex = 14
        Me.TitleLabel.Text = "Borrow Books"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(460, 369)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(198, 28)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Book to be Borrowed"
        '
        'BookIDComboBox
        '
        Me.BookIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BookIDComboBox.FormattingEnabled = True
        Me.BookIDComboBox.Location = New System.Drawing.Point(465, 401)
        Me.BookIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BookIDComboBox.Name = "BookIDComboBox"
        Me.BookIDComboBox.Size = New System.Drawing.Size(342, 36)
        Me.BookIDComboBox.TabIndex = 67
        '
        'BorrowerAddressTextBox
        '
        Me.BorrowerAddressTextBox.Location = New System.Drawing.Point(465, 321)
        Me.BorrowerAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.BorrowerAddressTextBox.Name = "BorrowerAddressTextBox"
        Me.BorrowerAddressTextBox.Size = New System.Drawing.Size(342, 34)
        Me.BorrowerAddressTextBox.TabIndex = 66
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(460, 286)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(82, 28)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(460, 124)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(64, 28)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(460, 204)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(80, 28)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Contact"
        '
        'BorrowerContactTextBox
        '
        Me.BorrowerContactTextBox.Location = New System.Drawing.Point(465, 245)
        Me.BorrowerContactTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.BorrowerContactTextBox.Name = "BorrowerContactTextBox"
        Me.BorrowerContactTextBox.Size = New System.Drawing.Size(342, 34)
        Me.BorrowerContactTextBox.TabIndex = 62
        '
        'BorrowerNameTextBox
        '
        Me.BorrowerNameTextBox.Location = New System.Drawing.Point(465, 162)
        Me.BorrowerNameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.BorrowerNameTextBox.Name = "BorrowerNameTextBox"
        Me.BorrowerNameTextBox.Size = New System.Drawing.Size(342, 34)
        Me.BorrowerNameTextBox.TabIndex = 61
        '
        'BorrowBtn
        '
        Me.BorrowBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BorrowBtn.FlatAppearance.BorderSize = 0
        Me.BorrowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BorrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BorrowBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BorrowBtn.ForeColor = System.Drawing.Color.White
        Me.BorrowBtn.Location = New System.Drawing.Point(465, 462)
        Me.BorrowBtn.Name = "BorrowBtn"
        Me.BorrowBtn.Size = New System.Drawing.Size(342, 40)
        Me.BorrowBtn.TabIndex = 60
        Me.BorrowBtn.Text = "Borrow Book"
        Me.BorrowBtn.UseVisualStyleBackColor = False
        '
        'BorrowerIDComboBox
        '
        Me.BorrowerIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BorrowerIDComboBox.FormattingEnabled = True
        Me.BorrowerIDComboBox.Location = New System.Drawing.Point(89, 162)
        Me.BorrowerIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BorrowerIDComboBox.Name = "BorrowerIDComboBox"
        Me.BorrowerIDComboBox.Size = New System.Drawing.Size(342, 36)
        Me.BorrowerIDComboBox.TabIndex = 69
        Me.BorrowerIDComboBox.Visible = False
        '
        'frmBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 627)
        Me.Controls.Add(Me.BorrowerIDComboBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BookIDComboBox)
        Me.Controls.Add(Me.BorrowerAddressTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BorrowerContactTextBox)
        Me.Controls.Add(Me.BorrowerNameTextBox)
        Me.Controls.Add(Me.BorrowBtn)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmBorrow"
        Me.Text = "frmBorrow"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BookIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BorrowerAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BorrowerContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BorrowerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BorrowBtn As System.Windows.Forms.Button
    Friend WithEvents BorrowerIDComboBox As System.Windows.Forms.ComboBox
End Class
