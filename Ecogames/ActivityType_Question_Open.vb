' ====================
'    Open questions
' ====================

Public Class ActivityType_Question_Open
    Public Sub PrepareNew()
        QuestionTextBox.Text = ""
        AnswerTextBox.Text = ""
        AutomaticEvaluationCheckBox.Checked = False
    End Sub

    Dim IsModifying As Boolean = False
    Public Sub PrepareModification()
        UseWaitCursor = True

        IsModifying = True

        Dim Activity As String() = My.Settings.Activities(CurrentActivityIndex).Split(";")

        LogD(Me, "Parsing activity...")
        QuestionTextBox.Text = Activity(4)
        AnswerTextBox.Text = Activity(5)
        AutomaticEvaluationCheckBox.Checked = Boolean.Parse(Activity(6))
        LogD(Me, "Done.")

        Saved = True

        UseWaitCursor = False
    End Sub

    Private Sub AutomaticEvaluationCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AutomaticEvaluationCheckBox.CheckedChanged
        If Not My.Settings.AutoEvalWarnShown Then
            MsgBox(My.Resources.Question_Open_AutoEvalWarn, MsgBoxStyle.Exclamation, My.Resources.Settings_General_Warn_Title)
            My.Settings.AutoEvalWarnShown = True
            SettingsSaver()
        End If
    End Sub
    Private Sub SaveActivityButton_Click(sender As Object, e As EventArgs) Handles SaveActivityButton.Click
        If IsModifying Then
            My.Settings.Activities(CurrentActivityIndex) = CurrentActivityIndex & ";" & Settings.SettingsActivityName.Text & ";" & Settings.SettingsActivityDescription.Text & ";" & Settings.SettingsActivityType.SelectedIndex & ";" & QuestionTextBox.Text & ";" & AnswerTextBox.Text & ";" & AutomaticEvaluationCheckBox.Checked.ToString
            LogD(Me, CurrentActivityIndex & ";" & Settings.SettingsActivityName.Text & ";" & Settings.SettingsActivityDescription.Text & ";" & Settings.SettingsActivityType.SelectedIndex & ";" & QuestionTextBox.Text & ";" & AnswerTextBox.Text & ";" & AutomaticEvaluationCheckBox.Checked.ToString)
        Else
            Dim NewActivityID As Integer = GetNewID()
            My.Settings.Activities.Add(NewActivityID & ";" & Settings.SettingsActivityName.Text & ";" & Settings.SettingsActivityDescription.Text & ";" & Settings.SettingsActivityType.SelectedIndex & ";" & QuestionTextBox.Text & ";" & AnswerTextBox.Text & ";" & AutomaticEvaluationCheckBox.Checked.ToString)
            LogD(Me, NewActivityID & ";" & Settings.SettingsActivityName.Text & ";" & Settings.SettingsActivityDescription.Text & ";" & Settings.SettingsActivityType.SelectedIndex & ";" & QuestionTextBox.Text & ";" & AnswerTextBox.Text & ";" & AutomaticEvaluationCheckBox.Checked.ToString)
            CurrentActivityIndex = NewActivityID
        End If
        SettingsSaver()
        Settings.UpdateActivities()
        Settings.ActivityListBox.SelectedIndex = CurrentActivityIndex
        Saved = True
        Close()
    End Sub

    Private Sub ActivityType_Question_Open_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not Saved Then
            If (MsgBox(My.Resources.Settings_General_UnsavedWarn, MsgBoxStyle.YesNo, My.Resources.Settings_General_Warn_Title) = MsgBoxResult.No) Then
                e.Cancel = True
            End If
        End If
    End Sub

    Dim Saved As Boolean = True
    Private Sub QuestionTextBox_TextChanged(sender As Object, e As EventArgs) Handles QuestionTextBox.TextChanged
        Saved = False
    End Sub

    Private Sub AnswerTextBox_TextChanged(sender As Object, e As EventArgs) Handles AnswerTextBox.TextChanged
        Saved = False
    End Sub
End Class