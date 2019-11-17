' ====================
'       Hangman
' ====================

Public Class ActivityType_Hangman
    Private ActivityName As String
    Private ActivityDescription As String
    Private ActivityType As Integer

    Dim Saved As Boolean = True

    Dim IsModifying As Boolean = False

    Public Sub PrepareNew(ByVal ActivityName As String, ByVal ActivityDescription As String, ActivityType As Integer)
        Me.ActivityName = ActivityName
        Me.ActivityDescription = ActivityDescription
        Me.ActivityType = ActivityType

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

    Public Sub PrepareModification(ByVal ActivityName As String, ByVal ActivityDescription As String, ActivityType As Integer)
        UseWaitCursor = True

        Me.ActivityName = ActivityName
        Me.ActivityDescription = ActivityDescription
        Me.ActivityType = ActivityType

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

        Dim Activity As String() = My.Settings.Activities(CurrentActivityIndex).Split(SemicolonChar)

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
            HangmanMaxTryAmountCheckbox.Checked = True
        End If

#If DEBUG Then
        LogD(Me, "Done.")
#End If

        UseWaitCursor = False
    End Sub

    Private Sub SaveActivity_Click(sender As Object, e As EventArgs) Handles SaveActivity.Click
        Dim HangmanTimePerLetterValue As Integer = 0
        If HangmanTimePerLetterCheckbox.Checked Then
            HangmanTimePerLetterValue = CInt(HangmanTimePerLetter.Value)
        End If

        Dim HangmanDefaultLetterAmountValue As Integer = 0
        If HangmanDefaultLetterAmountCheckbox.Checked Then
            HangmanDefaultLetterAmountValue = CInt(HangmanDefaultLetterAmount.Value)
        End If

        Dim HangmanMaxTryAmountValue As Integer = 0
        If HangmanMaxTryAmountCheckbox.Checked Then
            HangmanMaxTryAmountValue = CInt(HangmanMaxTryAmount.Value)
        End If

        If IsModifying Then
            My.Settings.Activities(CurrentActivityIndex) = CurrentActivityIndex & SemicolonChar & Me.ActivityName & SemicolonChar & Me.ActivityDescription & SemicolonChar & Me.ActivityType & SemicolonChar & HangmanWordTextBox.Text & SemicolonChar & HangmanScorePerLetter.Value & SemicolonChar & HangmanTimePerLetterValue & SemicolonChar & HangmanDefaultLetterAmountValue & SemicolonChar & HangmanMaxTryAmountValue
#If DEBUG Then
            LogD(Me, CurrentActivityIndex & SemicolonChar & Me.ActivityName & SemicolonChar & Me.ActivityDescription & SemicolonChar & Me.ActivityType & SemicolonChar & HangmanWordTextBox.Text & SemicolonChar & HangmanScorePerLetter.Value & SemicolonChar & HangmanTimePerLetterValue & SemicolonChar & HangmanDefaultLetterAmountValue & SemicolonChar & HangmanMaxTryAmountValue)
#End If
        Else
            Dim NewActivityID As Integer = GetNewID()
            My.Settings.Activities.Add(NewActivityID & SemicolonChar & Me.ActivityName & SemicolonChar & Me.ActivityDescription & SemicolonChar & Me.ActivityType & SemicolonChar & HangmanWordTextBox.Text & SemicolonChar & HangmanScorePerLetter.Value & SemicolonChar & HangmanTimePerLetterValue & SemicolonChar & HangmanDefaultLetterAmountValue & SemicolonChar & HangmanMaxTryAmountValue)
#If DEBUG Then
            LogD(Me, NewActivityID & SemicolonChar & Me.ActivityName & SemicolonChar & Me.ActivityDescription & SemicolonChar & Me.ActivityType & SemicolonChar & HangmanWordTextBox.Text & SemicolonChar & HangmanScorePerLetter.Value & SemicolonChar & HangmanTimePerLetterValue & SemicolonChar & HangmanDefaultLetterAmountValue & SemicolonChar & HangmanMaxTryAmountValue)
#End If
        End If
        SettingsSaver()
        Saved = True
        Close()
    End Sub

    Private Sub HangmanWordTextBox_TextChanged(sender As Object, e As EventArgs) Handles HangmanWordTextBox.TextChanged
        If HangmanWordTextBox.Text.Length > 0 Then
            HangmanScorePerLetter.Maximum = CDec(Math.Round(Integer.MaxValue / HangmanWordTextBox.Text.Length)) ' This is meant to prevent integer overflows.
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

    Private Sub ActivityType_Hangman_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not Saved Then
            If MessageBox.Show(My.Resources.Settings_General_UnsavedWarn, My.Resources.General_Warn_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class