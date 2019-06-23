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
    Public Const HangmanMaximumAttemptsPerCharacter As Integer = 15
    Public Const HangmanSeparator As Char = "_"c
    Public Const DefaultScoreMultiplier As Integer = 10
    Public Const SpaceChar As Char = " "c
    Public Const DotChar As Char = "."c
    Public Const SemicolonChar As Char = ";"c
    Public Const CommaChar As Char = ","c
    Public ReadOnly NormalExpressions As String() = { ' Common Spanish expressions, tweak as needed.
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
        "hacer"
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

    ' Local

    ' None.

    ' ====================
    '    Error handlers
    ' ====================

    ' None.

    ' ====================
    '  Content validators
    ' ====================
    Public Function SimpleLengthVerifier(ByRef InputTextBox As MetroFramework.Controls.MetroTextBox, ByRef InputPanel As Panel) As Boolean
#If DEBUG Then
        Const TAG = "SimpleLengthVerifier"
        LogD(TAG, "Verifying length Of " & InputTextBox.Name & ", should be greater than " & MinimumSimpleLength & "...")
#End If
        If InputTextBox.Text.Length > (MinimumSimpleLength + 1) Then
            InputPanel.BackColor = Color.LimeGreen
#If DEBUG Then
            LogD(TAG, "Verification Of " & InputTextBox.Name & " passed (length = " & InputTextBox.Text.Length & ").")
#End If
            Return True
        Else
            InputPanel.BackColor = Color.Red
#If DEBUG Then
            LogD(TAG, "Verification Of " & InputTextBox.Name & " failed (length = " & InputTextBox.Text.Length & ").")
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
        My.Settings.Save()
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
