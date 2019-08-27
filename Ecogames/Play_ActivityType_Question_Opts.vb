' ====================
'   Closed questions
' ====================

Public Class Play_ActivityType_Question_Opts
    Dim Answers As List(Of String) = New List(Of String)
    Dim AnswersStatuses As List(Of Boolean) = New List(Of Boolean)
    Dim QuestionOptsMaxTime As Integer = 0

    Dim Verified As Boolean = False

    Dim RemainingSeconds As Integer
    Dim ClockMode As Boolean = True
    Dim ShowingTutorial As Boolean

    Public Sub LoadActivity()
        UseWaitCursor = True

        ' Cleanup
        Answers.Clear()
        AnswersStatuses.Clear()
        AnswersListBox.Items.Clear()

        AnswersListBox.Visible = True

        Dim Activity As String() = My.Settings.Activities(CurrentActivityIndex).Split(SemicolonChar)

        QuestionOptsMaxTime = Integer.Parse(Activity(5))

#If DEBUG Then
        LogD(Me, "Parsing activity...")
#End If
        QuestionTextBox.Text = Activity(4)

        Dim ActivityPre As String = My.Settings.Activities(CurrentActivityIndex)
        For i = 0 To 5
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

                AnswersListBox.Items.Add(Answer(0))
            End If
        Next

        Dim PreviousIndex As Integer = AnswersListBox.SelectedIndex

#If DEBUG Then
        LogD(Me, "Done.")
#End If

        HelperLabel.Text = My.Resources.Play_Question_Opts_GeneralHelp
        StatusLabel.Text = String.Empty

        VerifyButton.Enabled = True
        AnswersListBox.Enabled = True

        Verified = False

        If QuestionOptsMaxTime > 0 Then
            TimeManager.Enabled = True

            RemainingSeconds = QuestionOptsMaxTime * SecondsInAMinute
        End If

        UseWaitCursor = False
    End Sub

    Private Sub ActivityType_Question_Open_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not Verified And PreventClose Then
            If MessageBox.Show(My.Resources.Play_General_IncompleteActivityWarn, My.Resources.General_Info_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                e.Cancel = True
            Else
                TimeManager.Enabled = False
            End If
        Else
            TimeManager.Enabled = False
        End If
    End Sub

    Private Sub VerifyButton_Click(sender As Object, e As EventArgs) Handles VerifyButton.Click
#If DEBUG Then
        LogD(Me, "Verifying answer...")
#End If
        TimeManager.Enabled = False

        Dim MaxScore As Integer = AnswersStatuses.Count
        Dim Score As Integer = MaxScore

        If AnswersListBox.SelectedIndices.Count > 0 Then
            If AnswersStatuses.Contains(True) Then
                For Each Index As Integer In AnswersListBox.SelectedIndices
                    If Not AnswersStatuses(Index) Then
                        Score -= 1
                    End If
                Next
            End If
        Else
            If AnswersStatuses.Contains(True) Then
                Score = 0
            Else
                For Each Index As Integer In AnswersListBox.SelectedIndices
                    If Not AnswersStatuses(Index) Then
                        Score -= 1
                    End If
                Next
            End If
        End If

        Dim MatchPercentage As Double = Math.Round((Score * 100) / MaxScore, 2)
        Dim Message As String
        If MatchPercentage > 0 Then
            Select Case MatchPercentage
                Case < 40 '%
                    Message = String.Format(My.Resources.Play_Question_General_AutoEvalWrong, MatchPercentage)
                    My.Computer.Audio.Play(My.Resources.Wrong, AudioPlayMode.Background)
                Case < 71 '%
                    Message = String.Format(My.Resources.Play_Question_General_AutoEvalRegular, MatchPercentage)
                    My.Computer.Audio.Play(My.Resources.Regular, AudioPlayMode.Background)
                Case < 100 '%
                    Message = String.Format(My.Resources.Play_Question_General_AutoEvalRight, MatchPercentage)
                    My.Computer.Audio.Play(My.Resources.Right, AudioPlayMode.Background)
                Case Else ' = 100 %
                    Message = String.Format(My.Resources.Play_General_PerfectScore, MatchPercentage)
                    My.Computer.Audio.Play(My.Resources.Perfect, AudioPlayMode.Background)
            End Select
        Else
            Message = String.Format(My.Resources.Play_Question_Open_AutoEvalNoScore, MatchPercentage)
            My.Computer.Audio.Play(My.Resources.Wrong, AudioPlayMode.Background)
        End If
        MessageBox.Show(Message, My.Resources.General_Info_Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        StatusLabel.Text = MatchPercentage & "% completado"

#If DEBUG Then
        LogD(Me, "Answer verification completed.")
#End If

        AnswersListBox.Enabled = False

        VerifyButton.Enabled = False
        PauseButton.Enabled = False

        Verified = True
    End Sub

    Private Sub TimeManager_Tick(sender As Object, e As EventArgs) Handles TimeManager.Tick
        RemainingSeconds -= 1
        If RemainingSeconds > 0 Then
            If RemainingSeconds > 90 Then
                StatusLabel.Text = String.Format(My.Resources.Play_General_RemainingMinutes_Plural, Math.Round(RemainingSeconds / SecondsInAMinute, 0))
            ElseIf RemainingSeconds > 60 And RemainingSeconds < 91 Then
                StatusLabel.Text = String.Format(My.Resources.Play_General_RemainingMinutes_Plural, 2)
            ElseIf RemainingSeconds = 60 Then
                StatusLabel.Text = String.Format(My.Resources.Play_General_RemainingMinutes_Singular, Math.Round(RemainingSeconds / SecondsInAMinute, 0))
            ElseIf RemainingSeconds > 1 Then
                StatusLabel.Text = String.Format(My.Resources.Play_General_RemainingSeconds_Plural, RemainingSeconds)
            Else
                StatusLabel.Text = String.Format(My.Resources.Play_General_RemainingSeconds_Singular, RemainingSeconds)
            End If
#If DEBUG Then
            LogD(Me, RemainingSeconds & " seconds remaining.")
#End If

            If RemainingSeconds < 5 Then
                If ClockMode Then
                    My.Computer.Audio.Play(My.Resources.Clock_tic, AudioPlayMode.Background)
                Else
                    My.Computer.Audio.Play(My.Resources.Clock_tac, AudioPlayMode.Background)
                End If

                ClockMode = Not ClockMode
            End If
        Else
            PreventClose = False
            TimeManager.Enabled = False

            VerifyButton.PerformClick()
        End If
    End Sub

    Private Sub PauseButton_Click(sender As Object, e As EventArgs) Handles PauseButton.Click
        TimeManager.Enabled = False
        Hide()
        MessageBox.Show(My.Resources.Play_General_Paused, My.Resources.General_Info_Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Show()
        TimeManager.Enabled = True
    End Sub

    Private Sub HowToPlayButton_Click(sender As Object, e As EventArgs) Handles HowToPlayButton.Click
        Dim HasChanges As Boolean = True ' Assume it's always true, we can't tell reliably.

        Dim Proceed As Boolean = True

        If HasChanges Then
            TimeManager.Enabled = False
            Hide()

            If MessageBox.Show(My.Resources.Tutorial_General_ActivityRestartRequest, My.Resources.General_Warn_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Proceed = False
            End If

            Show()
            TimeManager.Enabled = True
        End If

        If Proceed Then
            ShowingTutorial = True
            TimeManager.Enabled = False

            AnswersListBox.Enabled = False
            AnswersListBox.Items.Clear()

            HowToPlayButton.Enabled = False

            MessagesIndex = 0

            QuestionTextBox.Text = Messages(0)

            MessagesIndex += 1

            VerifyButton.Enabled = False
            PauseButton.Enabled = False

            StatusLabel.Text = String.Empty

            TutorialTimer.Enabled = True
        End If
    End Sub

    Private StatusBackup As String
    Private Messages As String() = {My.Resources.Tutorial_Play_Question_QuestionTextBox, My.Resources.Tutorial_Play_QuestionClosed_AnswersListBox, My.Resources.Tutorial_Play_QuestionClosed_AnswersListBox_Final}
    Private Sub TutorialTimer_Tick(sender As Object, e As EventArgs) Handles TutorialTimer.Tick
        If MessagesIndex < Messages.Length Then

            AnswersListBox.Items.Add(Messages(MessagesIndex))

            MessagesIndex += 1
        Else
            TutorialTimer.Enabled = False
            HowToPlayButton.Enabled = True

            VerifyButton.Enabled = True
            PauseButton.Enabled = True

            LoadActivity()
            ' AnswersListBox.Enabled = True - left due to legibility reasons, this is handled by LoadActivity().
        End If
    End Sub
End Class