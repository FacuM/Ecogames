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
        Me.QuestionTextBox.Location = New System.Drawing.Point(23, 164)
        Me.QuestionTextBox.Name = "QuestionTextBox"
        Me.QuestionTextBox.Size = New System.Drawing.Size(316, 23)
        Me.QuestionTextBox.TabIndex = 1
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.Location = New System.Drawing.Point(23, 341)
        Me.AnswerTextBox.Multiline = True
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(316, 23)
        Me.AnswerTextBox.TabIndex = 3
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
        '
        'AddAnswerButton
        '
        Me.AddAnswerButton.Enabled = False
        Me.AddAnswerButton.Location = New System.Drawing.Point(99, 377)
        Me.AddAnswerButton.Name = "AddAnswerButton"
        Me.AddAnswerButton.Size = New System.Drawing.Size(117, 23)
        Me.AddAnswerButton.TabIndex = 8
        Me.AddAnswerButton.Text = "Agregar"
        '
        'CorrectAnswerCheckBox
        '
        Me.CorrectAnswerCheckBox.Location = New System.Drawing.Point(23, 377)
        Me.CorrectAnswerCheckBox.Name = "CorrectAnswerCheckBox"
        Me.CorrectAnswerCheckBox.Size = New System.Drawing.Size(70, 23)
        Me.CorrectAnswerCheckBox.TabIndex = 9
        Me.CorrectAnswerCheckBox.Text = "Correcta"
        Me.CorrectAnswerCheckBox.UseVisualStyleBackColor = True
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
        Me.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow
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
