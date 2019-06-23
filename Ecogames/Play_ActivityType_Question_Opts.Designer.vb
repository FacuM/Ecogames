<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Play_ActivityType_Question_Opts
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
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.VerifyButton = New MetroFramework.Controls.MetroButton()
        Me.HelperLabel = New MetroFramework.Controls.MetroLabel()
        Me.AnswersListBox = New System.Windows.Forms.ListBox()
        Me.StatusLabel = New MetroFramework.Controls.MetroLabel()
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
        Me.QuestionTextBox.ReadOnly = True
        Me.QuestionTextBox.Size = New System.Drawing.Size(316, 23)
        Me.QuestionTextBox.TabIndex = 1
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 203)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(72, 23)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Opciones"
        '
        'VerifyButton
        '
        Me.VerifyButton.Location = New System.Drawing.Point(222, 378)
        Me.VerifyButton.Name = "VerifyButton"
        Me.VerifyButton.Size = New System.Drawing.Size(117, 23)
        Me.VerifyButton.TabIndex = 4
        Me.VerifyButton.Text = "Verificar"
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
        'AnswersListBox
        '
        Me.AnswersListBox.FormattingEnabled = True
        Me.AnswersListBox.Location = New System.Drawing.Point(23, 232)
        Me.AnswersListBox.Name = "AnswersListBox"
        Me.AnswersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.AnswersListBox.Size = New System.Drawing.Size(316, 134)
        Me.AnswersListBox.TabIndex = 11
        Me.AnswersListBox.Visible = False
        '
        'StatusLabel
        '
        Me.StatusLabel.Location = New System.Drawing.Point(23, 378)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(193, 23)
        Me.StatusLabel.TabIndex = 12
        Me.StatusLabel.Text = "N/A"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Play_ActivityType_Question_Opts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 412)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.AnswersListBox)
        Me.Controls.Add(Me.HelperLabel)
        Me.Controls.Add(Me.VerifyButton)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.QuestionTextBox)
        Me.Controls.Add(Me.MetroLabel1)
        Me.MaximizeBox = False
        Me.Name = "Play_ActivityType_Question_Opts"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow
        Me.Text = "Play_ActivityType_Question_Opts"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents QuestionTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents VerifyButton As MetroFramework.Controls.MetroButton
    Friend WithEvents HelperLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents AnswersListBox As ListBox
    Friend WithEvents StatusLabel As MetroFramework.Controls.MetroLabel
End Class
