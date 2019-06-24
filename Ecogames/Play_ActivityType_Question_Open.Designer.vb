<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Play_ActivityType_Question_Open
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Play_ActivityType_Question_Open))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.QuestionTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.AnswerTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.VerifyButton = New MetroFramework.Controls.MetroButton()
        Me.StatusLabel = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(72, 23)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Pregunta"
        '
        'QuestionTextBox
        '
        '
        '
        '
        Me.QuestionTextBox.CustomButton.Image = Nothing
        Me.QuestionTextBox.CustomButton.Location = New System.Drawing.Point(294, 1)
        Me.QuestionTextBox.CustomButton.Name = ""
        Me.QuestionTextBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.QuestionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.QuestionTextBox.CustomButton.TabIndex = 1
        Me.QuestionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.QuestionTextBox.CustomButton.UseSelectable = True
        Me.QuestionTextBox.CustomButton.Visible = False
        Me.QuestionTextBox.Lines = New String(-1) {}
        Me.QuestionTextBox.Location = New System.Drawing.Point(23, 86)
        Me.QuestionTextBox.MaxLength = 32767
        Me.QuestionTextBox.Name = "QuestionTextBox"
        Me.QuestionTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QuestionTextBox.ReadOnly = True
        Me.QuestionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.QuestionTextBox.SelectedText = ""
        Me.QuestionTextBox.SelectionLength = 0
        Me.QuestionTextBox.SelectionStart = 0
        Me.QuestionTextBox.ShortcutsEnabled = True
        Me.QuestionTextBox.Size = New System.Drawing.Size(316, 23)
        Me.QuestionTextBox.TabIndex = 0
        Me.QuestionTextBox.UseSelectable = True
        Me.QuestionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.QuestionTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'AnswerTextBox
        '
        '
        '
        '
        Me.AnswerTextBox.CustomButton.Image = Nothing
        Me.AnswerTextBox.CustomButton.Location = New System.Drawing.Point(186, 1)
        Me.AnswerTextBox.CustomButton.Name = ""
        Me.AnswerTextBox.CustomButton.Size = New System.Drawing.Size(129, 129)
        Me.AnswerTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.AnswerTextBox.CustomButton.TabIndex = 1
        Me.AnswerTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.AnswerTextBox.CustomButton.UseSelectable = True
        Me.AnswerTextBox.CustomButton.Visible = False
        Me.AnswerTextBox.Lines = New String(-1) {}
        Me.AnswerTextBox.Location = New System.Drawing.Point(23, 151)
        Me.AnswerTextBox.MaxLength = 32767
        Me.AnswerTextBox.Multiline = True
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AnswerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.AnswerTextBox.SelectedText = ""
        Me.AnswerTextBox.SelectionLength = 0
        Me.AnswerTextBox.SelectionStart = 0
        Me.AnswerTextBox.ShortcutsEnabled = True
        Me.AnswerTextBox.Size = New System.Drawing.Size(316, 131)
        Me.AnswerTextBox.TabIndex = 1
        Me.AnswerTextBox.UseSelectable = True
        Me.AnswerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.AnswerTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 125)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(72, 23)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Respuesta"
        '
        'VerifyButton
        '
        Me.VerifyButton.Location = New System.Drawing.Point(222, 299)
        Me.VerifyButton.Name = "VerifyButton"
        Me.VerifyButton.Size = New System.Drawing.Size(117, 23)
        Me.VerifyButton.TabIndex = 2
        Me.VerifyButton.Text = "Verificar"
        Me.VerifyButton.UseSelectable = True
        '
        'StatusLabel
        '
        Me.StatusLabel.Location = New System.Drawing.Point(23, 299)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(193, 23)
        Me.StatusLabel.TabIndex = 6
        Me.StatusLabel.Text = "N/A"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Play_ActivityType_Question_Open
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 339)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.VerifyButton)
        Me.Controls.Add(Me.AnswerTextBox)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.QuestionTextBox)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Play_ActivityType_Question_Open"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Play_ActivityType_Question_Open"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents QuestionTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents AnswerTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents VerifyButton As MetroFramework.Controls.MetroButton
    Friend WithEvents StatusLabel As MetroFramework.Controls.MetroLabel
End Class
