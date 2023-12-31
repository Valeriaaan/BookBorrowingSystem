<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.SignInPanel = New System.Windows.Forms.Panel()
        Me.GoToSignUpBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SignInBtn = New System.Windows.Forms.Button()
        Me.LoginNameLabel = New System.Windows.Forms.Label()
        Me.LoginPasswordLabel = New System.Windows.Forms.Label()
        Me.SignInPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.SignInUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.SignUpPanel = New System.Windows.Forms.Panel()
        Me.GoToSignInBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SignUpBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SignUpPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.SignUpUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SignInPanel.SuspendLayout()
        Me.SignUpPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(605, 60)
        Me.Panel1.TabIndex = 1
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TitleLabel.Location = New System.Drawing.Point(236, 16)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(132, 28)
        Me.TitleLabel.TabIndex = 1
        Me.TitleLabel.Text = "User Sign In"
        '
        'SignInPanel
        '
        Me.SignInPanel.Controls.Add(Me.GoToSignUpBtn)
        Me.SignInPanel.Controls.Add(Me.Label1)
        Me.SignInPanel.Controls.Add(Me.SignInBtn)
        Me.SignInPanel.Controls.Add(Me.LoginNameLabel)
        Me.SignInPanel.Controls.Add(Me.LoginPasswordLabel)
        Me.SignInPanel.Controls.Add(Me.SignInPasswordTextBox)
        Me.SignInPanel.Controls.Add(Me.SignInUsernameTextBox)
        Me.SignInPanel.Location = New System.Drawing.Point(12, 79)
        Me.SignInPanel.Name = "SignInPanel"
        Me.SignInPanel.Size = New System.Drawing.Size(581, 357)
        Me.SignInPanel.TabIndex = 2
        '
        'GoToSignUpBtn
        '
        Me.GoToSignUpBtn.BackColor = System.Drawing.SystemColors.Control
        Me.GoToSignUpBtn.FlatAppearance.BorderSize = 0
        Me.GoToSignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoToSignUpBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GoToSignUpBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GoToSignUpBtn.Location = New System.Drawing.Point(153, 294)
        Me.GoToSignUpBtn.Name = "GoToSignUpBtn"
        Me.GoToSignUpBtn.Size = New System.Drawing.Size(279, 40)
        Me.GoToSignUpBtn.TabIndex = 52
        Me.GoToSignUpBtn.Text = "Sign up to have access."
        Me.GoToSignUpBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(275, 255)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(31, 28)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "or"
        '
        'SignInBtn
        '
        Me.SignInBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SignInBtn.FlatAppearance.BorderSize = 0
        Me.SignInBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SignInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignInBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SignInBtn.ForeColor = System.Drawing.Color.White
        Me.SignInBtn.Location = New System.Drawing.Point(153, 204)
        Me.SignInBtn.Name = "SignInBtn"
        Me.SignInBtn.Size = New System.Drawing.Size(279, 40)
        Me.SignInBtn.TabIndex = 50
        Me.SignInBtn.Text = "Sign In "
        Me.SignInBtn.UseVisualStyleBackColor = False
        '
        'LoginNameLabel
        '
        Me.LoginNameLabel.AutoSize = True
        Me.LoginNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.LoginNameLabel.Location = New System.Drawing.Point(148, 23)
        Me.LoginNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LoginNameLabel.Name = "LoginNameLabel"
        Me.LoginNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LoginNameLabel.Size = New System.Drawing.Size(99, 28)
        Me.LoginNameLabel.TabIndex = 49
        Me.LoginNameLabel.Text = "Username"
        '
        'LoginPasswordLabel
        '
        Me.LoginPasswordLabel.AutoSize = True
        Me.LoginPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.LoginPasswordLabel.Location = New System.Drawing.Point(148, 103)
        Me.LoginPasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LoginPasswordLabel.Name = "LoginPasswordLabel"
        Me.LoginPasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LoginPasswordLabel.Size = New System.Drawing.Size(93, 28)
        Me.LoginPasswordLabel.TabIndex = 48
        Me.LoginPasswordLabel.Text = "Password"
        '
        'SignInPasswordTextBox
        '
        Me.SignInPasswordTextBox.Location = New System.Drawing.Point(153, 144)
        Me.SignInPasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.SignInPasswordTextBox.Name = "SignInPasswordTextBox"
        Me.SignInPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.SignInPasswordTextBox.Size = New System.Drawing.Size(279, 34)
        Me.SignInPasswordTextBox.TabIndex = 47
        '
        'SignInUsernameTextBox
        '
        Me.SignInUsernameTextBox.Location = New System.Drawing.Point(153, 61)
        Me.SignInUsernameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.SignInUsernameTextBox.Name = "SignInUsernameTextBox"
        Me.SignInUsernameTextBox.Size = New System.Drawing.Size(279, 34)
        Me.SignInUsernameTextBox.TabIndex = 46
        '
        'SignUpPanel
        '
        Me.SignUpPanel.Controls.Add(Me.GoToSignInBtn)
        Me.SignUpPanel.Controls.Add(Me.Label2)
        Me.SignUpPanel.Controls.Add(Me.SignUpBtn)
        Me.SignUpPanel.Controls.Add(Me.Label3)
        Me.SignUpPanel.Controls.Add(Me.Label4)
        Me.SignUpPanel.Controls.Add(Me.SignUpPasswordTextBox)
        Me.SignUpPanel.Controls.Add(Me.SignUpUsernameTextBox)
        Me.SignUpPanel.Location = New System.Drawing.Point(12, 79)
        Me.SignUpPanel.Name = "SignUpPanel"
        Me.SignUpPanel.Size = New System.Drawing.Size(581, 357)
        Me.SignUpPanel.TabIndex = 54
        '
        'GoToSignInBtn
        '
        Me.GoToSignInBtn.BackColor = System.Drawing.SystemColors.Control
        Me.GoToSignInBtn.FlatAppearance.BorderSize = 0
        Me.GoToSignInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoToSignInBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GoToSignInBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GoToSignInBtn.Location = New System.Drawing.Point(153, 294)
        Me.GoToSignInBtn.Name = "GoToSignInBtn"
        Me.GoToSignInBtn.Size = New System.Drawing.Size(279, 40)
        Me.GoToSignInBtn.TabIndex = 52
        Me.GoToSignInBtn.Text = "Sign in to your account."
        Me.GoToSignInBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(275, 255)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(31, 28)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "or"
        '
        'SignUpBtn
        '
        Me.SignUpBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SignUpBtn.FlatAppearance.BorderSize = 0
        Me.SignUpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignUpBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SignUpBtn.ForeColor = System.Drawing.Color.White
        Me.SignUpBtn.Location = New System.Drawing.Point(153, 204)
        Me.SignUpBtn.Name = "SignUpBtn"
        Me.SignUpBtn.Size = New System.Drawing.Size(279, 40)
        Me.SignUpBtn.TabIndex = 50
        Me.SignUpBtn.Text = "Sign Up"
        Me.SignUpBtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(148, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(99, 28)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(148, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(93, 28)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Password"
        '
        'SignUpPasswordTextBox
        '
        Me.SignUpPasswordTextBox.Location = New System.Drawing.Point(153, 144)
        Me.SignUpPasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.SignUpPasswordTextBox.Name = "SignUpPasswordTextBox"
        Me.SignUpPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.SignUpPasswordTextBox.Size = New System.Drawing.Size(279, 34)
        Me.SignUpPasswordTextBox.TabIndex = 47
        '
        'SignUpUsernameTextBox
        '
        Me.SignUpUsernameTextBox.Location = New System.Drawing.Point(153, 61)
        Me.SignUpUsernameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.SignUpUsernameTextBox.Name = "SignUpUsernameTextBox"
        Me.SignUpUsernameTextBox.Size = New System.Drawing.Size(279, 34)
        Me.SignUpUsernameTextBox.TabIndex = 46
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 448)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SignInPanel)
        Me.Controls.Add(Me.SignUpPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SignInPanel.ResumeLayout(False)
        Me.SignInPanel.PerformLayout()
        Me.SignUpPanel.ResumeLayout(False)
        Me.SignUpPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents SignInPanel As System.Windows.Forms.Panel
    Friend WithEvents GoToSignUpBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SignInBtn As System.Windows.Forms.Button
    Friend WithEvents LoginNameLabel As System.Windows.Forms.Label
    Friend WithEvents LoginPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents SignInPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SignInUsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SignUpPanel As System.Windows.Forms.Panel
    Friend WithEvents GoToSignInBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SignUpBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SignUpPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SignUpUsernameTextBox As System.Windows.Forms.TextBox
End Class
