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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Play_ActivityType_Question_Opts))
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
        resources.ApplyResources(Me.MetroLabel1, "MetroLabel1")
        Me.MetroLabel1.Name = "MetroLabel1"
        '
        'QuestionTextBox
        '
        resources.ApplyResources(Me.QuestionTextBox, "QuestionTextBox")
        '
        '
        '
        Me.QuestionTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription")
        Me.QuestionTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName")
        Me.QuestionTextBox.CustomButton.Anchor = CType(resources.GetObject("resource.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.QuestionTextBox.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize"), Boolean)
        Me.QuestionTextBox.CustomButton.AutoSizeMode = CType(resources.GetObject("resource.AutoSizeMode"), System.Windows.Forms.AutoSizeMode)
        Me.QuestionTextBox.CustomButton.BackgroundImage = CType(resources.GetObject("resource.BackgroundImage"), System.Drawing.Image)
        Me.QuestionTextBox.CustomButton.BackgroundImageLayout = CType(resources.GetObject("resource.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.QuestionTextBox.CustomButton.Dock = CType(resources.GetObject("resource.Dock"), System.Windows.Forms.DockStyle)
        Me.QuestionTextBox.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.QuestionTextBox.CustomButton.Font = CType(resources.GetObject("resource.Font"), System.Drawing.Font)
        Me.QuestionTextBox.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.QuestionTextBox.CustomButton.ImageAlign = CType(resources.GetObject("resource.ImageAlign"), System.Drawing.ContentAlignment)
        Me.QuestionTextBox.CustomButton.ImageIndex = CType(resources.GetObject("resource.ImageIndex"), Integer)
        Me.QuestionTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey")
        Me.QuestionTextBox.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode"), System.Windows.Forms.ImeMode)
        Me.QuestionTextBox.CustomButton.Location = CType(resources.GetObject("resource.Location"), System.Drawing.Point)
        Me.QuestionTextBox.CustomButton.MaximumSize = CType(resources.GetObject("resource.MaximumSize"), System.Drawing.Size)
        Me.QuestionTextBox.CustomButton.Name = ""
        Me.QuestionTextBox.CustomButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.QuestionTextBox.CustomButton.Size = CType(resources.GetObject("resource.Size"), System.Drawing.Size)
        Me.QuestionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.QuestionTextBox.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex"), Integer)
        Me.QuestionTextBox.CustomButton.TextAlign = CType(resources.GetObject("resource.TextAlign"), System.Drawing.ContentAlignment)
        Me.QuestionTextBox.CustomButton.TextImageRelation = CType(resources.GetObject("resource.TextImageRelation"), System.Windows.Forms.TextImageRelation)
        Me.QuestionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.QuestionTextBox.CustomButton.UseSelectable = True
        Me.QuestionTextBox.CustomButton.Visible = CType(resources.GetObject("resource.Visible"), Boolean)
        Me.QuestionTextBox.Lines = New String(-1) {}
        Me.QuestionTextBox.MaxLength = 32767
        Me.QuestionTextBox.Name = "QuestionTextBox"
        Me.QuestionTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QuestionTextBox.ReadOnly = True
        Me.QuestionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.QuestionTextBox.SelectedText = ""
        Me.QuestionTextBox.SelectionLength = 0
        Me.QuestionTextBox.SelectionStart = 0
        Me.QuestionTextBox.ShortcutsEnabled = True
        Me.QuestionTextBox.UseSelectable = True
        Me.QuestionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.QuestionTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        resources.ApplyResources(Me.MetroLabel2, "MetroLabel2")
        Me.MetroLabel2.Name = "MetroLabel2"
        '
        'VerifyButton
        '
        resources.ApplyResources(Me.VerifyButton, "VerifyButton")
        Me.VerifyButton.Name = "VerifyButton"
        Me.VerifyButton.UseSelectable = True
        '
        'HelperLabel
        '
        resources.ApplyResources(Me.HelperLabel, "HelperLabel")
        Me.HelperLabel.Name = "HelperLabel"
        '
        'AnswersListBox
        '
        resources.ApplyResources(Me.AnswersListBox, "AnswersListBox")
        Me.AnswersListBox.FormattingEnabled = True
        Me.AnswersListBox.Name = "AnswersListBox"
        Me.AnswersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        '
        'StatusLabel
        '
        resources.ApplyResources(Me.StatusLabel, "StatusLabel")
        Me.StatusLabel.Name = "StatusLabel"
        '
        'Play_ActivityType_Question_Opts
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
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
