<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Play_ActivityType_Hangman
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Play_ActivityType_Hangman))
        Me.Label11 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HangmanWordTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StatusPanel = New MetroFramework.Controls.MetroPanel()
        Me.StatusLabel = New MetroFramework.Controls.MetroLabel()
        Me.ScorePanel = New MetroFramework.Controls.MetroPanel()
        Me.ScoreLabel = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.StatusResetTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TimeManager = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatusPanel.SuspendLayout()
        Me.ScorePanel.SuspendLayout()
        Me.SuspendLayout()
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
        Me.HangmanWordTextBox.ReadOnly = True
        Me.HangmanWordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.HangmanWordTextBox.SelectedText = ""
        Me.HangmanWordTextBox.SelectionLength = 0
        Me.HangmanWordTextBox.SelectionStart = 0
        Me.HangmanWordTextBox.ShortcutsEnabled = True
        Me.HangmanWordTextBox.UseSelectable = True
        Me.HangmanWordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.HangmanWordTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.StatusPanel)
        Me.GroupBox1.Controls.Add(Me.ScorePanel)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'StatusPanel
        '
        resources.ApplyResources(Me.StatusPanel, "StatusPanel")
        Me.StatusPanel.Controls.Add(Me.StatusLabel)
        Me.StatusPanel.HorizontalScrollbarBarColor = False
        Me.StatusPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.StatusPanel.HorizontalScrollbarSize = 0
        Me.StatusPanel.Name = "StatusPanel"
        Me.StatusPanel.VerticalScrollbarBarColor = False
        Me.StatusPanel.VerticalScrollbarHighlightOnWheel = False
        Me.StatusPanel.VerticalScrollbarSize = 0
        '
        'StatusLabel
        '
        resources.ApplyResources(Me.StatusLabel, "StatusLabel")
        Me.StatusLabel.Name = "StatusLabel"
        '
        'ScorePanel
        '
        resources.ApplyResources(Me.ScorePanel, "ScorePanel")
        Me.ScorePanel.Controls.Add(Me.ScoreLabel)
        Me.ScorePanel.Controls.Add(Me.Label1)
        Me.ScorePanel.HorizontalScrollbarBarColor = False
        Me.ScorePanel.HorizontalScrollbarHighlightOnWheel = False
        Me.ScorePanel.HorizontalScrollbarSize = 0
        Me.ScorePanel.Name = "ScorePanel"
        Me.ScorePanel.VerticalScrollbarBarColor = False
        Me.ScorePanel.VerticalScrollbarHighlightOnWheel = False
        Me.ScorePanel.VerticalScrollbarSize = 0
        '
        'ScoreLabel
        '
        resources.ApplyResources(Me.ScoreLabel, "ScoreLabel")
        Me.ScoreLabel.Name = "ScoreLabel"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'StatusResetTimer
        '
        Me.StatusResetTimer.Interval = 2000
        '
        'TimeManager
        '
        Me.TimeManager.Interval = 1000
        '
        'Play_ActivityType_Hangman
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.HangmanWordTextBox)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Play_ActivityType_Hangman"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.StatusPanel.ResumeLayout(False)
        Me.ScorePanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HangmanWordTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StatusPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents StatusLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents ScorePanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents ScoreLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents StatusResetTimer As Timer
    Friend WithEvents TimeManager As Timer
End Class
