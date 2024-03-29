﻿Public NotInheritable Class SplashScreen
    Private FirstRun As FirstRun
    Private Play_Activities As Play_Activities

    Public SeparateThreadBusy As Boolean = False
    Private Ready As Boolean = False

    Private Sub LoadNextScreen()
        If Ready And Not SeparateThreadBusy Then
            UseWaitCursor = True
            Hide()
            If My.Settings.FirstRun Then
                Me.FirstRun.Show()
            Else
                Me.Play_Activities = New Play_Activities()
                Me.Play_Activities.Show()
            End If
            UseWaitCursor = False
            Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles AnimationHolderTimer.Tick
        LoadNextScreen()
    End Sub

    ' This method handles all supported click events across the form.
    Private Sub Global_Click(sender As Object, e As EventArgs) Handles MainLayoutPanel.Click, Me.Click
        LoadNextScreen()
    End Sub

    Private Sub SplashScreen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Set up the dialog text at runtime according to the application's assembly information.  

        'Application title
        If My.Application.Info.Title = String.Empty Then
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        Else
            ApplicationTitle.Text = My.Application.Info.Title
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright

        CurrentOperationLabel.Text = My.Resources.Startup_SplashScreen_BackgroundWorker

        OperationsDeferrerTimer.Enabled = True
    End Sub

    Private Sub OperationsDeferrerTimer_Tick(sender As Object, e As EventArgs) Handles OperationsDeferrerTimer.Tick
        Ready = False

        CurrentOperationLabel.Text = My.Resources.Startup_SplashScreen_SelfTest
        If SelfTest() Then ' the self test passes, keep going.
#If DEBUG And DEBUG_CLEAN Then
            MessageBox.Show(My.Resources.Debug_CleanEnvStartup, My.Resources.General_Info_Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
#End If

            CurrentOperationLabel.Text = My.Resources.Startup_SplashScreen_NotifyIcon
            PopulateNotifyIcon()

            If My.Settings.FirstRun Then
                CurrentOperationLabel.Text = My.Resources.Startup_SplashScreen_FirstRun
                Me.FirstRun = New FirstRun()
                Me.FirstRun.Populate()
            End If

            CurrentOperationLabel.Text = My.Resources.Startup_SplashScreen_SettingsPopulation
            Settings.Populate()
            CurrentOperationLabel.Text = My.Resources.Startup_SplashScreen_SettingsUpdate
            Settings.UpdateActivities()

            SeparateThreadBusy = False
            Ready = True

            CurrentOperationLabel.Text = My.Resources.Startup_SplashScreen_Ready
            ' We're done, lets fire up the timer.
            AnimationHolderTimer.Enabled = True
        Else ' after displaying the crash, shutdown.
            Close()
        End If
    End Sub
End Class
