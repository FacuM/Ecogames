﻿Imports System.Collections.Specialized

Public Class Play_Activities
    Private Play_ActivityType_Crossword As Play_ActivityType_Crossword
    Private Play_ActivityType_Hangman As Play_ActivityType_Hangman
    Private Play_ActivityType_Question_Open As Play_ActivityType_Question_Open
    Private Play_ActivityType_Question_Opts As Play_ActivityType_Question_Opts

    Public Sub UpdateActivities()
#If DEBUG Then
        LogD(Me, "Updating activities list...")
#End If
        If (My.Settings.Activities Is Nothing) Then
#If DEBUG Then
            LogD(Me, "no activities found, (re-)initializing container.")
#End If
            My.Settings.Activities = New StringCollection From {Nothing}
            My.Settings.Activities.Clear()
            SettingsSaver()
            ActivityListBox.Visible = False
        Else
#If DEBUG Then
            LogD(Me, My.Settings.Activities.Count & " activities found, processing...")
#End If
            ActivityListBox.Items.Clear()
            ActivityListBox.Visible = True

            For Each Activity As String In My.Settings.Activities
                Dim data As String() = Activity.Split(SemicolonChar)

                ActivityListBox.Items.Add(data(1))
            Next
#If DEBUG Then
            LogD(Me, "Done.")
#End If
        End If
    End Sub

    Private Sub PlayActivity_Load(sender As Object, e As EventArgs) Handles Me.Load
        Enabled = False
        UseWaitCursor = True

#If DEBUG Then
        LogD(Me, "Loading...")
#End If

        UpdateActivities()

        Text = My.Resources.Play_Activities_Text

#If DEBUG Then
        LogD(Me, "Done.")
#End If

        Enabled = True
        UseWaitCursor = False
    End Sub

#If DEBUG Then
    Private Sub Settings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LogD(Me, "Closed.")
    End Sub
#End If

    Private Sub ActivityListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ActivityListBox.SelectedIndexChanged
#If DEBUG Then
        LogD(Me, "Processing selected index...")
#End If
        CurrentActivityIndex = ActivityListBox.SelectedIndex

        If ActivityListBox.SelectedIndex > -1 Then
            Dim Activity As String() = My.Settings.Activities(ActivityListBox.SelectedIndex).Split(SemicolonChar)

            SettingsActivityDescription.Text = Activity(2).Replace(SemicolonAlternativeString, SemicolonChar)
            SettingsActivityName.Text = Activity(1)

            Dim ParsedActivityType As Integer = -1
            If Integer.TryParse(Activity(3), ParsedActivityType) Then
                CurrentActivityTypeId = ParsedActivityType
                Select Case CurrentActivityTypeId
                    Case Integer.Parse(My.Resources.ActivityType_Crossword_ID)
                        SettingsActivityType.Text = My.Resources.ActivityType_Crossword
                    Case Integer.Parse(My.Resources.ActivityType_Hangman_ID)
                        SettingsActivityType.Text = My.Resources.ActivityType_Hangman
                    Case Integer.Parse(My.Resources.ActivityType_Question_Open_ID)
                        SettingsActivityType.Text = My.Resources.ActivityType_Question_Open
                    Case Integer.Parse(My.Resources.ActivityType_Question_Opts_ID)
                        SettingsActivityType.Text = My.Resources.ActivityType_Question_Opts
                    Case Else
                End Select
#If DEBUG Then
                LogD(Me, "Done.")
#End If
            Else
#If DEBUG Then
                LogD(Me, "WARNING: failed to parse activity type for activity ID " & Activity(0) & ".")
#End If
                MessageBox.Show(String.Format(My.Resources.Settings_General_Err_Index, 3, "Activity"), My.Resources.General_Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' Enable activity play button.
            PlayActivity.Enabled = True
        Else
            ' No activity or invalid index selected, disable the activity play button.
            PlayActivity.Enabled = False
        End If

        SettingsActivityName.Enabled = True
    End Sub

    Private Sub Play_Activities_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.S Then
            Login.ShowDialog()

            If Login.DialogResult = DialogResult.OK Then
                Settings.Show()
            End If

            Close()
#If ENABLE_MASTER_RESET Then
        Else
            If My.Computer.Keyboard.CtrlKeyDown And My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.M Then
#If DEBUG Then
                LogD(Me, "=> Running a master reset!")
#End If

                NotifyIcon.ShowBalloonTip(5000, My.Application.Info.Title, My.Resources.Release_Beta_MasterReset, ToolTipIcon.Info)

                My.Settings.Reset()
                SettingsSaver()
                RequestUIRedraw(ConfirmationProvided:=True)
            End If
#End If
        End If
    End Sub

    Private Sub PlayActivity_Click(sender As Object, e As EventArgs) Handles PlayActivity.Click
        UseWaitCursor = False

        Select Case CurrentActivityTypeId
            Case Integer.Parse(My.Resources.ActivityType_Crossword_ID)
                If Me.Play_ActivityType_Crossword IsNot Nothing Then
                    Me.Play_ActivityType_Crossword.Dispose()
                End If

                Me.Play_ActivityType_Crossword = New Play_ActivityType_Crossword With {
                    .Text = SettingsActivityName.Text
                }

                Me.Play_ActivityType_Crossword.LoadActivity()
                Me.Play_ActivityType_Crossword.ShowDialog()
            Case Integer.Parse(My.Resources.ActivityType_Hangman_ID)
                If Me.Play_ActivityType_Hangman IsNot Nothing Then
                    Me.Play_ActivityType_Hangman.Dispose()
                End If

                Me.Play_ActivityType_Hangman = New Play_ActivityType_Hangman With {
                    .Text = SettingsActivityName.Text
                }

                Me.Play_ActivityType_Hangman.Text = SettingsActivityName.Text
                Me.Play_ActivityType_Hangman.LoadActivity()
                Me.Play_ActivityType_Hangman.ShowDialog()
            Case Integer.Parse(My.Resources.ActivityType_Question_Open_ID)
                If Me.Play_ActivityType_Question_Open IsNot Nothing Then
                    Me.Play_ActivityType_Question_Open.Dispose()
                End If

                Me.Play_ActivityType_Question_Open = New Play_ActivityType_Question_Open With {
                    .Text = SettingsActivityName.Text
                }

                Me.Play_ActivityType_Question_Open.Text = SettingsActivityName.Text
                Me.Play_ActivityType_Question_Open.LoadActivity()
                Me.Play_ActivityType_Question_Open.ShowDialog()
            Case Integer.Parse(My.Resources.ActivityType_Question_Opts_ID)
                If Me.Play_ActivityType_Question_Opts IsNot Nothing Then
                    Me.Play_ActivityType_Question_Opts.Dispose()
                End If

                Me.Play_ActivityType_Question_Opts = New Play_ActivityType_Question_Opts With {
                    .Text = SettingsActivityName.Text
                }

                Me.Play_ActivityType_Question_Opts.Text = SettingsActivityName.Text
                Me.Play_ActivityType_Question_Opts.LoadActivity()
                Me.Play_ActivityType_Question_Opts.ShowDialog()
        End Select

        UseWaitCursor = False
    End Sub
End Class
