﻿' ====================
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

        Dim Activity As String() = My.Settings.Activities(CurrentActivityIndex).Split(SemicolonChar)

#If DEBUG Then
        LogD(Me, "Parsing activity...")
#End If
        QuestionTextBox.Text = Activity(4)
        AnswerTextBox.Text = Activity(5)
        AutomaticEvaluationCheckBox.Checked = Boolean.Parse(Activity(6))
#If DEBUG Then
        LogD(Me, "Done.")
#End If

        Saved = True

        UseWaitCursor = False
    End Sub

    Private Sub AutomaticEvaluationCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AutomaticEvaluationCheckBox.CheckedChanged
        If Not My.Settings.AutoEvalWarnShown Then
            MessageBox.Show(My.Resources.Question_Open_AutoEvalWarn, My.Resources.General_Warn_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            My.Settings.AutoEvalWarnShown = True
            SettingsSaver()
        End If
    End Sub
    Private Sub SaveActivityButton_Click(sender As Object, e As EventArgs) Handles SaveActivityButton.Click
        If IsModifying Then
            My.Settings.Activities(CurrentActivityIndex) = CurrentActivityIndex & SemicolonChar & Settings.SettingsActivityName.Text & SemicolonChar & Settings.SettingsActivityDescription.Text & SemicolonChar & Settings.SettingsActivityType.SelectedIndex & SemicolonChar & QuestionTextBox.Text & SemicolonChar & AnswerTextBox.Text & SemicolonChar & AutomaticEvaluationCheckBox.Checked.ToString
#If DEBUG Then
            LogD(Me, CurrentActivityIndex & SemicolonChar & Settings.SettingsActivityName.Text & SemicolonChar & Settings.SettingsActivityDescription.Text & SemicolonChar & Settings.SettingsActivityType.SelectedIndex & SemicolonChar & QuestionTextBox.Text & SemicolonChar & AnswerTextBox.Text & SemicolonChar & AutomaticEvaluationCheckBox.Checked.ToString)
#End If
        Else
            Dim NewActivityID As Integer = GetNewID()
            My.Settings.Activities.Add(NewActivityID & SemicolonChar & Settings.SettingsActivityName.Text & SemicolonChar & Settings.SettingsActivityDescription.Text & SemicolonChar & Settings.SettingsActivityType.SelectedIndex & SemicolonChar & QuestionTextBox.Text & SemicolonChar & AnswerTextBox.Text & SemicolonChar & AutomaticEvaluationCheckBox.Checked.ToString)
#If DEBUG Then
            LogD(Me, NewActivityID & SemicolonChar & Settings.SettingsActivityName.Text & SemicolonChar & Settings.SettingsActivityDescription.Text & SemicolonChar & Settings.SettingsActivityType.SelectedIndex & SemicolonChar & QuestionTextBox.Text & SemicolonChar & AnswerTextBox.Text & SemicolonChar & AutomaticEvaluationCheckBox.Checked.ToString)
#End If
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
            If MessageBox.Show(My.Resources.Settings_General_UnsavedWarn, My.Resources.General_Warn_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
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