<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumberOfBooksLabel = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TransactionsMadeLabel = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BooksRegisteredLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GenerateReportBtn = New System.Windows.Forms.Button()
        Me.BorrowerDGV = New System.Windows.Forms.DataGridView()
        Me.TransactionDGV = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.BorrowerDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TitleLabel.Location = New System.Drawing.Point(573, 16)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(119, 28)
        Me.TitleLabel.TabIndex = 14
        Me.TitleLabel.Text = "Dashboard"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(640, 227)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 28)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Recent Borrowers"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Location = New System.Drawing.Point(12, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1242, 155)
        Me.Panel1.TabIndex = 41
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.NumberOfBooksLabel)
        Me.Panel6.Location = New System.Drawing.Point(812, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(331, 139)
        Me.Panel6.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.Label4.Size = New System.Drawing.Size(187, 36)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total No. of Books"
        '
        'NumberOfBooksLabel
        '
        Me.NumberOfBooksLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumberOfBooksLabel.AutoSize = True
        Me.NumberOfBooksLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfBooksLabel.ForeColor = System.Drawing.Color.White
        Me.NumberOfBooksLabel.Location = New System.Drawing.Point(5, 46)
        Me.NumberOfBooksLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.NumberOfBooksLabel.Name = "NumberOfBooksLabel"
        Me.NumberOfBooksLabel.Padding = New System.Windows.Forms.Padding(8)
        Me.NumberOfBooksLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumberOfBooksLabel.Size = New System.Drawing.Size(65, 75)
        Me.NumberOfBooksLabel.TabIndex = 1
        Me.NumberOfBooksLabel.Text = "2"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TransactionsMadeLabel)
        Me.Panel4.Location = New System.Drawing.Point(457, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(331, 139)
        Me.Panel4.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.Label2.Size = New System.Drawing.Size(189, 36)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Transactions Made"
        '
        'TransactionsMadeLabel
        '
        Me.TransactionsMadeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TransactionsMadeLabel.AutoSize = True
        Me.TransactionsMadeLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionsMadeLabel.ForeColor = System.Drawing.Color.White
        Me.TransactionsMadeLabel.Location = New System.Drawing.Point(5, 46)
        Me.TransactionsMadeLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.TransactionsMadeLabel.Name = "TransactionsMadeLabel"
        Me.TransactionsMadeLabel.Padding = New System.Windows.Forms.Padding(8)
        Me.TransactionsMadeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TransactionsMadeLabel.Size = New System.Drawing.Size(65, 75)
        Me.TransactionsMadeLabel.TabIndex = 1
        Me.TransactionsMadeLabel.Text = "2"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.BooksRegisteredLabel)
        Me.Panel5.Location = New System.Drawing.Point(102, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(331, 139)
        Me.Panel5.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.Label1.Size = New System.Drawing.Size(178, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Books Registered"
        '
        'BooksRegisteredLabel
        '
        Me.BooksRegisteredLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BooksRegisteredLabel.AutoSize = True
        Me.BooksRegisteredLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BooksRegisteredLabel.ForeColor = System.Drawing.Color.White
        Me.BooksRegisteredLabel.Location = New System.Drawing.Point(5, 46)
        Me.BooksRegisteredLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.BooksRegisteredLabel.Name = "BooksRegisteredLabel"
        Me.BooksRegisteredLabel.Padding = New System.Windows.Forms.Padding(8)
        Me.BooksRegisteredLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BooksRegisteredLabel.Size = New System.Drawing.Size(65, 75)
        Me.BooksRegisteredLabel.TabIndex = 1
        Me.BooksRegisteredLabel.Text = "2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(111, 227)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 28)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Recent Transactions"
        '
        'GenerateReportBtn
        '
        Me.GenerateReportBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GenerateReportBtn.FlatAppearance.BorderSize = 0
        Me.GenerateReportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GenerateReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenerateReportBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GenerateReportBtn.ForeColor = System.Drawing.Color.White
        Me.GenerateReportBtn.Location = New System.Drawing.Point(116, 562)
        Me.GenerateReportBtn.Name = "GenerateReportBtn"
        Me.GenerateReportBtn.Size = New System.Drawing.Size(1039, 40)
        Me.GenerateReportBtn.TabIndex = 52
        Me.GenerateReportBtn.Text = "Generate Report"
        Me.GenerateReportBtn.UseVisualStyleBackColor = False
        '
        'BorrowerDGV
        '
        Me.BorrowerDGV.AllowUserToAddRows = False
        Me.BorrowerDGV.AllowUserToDeleteRows = False
        Me.BorrowerDGV.AllowUserToResizeColumns = False
        Me.BorrowerDGV.AllowUserToResizeRows = False
        Me.BorrowerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BorrowerDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.BorrowerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BorrowerDGV.Location = New System.Drawing.Point(645, 259)
        Me.BorrowerDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.BorrowerDGV.Name = "BorrowerDGV"
        Me.BorrowerDGV.ReadOnly = True
        Me.BorrowerDGV.RowHeadersWidth = 21
        Me.BorrowerDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BorrowerDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BorrowerDGV.RowTemplate.Height = 24
        Me.BorrowerDGV.Size = New System.Drawing.Size(510, 277)
        Me.BorrowerDGV.TabIndex = 53
        '
        'TransactionDGV
        '
        Me.TransactionDGV.AllowUserToAddRows = False
        Me.TransactionDGV.AllowUserToDeleteRows = False
        Me.TransactionDGV.AllowUserToResizeColumns = False
        Me.TransactionDGV.AllowUserToResizeRows = False
        Me.TransactionDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TransactionDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TransactionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransactionDGV.Location = New System.Drawing.Point(116, 259)
        Me.TransactionDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.TransactionDGV.Name = "TransactionDGV"
        Me.TransactionDGV.ReadOnly = True
        Me.TransactionDGV.RowHeadersWidth = 21
        Me.TransactionDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TransactionDGV.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.TransactionDGV.RowTemplate.Height = 24
        Me.TransactionDGV.Size = New System.Drawing.Size(510, 277)
        Me.TransactionDGV.TabIndex = 54
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 627)
        Me.Controls.Add(Me.TransactionDGV)
        Me.Controls.Add(Me.BorrowerDGV)
        Me.Controls.Add(Me.GenerateReportBtn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmHome"
        Me.Text = "frmHome"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.BorrowerDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents BooksRegisteredLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GenerateReportBtn As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumberOfBooksLabel As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TransactionsMadeLabel As System.Windows.Forms.Label
    Friend WithEvents BorrowerDGV As System.Windows.Forms.DataGridView
    Friend WithEvents TransactionDGV As System.Windows.Forms.DataGridView
End Class
