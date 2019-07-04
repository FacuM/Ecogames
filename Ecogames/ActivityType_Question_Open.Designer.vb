<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ActivityType_Question_Open
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActivityType_Question_Open))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.QuestionTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.AnswerTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.SaveActivityButton = New MetroFramework.Controls.MetroButton()
        Me.AutomaticEvaluationCheckBox = New MetroFramework.Controls.MetroCheckBox()
        Me.TimePerQuestionCheckBox = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.TimePerQuestionNumericUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.TimePerQuestionNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        resources.ApplyResources(Me.MetroLabel1, "MetroLabel1")
        Me.MetroLabel1.Name = "MetroLabel1"
        '
        'QuestionTextBox
        '
        '
        '
        '
        Me.QuestionTextBox.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.QuestionTextBox.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode"), System.Windows.Forms.ImeMode)
        Me.QuestionTextBox.CustomButton.Location = CType(resources.GetObject("resource.Location"), System.Drawing.Point)
        Me.QuestionTextBox.CustomButton.Name = ""
        Me.QuestionTextBox.CustomButton.Size = CType(resources.GetObject("resource.Size"), System.Drawing.Size)
        Me.QuestionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.QuestionTextBox.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex"), Integer)
        Me.QuestionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.QuestionTextBox.CustomButton.UseSelectable = True
        Me.QuestionTextBox.CustomButton.Visible = CType(resources.GetObject("resource.Visible"), Boolean)
        Me.QuestionTextBox.Lines = New String(-1) {}
        resources.ApplyResources(Me.QuestionTextBox, "QuestionTextBox")
        Me.QuestionTextBox.MaxLength = 32767
        Me.QuestionTextBox.Name = "QuestionTextBox"
        Me.QuestionTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QuestionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.QuestionTextBox.SelectedText = ""
        Me.QuestionTextBox.SelectionLength = 0
        Me.QuestionTextBox.SelectionStart = 0
        Me.QuestionTextBox.ShortcutsEnabled = True
        Me.QuestionTextBox.UseSelectable = True
        Me.QuestionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.QuestionTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'AnswerTextBox
        '
        '
        '
        '
        Me.AnswerTextBox.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.AnswerTextBox.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode1"), System.Windows.Forms.ImeMode)
        Me.AnswerTextBox.CustomButton.Location = CType(resources.GetObject("resource.Location1"), System.Drawing.Point)
        Me.AnswerTextBox.CustomButton.Name = ""
        Me.AnswerTextBox.CustomButton.Size = CType(resources.GetObject("resource.Size1"), System.Drawing.Size)
        Me.AnswerTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.AnswerTextBox.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex1"), Integer)
        Me.AnswerTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.AnswerTextBox.CustomButton.UseSelectable = True
        Me.AnswerTextBox.CustomButton.Visible = CType(resources.GetObject("resource.Visible1"), Boolean)
        Me.AnswerTextBox.Lines = New String(-1) {}
        resources.ApplyResources(Me.AnswerTextBox, "AnswerTextBox")
        Me.AnswerTextBox.MaxLength = 32767
        Me.AnswerTextBox.Multiline = True
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AnswerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.AnswerTextBox.SelectedText = ""
        Me.AnswerTextBox.SelectionLength = 0
        Me.AnswerTextBox.SelectionStart = 0
        Me.AnswerTextBox.ShortcutsEnabled = True
        Me.AnswerTextBox.UseSelectable = True
        Me.AnswerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.AnswerTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        resources.ApplyResources(Me.MetroLabel2, "MetroLabel2")
        Me.MetroLabel2.Name = "MetroLabel2"
        '
        'SaveActivityButton
        '
        resources.ApplyResources(Me.SaveActivityButton, "SaveActivityButton")
        Me.SaveActivityButton.Name = "SaveActivityButton"
        Me.SaveActivityButton.UseSelectable = True
        '
        'AutomaticEvaluationCheckBox
        '
        resources.ApplyResources(Me.AutomaticEvaluationCheckBox, "AutomaticEvaluationCheckBox")
        Me.AutomaticEvaluationCheckBox.Name = "AutomaticEvaluationCheckBox"
        Me.AutomaticEvaluationCheckBox.UseSelectable = True
        '
        'TimePerQuestionCheckBox
        '
        Me.TimePerQuestionCheckBox.Checked = True
        Me.TimePerQuestionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        resources.ApplyResources(Me.TimePerQuestionCheckBox, "TimePerQuestionCheckBox")
        Me.TimePerQuestionCheckBox.Name = "TimePerQuestionCheckBox"
        Me.TimePerQuestionCheckBox.UseSelectable = True
        '
        'MetroLabel3
        '
        resources.ApplyResources(Me.MetroLabel3, "MetroLabel3")
        Me.MetroLabel3.Name = "MetroLabel3"
        '
        'TimePerQuestionNumericUpDown
        '
        resources.ApplyResources(Me.TimePerQuestionNumericUpDown, "TimePerQuestionNumericUpDown")
        Me.TimePerQuestionNumericUpDown.Name = "TimePerQuestionNumericUpDown"
        '
        'ActivityType_Question_Open
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TimePerQuestionCheckBox)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.TimePerQuestionNumericUpDown)
        Me.Controls.Add(Me.AutomaticEvaluationCheckBox)
        Me.Controls.Add(Me.SaveActivityButton)
        Me.Controls.Add(Me.AnswerTextBox)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.QuestionTextBox)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "ActivityType_Question_Open"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        CType(Me.TimePerQuestionNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents QuestionTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents AnswerTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SaveActivityButton As MetroFramework.Controls.MetroButton
    Friend WithEvents AutomaticEvaluationCheckBox As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents TimePerQuestionCheckBox As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TimePerQuestionNumericUpDown As NumericUpDown
End Class
