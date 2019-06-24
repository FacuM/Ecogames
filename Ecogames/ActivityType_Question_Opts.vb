' ====================
'   Closed questions
' ====================

Public Class ActivityType_Question_Opts
    Dim Answers As List(Of String) = New List(Of String)
    Dim AnswersStatuses As List(Of Boolean) = New List(Of Boolean)

    Dim Saved As Boolean = True

    Private Sub UpdateAnswers()
        Dim PreviousIndex As Integer = AnswersListBox.SelectedIndex

        AnswersListBox.Items.Clear()
        AnswersListBox.Items.Add(My.Resources.Question_Opts_NewAnswer)
        For i = 0 To Answers.Count - 1
            Dim CorrectAnswer As String
            If AnswersStatuses(i) Then
                SaveActivityButton.Enabled = True
                CorrectAnswer = "Correcta"
            Else
                CorrectAnswer = "Incorrecta"
            End If

            AnswersListBox.Items.Insert(AnswersListBox.Items.Count - 1, Answers(i) & " (" & CorrectAnswer & ")")
        Next
        AnswersListBox.SelectedIndex = PreviousIndex
    End Sub

    Public Sub PrepareNew()
        QuestionTextBox.Clear()
        AnswerTextBox.Clear()
        Size = New Size(Size.Width, 242)
        MetroLabel2.Visible = False
        AnswerTextBox.Visible = False
        SaveActivityButton.Visible = False
        Answers.Clear()
        AnswersStatuses.Clear()
        HelperLabel.Text = String.Format(My.Resources.Question_Opts_GeneralHelp, My.Resources.Question_Opts_NextActionHelp)
        AnswersListBox.Items.Add(My.Resources.Question_Opts_NewAnswer)
        AnswersListBox.SelectedIndex = AnswersListBox.Items.Count - 1
    End Sub

    Dim IsModifying As Boolean = False
    Public Sub PrepareModification()
        UseWaitCursor = True

        IsModifying = True

        AnswersListBox.Visible = True

        Answers.Clear()
        AnswersStatuses.Clear()
        Dim Activity As String() = My.Settings.Activities(CurrentActivityIndex).Split(SemicolonChar)

#If DEBUG Then
        LogD(Me, "Parsing activity...")
#End If
        QuestionTextBox.Text = Activity(4)

        Dim ActivityPre As String = My.Settings.Activities(CurrentActivityIndex)
        For i = 0 To 4
            ActivityPre = ActivityPre.Remove(0, ActivityPre.IndexOf(SemicolonChar) + 1)
#If DEBUG Then
            LogD(Me, ActivityPre)
#End If
        Next

        For Each AnswerPair As String In ActivityPre.Split(RowSplitter, options:=StringSplitOptions.None)
#If DEBUG Then
            LogD(Me, AnswerPair)
#End If
            Dim Answer As String() = AnswerPair.Split(SemicolonChar)

            If Answer.Length > 1 Then
                Answers.Add(Answer(0))
                AnswersStatuses.Add(Boolean.Parse(Answer(1)))
            End If
        Next

        UpdateAnswers()

#If DEBUG Then
        LogD(Me, "Done.")
#End If

        Saved = True

        UseWaitCursor = False
    End Sub

    Private Sub SaveActivityButton_Click(sender As Object, e As EventArgs) Handles SaveActivityButton.Click
        Dim ActivityString = String.Empty
        For i = 0 To Answers.Count - 1
            ActivityString &= Answers(i) & SemicolonChar & AnswersStatuses(i) & SemicolonChar & RowSplitter(0)
        Next
        If IsModifying Then
            My.Settings.Activities(CurrentActivityIndex) = CurrentActivityIndex & SemicolonChar & Settings.SettingsActivityName.Text & SemicolonChar & Settings.SettingsActivityDescription.Text & SemicolonChar & Settings.SettingsActivityType.SelectedIndex & SemicolonChar & QuestionTextBox.Text & SemicolonChar & ActivityString
#If DEBUG Then
            LogD(Me, CurrentActivityIndex & SemicolonChar & Settings.SettingsActivityName.Text & SemicolonChar & Settings.SettingsActivityDescription.Text & SemicolonChar & Settings.SettingsActivityType.SelectedIndex & SemicolonChar & QuestionTextBox.Text & SemicolonChar & ActivityString)
#End If
        Else
            Dim NewActivityID As Integer = GetNewID()
            My.Settings.Activities.Add(NewActivityID & SemicolonChar & Settings.SettingsActivityName.Text & SemicolonChar & Settings.SettingsActivityDescription.Text & SemicolonChar & Settings.SettingsActivityType.SelectedIndex & SemicolonChar & QuestionTextBox.Text & SemicolonChar & ActivityString)
#If DEBUG Then
            LogD(Me, NewActivityID & SemicolonChar & Settings.SettingsActivityName.Text & SemicolonChar & Settings.SettingsActivityDescription.Text & SemicolonChar & Settings.SettingsActivityType.SelectedIndex & SemicolonChar & QuestionTextBox.Text & SemicolonChar & ActivityString)
#End If
            CurrentActivityIndex = NewActivityID
        End If
#If DEBUG Then
        LogD(Me, ActivityString)
#End If
        SettingsSaver()
        Saved = True
        Settings.UpdateActivities()
        Close()
    End Sub

    Private Sub ActivityType_Question_Open_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not Saved Then
            If MessageBox.Show(My.Resources.Settings_General_UnsavedWarn, My.Resources.General_Warn_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub QuestionTextBox_TextChanged(sender As Object, e As EventArgs) Handles QuestionTextBox.TextChanged
        Saved = False
        If String.IsNullOrEmpty(QuestionTextBox.Text) Then
            NextActionButton.Enabled = False
        Else
            NextActionButton.Enabled = True
        End If
    End Sub

    Private Sub AnswerTextBox_TextChanged(sender As Object, e As EventArgs) Handles AnswerTextBox.TextChanged
        Saved = False
        If String.IsNullOrEmpty(AnswerTextBox.Text) Then
            AddAnswerButton.Enabled = False
            ModifyButton.Text = My.Resources.Question_Opts_DelMode
        Else
            AddAnswerButton.Enabled = True
            ModifyButton.Text = My.Resources.Question_Opts_ModMode
        End If
    End Sub

    Dim NormalHeight As Integer = 412
    Private Sub NextActionButton_Click(sender As Object, e As EventArgs) Handles NextActionButton.Click
        AnswersListBox.Visible = True
        QuestionTextBox.Enabled = False
        MetroLabel2.Visible = True
        AnswerTextBox.Visible = True
        SaveActivityButton.Visible = True
        NextActionButton.Visible = False
        Size = New Size(Size.Width, NormalHeight)
        AcceptButton = AddAnswerButton
        HelperLabel.Text = String.Format(My.Resources.Question_Opts_GeneralHelp, My.Resources.Question_Opts_NextAnswerHelp)
    End Sub

    Private Sub AddAnswerButton_Click(sender As Object, e As EventArgs) Handles AddAnswerButton.Click
        Dim CorrectAnswer As String
        If CorrectAnswerCheckBox.Checked Then
            SaveActivityButton.Enabled = True
            CorrectAnswer = "Correcta"
        Else
            CorrectAnswer = "Incorrecta"
        End If

        Answers.Add(AnswerTextBox.Text)
        AnswersStatuses.Add(CorrectAnswerCheckBox.Checked)

        AnswersListBox.Items.Insert(AnswersListBox.Items.Count - 1, AnswerTextBox.Text & " (" & CorrectAnswer & ")")
        AnswerTextBox.Clear()

#If DEBUG Then
        LogD(Me, "New answer pair: " & Answers(Answers.Count - 1) & SemicolonChar & AnswersStatuses(AnswersStatuses.Count - 1).ToString)
#End If
        CorrectAnswerCheckBox.Checked = False
        AddAnswerButton.Enabled = False
    End Sub

    Private Sub AnswersListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AnswersListBox.SelectedIndexChanged
        If AnswersListBox.SelectedIndex < AnswersListBox.Items.Count - 1 Then
            AnswerTextBox.Text = Answers(AnswersListBox.SelectedIndex)

            AddAnswerButton.Visible = False
            ModifyButton.Visible = True
        Else
            ModifyButton.Visible = False
            AddAnswerButton.Visible = True
        End If
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        If String.IsNullOrEmpty(AnswerTextBox.Text) Then
            If MessageBox.Show(My.Resources.Question_Opts_Empty, My.Resources.General_Warn_Title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                Answers.RemoveAt(AnswersListBox.SelectedIndex)
                AnswersStatuses.RemoveAt(AnswersListBox.SelectedIndex)

                UpdateAnswers()
            End If
        Else
            Answers(AnswersListBox.SelectedIndex) = AnswerTextBox.Text
            AnswersStatuses(AnswersListBox.SelectedIndex) = CorrectAnswerCheckBox.Checked

            UpdateAnswers()

            AnswerTextBox.Clear()
        End If
        SaveActivityButton.Enabled = AnswersStatuses.Contains(True)
    End Sub
End Class