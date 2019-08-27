Imports System.Configuration

Module General
    ' ====================
    '      Constants
    ' ====================

    ' Global
    Public Const MaximumCrosswordXIndex As Long = Long.MaxValue
    Public Const SemicolonAlternativeString As String = "[sc]"
    Public ReadOnly RowSplitter As String() = New String() {"[rs]"}
    Public Const CrosswordDefaultColumns As Integer = 13
    Public Const CrosswordDefaultRows As Integer = 15
    Public Const HangmanMaximumSecondsPerCharacter As Integer = 45
    Public Const HangmanMinimumSecondsPerCharacter As Integer = 5
    Public Const CrosswordMaximumSecondsPerCharacter As Integer = HangmanMaximumSecondsPerCharacter
    Public Const CrosswordMinimumSecondsPerCharacter As Integer = HangmanMinimumSecondsPerCharacter
    Public Const QuestionOpenMaximumSecondsPerCharacter As Integer = HangmanMaximumSecondsPerCharacter
    Public Const QuestionOpenMinimumSecondsPerCharacter As Integer = HangmanMinimumSecondsPerCharacter
    Public Const QuestionOptsMaximumMinutes As Integer = 10
    Public Const QuestionOptsMinimumMinutes As Integer = 1
    Public Const SecondsInAMinute As Integer = 60
    Public Const HangmanMaximumAttemptsPerCharacter As Integer = 15
    Public Const HangmanSeparator As Char = "_"c
    Public Const DefaultScoreMultiplier As Integer = 10
    Public Const MaximumRecoveryAttempts As Integer = 3
    Public Const SpaceChar As Char = " "c
    Public Const DotChar As Char = "."c
    Public Const SemicolonChar As Char = ";"c
    Public Const CommaChar As Char = ","c
    Public Const DefaultLanguage As String = "es"
    Public ReadOnly SupportedLanguages As String() = {"en", "es"}
    Public ReadOnly LanguagesDescription As String() = {"English", "Español"}
    Public ReadOnly NormalExpressions As String() = { ' Common Spanish and English expressions, tweak as needed.
        "es",
        "está",
        "tiene",
        "contiene",
        "que",
        "por",
        "así",
        "asi",
        "si",
        "debe",
        "ende",
        "tal",
        "como",
        "qué",
        "cuál",
        "dónde",
        "donde",
        "debe",
        "puede",
        "hace",
        "hacer",
        "i ",
        "is",
        " are ",
        "'re",
        " do ",
        " did ",
        " have ",
        " has ",
        " had ",
        " we ",
        "they",
        "their",
        "our",
        "your",
        "yours",
        "'s"
    }

    ' Local
    Private Const MinimumPasswordLength As Integer = 8
    Private Const MinimumSimpleLength As Integer = 1

    ' ====================
    '      Variables
    ' ====================

    ' Global
    Public CurrentActivityIndex As Integer = -1
    Public CurrentActivityTypeId As Integer = -1 ' Only used for play mode.
    Public MessagesIndex As Integer = 0

    Public RecoveryMode As Boolean = False
    Public PreventClose As Boolean = True

    ' Local

    ' None.

    ' ====================
    '    Error handlers
    ' ====================

    ' None.

    ' ====================
    '  Content validators
    ' ====================
    Private Sub BrokenBuildException(ByVal Exception As String)
        MessageBox.Show("This build isn't properly compiled." & vbCrLf & vbCrLf & Exception & " (General.vb).", My.Resources.General_Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Public Function SelfTest() As Boolean
#If DEBUG Then
        Const TAG = "SelfTest"
#End If

#If KEEP_LANG Then
        Dim LanguageBackup As String = My.Settings.Language
#End If
#If DEBUG_CLEAN Then
        My.Settings.Reset()
        SettingsSaver()
#End If
#If KEEP_LANG Then
        My.Settings.Language = LanguageBackup
#End If

        ' Try to save settings, even before one
        ' entry is created, so that we can keep
        ' everything properly encrypted.
        SettingsSaver()

        If RecoveryMode Then
            ' Recovery sequence (lost password).
            My.Settings.UserName = Nothing
            My.Settings.UserPassword = Nothing
            My.Settings.SecurityWord = Nothing
            My.Settings.FirstRun = True
            SettingsSaver()
        End If

        ' In order of appearance.
        If MaximumCrosswordXIndex < 1 Then
            BrokenBuildException("MaximumCrosswordXIndex should be set to 1 or more, up to " & Long.MaxValue)

            Return False
        End If

        If SemicolonAlternativeString = String.Empty Then
            BrokenBuildException("SemicolonAlternativeString must not be empty")

            Return False
        End If

        If RowSplitter.Length < 1 Then
            BrokenBuildException("RowSplitter must not be empty")

            Return False
        ElseIf RowSplitter.Length > 1 Then
            BrokenBuildException("RowSplitter must not have more than one item")

            Return False
        End If

        ' CrosswordDefaultColumns does not require testing.

        ' CrosswordDefaultRows does not require testing.

        ' HangmanMaximumSecondsPerCharacter does not require testing.

        ' HangmanMinimumSecondsPerCharacter does not require testing.

        ' HangmanMaximumAttemptsPerCharacter does not require testing.

        If HangmanSeparator = Nothing Then
            BrokenBuildException("HangmanSeparator must not be empty")

            Return False
        End If

        If DefaultScoreMultiplier < 1 Then
            BrokenBuildException("DefaultScoreMultiplier should be set to 1 or more.")

            Return False
        End If

        If SpaceChar = Nothing Then
            BrokenBuildException("SpaceChar must not be empty")

            Return False
        End If

        If DotChar = Nothing Then
            BrokenBuildException("DotChar must not be empty")

            Return False
        End If

        If SemicolonChar = Nothing Then
            BrokenBuildException("SemicolonChar must not be empty")

            Return False
        End If

        If CommaChar = Nothing Then
            BrokenBuildException("CommaChar must not be empty")

            Return False
        End If

        ' NormalExpressions does not require testing.

        If MinimumPasswordLength < 1 Then
            BrokenBuildException("MinimumPasswordLength should be set to 1 or more.")

            Return False
        End If

        If MinimumSimpleLength < 1 Then
            BrokenBuildException("MinimumSimpleLength should be set to 1 or more.")

            Return False
        End If

        If DefaultLanguage = String.Empty Then
            BrokenBuildException("A default language must be set.")

            Return False
        End If

        If (SupportedLanguages.Length < 1 Or LanguagesDescription.Length < 1) Or (SupportedLanguages.Length <> LanguagesDescription.Length) Then
            BrokenBuildException("The structure of SupportedLanguages and LanguageDescription doesn't match.")

            Return False
        End If

        If My.Settings.Language = String.Empty Then
#If DEBUG Then
            LogD(TAG, "No language has been set, falling back to defaults (" & DefaultLanguage & ").")
#End If
            My.Settings.Language = DefaultLanguage
        End If
        LoadLanguage()

        Return True ' Everything is fine.
    End Function

    Public Function SimpleLengthVerifier(ByRef InputTextBox As MetroFramework.Controls.MetroTextBox, ByRef InputPanel As Panel) As Boolean
#If DEBUG Then
        Const TAG = "SimpleLengthVerifier"
        LogD(TAG, "Verifying length of " & InputTextBox.Name & ", should be greater than " & MinimumSimpleLength & "...")
#End If
        If InputTextBox.Text.Length >= MinimumSimpleLength Then
            InputPanel.BackColor = Color.LimeGreen
#If DEBUG Then
            LogD(TAG, "Verification of " & InputTextBox.Name & " passed (length = " & InputTextBox.Text.Length & ").")
#End If
            Return True
        Else
            InputPanel.BackColor = Color.Red
#If DEBUG Then
            LogD(TAG, "Verification of " & InputTextBox.Name & " failed (length = " & InputTextBox.Text.Length & ").")
#End If
            Return False
        End If
    End Function

    Public Function PasswordStrengthVerifier(ByRef InputTextBox As MetroFramework.Controls.MetroTextBox, ByRef InputPanel As Panel) As Boolean
#If DEBUG Then
        Const TAG = "PasswordStrengthVerifier"
        LogD(TAG, "Verifying length Of " & InputTextBox.Name & ", should be greater than " & MinimumPasswordLength & "...")
#End If
        If InputTextBox.Text.Length > MinimumPasswordLength Then
            InputPanel.BackColor = Color.LimeGreen
#If DEBUG Then
            LogD(TAG, "Verification Of " & InputTextBox.Name & " passed (length = " & InputTextBox.Text.Length & ").")
#End If
            Return True
        Else
#If DEBUG Then
            LogD(TAG, "Verification Of " & InputTextBox.Name & " failed (length = " & InputTextBox.Text.Length & ").")
#End If
            If InputTextBox.Text.Length > (MinimumPasswordLength / 2) Then
                InputPanel.BackColor = Color.Orange
                Return False
            Else
                InputPanel.BackColor = Color.Red
                Return False
            End If
        End If
    End Function

    Public Function PasswordConfirmationVerifier(ByRef InputTextBoxOrigin As MetroFramework.Controls.MetroTextBox, ByRef InputTextBoxDestination As MetroFramework.Controls.MetroTextBox, ByRef InputPanel As Panel) As Boolean
#If DEBUG Then
        Const TAG = "PasswordConfirmationVerifier"
        LogD(TAG, "Comparing " & InputTextBoxOrigin.Name & " And " & InputTextBoxDestination.Name & ", looking For a match...")
#End If
        If InputTextBoxOrigin.Text = InputTextBoxDestination.Text And (InputTextBoxOrigin.Text.Length > MinimumPasswordLength And InputTextBoxDestination.Text.Length > MinimumPasswordLength) Then
#If DEBUG Then
            LogD(TAG, "Both match.")
#End If
            InputPanel.BackColor = Color.LimeGreen
            Return True
        Else
#If DEBUG Then
            LogD(TAG, "Can't find a match.")
#End If
            InputPanel.BackColor = Color.Red
        End If
        Return False
    End Function

    ' Escapes a string containing a semicolon with another string
    ' selectable by SemicolonAlternativeString (default is "[sc]").
    Public Function GetEscapedString(ByVal Data As String) As String
        Return Data.Replace(SemicolonChar, SemicolonAlternativeString)
    End Function

    ' ====================
    '    Custom loggers
    ' ====================
#If DEBUG Then
    Public Sub LogD(ByRef Form As Control, ByVal Message As String)
        Debug.WriteLine(Form.Name & ": " & Message)
    End Sub

    Public Sub LogD(ByRef TAG As String, ByVal Message As String)
        Debug.WriteLine(TAG & ": " & Message)
    End Sub
#End If

    ' ====================
    '    Data handlers
    ' ====================
    Public Sub SettingsSaver()
#If DEBUG Then
        Const TAG = "SettingsSaver"
        LogD(TAG, "Saving settings...")
#End If

        Dim Configuration As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal)
        Dim Section As ConfigurationSection = Configuration.GetSection("userSettings/" & My.Application.Info.Title & ".My.MySettings")

        If Not Section.SectionInformation.IsProtected Then
            Section.SectionInformation.ProtectSection("RsaProtectedConfigurationProvider")
        End If
        Section.SectionInformation.ForceSave = True

        Configuration.Save(ConfigurationSaveMode.Full)

#If DEBUG Then
        LogD(TAG, "Done saving.")
#End If
    End Sub

    Public Function GetNewID() As Integer
#If DEBUG Then
        Const TAG = "GetNewID"
        LogD(TAG, "Finding a new ID...")
#End If
        Dim ActivityID As Integer = 0
        For Each Activity As String In My.Settings.Activities
            Dim ActivityString As String() = Activity.Split(SemicolonChar)
            ActivityID = Integer.Parse(ActivityString(0))
        Next
        ActivityID += 1
#If DEBUG Then
        LogD(TAG, "Found, the new ID is " & ActivityID & ".")
#End If
        Return ActivityID
    End Function

    ' ====================
    '    User interface
    ' ====================
    Public Sub LoadLanguage(ByVal Optional Language As String = DefaultLanguage)
#If DEBUG Then
        Const TAG = "LoadLanguage"
        LogD(TAG, "Current language: " & My.Application.UICulture.ToString)
#End If
        If My.Application.UICulture.ToString <> My.Settings.Language Then
#If DEBUG Then
            LogD(TAG, "New language: " & My.Application.UICulture.ToString)
#End If
            My.Application.ChangeUICulture(My.Settings.Language)
        End If
    End Sub

    Private Sub SetLanguage(sender As Object, e As EventArgs)
        PreventClose = False

        Dim ToolStripItemClickedEventArgs As ToolStripItemClickedEventArgs = DirectCast(e, ToolStripItemClickedEventArgs)
        My.Settings.Language = SupportedLanguages(Array.IndexOf(LanguagesDescription, ToolStripItemClickedEventArgs.ClickedItem.ToString))

        SettingsSaver()

        LoadLanguage()
        RequestUIRedraw()
    End Sub

    Public NotifyIcon As NotifyIcon = New NotifyIcon()
    Private ContextMenuStrip As ContextMenuStrip = New ContextMenuStrip()
    Public Sub PopulateNotifyIcon()
        If NotifyIcon.Icon IsNot Nothing Then
            NotifyIcon.Icon.Dispose()
        End If
        NotifyIcon.Dispose()

        NotifyIcon = New NotifyIcon With {
            .Icon = My.Resources.Logo,
            .Text = My.Resources.NotifyIcon_Text
        }

        ContextMenuStrip = New ContextMenuStrip()
        For Each Language As String In LanguagesDescription
            ContextMenuStrip.Items.Add(Language)
        Next

        AddHandler ContextMenuStrip.ItemClicked, AddressOf SetLanguage

        NotifyIcon.ContextMenuStrip = ContextMenuStrip

        NotifyIcon.Visible = True
    End Sub

    Private Sub Restart()
#If DEBUG Then
        Const TAG = "Restart"
#End If
        SplashScreen.SeparateThreadBusy = True
        For i = My.Application.OpenForms.Count - 1 To 0 Step -1
            Dim Form As Form = My.Application.OpenForms(i)
            If Not Form.Name = SplashScreen.Name Then
#If DEBUG Then
                LogD(TAG, "Hiding """ & Form.Name & """...")
#End If
                Form.Hide()
            End If
        Next
        SplashScreen.Show()
        For i = My.Application.OpenForms.Count - 1 To 0 Step -1
            Dim Form As Form = My.Application.OpenForms(i)
            If Not Form.Name = SplashScreen.Name Then
#If DEBUG Then
                LogD(TAG, "Closing """ & Form.Name & """...")
#End If
                Form.Close()
            End If
        Next

        PreventClose = True
    End Sub

    Public Sub Shutdown()
#If DEBUG Then
        Const TAG = "Shutdown"
#End If
        For i = My.Application.OpenForms.Count - 1 To 0 Step -1
            Dim Form As Form = My.Application.OpenForms(i)
#If DEBUG Then
            LogD(TAG, "Closing """ & Form.Name & """...")
#End If
            Form.Close()
        Next
    End Sub

    Public Sub RequestUIRedraw(ByVal Optional ConfirmationProvided As Boolean = False)
        If ConfirmationProvided Then
            Restart()
        Else
            If MessageBox.Show(My.Resources.NotifyIcon_LanguageResetWarn, My.Resources.General_Warn_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Restart()
            End If
        End If
    End Sub

    Public Sub SetColor(ByRef ReplyColor As Color, ByRef ColorPreviewPanel As Panel)
#If DEBUG Then
        Const TAG As String = "ColorDialog"
        LogD(TAG, "Showing a color picker...")
#End If

        Dim ColorDialog As New ColorDialog With {.Color = ReplyColor}
        If (ColorDialog.ShowDialog() = DialogResult.OK) Then
#If DEBUG Then
            LogD(TAG, "Operation accepted.")
#End If
            ReplyColor = ColorDialog.Color
            ColorPreviewPanel.BackColor = ReplyColor
            SettingsSaver()
#If DEBUG Then
        Else
            LogD(TAG, "Operation canceled.")
#End If
        End If
    End Sub

    Public Sub GetColor(ByRef ReplyColor As Color, ByRef ColorPreviewPanel As Panel)
        ColorPreviewPanel.BackColor = ReplyColor
    End Sub
End Module
