' ====================
'   Closed questions
' ====================

Public Class Play_ActivityType_Question_Opts
    Dim Answers As List(Of String) = New List(Of String)
    Dim AnswersStatuses As List(Of Boolean) = New List(Of Boolean)

    Dim Verified As Boolean = False

    Public Sub LoadActivity()
        UseWaitCursor = True

        ' Cleanup
        Answers.Clear()
        AnswersStatuses.Clear()
        AnswersListBox.Items.Clear()

        AnswersListBox.Visible = True

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

        UseWaitCursor = False
    End Sub

    Private Sub ActivityType_Question_Open_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not Verified Then
            If MessageBox.Show(My.Resources.Play_General_IncompleteActivityWarn, My.Resources.General_Warn_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub VerifyButton_Click(sender As Object, e As EventArgs) Handles VerifyButton.Click
#If DEBUG Then
        LogD(Me, "Verifying answer...")
#End If

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

        Verified = True
    End Sub
End Class