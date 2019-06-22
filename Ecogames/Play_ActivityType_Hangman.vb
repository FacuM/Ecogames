﻿' ====================
'       Hangman
' ====================

Public Class Play_ActivityType_Hangman
    Dim HangmanWordText As String = String.Empty
    Dim HangmanWordTextAux As String = HangmanWordText
    Dim HangmanScorePerLetter As Integer = DefaultScoreMultiplier
    Dim HangmanTimePerLetter As Integer = 0
    Dim HangmanDefaultLetterAmount As Integer = 0
    Dim HangmanMaxTryAmount As Integer = 0

    Dim Score As Integer
    Dim MaxScore As Integer
    Dim RemainingAttempts As Integer
    Dim RemainingSeconds As Integer

    Public Sub LoadActivity()
        UseWaitCursor = True

#If DEBUG Then
        LogD(Me, "Parsing activity...")
#End If

        Score = 0

        Dim Activity As String() = My.Settings.Activities(CurrentActivityIndex).Split(";")

        HangmanWordText = Activity(4)
        HangmanWordTextAux = HangmanWordText
        HangmanScorePerLetter = Integer.Parse(Activity(5))
        HangmanTimePerLetter = Integer.Parse(Activity(6))
        If HangmanTimePerLetter > 0 Then
            TimeManager.Enabled = True
            RemainingSeconds = HangmanTimePerLetter
            StatusLabel.Text = My.Resources.Play_General_GameBegins
        Else
            StatusLabel.Text = String.Empty
        End If

        HangmanDefaultLetterAmount = Integer.Parse(Activity(7))

        HangmanMaxTryAmount = Integer.Parse(Activity(8))
        RemainingAttempts = HangmanMaxTryAmount

        HangmanWordTextBox.Text = String.Empty
        For i = 0 To HangmanWordText.Length - 1
            If HangmanWordText(i) = SpaceChar Then
                HangmanWordTextBox.Text &= SpaceChar
            Else
                HangmanWordTextBox.Text &= HangmanSeparator
            End If
        Next

#If DEBUG Then
        LogD(Me, "Done.")
#End If

        MaxScore = HangmanWordText.Replace(SpaceChar, String.Empty).Length * HangmanScorePerLetter
        ScoreLabel.Text = Score.ToString & " / " & MaxScore.ToString

        DoKeyPressEvent = True

        UseWaitCursor = False
    End Sub

    Dim DoResetCycle As Boolean = True
    Private Sub StatusResetTimer_Tick(sender As Object, e As EventArgs) Handles StatusResetTimer.Tick
        StatusLabel.Text = String.Empty
        StatusResetTimer.Enabled = False
    End Sub

    Dim DoKeyPressEvent As Boolean = True
    Private Sub Play_ActivityType_Hangman_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If DoKeyPressEvent Then
            If Integer.TryParse(e.KeyChar, Nothing) Then
#If DEBUG Then
                LogD(Me, "Number entered, won't do anything.")
#End If
            Else
                If e.KeyChar = SpaceChar Then
#If DEBUG Then
                    LogD(Me, "Space entered, won't do anything.")
#End If
                Else
#If DEBUG Then
                    LogD(Me, e.KeyChar & " pressed.")
#End If

                    If Not HangmanWordTextBox.Text.ToLower.Contains(e.KeyChar.ToString.ToLower) Then
                        Dim IndexOfMatch As Integer = HangmanWordText.ToLower.IndexOf(e.KeyChar.ToString.ToLower)
                        Dim IndexOfMatchAux As Integer = HangmanWordTextAux.ToLower.IndexOf(e.KeyChar.ToString.ToLower)
                        Dim LastIndex As Integer = -1
                        Dim RightAnswer As Boolean = False
                        While IndexOfMatch > -1
#If DEBUG Then
                            LogD(Me, "Found a match!")
#End If

                            RemainingSeconds = HangmanTimePerLetter

                            Score += HangmanScorePerLetter

                            LastIndex = IndexOfMatchAux

                            StatusLabel.Text = My.Resources.Play_General_RightAnswer
                            RightAnswer = True

                            Mid(HangmanWordTextBox.Text, IndexOfMatchAux + 1, 1) = HangmanWordText(IndexOfMatch)
                            HangmanWordText = Replace(Expression:=HangmanWordText, Find:=HangmanWordText(IndexOfMatch), Replacement:="", Count:=1)

#If DEBUG Then
                            LogD(Me, "Current expectation: " & HangmanWordText)
#End If

                            IndexOfMatch = HangmanWordText.ToLower.IndexOf(e.KeyChar.ToString.ToLower)
                            IndexOfMatchAux = HangmanWordTextAux.ToLower.IndexOf(e.KeyChar.ToString.ToLower, LastIndex + 1)
                        End While
                        If IndexOfMatch < 0 Then
                            If RightAnswer Then
                                ScoreLabel.Text = Score.ToString & " / " & MaxScore.ToString
                            Else
#If DEBUG Then
                                LogD(Me, "That was wrong.")
#End If
                                If HangmanMaxTryAmount > 0 Then
#If DEBUG Then
                                    LogD(Me, RemainingAttempts & " remaining attempts.")
#End If
                                    If RemainingAttempts > 0 Then
                                        StatusLabel.Text = String.Format(My.Resources.Play_Hangman_Wrong_RemainingAttempts, RemainingAttempts)
                                        RemainingAttempts -= 1
                                    Else
                                        DoKeyPressEvent = False

                                        StatusResetTimer.Enabled = False
                                        TimeManager.Enabled = False

                                        If Score = 0 Then
                                            MsgBox(My.Resources.Play_General_NoAttempts & vbCrLf & vbCrLf & My.Resources.Play_General_NoCompletion, MsgBoxStyle.Information, My.Resources.General_Info_Title)
                                        Else
                                            MsgBox(My.Resources.Play_General_NoAttempts & vbCrLf & vbCrLf & String.Format(My.Resources.Play_General_CompletionLevel, Score, MaxScore, ((Score * MaxScore) / 100)), MsgBoxStyle.Information, My.Resources.General_Info_Title)
                                        End If
                                        StatusLabel.Text = My.Resources.Play_General_NoAttempts

                                    End If
                                End If
                            End If
                        End If
                        If Score = MaxScore Then
                            TimeManager.Enabled = False
                            StatusResetTimer.Enabled = False
                            MsgBox(My.Resources.Play_General_PerfectScore, MsgBoxStyle.Information, My.Resources.General_Info_Title)
                            DoKeyPressEvent = False
                            StatusLabel.Text = My.Resources.Play_General_PerfectScore_Trim
                        Else
                            If DoKeyPressEvent Then
                                StatusResetTimer.Enabled = True
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TimeManager_Tick(sender As Object, e As EventArgs) Handles TimeManager.Tick
        If Not StatusResetTimer.Enabled Then
            If RemainingSeconds > 0 Then
                If RemainingSeconds = 1 Then
                    StatusLabel.Text = String.Format(My.Resources.Play_General_RemainingSeconds_Singular, RemainingSeconds)
                Else
                    StatusLabel.Text = String.Format(My.Resources.Play_General_RemainingSeconds_Plural, RemainingSeconds)
                End If
#If DEBUG Then
                LogD(Me, RemainingSeconds & " seconds remaining.")
#End If
                RemainingSeconds -= 1
            Else
                DoKeyPressEvent = False
                TimeManager.Enabled = False

                StatusLabel.Text = My.Resources.Play_General_Timedout

                If Score = 0 Then
                    MsgBox(My.Resources.Play_General_Timedout & vbCrLf & vbCrLf & My.Resources.Play_General_NoCompletion, MsgBoxStyle.Information, My.Resources.General_Info_Title)
                Else
                    MsgBox(My.Resources.Play_General_Timedout & vbCrLf & vbCrLf & String.Format(My.Resources.Play_General_CompletionLevel, Score, MaxScore, ((Score * MaxScore) / 100)), MsgBoxStyle.Information, My.Resources.General_Info_Title)
                End If
            End If
        End If
    End Sub
End Class