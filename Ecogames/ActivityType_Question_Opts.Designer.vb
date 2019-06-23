<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ActivityType_Question_Opts
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.QuestionTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.AnswerTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.SaveActivityButton = New MetroFramework.Controls.MetroButton()
        Me.HelperLabel = New MetroFramework.Controls.MetroLabel()
        Me.NextActionButton = New MetroFramework.Controls.MetroButton()
        Me.AddAnswerButton = New MetroFramework.Controls.MetroButton()
        Me.CorrectAnswerCheckBox = New MetroFramework.Controls.MetroCheckBox()
        Me.AnswersListBox = New System.Windows.Forms.ListBox()
        Me.ModifyButton = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 138)
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
        Me.QuestionTextBox.Location = New System.Drawing.Point(23, 164)
        Me.QuestionTextBox.MaxLength = 32767
        Me.QuestionTextBox.Name = "QuestionTextBox"
        Me.QuestionTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QuestionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.QuestionTextBox.SelectedText = ""
        Me.QuestionTextBox.SelectionLength = 0
        Me.QuestionTextBox.SelectionStart = 0
        Me.QuestionTextBox.ShortcutsEnabled = True
        Me.QuestionTextBox.Size = New System.Drawing.Size(316, 23)
        Me.QuestionTextBox.TabIndex = 1
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
        Me.AnswerTextBox.CustomButton.Location = New System.Drawing.Point(294, 1)
        Me.AnswerTextBox.CustomButton.Name = ""
        Me.AnswerTextBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.AnswerTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.AnswerTextBox.CustomButton.TabIndex = 1
        Me.AnswerTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.AnswerTextBox.CustomButton.UseSelectable = True
        Me.AnswerTextBox.CustomButton.Visible = False
        Me.AnswerTextBox.Lines = New String(-1) {}
        Me.AnswerTextBox.Location = New System.Drawing.Point(23, 341)
        Me.AnswerTextBox.MaxLength = 32767
        Me.AnswerTextBox.Multiline = True
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AnswerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.AnswerTextBox.SelectedText = ""
        Me.AnswerTextBox.SelectionLength = 0
        Me.AnswerTextBox.SelectionStart = 0
        Me.AnswerTextBox.ShortcutsEnabled = True
        Me.AnswerTextBox.Size = New System.Drawing.Size(316, 23)
        Me.AnswerTextBox.TabIndex = 3
        Me.AnswerTextBox.UseSelectable = True
        Me.AnswerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.AnswerTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 203)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(72, 23)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Opciones"
        '
        'SaveActivityButton
        '
        Me.SaveActivityButton.Enabled = False
        Me.SaveActivityButton.Location = New System.Drawing.Point(222, 377)
        Me.SaveActivityButton.Name = "SaveActivityButton"
        Me.SaveActivityButton.Size = New System.Drawing.Size(117, 23)
        Me.SaveActivityButton.TabIndex = 4
        Me.SaveActivityButton.Text = "Guardar"
        Me.SaveActivityButton.UseSelectable = True
        '
        'HelperLabel
        '
        Me.HelperLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HelperLabel.Location = New System.Drawing.Point(20, 60)
        Me.HelperLabel.Name = "HelperLabel"
        Me.HelperLabel.Size = New System.Drawing.Size(322, 74)
        Me.HelperLabel.TabIndex = 6
        Me.HelperLabel.Text = "N/A"
        Me.HelperLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NextActionButton
        '
        Me.NextActionButton.Enabled = False
        Me.NextActionButton.Location = New System.Drawing.Point(222, 203)
        Me.NextActionButton.Name = "NextActionButton"
        Me.NextActionButton.Size = New System.Drawing.Size(117, 23)
        Me.NextActionButton.TabIndex = 7
        Me.NextActionButton.Text = "Siguiente"
        Me.NextActionButton.UseSelectable = True
        '
        'AddAnswerButton
        '
        Me.AddAnswerButton.Enabled = False
        Me.AddAnswerButton.Location = New System.Drawing.Point(99, 377)
        Me.AddAnswerButton.Name = "AddAnswerButton"
        Me.AddAnswerButton.Size = New System.Drawing.Size(117, 23)
        Me.AddAnswerButton.TabIndex = 8
        Me.AddAnswerButton.Text = "Agregar"
        Me.AddAnswerButton.UseSelectable = True
        '
        'CorrectAnswerCheckBox
        '
        Me.CorrectAnswerCheckBox.Location = New System.Drawing.Point(23, 377)
        Me.CorrectAnswerCheckBox.Name = "CorrectAnswerCheckBox"
        Me.CorrectAnswerCheckBox.Size = New System.Drawing.Size(70, 23)
        Me.CorrectAnswerCheckBox.TabIndex = 9
        Me.CorrectAnswerCheckBox.Text = "Correcta"
        Me.CorrectAnswerCheckBox.UseSelectable = True
        '
        'AnswersListBox
        '
        Me.AnswersListBox.FormattingEnabled = True
        Me.AnswersListBox.Location = New System.Drawing.Point(23, 232)
        Me.AnswersListBox.Name = "AnswersListBox"
        Me.AnswersListBox.Size = New System.Drawing.Size(316, 95)
        Me.AnswersListBox.TabIndex = 11
        Me.AnswersListBox.Visible = False
        '
        'ModifyButton
        '
        Me.ModifyButton.Location = New System.Drawing.Point(99, 377)
        Me.ModifyButton.Name = "ModifyButton"
        Me.ModifyButton.Size = New System.Drawing.Size(117, 23)
        Me.ModifyButton.TabIndex = 12
        Me.ModifyButton.Text = "Modificar"
        Me.ModifyButton.UseSelectable = True
        Me.ModifyButton.Visible = False
        '
        'ActivityType_Question_Opts
        '
        Me.AcceptButton = Me.NextActionButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 412)
        Me.Controls.Add(Me.ModifyButton)
        Me.Controls.Add(Me.AnswersListBox)
        Me.Controls.Add(Me.CorrectAnswerCheckBox)
        Me.Controls.Add(Me.AddAnswerButton)
        Me.Controls.Add(Me.NextActionButton)
        Me.Controls.Add(Me.HelperLabel)
        Me.Controls.Add(Me.SaveActivityButton)
        Me.Controls.Add(Me.AnswerTextBox)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.QuestionTextBox)
        Me.Controls.Add(Me.MetroLabel1)
        Me.MaximizeBox = False
        Me.Name = "ActivityType_Question_Opts"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "ActivityType_Question_Opts"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents QuestionTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents AnswerTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SaveActivityButton As MetroFramework.Controls.MetroButton
    Friend WithEvents HelperLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents NextActionButton As MetroFramework.Controls.MetroButton
    Friend WithEvents AddAnswerButton As MetroFramework.Controls.MetroButton
    Friend WithEvents CorrectAnswerCheckBox As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents AnswersListBox As ListBox
    Friend WithEvents ModifyButton As MetroFramework.Controls.MetroButton
End Class
