Imports System.Collections.Specialized

Public Class Settings
    Public Sub UpdateActivities()
        LogD(Me, "Updating activities list...")
        If (My.Settings.Activities Is Nothing) Then
            LogD(Me, "no activities found, (re-)initializing container.")
            My.Settings.Activities = New StringCollection From {Nothing}
            My.Settings.Activities.Clear()
            SettingsSaver()
            ActivityListBox.Visible = False
        Else
            LogD(Me, My.Settings.Activities.Count & " activities found, processing...")
            ActivityListBox.Items.Clear()
            ActivityListBox.Visible = True

            For Each Activity As String In My.Settings.Activities
                Dim data As String() = Activity.Split(";")

                ActivityListBox.Items.Add(data(1))
            Next
            LogD(Me, "Done.")
        End If

        ActivityListBox.Items.Add(My.Resources.Settings_General_NewActivity)
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Enabled = False
        UseWaitCursor = True

        LogD(Me, "Loading...")

        UpdateActivities()

        'My.Settings.Activities = String and contains ID, Name, Description, Activity Type (in order).
        My.Settings.Activities.Clear()
        My.Settings.Activities.Add("0;Nombre;Descripcion;0")
        My.Settings.Activities.Add("1;Nombre;Descripcion;1")
        My.Settings.Activities.Add("2;Nombre;Descripcion;2")
        My.Settings.Activities.Add("3;Nombre;Descripcion;3")

        UpdateActivities()

        'WindowState = My.Settings.LastWindowState

        LogD(Me, "Done.")

        Enabled = True
        UseWaitCursor = False
    End Sub

    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.LastWindowState = WindowState
        LogD(Me, "Saving window state and closing...")
        SettingsSaver()
    End Sub

    Private Sub Settings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LogD(Me, "Closed.")
    End Sub

    Private Sub SettingsActivityType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SettingsActivityType.SelectedIndexChanged
        If ActivityListBox.SelectedIndex > 0 And ActivityListBox.SelectedIndex < (ActivityListBox.Items.Count - 2) Then
            Dim original As String() = My.Settings.Activities(ActivityListBox.SelectedIndex).Split(";") ' Just for shortening purposes
            LogD(Me, "Updating selected activity (""" & original(1) & """)...")
            My.Settings.Activities(ActivityListBox.SelectedIndex) = original(0) & ";" & original(1) & ";" & original(2) & ";" & SettingsActivityType.SelectedIndex
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
            Dim original As String() = My.Settings.Activities(ActivityListBox.SelectedIndex).Split(";") ' Just for shortening purposes
            LogD(Me, "Updating selected activity (""" & original(1) & """)...")
            My.Settings.Activities(ActivityListBox.SelectedIndex) = original(0) & ";" & original(1) & ";" & SettingsActivityDescription.Text & ";" & original(3)
            SettingsSaver()
        Else
        End If
    End Sub

    Private Sub SettingsActivityName_TextChanged(sender As Object, e As EventArgs) Handles SettingsActivityName.TextChanged
        If ActivityListBox.SelectedIndex > 0 And ActivityListBox.SelectedIndex < (ActivityListBox.Items.Count - 2) Then
            Dim original As String() = My.Settings.Activities(ActivityListBox.SelectedIndex).Split(";") ' Just for shortening purposes
            LogD(Me, "Updating selected activity (""" & original(1) & """)...")
            My.Settings.Activities(ActivityListBox.SelectedIndex) = original(0) & ";" & SettingsActivityName.Text & ";" & original(2) & ";" & original(3)
            SettingsSaver()
            UpdateActivities()
            ActivityListBox.SelectedIndex = PreviousIndex
        Else
            If String.IsNullOrEmpty(SettingsActivityName.Text) Then
                SettingsActivityType.Enabled = False
                SettingsActivityDescription.Enabled = False
                AddActivity.Enabled = False
            Else
                LogD(Me, "Switched to activity creation mode.")

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
        LogD(Me, "Processing selected index...")

        If ActivityListBox.SelectedIndex > -1 And ActivityListBox.SelectedIndex < (ActivityListBox.Items.Count - 1) Then
            Dim Activity As String() = My.Settings.Activities(ActivityListBox.SelectedIndex).Split(";")

            SettingsActivityDescription.Text = Activity(2)
            SettingsActivityName.Text = Activity(1)

            Dim ParsedActivityType As Integer = -1
            If Integer.TryParse(Activity(3), ParsedActivityType) Then
                SettingsActivityType.SelectedIndex = ParsedActivityType
                SettingsActivityType.Enabled = True
                LogD(Me, "Done.")
            Else
                LogD(Me, "WARNING: failed to parse activity type for activity ID " & Activity(0) & ".")
                MsgBox(String.Format(My.Resources.Settings_General_Err_Index, 3, "Activity"), MsgBoxStyle.Critical, My.Resources.Settings_General_Err_Title)
            End If

            SettingsActivityDescription.Enabled = True
            SettingsActivityType.Enabled = False

            ' Disable activity creation, enable modify and delete mode.
            ModifyActivity.Visible = True
            DeleteActivity.Visible = True
            AddActivity.Visible = False
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

    Private Sub AddActivity_Click(sender As Object, e As EventArgs) Handles AddActivity.Click
        UseWaitCursor = False

        Select Case SettingsActivityType.SelectedIndex
            Case My.Resources.ActivityType_Crossword_ID
                ActivityType_Crossword.Text = SettingsActivityName.Text
                ActivityType_Crossword.PrepareNew()
                ActivityType_Crossword.ShowDialog()
            Case My.Resources.ActivityType_Hangman_ID
                ActivityType_Hangman.Text = SettingsActivityName.Text
                ActivityType_Hangman.PrepareNew()
                ActivityType_Hangman.ShowDialog()
            Case My.Resources.ActivityType_Question_Open_ID
                ActivityType_Question_Open.Text = SettingsActivityName.Text
                ActivityType_Question_Open.PrepareNew()
                ActivityType_Question_Open.ShowDialog()
            Case My.Resources.ActivityType_Question_Opts_ID
                ActivityType_Question_Opts.Text = SettingsActivityName.Text
                ActivityType_Question_Opts.PrepareNew()
                ActivityType_Question_Opts.ShowDialog()
        End Select

        UseWaitCursor = False
    End Sub

    Private Sub DeleteActivity_Click(sender As Object, e As EventArgs) Handles DeleteActivity.Click
        Dim PreviousIndex As Integer = ActivityListBox.SelectedIndex
        My.Settings.Activities.RemoveAt(PreviousIndex)
        UpdateActivities()
        If ActivityListBox.Items.Count > 1 And PreviousIndex > 0 Then
            ActivityListBox.SelectedIndex = PreviousIndex - 1
        Else
            ActivityListBox.SelectedIndex = ActivityListBox.Items.Count - 1
        End If
    End Sub
End Class
