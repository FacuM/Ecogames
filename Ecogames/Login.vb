﻿Public Class Login
    Private Settings As Settings
    Dim RemainingAttempts As Integer = MaximumRecoveryAttempts
    Public Result As DialogResult = Nothing

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        If String.IsNullOrEmpty(PasswordTextBox.Text) Then
            PasswordStatusPanel.BackColor = Color.Red
            ContinueButton.Enabled = False
        Else
            ContinueButton.Enabled = True
            PasswordStatusPanel.BackColor = Color.LimeGreen
        End If
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        RecoveryMode = False
        Close()
        Result = DialogResult.Abort
    End Sub

    Private Sub ContinueButton_Click(sender As Object, e As EventArgs) Handles ContinueButton.Click
        DialogResult = DialogResult.None
        If RecoveryMode Then
            If PasswordTextBox.Text <> My.Settings.SecurityWord Then
                PasswordTextBox.Text = String.Empty

                If RemainingAttempts > 0 Then
                    MessageBox.Show(String.Format(My.Resources.Login_RecoveryModeWrongWord, RemainingAttempts), My.Resources.General_Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    RemainingAttempts -= 1
                Else
                    MessageBox.Show(My.Resources.Login_RecoveryMode_NoAttempts, My.Resources.General_Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Shutdown()
                End If
            Else
                RequestUIRedraw(ConfirmationProvided:=True)
            End If
        Else
            If PasswordTextBox.Text = My.Settings.UserPassword Then
                Hide()

                If Me.Settings IsNot Nothing Then
                    Me.Settings.Dispose()
                End If

                Me.Settings = New Settings()

                Me.Settings.Populate()
                Me.Settings.UpdateActivities()
                Me.Settings.Show()

                Result = DialogResult.OK
                Close()
            Else
                PasswordTextBox.Text = String.Empty
                MessageBox.Show(My.Resources.Login_WrongPassword, My.Resources.General_Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Text = My.Resources.Login_Text
        PasswordTextBox.Text = String.Empty
        HelperLabel.Text = My.Resources.Login_HelperText
        ForgotPasswordLink.Visible = (My.Settings.SecurityWord <> String.Empty)
    End Sub

    Private Sub ForgotPasswordLink_Click(sender As Object, e As EventArgs) Handles ForgotPasswordLink.Click
        RecoveryMode = True
        ForgotPasswordLink.Visible = False

        Hide()
        Text = My.Resources.Login_Text_RecoveryMode
        HelperLabel.Text = My.Resources.Login_RecoveryModeHelper
        Show() ' Cycle hide/show so that the resources get drawn again.
    End Sub
End Class