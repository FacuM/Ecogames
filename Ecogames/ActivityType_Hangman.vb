' ====================
'       Hangman
' ====================

Public Class ActivityType_Hangman
    Public Sub PrepareNew()
        HangmanScorePerLetter.Maximum = Integer.MaxValue
        HangmanScorePerLetter.Value = DefaultScoreMultiplier
        HangmanTimePerLetter.Minimum = HangmanMinimumSecondsPerCharacter
        HangmanTimePerLetter.Maximum = HangmanMaximumSecondsPerCharacter
        HangmanDefaultLetterAmount.Maximum = 0
        HangmanMaxTryAmount.Maximum = HangmanMaximumAttemptsPerCharacter

#If DEBUG Then
        LogD(Me, "HangmanScorePerLetter.Maximum = " & HangmanScorePerLetter.Maximum)
        LogD(Me, "HangmanScorePerLetter.Value = " & HangmanScorePerLetter.Value)
        LogD(Me, "HangmanTimePerLetter.Minimum = " & HangmanTimePerLetter.Minimum)
        LogD(Me, "HangmanTimePerLetter.Maximum = " & HangmanTimePerLetter.Maximum)
        LogD(Me, "HangmanDefaultLetterAmount.Maximum = " & HangmanDefaultLetterAmount.Maximum)
        LogD(Me, "HangmanMaxTryAmount.Minimum = " & HangmanMaxTryAmount.Minimum)
#End If
    End Sub

    Dim IsModifying As Boolean = False
    Public Sub PrepareModification()
        UseWaitCursor = True

        HangmanScorePerLetter.Maximum = Integer.MaxValue
        HangmanScorePerLetter.Value = DefaultScoreMultiplier
        HangmanTimePerLetter.Minimum = HangmanMinimumSecondsPerCharacter
        HangmanTimePerLetter.Maximum = HangmanMaximumSecondsPerCharacter
        HangmanMaxTryAmount.Maximum = HangmanMaximumAttemptsPerCharacter

#If DEBUG Then
        LogD(Me, "HangmanScorePerLetter.Maximum = " & HangmanScorePerLetter.Maximum)
        LogD(Me, "HangmanScorePerLetter.Value = " & HangmanScorePerLetter.Value)
        LogD(Me, "HangmanTimePerLetter.Minimum = " & HangmanTimePerLetter.Minimum)
        LogD(Me, "HangmanTimePerLetter.Maximum = " & HangmanTimePerLetter.Maximum)
        LogD(Me, "HangmanDefaultLetterAmount.Maximum = " & HangmanDefaultLetterAmount.Maximum)
        LogD(Me, "HangmanMaxTryAmount.Minimum = " & HangmanMaxTryAmount.Minimum)
#End If

        IsModifying = True

        Dim Activity As String() = My.Settings.Activities(CurrentActivityIndex).Split(";")

#If DEBUG Then
        LogD(Me, "Parsing activity...")
#End If

        HangmanWordTextBox.Text = Activity(4)

        HangmanDefaultLetterAmount.Maximum = HangmanWordTextBox.Text.Length

        HangmanScorePerLetter.Value = Integer.Parse(Activity(5))

        Dim HangmanTimePerLetterValue = Integer.Parse(Activity(6))
        If HangmanTimePerLetterValue = 0 Then
            HangmanTimePerLetter.Value = HangmanTimePerLetter.Minimum
            HangmanTimePerLetterCheckbox.Checked = False
        Else
            HangmanTimePerLetter.Value = HangmanTimePerLetterValue
            HangmanTimePerLetterCheckbox.Checked = True
        End If

        Dim HangmanDefaultLetterAmountValue As Integer = Integer.Parse(Activity(7))
        If HangmanDefaultLetterAmountValue = 0 Then
            HangmanDefaultLetterAmount.Value = HangmanDefaultLetterAmount.Minimum
            HangmanDefaultLetterAmountCheckbox.Checked = False
        Else
            HangmanDefaultLetterAmount.Value = HangmanDefaultLetterAmountValue
            HangmanDefaultLetterAmountCheckbox.Checked = True
        End If

        Dim HangmanMaxTryAmountValue = Integer.Parse(Activity(8))
        If HangmanMaxTryAmountValue = 0 Then
            HangmanMaxTryAmount.Value = HangmanMaxTryAmount.Minimum
            HangmanMaxTryAmountCheckbox.Checked = False
        Else
            HangmanMaxTryAmount.Value = HangmanMaxTryAmountValue
            HangmanMaxTryAmountCheckbox.Checked= True
        End If

#If DEBUG Then
        LogD(Me, "Done.")
#End If

        UseWaitCursor = False
    End Sub

    Private Sub SaveActivity_Click(sender As Object, e As EventArgs) Handles SaveActivity.Click
        Dim HangmanTimePerLetterValue As Integer = 0
        If HangmanTimePerLetterCheckbox.Checked Then
            HangmanTimePerLetterValue = HangmanTimePerLetter.Value
        End If

        Dim HangmanDefaultLetterAmountValue As Integer = 0
        If HangmanDefaultLetterAmountCheckbox.Checked Then
            HangmanDefaultLetterAmountValue = HangmanDefaultLetterAmount.Value
        End If

        Dim HangmanMaxTryAmountValue As Integer = 0
        If HangmanMaxTryAmountCheckbox.Checked Then
            HangmanMaxTryAmountValue = HangmanMaxTryAmount.Value
        End If

        If IsModifying Then
            My.Settings.Activities(CurrentActivityIndex) = CurrentActivityIndex & ";" & Settings.SettingsActivityName.Text & ";" & Settings.SettingsActivityDescription.Text & ";" & Settings.SettingsActivityType.SelectedIndex & ";" & HangmanWordTextBox.Text & ";" & HangmanScorePerLetter.Value & ";" & HangmanTimePerLetterValue & ";" & HangmanDefaultLetterAmountValue & ";" & HangmanMaxTryAmountValue
#If DEBUG Then
            LogD(Me, CurrentActivityIndex & ";" & Settings.SettingsActivityName.Text & ";" & Settings.SettingsActivityDescription.Text & ";" & Settings.SettingsActivityType.SelectedIndex & ";" & HangmanWordTextBox.Text & ";" & HangmanScorePerLetter.Value & ";" & HangmanTimePerLetterValue & ";" & HangmanDefaultLetterAmountValue & ";" & HangmanMaxTryAmountValue)
#End If
        Else
            Dim NewActivityID As Integer = GetNewID()
            My.Settings.Activities.Add(NewActivityID & ";" & Settings.SettingsActivityName.Text & ";" & Settings.SettingsActivityDescription.Text & ";" & Settings.SettingsActivityType.SelectedIndex & ";" & HangmanWordTextBox.Text & ";" & HangmanScorePerLetter.Value & ";" & HangmanTimePerLetterValue & ";" & HangmanDefaultLetterAmountValue & ";" & HangmanMaxTryAmountValue)
#If DEBUG Then
            LogD(Me, NewActivityID & ";" & Settings.SettingsActivityName.Text & ";" & Settings.SettingsActivityDescription.Text & ";" & Settings.SettingsActivityType.SelectedIndex & ";" & HangmanWordTextBox.Text & ";" & HangmanScorePerLetter.Value & ";" & HangmanTimePerLetterValue & ";" & HangmanDefaultLetterAmountValue & ";" & HangmanMaxTryAmountValue)
#End If
        End If
        SettingsSaver()
        Settings.UpdateActivities()
        Close()
    End Sub

    Private Sub HangmanWordTextBox_TextChanged(sender As Object, e As EventArgs) Handles HangmanWordTextBox.TextChanged
        If HangmanWordTextBox.Text.Length > 0 Then
            HangmanScorePerLetter.Maximum = Math.Round(Integer.MaxValue / HangmanWordTextBox.Text.Length) ' This is meant to prevent integer overflows.
            HangmanDefaultLetterAmount.Maximum = HangmanWordTextBox.Text.Length
        Else
            HangmanScorePerLetter.Maximum = Integer.MaxValue
        End If
#If DEBUG Then
        LogD(Me, "HangmanScorePerLetter.Maximum = " & HangmanScorePerLetter.Maximum)
#End If
    End Sub

    Private Sub HangmanTimePerLetterCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles HangmanTimePerLetterCheckbox.CheckedChanged
        HangmanTimePerLetter.Enabled = HangmanTimePerLetterCheckbox.Checked
    End Sub

    Private Sub HangmanDefaultLetterAmountCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles HangmanDefaultLetterAmountCheckbox.CheckedChanged
        HangmanDefaultLetterAmount.Enabled = HangmanDefaultLetterAmountCheckbox.Checked
    End Sub

    Private Sub HangmanMaxTryAmountCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles HangmanMaxTryAmountCheckbox.CheckedChanged
        HangmanMaxTryAmount.Enabled = HangmanMaxTryAmountCheckbox.Checked
    End Sub
End Class