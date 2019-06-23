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
        Me.ScoreLabel = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.StatusResetTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatusPanel.SuspendLayout()
        Me.ScorePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(20, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(639, 321)
        Me.DataGridView1.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StatusPanel)
        Me.GroupBox1.Controls.Add(Me.ScorePanel)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(20, 381)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 49)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'StatusPanel
        '
        Me.StatusPanel.Controls.Add(Me.StatusLabel)
        Me.StatusPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.StatusPanel.HorizontalScrollbarBarColor = False
        Me.StatusPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.StatusPanel.HorizontalScrollbarSize = 0
        Me.StatusPanel.Location = New System.Drawing.Point(203, 16)
        Me.StatusPanel.Name = "StatusPanel"
        Me.StatusPanel.Size = New System.Drawing.Size(433, 30)
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
        Me.StatusLabel.Size = New System.Drawing.Size(430, 30)
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
        'Play_ActivityType_Crossword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Play_ActivityType_Crossword"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Play_ActivityType_Crossword"
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
End Class
