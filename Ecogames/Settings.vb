Imports System.Collections.Specialized

Public Class Settings
    Public Sub Populate()
#If DEBUG Then
        LogD(Me, "Preparing " & Name & " elements...")
#End If

        ' Cleanup.
        SettingsActivityType.Items.Clear()

        ' Prepare elements in Settings.
        SettingsActivityType.Items.Add(My.Resources.ActivityType_Crossword)
        SettingsActivityType.Items.Add(My.Resources.ActivityType_Hangman)
        SettingsActivityType.Items.Add(My.Resources.ActivityType_Question_Open)
        SettingsActivityType.Items.Add(My.Resources.ActivityType_Question_Opts)

        GetColor(My.Settings.UserRepOk, Panel3)
        GetColor(My.Settings.UserRepWrong, Panel4)
        GetColor(My.Settings.UserRepRegular, Panel5)
        GetColor(My.Settings.UserRepCust1, Panel6)
        GetColor(My.Settings.UserRepCust2, Panel7)
        GetColor(My.Settings.UserRepCust3, Panel8)

        Text = My.Resources.Settings_Text

#If DEBUG Then
        LogD(Me, "Done.")
#End If
    End Sub
    Public Sub UpdateActivities()
        'My.Settings.Activities
        '  => String()
        '     => ID;Name;Description;Activity Type;Activity Data

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

        ActivityListBox.Items.Add(My.Resources.Settings_General_NewActivity)

        If CurrentActivityIndex > -1 Then
            ActivityListBox.SelectedIndex = CurrentActivityIndex
        End If
    End Sub

    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
#If DEBUG Then
        LogD(Me, "Saving window state and closing...")
#End If
        SettingsSaver()
    End Sub

    Private Sub Settings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
#If DEBUG Then
        LogD(Me, "Closed.")
#End If
        Play_Activities.Show()
    End Sub

    Private Sub SettingsActivityType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SettingsActivityType.SelectedIndexChanged
        If ActivityListBox.SelectedIndex > 0 And ActivityListBox.SelectedIndex < (ActivityListBox.Items.Count - 2) Then
            Dim original As String() = My.Settings.Activities(ActivityListBox.SelectedIndex).Split(SemicolonChar) ' Just for shortening purposes
#If DEBUG Then
            LogD(Me, "Updating selected activity (""" & original(1) & """)...")
#End If
            My.Settings.Activities(ActivityListBox.SelectedIndex) = original(0) & SemicolonChar & original(1) & SemicolonChar & original(2) & SemicolonChar & SettingsActivityType.SelectedIndex
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

    Private Sub SettingsActivityDescription_TextChanged(sender As Object, e As EventArgs) Handles SettingsActivityDescription.TextChanged
        If ActivityListBox.SelectedIndex > 0 And ActivityListBox.SelectedIndex < (ActivityListBox.Items.Count - 2) Then
            Dim original As String() = My.Settings.Activities(ActivityListBox.SelectedIndex).Split(SemicolonChar) ' Just for shortening purposes
#If DEBUG Then
            LogD(Me, "Updating selected activity (""" & original(1) & """)...")
#End If
            My.Settings.Activities(ActivityListBox.SelectedIndex) = original(0) & SemicolonChar & original(1) & SemicolonChar & SettingsActivityDescription.Text & SemicolonChar & original(3)
            SettingsSaver()
        Else
        End If
    End Sub

    Private Sub SettingsActivityName_TextChanged(sender As Object, e As EventArgs) Handles SettingsActivityName.TextChanged
        If ActivityListBox.SelectedIndex > 0 And ActivityListBox.SelectedIndex < (ActivityListBox.Items.Count - 2) Then
            Dim original As String() = My.Settings.Activities(ActivityListBox.SelectedIndex).Split(SemicolonChar) ' Just for shortening purposes
#If DEBUG Then
            LogD(Me, "Updating selected activity (""" & original(1) & """)...")
#End If
            My.Settings.Activities(ActivityListBox.SelectedIndex) = original(0) & SemicolonChar & SettingsActivityName.Text & SemicolonChar & original(2) & SemicolonChar & original(3)
            SettingsSaver()
            UpdateActivities()
            ActivityListBox.SelectedIndex = PreviousIndex
        Else
            If String.IsNullOrEmpty(SettingsActivityName.Text) Then
                SettingsActivityType.Enabled = False
                SettingsActivityDescription.Enabled = False
                AddActivity.Enabled = False
            Else
#If DEBUG Then
                LogD(Me, "Switched to activity creation mode.")
#End If

                SettingsActivityType.Enabled = True
                SettingsActivityDescription.Enabled = True
                AddActivity.Enabled = True
            End If
        End If
    End Sub

    Dim PreviousIndex As Integer
    Private Sub SettingsActivityName_Leave(sender As Object, e As EventArgs) Handles SettingsActivityName.Leave
        PreviousIndex = ActivityListBox.SelectedIndex
    End Sub

    Private Sub UserRepOkColorBtn_Click(sender As Object, e As EventArgs) Handles UserRepOkColorBtn.Click
        SetColor(My.Settings.UserRepOk, Panel3)
    End Sub

    Private Sub UserRepWrongColorBtn_Click(sender As Object, e As EventArgs) Handles UserRepWrongColorBtn.Click
        SetColor(My.Settings.UserRepWrong, Panel4)
    End Sub

    Private Sub UserRepRegularColorBtn_Click(sender As Object, e As EventArgs) Handles UserRepRegularColorBtn.Click
        SetColor(My.Settings.UserRepRegular, Panel5)
    End Sub

    Private Sub UserRepCust1Btn_Click(sender As Object, e As EventArgs) Handles UserRepCust1Btn.Click
        SetColor(My.Settings.UserRepCust1, Panel6)
    End Sub

    Private Sub UserRepCust2Btn_Click(sender As Object, e As EventArgs) Handles UserRepCust2Btn.Click
        SetColor(My.Settings.UserRepCust2, Panel7)
    End Sub

    Private Sub UserRepCust3Btn_Click(sender As Object, e As EventArgs) Handles UserRepCust3Btn.Click
        SetColor(My.Settings.UserRepCust3, Panel8)
    End Sub

    Private Sub ActivityListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ActivityListBox.SelectedIndexChanged
#If DEBUG Then
        LogD(Me, "Processing selected index...")
#End If

        If ActivityListBox.SelectedIndex > -1 And ActivityListBox.SelectedIndex < (ActivityListBox.Items.Count - 1) Then
            Dim Activity As String() = My.Settings.Activities(ActivityListBox.SelectedIndex).Split(SemicolonChar)

            SettingsActivityDescription.Text = Activity(2)
            SettingsActivityName.Text = Activity(1)

            Dim ParsedActivityType As Integer = -1
            If Integer.TryParse(Activity(3), ParsedActivityType) Then
                SettingsActivityType.SelectedIndex = ParsedActivityType
                SettingsActivityType.Enabled = True
#If DEBUG Then
                LogD(Me, "Done.")
#End If
            Else
#If DEBUG Then
                LogD(Me, "WARNING: failed to parse activity type for activity ID " & Activity(0) & ".")
#End If
                MessageBox.Show(String.Format(My.Resources.Settings_General_Err_Index, 3, "Activity"), My.Resources.General_Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            SettingsActivityDescription.Enabled = True
            SettingsActivityType.Enabled = False

            ' Disable activity creation, enable modify and delete mode.
            ModifyActivity.Visible = True
            DeleteActivity.Visible = True
            AddActivity.Visible = False

            SettingsActivityName.Enabled = False
            SettingsActivityType.Enabled = False
            SettingsActivityDescription.Enabled = False
        ElseIf ActivityListBox.SelectedIndex = ActivityListBox.Items.Count - 1 Then
            SettingsActivityDescription.Enabled = True
            SettingsActivityDescription.Text = ""
            SettingsActivityName.Text = ""
            SettingsActivityType.Enabled = True
            SettingsActivityType.SelectedIndex = 0

            ' Enable activity creation, disable modify and delete mode.
            ModifyActivity.Visible = False
            DeleteActivity.Visible = False
            AddActivity.Visible = True
        End If

        SettingsActivityName.Enabled = True
    End Sub

    Private Sub ModifyActivity_Click(sender As Object, e As EventArgs) Handles ModifyActivity.Click
        If ActivityListBox.SelectedIndex > -1 Then
            CurrentActivityIndex = ActivityListBox.SelectedIndex
        End If
        Select Case SettingsActivityType.SelectedIndex
            Case Integer.Parse(My.Resources.ActivityType_Crossword_ID)
                ActivityType_Crossword.Text = SettingsActivityName.Text
                ActivityType_Crossword.PrepareModification()
                ActivityType_Crossword.ShowDialog()
            Case Integer.Parse(My.Resources.ActivityType_Hangman_ID)
                ActivityType_Hangman.Text = SettingsActivityName.Text
                ActivityType_Hangman.PrepareModification()
                ActivityType_Hangman.ShowDialog()
            Case Integer.Parse(My.Resources.ActivityType_Question_Open_ID)
                ActivityType_Question_Open.Text = SettingsActivityName.Text
                ActivityType_Question_Open.PrepareModification()
                ActivityType_Question_Open.ShowDialog()
            Case Integer.Parse(My.Resources.ActivityType_Question_Opts_ID)
                ActivityType_Question_Opts.Text = SettingsActivityName.Text
                ActivityType_Question_Opts.PrepareModification()
                ActivityType_Question_Opts.ShowDialog()
        End Select
    End Sub

    Private Sub AddActivity_Click(sender As Object, e As EventArgs) Handles AddActivity.Click
        UseWaitCursor = False

        Select Case SettingsActivityType.SelectedIndex
            Case Integer.Parse(My.Resources.ActivityType_Crossword_ID)
                ActivityType_Crossword.Text = SettingsActivityName.Text
                ActivityType_Crossword.PrepareNew()
                ActivityType_Crossword.ShowDialog()
            Case Integer.Parse(My.Resources.ActivityType_Hangman_ID)
                ActivityType_Hangman.Text = SettingsActivityName.Text
                ActivityType_Hangman.PrepareNew()
                ActivityType_Hangman.ShowDialog()
            Case Integer.Parse(My.Resources.ActivityType_Question_Open_ID)
                ActivityType_Question_Open.Text = SettingsActivityName.Text
                ActivityType_Question_Open.PrepareNew()
                ActivityType_Question_Open.ShowDialog()
            Case Integer.Parse(My.Resources.ActivityType_Question_Opts_ID)
                ActivityType_Question_Opts.Text = SettingsActivityName.Text
                ActivityType_Question_Opts.PrepareNew()
                ActivityType_Question_Opts.ShowDialog()
        End Select

        UseWaitCursor = False
    End Sub

    Private Sub DeleteActivity_Click(sender As Object, e As EventArgs) Handles DeleteActivity.Click
        If My.Computer.Keyboard.CtrlKeyDown And My.Computer.Keyboard.AltKeyDown And ActivityListBox.Items.Count > 1 Then
            If MessageBox.Show(My.Resources.Settings_General_DeleteAllWarn, My.Resources.General_Warn_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                For i = My.Settings.Activities.Count - 1 To 0 Step -1
                    My.Settings.Activities.RemoveAt(i)
                Next
                CurrentActivityIndex = 0
                SettingsSaver()
                UpdateActivities()
            End If

            DeleteActivity.Text = My.Resources.Settings_General_DeleteText
            If ActivityListBox.SelectedIndex > ActivityListBox.Items.Count - 2 Or ActivityListBox.SelectedIndex < 0 Then
                DeleteActivity.Visible = False
            End If
        Else
            Dim PreviousIndex As Integer = ActivityListBox.SelectedIndex
            My.Settings.Activities.RemoveAt(PreviousIndex)
            UpdateActivities()
            If ActivityListBox.Items.Count > 1 And PreviousIndex > 0 Then
                ActivityListBox.SelectedIndex = PreviousIndex - 1
            Else
                ActivityListBox.SelectedIndex = ActivityListBox.Items.Count - 1
            End If
        End If
    End Sub

    Private Sub Settings_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If My.Computer.Keyboard.CtrlKeyDown And My.Computer.Keyboard.AltKeyDown And ActivityListBox.Items.Count > 1 Then
            DeleteActivity.Text = My.Resources.Settings_General_DeleteAllText
            DeleteActivity.Visible = True
        End If
    End Sub

    Private Sub Settings_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If Not My.Computer.Keyboard.CtrlKeyDown Or Not My.Computer.Keyboard.AltKeyDown And ActivityListBox.Items.Count > 1 Then
            DeleteActivity.Text = My.Resources.Settings_General_DeleteText
            DeleteActivity.Visible = False
        End If
    End Sub
End Class
