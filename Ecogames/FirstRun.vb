Public Class FirstRun
    Public Sub Populate()
        For i = 0 To LanguagesDescription.Length - 1
            LanguagePickerComboBox.Items.Add(LanguagesDescription(i))
        Next

        LanguagePickerComboBox.SelectedIndex = Array.IndexOf(SupportedLanguages, My.Settings.Language)

        Text = My.Resources.FirstRun_Text
    End Sub

    Private Sub ButtonEnabler()
        If SimpleLengthVerifier(UsernameTextBox, Panel3) Then
            If String.IsNullOrEmpty(PasswordTextBox.Text) And String.IsNullOrEmpty(PasswordVerifyTextBox.Text) Then
                StatusLabel.Text = String.Empty
            Else
                If PasswordConfirmationVerifier(PasswordTextBox, PasswordVerifyTextBox, Panel2) Then
                    StatusLabel.Text = String.Empty
                    ContinueButton.Enabled = True
                Else
                    ContinueButton.Enabled = False
                    StatusLabel.Text = My.Resources.FirstRun_PasswordsDontMatch
                End If
            End If
        Else
            StatusLabel.Text = My.Resources.FirstRun_UsernameRequired
        End If
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        If String.IsNullOrEmpty(PasswordTextBox.Text) Then
            StatusLabel.Text = String.Empty
        Else
            If PasswordStrengthVerifier(PasswordTextBox, Panel1) Then
                StatusLabel.Text = String.Empty
                ButtonEnabler()
            Else
                StatusLabel.Text = My.Resources.FirstRun_PasswordTooShort
            End If
        End If
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Close()
    End Sub

    Private Sub PasswordVerifyTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordVerifyTextBox.TextChanged
        ButtonEnabler()
    End Sub

    Private Sub ContinueButton_Click(sender As Object, e As EventArgs) Handles ContinueButton.Click
        Dim ContinueSignup As Boolean = False
        If SecurityWordTextBox.Text = String.Empty Then
            If MessageBox.Show(My.Resources.FirstRun_EmptySecretWordWarn, My.Resources.General_Warn_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                ContinueSignup = True
            End If
        Else
            My.Settings.SecurityWord = SecurityWordTextBox.Text
            ContinueSignup = True
        End If

        If ContinueSignup Then
            My.Settings.UserName = UsernameTextBox.Text
            My.Settings.UserPassword = PasswordVerifyTextBox.Text
            My.Settings.FirstRun = False
            SettingsSaver()
            Hide()
            Settings = Nothing
            Settings.Populate()
            Settings.UpdateActivities()
            Settings.Show()
            Close()
        End If
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged
        ButtonEnabler()
    End Sub

    Private Sub FirstRun_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        StatusLabel.Text = String.Empty
    End Sub

    Private Sub LanguagePickerComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LanguagePickerComboBox.SelectedIndexChanged
        My.Settings.Language = SupportedLanguages(LanguagePickerComboBox.SelectedIndex)

        RequestUIRedraw(ConfirmationProvided:=True)
    End Sub

    Private Sub SecurityWordTextBox_TextChanged(sender As Object, e As EventArgs) Handles SecurityWordTextBox.TextChanged
        SimpleLengthVerifier(SecurityWordTextBox, Panel4)
    End Sub
End Class