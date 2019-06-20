Public NotInheritable Class SplashScreen
    Private Ready As Boolean = False
    Private Sub LoadNextScreen()
        UseWaitCursor = True
        Hide()
        If My.Settings.FirstRun Then
            FirstRun.Show()
        Else
            Login.Show()
        End If
        UseWaitCursor = False
        Close()
    End Sub

    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright

        LogD(Me, "Preparing " & Settings.Name & " elements...")

        ' Prepare elements in Settings.
        Settings.SettingsActivityType.Items.Add(My.Resources.ActivityType_Crossword)
        Settings.SettingsActivityType.Items.Add(My.Resources.ActivityType_Hangman)
        Settings.SettingsActivityType.Items.Add(My.Resources.ActivityType_Question_Open)
        Settings.SettingsActivityType.Items.Add(My.Resources.ActivityType_Question_Opts)

        GetColor(My.Settings.UserRepOk, Settings.Panel3)
        GetColor(My.Settings.UserRepWrong, Settings.Panel4)
        GetColor(My.Settings.UserRepRegular, Settings.Panel5)
        GetColor(My.Settings.UserRepCust1, Settings.Panel6)
        GetColor(My.Settings.UserRepCust2, Settings.Panel7)
        GetColor(My.Settings.UserRepCust3, Settings.Panel8)

        Ready = True

        LogD(Me, "Done.")

        ' We're done, lets fire up the timer.
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadNextScreen()
    End Sub

    ' This method handles all supported click events across the form.
    Private Sub Global_Click(sender As Object, e As EventArgs) Handles MainLayoutPanel.Click, Me.Click, ApplicationTitle.Click
        If Ready Then
            LoadNextScreen()
        End If
    End Sub
End Class
