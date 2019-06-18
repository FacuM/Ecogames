Public Class FirstRun
    Private Sub ButtonEnabler()
        If PasswordConfirmationVerifier(PasswordTextBox, PasswordVerifyTextBox, Panel2) And SimpleLengthVerifier(UsernameTextBox, Panel3) Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        PasswordStrengthVerifier(PasswordTextBox, Panel1)
        ButtonEnabler()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles PasswordVerifyTextBox.TextChanged
        ButtonEnabler()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.UserName = UsernameTextBox.Text
        My.Settings.UserPassword = PasswordVerifyTextBox.Text
        My.Settings.FirstRun = False
        SettingsSaver()
        Hide()
        Settings.Show()
        Close()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged
        ButtonEnabler()
    End Sub
End Class