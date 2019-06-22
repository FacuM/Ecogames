Imports System.Collections.Specialized

Public Class Play_Activities
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
                Dim data As String() = Activity.Split(";")

                ActivityListBox.Items.Add(data(1))
            Next
#If DEBUG Then
            LogD(Me, "Done.")
#End If
        End If
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Enabled = False
        UseWaitCursor = True

#If DEBUG Then
        LogD(Me, "Loading...")
#End If

        UpdateActivities()

        'My.Settings.Activities = String and contains ID, Name, Description, Activity Type (in order).

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

    Private Sub SettingsActivityType_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ActivityListBox.SelectedIndex > 0 And ActivityListBox.SelectedIndex < (ActivityListBox.Items.Count - 2) Then
            Dim original As String() = My.Settings.Activities(ActivityListBox.SelectedIndex).Split(";") ' Just for shortening purposes
#If DEBUG Then
            LogD(Me, "Updating selected activity (""" & original(1) & """)...")
#End If
            My.Settings.Activities(ActivityListBox.SelectedIndex) = original(0) & ";" & original(1) & ";" & original(2) & ";" & CurrentActivityTypeId
            SettingsSaver()
        Else
            If String.IsNullOrEmpty(SettingsActivityName.Text) Then
                SettingsActivityType.Enabled = False
                SettingsActivityDescription.Enabled = False
            Else
                SettingsActivityType.Enabled = True
                SettingsActivityDescription.Enabled = True
            End If
        End If
    End Sub

    Dim PreviousIndex As Integer
    Private Sub SettingsActivityName_Leave(sender As Object, e As EventArgs) Handles SettingsActivityName.Leave
        PreviousIndex = ActivityListBox.SelectedIndex
    End Sub

    Private Sub ActivityListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ActivityListBox.SelectedIndexChanged
#If DEBUG Then
        LogD(Me, "Processing selected index...")
#End If
        CurrentActivityIndex = ActivityListBox.SelectedIndex

        If ActivityListBox.SelectedIndex > -1 Then
            Dim Activity As String() = My.Settings.Activities(ActivityListBox.SelectedIndex).Split(";")

            SettingsActivityDescription.Text = Activity(2)
            SettingsActivityName.Text = Activity(1)

            Dim ParsedActivityType As Integer = -1
            If Integer.TryParse(Activity(3), ParsedActivityType) Then
                CurrentActivityTypeId = ParsedActivityType
                Select Case CurrentActivityTypeId
                    Case My.Resources.ActivityType_Crossword_ID
                        SettingsActivityType.Text = My.Resources.ActivityType_Crossword
                    Case My.Resources.ActivityType_Hangman_ID
                        SettingsActivityType.Text = My.Resources.ActivityType_Hangman
                    Case My.Resources.ActivityType_Question_Open_ID
                        SettingsActivityType.Text = My.Resources.ActivityType_Question_Open
                    Case My.Resources.ActivityType_Question_Opts_ID
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
                MsgBox(String.Format(My.Resources.Settings_General_Err_Index, 3, "Activity"), MsgBoxStyle.Critical, My.Resources.General_Error_Title)
            End If

            ' Enable activity play button.
            PlayActivity.Enabled = True
        Else
            ' No activity or invalid index selected, disable the activity play button.
            PlayActivity.Enabled = False
        End If

        SettingsActivityName.Enabled = True
    End Sub

    Private Sub ModifyActivity_Click(sender As Object, e As EventArgs)
        If ActivityListBox.SelectedIndex > -1 Then
            CurrentActivityIndex = ActivityListBox.SelectedIndex
        End If
        Select Case CurrentActivityTypeId
            Case My.Resources.ActivityType_Crossword_ID
                ActivityType_Crossword.Text = SettingsActivityName.Text
                ActivityType_Crossword.PrepareModification()
                ActivityType_Crossword.ShowDialog()
            Case My.Resources.ActivityType_Hangman_ID
                ActivityType_Hangman.Text = SettingsActivityName.Text
                ActivityType_Hangman.PrepareModification()
                ActivityType_Hangman.ShowDialog()
            Case My.Resources.ActivityType_Question_Open_ID
                ActivityType_Question_Open.Text = SettingsActivityName.Text
                ActivityType_Question_Open.PrepareModification()
                ActivityType_Question_Open.ShowDialog()
            Case My.Resources.ActivityType_Question_Opts_ID
                ActivityType_Question_Opts.Text = SettingsActivityName.Text
                ActivityType_Question_Opts.PrepareModification()
                ActivityType_Question_Opts.ShowDialog()
        End Select
    End Sub

    Private Sub Play_Activities_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.S Then
            Login.ShowDialog()
        End If
    End Sub

    Private Sub PlayActivity_Click(sender As Object, e As EventArgs) Handles PlayActivity.Click
        UseWaitCursor = False

        Select Case CurrentActivityTypeId
            Case My.Resources.ActivityType_Crossword_ID
                Play_ActivityType_Crossword.Text = SettingsActivityName.Text
                Play_ActivityType_Crossword.LoadActivity()
                Play_ActivityType_Crossword.ShowDialog()
            Case My.Resources.ActivityType_Hangman_ID
                Play_ActivityType_Hangman.Text = SettingsActivityName.Text
                Play_ActivityType_Hangman.LoadActivity()
                Play_ActivityType_Hangman.ShowDialog()
            Case My.Resources.ActivityType_Question_Open_ID
                Play_ActivityType_Question_Open.Text = SettingsActivityName.Text
                Play_ActivityType_Question_Open.LoadActivity()
                Play_ActivityType_Question_Open.ShowDialog()
                'Case My.Resources.ActivityType_Question_Opts_ID
                '    ActivityType_Question_Opts.Text = SettingsActivityName.Text
                '    ActivityType_Question_Opts.PrepareNew()
                '    ActivityType_Question_Opts.ShowDialog()
        End Select

        UseWaitCursor = False
    End Sub
End Class
