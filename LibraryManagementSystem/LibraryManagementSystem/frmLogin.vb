Imports MySql.Data.MySqlClient

Public Class frmLogin

    ' Clears the textboxes in the SignUpPanel
    Private Sub ClearSignUpTextBoxes()
        SignUpUsernameTextBox.Clear()
        SignUpPasswordTextBox.Clear()
    End Sub

    ' Clears the textboxes in the SignInPanel
    Private Sub ClearSignInTextBoxes()
        SignInUsernameTextBox.Clear()
        SignInPasswordTextBox.Clear()
    End Sub

    ' Handles the click event for the GoToSignUpBtn
    Private Sub GoToSignUpBtn_Click(sender As Object, e As EventArgs) Handles GoToSignUpBtn.Click
        SignInPanel.Visible = False
        SignUpPanel.Visible = True
        TitleLabel.Text = "User Sign Up"

        ClearSignUpTextBoxes()
        ClearSignInTextBoxes()
    End Sub

    ' Handles the click event for the GoToSignInBtn
    Private Sub GoToSignInBtn_Click(sender As Object, e As EventArgs) Handles GoToSignInBtn.Click
        SignInPanel.Visible = True
        SignUpPanel.Visible = False
        TitleLabel.Text = "User Sign In"

        ClearSignUpTextBoxes()
        ClearSignInTextBoxes()
    End Sub

    ' Handles the click event for the SignInBtn
    Private Sub SignInBtn_Click(sender As Object, e As EventArgs) Handles SignInBtn.Click
        Try
            openCon()
            Using cmd As New MySqlCommand("SELECT * FROM user WHERE user_Name=@UserName AND user_Password=@UserPassword", con)

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@UserName", SignInUsernameTextBox.Text)
                cmd.Parameters.AddWithValue("@UserPassword", SignInPasswordTextBox.Text)

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader
                    If reader.Read() Then
                        MsgBox("Login successful!")

                        ClearSignUpTextBoxes()
                        ClearSignInTextBoxes()

                        ' Open the main form
                        Dim frmMain As New frmMain
                        frmMain.Show()
                        Me.Hide()
                    Else
                        MsgBox("Invalid username or password. Please try again.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Handles the click event for the SignUpBtn
    Private Sub SignUpBtn_Click(sender As Object, e As EventArgs) Handles SignUpBtn.Click
        ' Check if the password meets the length requirement
        If SignUpPasswordTextBox.Text.Length >= 8 Then
            Try
                openCon()

                ' Check if the username already exists
                Using cmdCheck As New MySqlCommand("SELECT COUNT(*) FROM user WHERE user_Name=@UserName", con)
                    cmdCheck.Parameters.AddWithValue("@UserName", SignUpUsernameTextBox.Text)

                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If

                    Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                    If count > 0 Then
                        MsgBox("Username already exists. Please choose a different username.")
                        Return ' Exit the method without proceeding to sign up
                    End If
                End Using

                ' Proceed with sign up if the username is unique
                Using cmd As New MySqlCommand("INSERT INTO user (user_Name, user_Password) VALUES (@UserName, @UserPassword)", con)

                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@UserName", SignUpUsernameTextBox.Text)
                    cmd.Parameters.AddWithValue("@UserPassword", SignUpPasswordTextBox.Text)

                    If MsgBox("Do you want to sign up with these credentials?", MsgBoxStyle.YesNo) = vbYes Then
                        cmd.ExecuteNonQuery()
                        MsgBox("Sign up Successful. Account Registered!")

                        ClearSignUpTextBoxes()
                        ClearSignInTextBoxes()

                        ' Switch to the SignInPanel after successful signup
                        SignInPanel.Visible = True
                        SignUpPanel.Visible = False
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                con.Close()
            End Try
        Else
            MsgBox("Password must contain 8 or more characters. Please try again.")
        End If
    End Sub


End Class
