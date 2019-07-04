' ====================
'    Open questions
' ====================

Public Class Play_ActivityType_Question_Open
    Dim DoAutoEvaluation As Boolean = False
    Dim AnswerExpectedWords As List(Of String) = New List(Of String)
    Dim ExpectedAnswer As String
    Dim QuestionOpenMaxTimePerQuestion As Integer = 0

    Dim RemainingSeconds As Integer
    Dim ClockMode As Boolean = True
    Dim WarnEmptyAnswer As Boolean = True


    Public Sub LoadActivity()
        UseWaitCursor = True

        Dim Activity As String() = My.Settings.Activities(CurrentActivityIndex).Split(SemicolonChar)

#If DEBUG Then
        LogD(Me, "Parsing activity...")
#End If
        QuestionTextBox.Text = Activity(4)
        ExpectedAnswer = Activity(5)
#If DEBUG Then
        LogD(Me, "Question: """ & QuestionTextBox.Text & """")
        LogD(Me, "Expected answer: """ & ExpectedAnswer & """")
        LogD(Me, "Generating verification word list...")
#End If

        DoAutoEvaluation = Boolean.Parse(Activity(6))

        If DoAutoEvaluation Then
            Dim Paragraph As String = ExpectedAnswer
            Paragraph = Paragraph.Replace(DotChar, String.Empty).Replace(CommaChar, String.Empty).Replace(SemicolonChar, String.Empty)

            For Each Word In Paragraph.ToLower().Split(SpaceChar)
#If DEBUG Then
                LogD(Me, "Storing """ & Word & """ for comparison...")
#End If
                AnswerExpectedWords.Add(Word)
            Next
#If DEBUG Then
            LogD(Me, "Automatic evaluation: enabled.")
#End If
        End If

        QuestionOpenMaxTimePerQuestion = Integer.Parse(Activity(7))

#If DEBUG Then
        LogD(Me, "Done.")
#End If

        StatusLabel.Text = String.Empty

        AnswerTextBox.Text = String.Empty
        AnswerTextBox.ReadOnly = False

        VerifyButton.Enabled = True

        If QuestionOpenMaxTimePerQuestion > 0 Then
            TimeManager.Enabled = True

            RemainingSeconds = QuestionOpenMaxTimePerQuestion
        End If

        WarnEmptyAnswer = True

        UseWaitCursor = False
    End Sub

    Private Sub VerifyButton_Click(sender As Object, e As EventArgs) Handles VerifyButton.Click
        Dim Answer As String = ""

        Dim CompleteEvaluation As Boolean = True
        If String.IsNullOrEmpty(AnswerTextBox.Text) And WarnEmptyAnswer Then
            If MessageBox.Show(My.Resources.Play_Question_General_AutoEvalEmptyAnswerWarn, My.Resources.General_Info_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                MessageBox.Show(String.Format(My.Resources.Play_Question_General_AutoEvalEmpty, 0), My.Resources.General_Info_Title, MessageBoxButtons.OK, MessageBoxIcon.Information)

                Answer = My.Resources.Play_General_EmptyAnswerDescriptor

                AnswerTextBox.ReadOnly = True
                AnswerTextBox.Text = String.Format(My.Resources.Play_Question_Open_AutoEvalResult, Answer, ExpectedAnswer)

                VerifyButton.Enabled = False
                PauseButton.Enabled = False

                PreventClose = False
            End If
            CompleteEvaluation = False
        Else
            Answer = AnswerTextBox.Text
        End If

        If CompleteEvaluation Then
            VerifyButton.Enabled = False
            PauseButton.Enabled = False

            TimeManager.Enabled = False

            PreventClose = False

            If DoAutoEvaluation Then
#If DEBUG Then
                LogD(Me, "Verifying answer...")
#End If

                Dim WordMatchCount As Integer = 0

                Dim Paragraph As String = AnswerTextBox.Text
                Paragraph = Paragraph.Replace(DotChar, String.Empty).Replace(CommaChar, String.Empty).Replace(SemicolonChar, String.Empty)

                For Each Word In Paragraph.ToLower().Split(SpaceChar)
#If DEBUG Then
                    LogD(Me, "Comparing """ & Word & """...")
#End If
                    If AnswerExpectedWords.Contains(Word) Then
                        WordMatchCount += 1
                    End If
                Next

                Dim MatchPercentage As Double = (WordMatchCount * 100) / AnswerExpectedWords.Count
                Dim Message As String
                Select Case MatchPercentage
                    Case < 40 '%
                        Message = String.Format(My.Resources.Play_Question_General_AutoEvalWrong, MatchPercentage)
                        My.Computer.Audio.Play(My.Resources.Wrong, AudioPlayMode.Background)
                    Case < 71 '%
                        Message = String.Format(My.Resources.Play_Question_General_AutoEvalRegular, MatchPercentage)
                        My.Computer.Audio.Play(My.Resources.Regular, AudioPlayMode.Background)
                    Case Else ' > 71 %
                        Message = String.Format(My.Resources.Play_Question_General_AutoEvalRight, MatchPercentage)
                        My.Computer.Audio.Play(My.Resources.Right, AudioPlayMode.Background)
                End Select
                MessageBox.Show(Message, My.Resources.General_Info_Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                StatusLabel.Text = MatchPercentage & "% completado"

#If DEBUG Then
                LogD(Me, "Answer verification completed.")
#End If
            Else
                My.Computer.Audio.Play(My.Resources.Completed, AudioPlayMode.Background)
                MessageBox.Show(My.Resources.Play_Question_Open_NoAutoEvalThanks & vbCrLf & vbCrLf & My.Resources.Play_Question_Open_NoAutoEvalInfo, My.Resources.General_Info_Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


            AnswerTextBox.ReadOnly = True
            AnswerTextBox.Text = String.Format(My.Resources.Play_Question_Open_AutoEvalResult, Answer, ExpectedAnswer)

            If Not DoAutoEvaluation Then
                AnswerTextBox.Text &= vbCrLf & vbCrLf & My.Resources.Play_Question_Open_NoAutoEvalInfo
            End If
        End If
    End Sub

    Private Sub TimeManager_Tick(sender As Object, e As EventArgs) Handles TimeManager.Tick
        RemainingSeconds -= 1
        If RemainingSeconds > 0 Then
            If RemainingSeconds = 1 Then
                StatusLabel.Text = String.Format(My.Resources.Play_General_RemainingSeconds_Singular, RemainingSeconds)
            Else
                StatusLabel.Text = String.Format(My.Resources.Play_General_RemainingSeconds_Plural, RemainingSeconds)
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

            TimeManager.Enabled = False

            WarnEmptyAnswer = False

            VerifyButton.PerformClick()

            PreventClose = False
            QuestionTextBox.ReadOnly = True
            AnswerTextBox.ReadOnly = True
        End If
    End Sub

    Private Sub PauseButton_Click(sender As Object, e As EventArgs) Handles PauseButton.Click
        TimeManager.Enabled = False
        Hide()
        MessageBox.Show(My.Resources.Play_General_Paused, My.Resources.General_Info_Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Show()
        TimeManager.Enabled = True
    End Sub

    Private Sub Play_ActivityType_Question_Open_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If PreventClose Then
            If MessageBox.Show(My.Resources.Play_General_IncompleteActivityWarn, My.Resources.General_Info_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                e.Cancel = True
            Else
                TimeManager.Enabled = False
            End If
        Else
            TimeManager.Enabled = False
        End If
    End Sub
End Class