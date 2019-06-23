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
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(181, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 19)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Texto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ecogames.My.Resources.Resources.drawing
        Me.PictureBox1.Location = New System.Drawing.Point(23, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 178)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'HangmanWordTextBox
        '
        '
        '
        '
        Me.HangmanWordTextBox.CustomButton.Image = Nothing
        Me.HangmanWordTextBox.CustomButton.Location = New System.Drawing.Point(310, 2)
        Me.HangmanWordTextBox.CustomButton.Name = ""
        Me.HangmanWordTextBox.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.HangmanWordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.HangmanWordTextBox.CustomButton.TabIndex = 1
        Me.HangmanWordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.HangmanWordTextBox.CustomButton.UseSelectable = True
        Me.HangmanWordTextBox.CustomButton.Visible = False
        Me.HangmanWordTextBox.Lines = New String(-1) {}
        Me.HangmanWordTextBox.Location = New System.Drawing.Point(181, 147)
        Me.HangmanWordTextBox.MaxLength = 45
        Me.HangmanWordTextBox.Name = "HangmanWordTextBox"
        Me.HangmanWordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HangmanWordTextBox.ReadOnly = True
        Me.HangmanWordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.HangmanWordTextBox.SelectedText = ""
        Me.HangmanWordTextBox.SelectionLength = 0
        Me.HangmanWordTextBox.SelectionStart = 0
        Me.HangmanWordTextBox.ShortcutsEnabled = True
        Me.HangmanWordTextBox.Size = New System.Drawing.Size(328, 20)
        Me.HangmanWordTextBox.TabIndex = 0
        Me.HangmanWordTextBox.UseSelectable = True
        Me.HangmanWordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.HangmanWordTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StatusPanel)
        Me.GroupBox1.Controls.Add(Me.ScorePanel)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(20, 246)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 49)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'StatusPanel
        '
        Me.StatusPanel.Controls.Add(Me.StatusLabel)
        Me.StatusPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusPanel.HorizontalScrollbarBarColor = False
        Me.StatusPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.StatusPanel.HorizontalScrollbarSize = 0
        Me.StatusPanel.Location = New System.Drawing.Point(203, 16)
        Me.StatusPanel.Name = "StatusPanel"
        Me.StatusPanel.Size = New System.Drawing.Size(283, 30)
        Me.StatusPanel.TabIndex = 28
        Me.StatusPanel.VerticalScrollbarBarColor = False
        Me.StatusPanel.VerticalScrollbarHighlightOnWheel = False
        Me.StatusPanel.VerticalScrollbarSize = 0
        '
        'StatusLabel
        '
        Me.StatusLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.StatusLabel.Location = New System.Drawing.Point(0, 0)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(280, 30)
        Me.StatusLabel.TabIndex = 25
        Me.StatusLabel.Text = "N/A"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ScorePanel
        '
        Me.ScorePanel.Controls.Add(Me.ScoreLabel)
        Me.ScorePanel.Controls.Add(Me.Label1)
        Me.ScorePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ScorePanel.HorizontalScrollbarBarColor = False
        Me.ScorePanel.HorizontalScrollbarHighlightOnWheel = False
        Me.ScorePanel.HorizontalScrollbarSize = 0
        Me.ScorePanel.Location = New System.Drawing.Point(3, 16)
        Me.ScorePanel.Name = "ScorePanel"
        Me.ScorePanel.Size = New System.Drawing.Size(200, 30)
        Me.ScorePanel.TabIndex = 27
        Me.ScorePanel.VerticalScrollbarBarColor = False
        Me.ScorePanel.VerticalScrollbarHighlightOnWheel = False
        Me.ScorePanel.VerticalScrollbarSize = 0
        '
        'ScoreLabel
        '
        Me.ScoreLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScoreLabel.Location = New System.Drawing.Point(64, 0)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(136, 30)
        Me.ScoreLabel.TabIndex = 21
        Me.ScoreLabel.Text = "N/A"
        Me.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 30)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Puntaje: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 315)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.HangmanWordTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Play_ActivityType_Hangman"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Play_ActivityType_Hangman"
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
