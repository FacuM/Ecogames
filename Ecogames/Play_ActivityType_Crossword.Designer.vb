<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Play_ActivityType_Crossword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Play_ActivityType_Crossword))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StatusPanel = New MetroFramework.Controls.MetroPanel()
        Me.StatusLabel = New MetroFramework.Controls.MetroLabel()
        Me.ScorePanel = New MetroFramework.Controls.MetroPanel()
        Me.PauseButton = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.ScoreLabel = New MetroFramework.Controls.MetroLabel()
        Me.StatusResetTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TimeManager = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatusPanel.SuspendLayout()
        Me.ScorePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Name = "DataGridView1"
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
        Me.ScorePanel.Controls.Add(Me.PauseButton)
        Me.ScorePanel.Controls.Add(Me.Label1)
        Me.ScorePanel.Controls.Add(Me.ScoreLabel)
        Me.ScorePanel.HorizontalScrollbarBarColor = False
        Me.ScorePanel.HorizontalScrollbarHighlightOnWheel = False
        Me.ScorePanel.HorizontalScrollbarSize = 0
        Me.ScorePanel.Name = "ScorePanel"
        Me.ScorePanel.VerticalScrollbarBarColor = False
        Me.ScorePanel.VerticalScrollbarHighlightOnWheel = False
        Me.ScorePanel.VerticalScrollbarSize = 0
        '
        'PauseButton
        '
        resources.ApplyResources(Me.PauseButton, "PauseButton")
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.UseSelectable = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'ScoreLabel
        '
        resources.ApplyResources(Me.ScoreLabel, "ScoreLabel")
        Me.ScoreLabel.Name = "ScoreLabel"
        '
        'StatusResetTimer
        '
        Me.StatusResetTimer.Interval = 2000
        '
        'TimeManager
        '
        Me.TimeManager.Interval = 1000
        '
        'Play_ActivityType_Crossword
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "Play_ActivityType_Crossword"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.StatusPanel.ResumeLayout(False)
        Me.ScorePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ScorePanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ScoreLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents StatusPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents StatusLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents StatusResetTimer As Timer
    Friend WithEvents TimeManager As Timer
    Friend WithEvents PauseButton As MetroFramework.Controls.MetroButton
End Class
