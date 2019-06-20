Public Class Login
    Private Sub ButtonEnabler()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        If String.IsNullOrEmpty(PasswordTextBox.Text) Then
            PasswordStatusPanel.BackColor = Color.Red
            ContinueButton.Enabled = False
        Else
            ContinueButton.Enabled = True
            PasswordStatusPanel.BackColor = Color.LimeGreen
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
        ButtonEnabler()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ContinueButton.Click
        If PasswordTextBox.Text = My.Settings.UserPassword Then
            Hide()
            Settings.Show()
            Close()
        Else
            MsgBox(My.Resources.Login_WrongPassword, MsgBoxStyle.Critical, My.Resources.Settings_General_Err_Title)
        End If
    End Sub
End Class