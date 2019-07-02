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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActivityType_Question_Opts))
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
        resources.ApplyResources(Me.AnswerTextBox, "AnswerTextBox")
        '
        '
        '
        Me.AnswerTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription1")
        Me.AnswerTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName1")
        Me.AnswerTextBox.CustomButton.Anchor = CType(resources.GetObject("resource.Anchor1"), System.Windows.Forms.AnchorStyles)
        Me.AnswerTextBox.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize1"), Boolean)
        Me.AnswerTextBox.CustomButton.AutoSizeMode = CType(resources.GetObject("resource.AutoSizeMode1"), System.Windows.Forms.AutoSizeMode)
        Me.AnswerTextBox.CustomButton.BackgroundImage = CType(resources.GetObject("resource.BackgroundImage1"), System.Drawing.Image)
        Me.AnswerTextBox.CustomButton.BackgroundImageLayout = CType(resources.GetObject("resource.BackgroundImageLayout1"), System.Windows.Forms.ImageLayout)
        Me.AnswerTextBox.CustomButton.Dock = CType(resources.GetObject("resource.Dock1"), System.Windows.Forms.DockStyle)
        Me.AnswerTextBox.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle1"), System.Windows.Forms.FlatStyle)
        Me.AnswerTextBox.CustomButton.Font = CType(resources.GetObject("resource.Font1"), System.Drawing.Font)
        Me.AnswerTextBox.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.AnswerTextBox.CustomButton.ImageAlign = CType(resources.GetObject("resource.ImageAlign1"), System.Drawing.ContentAlignment)
        Me.AnswerTextBox.CustomButton.ImageIndex = CType(resources.GetObject("resource.ImageIndex1"), Integer)
        Me.AnswerTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey1")
        Me.AnswerTextBox.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode1"), System.Windows.Forms.ImeMode)
        Me.AnswerTextBox.CustomButton.Location = CType(resources.GetObject("resource.Location1"), System.Drawing.Point)
        Me.AnswerTextBox.CustomButton.MaximumSize = CType(resources.GetObject("resource.MaximumSize1"), System.Drawing.Size)
        Me.AnswerTextBox.CustomButton.Name = ""
        Me.AnswerTextBox.CustomButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft1"), System.Windows.Forms.RightToLeft)
        Me.AnswerTextBox.CustomButton.Size = CType(resources.GetObject("resource.Size1"), System.Drawing.Size)
        Me.AnswerTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.AnswerTextBox.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex1"), Integer)
        Me.AnswerTextBox.CustomButton.TextAlign = CType(resources.GetObject("resource.TextAlign1"), System.Drawing.ContentAlignment)
        Me.AnswerTextBox.CustomButton.TextImageRelation = CType(resources.GetObject("resource.TextImageRelation1"), System.Windows.Forms.TextImageRelation)
        Me.AnswerTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.AnswerTextBox.CustomButton.UseSelectable = True
        Me.AnswerTextBox.CustomButton.Visible = CType(resources.GetObject("resource.Visible1"), Boolean)
        Me.AnswerTextBox.Lines = New String(-1) {}
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
        'HelperLabel
        '
        resources.ApplyResources(Me.HelperLabel, "HelperLabel")
        Me.HelperLabel.Name = "HelperLabel"
        Me.HelperLabel.WrapToLine = True
        '
        'NextActionButton
        '
        resources.ApplyResources(Me.NextActionButton, "NextActionButton")
        Me.NextActionButton.Name = "NextActionButton"
        Me.NextActionButton.UseSelectable = True
        '
        'AddAnswerButton
        '
        resources.ApplyResources(Me.AddAnswerButton, "AddAnswerButton")
        Me.AddAnswerButton.Name = "AddAnswerButton"
        Me.AddAnswerButton.UseSelectable = True
        '
        'CorrectAnswerCheckBox
        '
        resources.ApplyResources(Me.CorrectAnswerCheckBox, "CorrectAnswerCheckBox")
        Me.CorrectAnswerCheckBox.Name = "CorrectAnswerCheckBox"
        Me.CorrectAnswerCheckBox.UseSelectable = True
        '
        'AnswersListBox
        '
        resources.ApplyResources(Me.AnswersListBox, "AnswersListBox")
        Me.AnswersListBox.FormattingEnabled = True
        Me.AnswersListBox.Name = "AnswersListBox"
        '
        'ModifyButton
        '
        resources.ApplyResources(Me.ModifyButton, "ModifyButton")
        Me.ModifyButton.Name = "ModifyButton"
        Me.ModifyButton.UseSelectable = True
        '
        'ActivityType_Question_Opts
        '
        Me.AcceptButton = Me.NextActionButton
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
