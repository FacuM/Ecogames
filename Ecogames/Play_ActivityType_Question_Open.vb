﻿' ====================
'    Open questions
' ====================

Public Class Play_ActivityType_Question_Open
    Dim DoAutoEvaluation As Boolean = False
    Dim AnswerExpectedWords As List(Of String) = New List(Of String)
    Dim ExpectedAnswer As String

    Public Sub LoadActivity()
        UseWaitCursor = True

        Dim Activity As String() = My.Settings.Activities(CurrentActivityIndex).Split(";")

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
#If DEBUG Then
        LogD(Me, "Done.")
#End If

        StatusLabel.Text = String.Empty

        AnswerTextBox.Text = String.Empty
        AnswerTextBox.ReadOnly = False

        VerifyButton.Enabled = True

        UseWaitCursor = False
    End Sub

    Private Sub VerifyButton_Click(sender As Object, e As EventArgs) Handles VerifyButton.Click
        Dim Answer As String = ""

        Dim CompleteEvaluation As Boolean = True
        If String.IsNullOrEmpty(AnswerTextBox.Text) Then
            If MsgBox(My.Resources.Play_Question_General_AutoEvalEmptyAnswerWarn, MsgBoxStyle.Information + MsgBoxStyle.YesNo, My.Resources.General_Info_Title) = MsgBoxResult.Yes Then
                MsgBox(String.Format(My.Resources.Play_Question_General_AutoEvalEmpty, 0), MsgBoxStyle.Information, My.Resources.General_Info_Title)

                Answer = My.Resources.Play_General_EmptyAnswerDescriptor
            Else
                CompleteEvaluation = False
            End If
        Else
            Answer = AnswerTextBox.Text
        End If

        If CompleteEvaluation Then
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
                    Case < 71 '%
                        Message = String.Format(My.Resources.Play_Question_General_AutoEvalRegular, MatchPercentage)
                    Case Else ' > 71 %
                        Message = String.Format(My.Resources.Play_Question_General_AutoEvalRight, MatchPercentage)
                End Select
                MsgBox(Message, MsgBoxStyle.Information, My.Resources.General_Info_Title)
                StatusLabel.Text = MatchPercentage & "% completado"

#If DEBUG Then
                LogD(Me, "Answer verification completed.")
#End If
            Else
                MsgBox(My.Resources.Play_Question_Open_NoAutoEvalThanks & vbCrLf & vbCrLf & My.Resources.Play_Question_Open_NoAutoEvalInfo, MsgBoxStyle.Information, My.Resources.General_Info_Title)
            End If


            AnswerTextBox.ReadOnly = True
            AnswerTextBox.Text = String.Format(My.Resources.Play_Question_Open_AutoEvalResult, Answer, ExpectedAnswer)

            If Not DoAutoEvaluation Then
                AnswerTextBox.Text &= vbCrLf & vbCrLf & My.Resources.Play_Question_Open_NoAutoEvalInfo
            End If

            VerifyButton.Enabled = False
        End If
    End Sub
End Class