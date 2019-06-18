' ====================
'       Hangman
' ====================

Public Class ActivityType_Hangman
    Public Sub PrepareNew()
        HangmanScorePerLetter.Maximum = Integer.MaxValue
        LogD(Me, "NumericUpDown1.Maximum = " & HangmanScorePerLetter.Maximum)
        HangmanTimePerLetter.Maximum = HangmanMaximumSecondsPerCharacter
        LogD(Me, "NumericUpDown2.Maximum = " & HangmanTimePerLetter.Maximum)
        HangmanTimePerLetter.Minimum = HangmanMinimumSecondsPerCharacter
        LogD(Me, "NumericUpDown2.Minimum = " & HangmanTimePerLetter.Minimum)
        HangmanDefaultLetterAmount.Maximum = 0
        LogD(Me, "NumericUpDown3.Maximum = " & HangmanDefaultLetterAmount.Maximum)
        HangmanMaxTryAmount.Maximum = HangmanMaximumAttemptsPerCharacter
        LogD(Me, "NumericUpDown1.Minimum = " & HangmanMaxTryAmount.Minimum)
    End Sub

    Dim IsModifying As Boolean = False
    Public Sub PrepareModification()
        UseWaitCursor = True

        IsModifying = True

        Dim Activity As String() = My.Settings.Activities(CurrentActivityIndex).Split(";")

        LogD(Me, "Parsing activity...")
        HangmanWordTextBox.Text = Activity(4)
        HangmanScorePerLetter.Value = Integer.Parse(Activity(5))
        HangmanTimePerLetter.Value = Integer.Parse(Activity(6))
        HangmanDefaultLetterAmount.Value = Integer.Parse(Activity(7))
        HangmanMaxTryAmount.Value = Integer.Parse(Activity(8))
        LogD(Me, "Done.")

        UseWaitCursor = False
    End Sub

    Private Sub SaveActivity_Click(sender As Object, e As EventArgs) Handles SaveActivity.Click
        If IsModifying Then
            My.Settings.Activities(CurrentActivityIndex) = CurrentActivityIndex & ";" & Settings.SettingsActivityName.Text & ";" & Settings.SettingsActivityDescription.Text & ";" & Settings.SettingsActivityType.SelectedIndex & ";" & HangmanWordTextBox.Text & ";" & HangmanScorePerLetter.Value & ";" & HangmanTimePerLetter.Value & ";" & HangmanDefaultLetterAmount.Value & ";" & HangmanMaxTryAmount.Value
            LogD(Me, CurrentActivityIndex & ";" & Settings.SettingsActivityName.Text & ";" & Settings.SettingsActivityDescription.Text & ";" & Settings.SettingsActivityType.SelectedIndex & ";" & HangmanWordTextBox.Text & ";" & HangmanScorePerLetter.Value & ";" & HangmanTimePerLetter.Value & ";" & HangmanDefaultLetterAmount.Value & ";" & HangmanMaxTryAmount.Value)
        Else
            Dim NewActivityID As Integer = GetNewID()
            My.Settings.Activities.Add(NewActivityID & ";" & Settings.SettingsActivityName.Text & ";" & Settings.SettingsActivityDescription.Text & ";" & Settings.SettingsActivityType.SelectedIndex & ";" & HangmanWordTextBox.Text & ";" & HangmanScorePerLetter.Value & ";" & HangmanTimePerLetter.Value & ";" & HangmanDefaultLetterAmount.Value & ";" & HangmanMaxTryAmount.Value)
            LogD(Me, NewActivityID & ";" & Settings.SettingsActivityName.Text & ";" & Settings.SettingsActivityDescription.Text & ";" & Settings.SettingsActivityType.SelectedIndex & ";" & HangmanWordTextBox.Text & ";" & HangmanScorePerLetter.Value & ";" & HangmanTimePerLetter.Value & ";" & HangmanDefaultLetterAmount.Value & ";" & HangmanMaxTryAmount.Value)
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
        LogD(Me, "NumericUpDown1.Maximum = " & HangmanScorePerLetter.Maximum)
    End Sub
End Class