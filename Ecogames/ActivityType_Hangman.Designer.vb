<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivityType_Hangman
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActivityType_Hangman))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.HangmanScorePerLetterCheckbox = New MetroFramework.Controls.MetroCheckBox()
        Me.HangmanMaxTryAmountCheckbox = New MetroFramework.Controls.MetroCheckBox()
        Me.HangmanDefaultLetterAmountCheckbox = New MetroFramework.Controls.MetroCheckBox()
        Me.HangmanTimePerLetterCheckbox = New MetroFramework.Controls.MetroCheckBox()
        Me.SaveActivity = New MetroFramework.Controls.MetroButton()
        Me.Label16 = New MetroFramework.Controls.MetroLabel()
        Me.HangmanMaxTryAmount = New System.Windows.Forms.NumericUpDown()
        Me.HangmanDefaultLetterAmount = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New MetroFramework.Controls.MetroLabel()
        Me.HangmanTimePerLetter = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New MetroFramework.Controls.MetroLabel()
        Me.HangmanScorePerLetter = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New MetroFramework.Controls.MetroLabel()
        Me.Label11 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HangmanWordTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox4.SuspendLayout()
        CType(Me.HangmanMaxTryAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HangmanDefaultLetterAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HangmanTimePerLetter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HangmanScorePerLetter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Controls.Add(Me.HangmanScorePerLetterCheckbox)
        Me.GroupBox4.Controls.Add(Me.HangmanMaxTryAmountCheckbox)
        Me.GroupBox4.Controls.Add(Me.HangmanDefaultLetterAmountCheckbox)
        Me.GroupBox4.Controls.Add(Me.HangmanTimePerLetterCheckbox)
        Me.GroupBox4.Controls.Add(Me.SaveActivity)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.HangmanMaxTryAmount)
        Me.GroupBox4.Controls.Add(Me.HangmanDefaultLetterAmount)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.HangmanTimePerLetter)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.HangmanScorePerLetter)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'HangmanScorePerLetterCheckbox
        '
        resources.ApplyResources(Me.HangmanScorePerLetterCheckbox, "HangmanScorePerLetterCheckbox")
        Me.HangmanScorePerLetterCheckbox.Checked = True
        Me.HangmanScorePerLetterCheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HangmanScorePerLetterCheckbox.Name = "HangmanScorePerLetterCheckbox"
        Me.HangmanScorePerLetterCheckbox.UseSelectable = True
        '
        'HangmanMaxTryAmountCheckbox
        '
        resources.ApplyResources(Me.HangmanMaxTryAmountCheckbox, "HangmanMaxTryAmountCheckbox")
        Me.HangmanMaxTryAmountCheckbox.Name = "HangmanMaxTryAmountCheckbox"
        Me.HangmanMaxTryAmountCheckbox.UseSelectable = True
        '
        'HangmanDefaultLetterAmountCheckbox
        '
        resources.ApplyResources(Me.HangmanDefaultLetterAmountCheckbox, "HangmanDefaultLetterAmountCheckbox")
        Me.HangmanDefaultLetterAmountCheckbox.Name = "HangmanDefaultLetterAmountCheckbox"
        Me.HangmanDefaultLetterAmountCheckbox.UseSelectable = True
        '
        'HangmanTimePerLetterCheckbox
        '
        resources.ApplyResources(Me.HangmanTimePerLetterCheckbox, "HangmanTimePerLetterCheckbox")
        Me.HangmanTimePerLetterCheckbox.Name = "HangmanTimePerLetterCheckbox"
        Me.HangmanTimePerLetterCheckbox.UseSelectable = True
        '
        'SaveActivity
        '
        resources.ApplyResources(Me.SaveActivity, "SaveActivity")
        Me.SaveActivity.Name = "SaveActivity"
        Me.SaveActivity.UseSelectable = True
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'HangmanMaxTryAmount
        '
        resources.ApplyResources(Me.HangmanMaxTryAmount, "HangmanMaxTryAmount")
        Me.HangmanMaxTryAmount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.HangmanMaxTryAmount.Name = "HangmanMaxTryAmount"
        Me.HangmanMaxTryAmount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'HangmanDefaultLetterAmount
        '
        resources.ApplyResources(Me.HangmanDefaultLetterAmount, "HangmanDefaultLetterAmount")
        Me.HangmanDefaultLetterAmount.Name = "HangmanDefaultLetterAmount"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'HangmanTimePerLetter
        '
        resources.ApplyResources(Me.HangmanTimePerLetter, "HangmanTimePerLetter")
        Me.HangmanTimePerLetter.Name = "HangmanTimePerLetter"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'HangmanScorePerLetter
        '
        resources.ApplyResources(Me.HangmanScorePerLetter, "HangmanScorePerLetter")
        Me.HangmanScorePerLetter.Name = "HangmanScorePerLetter"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Image = Global.Ecogames.My.Resources.Resources.drawing
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'HangmanWordTextBox
        '
        resources.ApplyResources(Me.HangmanWordTextBox, "HangmanWordTextBox")
        '
        '
        '
        Me.HangmanWordTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription")
        Me.HangmanWordTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName")
        Me.HangmanWordTextBox.CustomButton.Anchor = CType(resources.GetObject("resource.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.HangmanWordTextBox.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize"), Boolean)
        Me.HangmanWordTextBox.CustomButton.AutoSizeMode = CType(resources.GetObject("resource.AutoSizeMode"), System.Windows.Forms.AutoSizeMode)
        Me.HangmanWordTextBox.CustomButton.BackgroundImage = CType(resources.GetObject("resource.BackgroundImage"), System.Drawing.Image)
        Me.HangmanWordTextBox.CustomButton.BackgroundImageLayout = CType(resources.GetObject("resource.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.HangmanWordTextBox.CustomButton.Dock = CType(resources.GetObject("resource.Dock"), System.Windows.Forms.DockStyle)
        Me.HangmanWordTextBox.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.HangmanWordTextBox.CustomButton.Font = CType(resources.GetObject("resource.Font"), System.Drawing.Font)
        Me.HangmanWordTextBox.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.HangmanWordTextBox.CustomButton.ImageAlign = CType(resources.GetObject("resource.ImageAlign"), System.Drawing.ContentAlignment)
        Me.HangmanWordTextBox.CustomButton.ImageIndex = CType(resources.GetObject("resource.ImageIndex"), Integer)
        Me.HangmanWordTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey")
        Me.HangmanWordTextBox.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode"), System.Windows.Forms.ImeMode)
        Me.HangmanWordTextBox.CustomButton.Location = CType(resources.GetObject("resource.Location"), System.Drawing.Point)
        Me.HangmanWordTextBox.CustomButton.MaximumSize = CType(resources.GetObject("resource.MaximumSize"), System.Drawing.Size)
        Me.HangmanWordTextBox.CustomButton.Name = ""
        Me.HangmanWordTextBox.CustomButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HangmanWordTextBox.CustomButton.Size = CType(resources.GetObject("resource.Size"), System.Drawing.Size)
        Me.HangmanWordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.HangmanWordTextBox.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex"), Integer)
        Me.HangmanWordTextBox.CustomButton.TextAlign = CType(resources.GetObject("resource.TextAlign"), System.Drawing.ContentAlignment)
        Me.HangmanWordTextBox.CustomButton.TextImageRelation = CType(resources.GetObject("resource.TextImageRelation"), System.Windows.Forms.TextImageRelation)
        Me.HangmanWordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.HangmanWordTextBox.CustomButton.UseSelectable = True
        Me.HangmanWordTextBox.CustomButton.Visible = CType(resources.GetObject("resource.Visible"), Boolean)
        Me.HangmanWordTextBox.Lines = New String(-1) {}
        Me.HangmanWordTextBox.MaxLength = 45
        Me.HangmanWordTextBox.Name = "HangmanWordTextBox"
        Me.HangmanWordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HangmanWordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.HangmanWordTextBox.SelectedText = ""
        Me.HangmanWordTextBox.SelectionLength = 0
        Me.HangmanWordTextBox.SelectionStart = 0
        Me.HangmanWordTextBox.ShortcutsEnabled = True
        Me.HangmanWordTextBox.UseSelectable = True
        Me.HangmanWordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.HangmanWordTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ActivityType_Hangman
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.HangmanWordTextBox)
        Me.MaximizeBox = False
        Me.Name = "ActivityType_Hangman"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.HangmanMaxTryAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HangmanDefaultLetterAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HangmanTimePerLetter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HangmanScorePerLetter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents HangmanMaxTryAmount As NumericUpDown
    Friend WithEvents HangmanDefaultLetterAmount As NumericUpDown
    Friend WithEvents HangmanTimePerLetter As NumericUpDown
    Friend WithEvents HangmanScorePerLetter As NumericUpDown
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HangmanWordTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents SaveActivity As MetroFramework.Controls.MetroButton
    Friend WithEvents Label16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents HangmanMaxTryAmountCheckbox As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents HangmanDefaultLetterAmountCheckbox As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents HangmanTimePerLetterCheckbox As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents HangmanScorePerLetterCheckbox As MetroFramework.Controls.MetroCheckBox
End Class
