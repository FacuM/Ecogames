Public Class Login
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ContinueButton.Click
        If PasswordTextBox.Text = My.Settings.UserPassword Then
            Hide()
            Settings.Show()
            Close()
            If Play_Activities.Visible Then
                Play_Activities.Close()
            End If
        Else
            MessageBox.Show(My.Resources.Login_WrongPassword, My.Resources.General_Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        PasswordTextBox.Text = String.Empty
    End Sub
End Class