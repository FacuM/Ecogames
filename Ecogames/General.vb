Module General
    ' ====================
    '      Constants
    ' ====================

    ' Global
    Public Const MaximumCrosswordXIndex As Long = Long.MaxValue
    Public Const SemicolonAlternativeString As String = "[sc]"
    Public RowSplitter As String() = New String() {"[rs]"}
    Public Const CrosswordDefaultColumns As Integer = 13
    Public Const CrosswordDefaultRows As Integer = 15
    Public Const HangmanMaximumSecondsPerCharacter As Integer = 45
    Public Const HangmanMinimumSecondsPerCharacter As Integer = 5
    Public Const HangmanMaximumAttemptsPerCharacter As Integer = 15
    Public Const DefaultScoreMultiplier As Integer = 10

    ' Local
    Private Const MinimumPasswordLength As Integer = 8
    Private Const MinimumSimpleLength As Integer = 1

    ' ====================
    '      Variables
    ' ====================

    ' Global
    Public CurrentActivityIndex As Integer = -1
    Public CurrentActivityTypeId As Integer = -1 ' Only used for play mode.

    ' Local

    ' None.

    ' ====================
    '    Error handlers
    ' ====================

    ' None.

    ' ====================
    '  Content validators
    ' ====================
    Public Function SimpleLengthVerifier(ByRef InputTextBox As MetroFramework.Controls.MetroTextBox, ByRef InputPanel As Panel)
        Const TAG = "SimpleLengthVerifier"
        LogD(TAG, "Verifying length Of " & InputTextBox.Name & ", should be greater than " & MinimumSimpleLength & "...")
        If InputTextBox.Text.Length > (MinimumSimpleLength + 1) Then
            InputPanel.BackColor = Color.LimeGreen
            LogD(TAG, "Verification Of " & InputTextBox.Name & " passed (length = " & InputTextBox.Text.Length & ").")
            Return True
        Else
            InputPanel.BackColor = Color.Red
            LogD(TAG, "Verification Of " & InputTextBox.Name & " failed (length = " & InputTextBox.Text.Length & ").")
            Return False
        End If
    End Function

    Public Function PasswordStrengthVerifier(ByRef InputTextBox As MetroFramework.Controls.MetroTextBox, ByRef InputPanel As Panel)
        Const TAG = "PasswordStrengthVerifier"
        LogD(TAG, "Verifying length Of " & InputTextBox.Name & ", should be greater than " & MinimumPasswordLength & "...")
        If InputTextBox.Text.Length > MinimumPasswordLength Then
            InputPanel.BackColor = Color.LimeGreen
            LogD(TAG, "Verification Of " & InputTextBox.Name & " passed (length = " & InputTextBox.Text.Length & ").")
            Return True
        Else
            LogD(TAG, "Verification Of " & InputTextBox.Name & " failed (length = " & InputTextBox.Text.Length & ").")
            If InputTextBox.Text.Length > (MinimumPasswordLength / 2) Then
                InputPanel.BackColor = Color.Orange
                Return False
            Else
                InputPanel.BackColor = Color.Red
                Return False
            End If
        End If
    End Function

    Public Function PasswordConfirmationVerifier(ByRef InputTextBoxOrigin As MetroFramework.Controls.MetroTextBox, ByRef InputTextBoxDestination As MetroFramework.Controls.MetroTextBox, ByRef InputPanel As Panel)
        Const TAG = "PasswordConfirmationVerifier"
        LogD(TAG, "Comparing " & InputTextBoxOrigin.Name & " And " & InputTextBoxDestination.Name & ", looking For a match...")
        If InputTextBoxOrigin.Text = InputTextBoxDestination.Text And (InputTextBoxOrigin.Text.Length > MinimumPasswordLength And InputTextBoxDestination.Text.Length > MinimumPasswordLength) Then
            LogD(TAG, "Both match.")
            InputPanel.BackColor = Color.LimeGreen
            Return True
        Else
            LogD(TAG, "Can't find a match.")
            InputPanel.BackColor = Color.Red
        End If
        Return False
    End Function

    ' Escapes a string containing a semicolon with another string
    ' selectable by SemicolonAlternativeString (default is "[sc]").
    Public Function GetEscapedString(ByVal Data As String)
        Return Data.Replace(";", SemicolonAlternativeString)
    End Function

    ' ====================
    '    Custom loggers
    ' ====================
    Public Sub LogD(ByRef Form As Control, ByVal Message As String)
        Debug.WriteLine(Form.Name & ": " & Message)
    End Sub

    Public Sub LogD(ByRef TAG As String, ByVal Message As String)
        Debug.WriteLine(TAG & ": " & Message)
    End Sub

    ' ====================
    '    Data handlers
    ' ====================
    Public Sub SettingsSaver()
        Const TAG = "SettingsSaver"
        LogD(TAG, "Saving settings...")
        My.Settings.Save()
        LogD(TAG, "Done saving.")
    End Sub

    Public Function GetNewID()
        Const TAG = "GetNewID"
        Dim ActivityID As Integer = 0
        LogD(TAG, "Finding a new ID...")
        For Each Activity As String In My.Settings.Activities
            Dim ActivityString As String() = Activity.Split(";")
            ActivityID = Integer.Parse(ActivityString(0))
        Next
        ActivityID += 1
        LogD(TAG, "Found, the new ID is " & ActivityID & ".")
        Return ActivityID
    End Function

    ' ====================
    '    User interface
    ' ====================
    Public Sub SetColor(ByRef ReplyColor As Color, ByRef ColorPreviewPanel As Panel)
        Const TAG As String = "ColorDialog"
        Dim ColorDialog As New ColorDialog With {.Color = ReplyColor}

        LogD(TAG, "Showing a color picker...")
        If (ColorDialog.ShowDialog() = DialogResult.OK) Then
            LogD(TAG, "Operation accepted.")
            ReplyColor = ColorDialog.Color
            ColorPreviewPanel.BackColor = ReplyColor
            SettingsSaver()
        Else
            LogD(TAG, "Operation canceled.")
        End If
    End Sub

    Public Sub GetColor(ByRef ReplyColor As Color, ByRef ColorPreviewPanel As Panel)
        ColorPreviewPanel.BackColor = ReplyColor
    End Sub
End Module
