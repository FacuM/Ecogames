<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents MainLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DetailsLayoutPanel As System.Windows.Forms.TableLayoutPanel

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.MainLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.DetailsLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Version = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.MetroProgressSpinner1 = New MetroFramework.Controls.MetroProgressSpinner()
        Me.LiveDetailsPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.CurrentOperationLabel = New System.Windows.Forms.Label()
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.AnimationHolderTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OperationsDeferrerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MainLayoutPanel.SuspendLayout()
        Me.DetailsLayoutPanel.SuspendLayout()
        Me.LiveDetailsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainLayoutPanel
        '
        resources.ApplyResources(Me.MainLayoutPanel, "MainLayoutPanel")
        Me.MainLayoutPanel.Controls.Add(Me.DetailsLayoutPanel, 1, 1)
        Me.MainLayoutPanel.Controls.Add(Me.MetroProgressSpinner1, 0, 0)
        Me.MainLayoutPanel.Controls.Add(Me.LiveDetailsPanel, 0, 1)
        Me.MainLayoutPanel.Name = "MainLayoutPanel"
        '
        'DetailsLayoutPanel
        '
        Me.DetailsLayoutPanel.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.DetailsLayoutPanel, "DetailsLayoutPanel")
        Me.DetailsLayoutPanel.Controls.Add(Me.Version, 0, 0)
        Me.DetailsLayoutPanel.Controls.Add(Me.Copyright, 0, 1)
        Me.DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        '
        'Version
        '
        Me.Version.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Version, "Version")
        Me.Version.ForeColor = System.Drawing.Color.White
        Me.Version.Name = "Version"
        '
        'Copyright
        '
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Copyright, "Copyright")
        Me.Copyright.ForeColor = System.Drawing.Color.White
        Me.Copyright.Name = "Copyright"
        '
        'MetroProgressSpinner1
        '
        Me.MetroProgressSpinner1.BackColor = System.Drawing.Color.DeepSkyBlue
        resources.ApplyResources(Me.MetroProgressSpinner1, "MetroProgressSpinner1")
        Me.MetroProgressSpinner1.Maximum = 100
        Me.MetroProgressSpinner1.Name = "MetroProgressSpinner1"
        Me.MetroProgressSpinner1.Style = MetroFramework.MetroColorStyle.White
        Me.MetroProgressSpinner1.UseCustomBackColor = True
        Me.MetroProgressSpinner1.UseSelectable = True
        '
        'LiveDetailsPanel
        '
        Me.LiveDetailsPanel.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.LiveDetailsPanel, "LiveDetailsPanel")
        Me.LiveDetailsPanel.Controls.Add(Me.CurrentOperationLabel, 0, 1)
        Me.LiveDetailsPanel.Controls.Add(Me.ApplicationTitle, 0, 0)
        Me.LiveDetailsPanel.Name = "LiveDetailsPanel"
        '
        'CurrentOperationLabel
        '
        Me.CurrentOperationLabel.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.CurrentOperationLabel, "CurrentOperationLabel")
        Me.CurrentOperationLabel.ForeColor = System.Drawing.Color.White
        Me.CurrentOperationLabel.Name = "CurrentOperationLabel"
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.ApplicationTitle, "ApplicationTitle")
        Me.ApplicationTitle.ForeColor = System.Drawing.Color.White
        Me.ApplicationTitle.Name = "ApplicationTitle"
        '
        'AnimationHolderTimer
        '
        Me.AnimationHolderTimer.Interval = 500
        '
        'OperationsDeferrerTimer
        '
        Me.OperationsDeferrerTimer.Interval = 500
        '
        'SplashScreen
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.MainLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen"
        Me.ShowInTaskbar = False
        Me.MainLayoutPanel.ResumeLayout(False)
        Me.DetailsLayoutPanel.ResumeLayout(False)
        Me.LiveDetailsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AnimationHolderTimer As Timer
    Friend WithEvents MetroProgressSpinner1 As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents OperationsDeferrerTimer As Timer
    Friend WithEvents LiveDetailsPanel As TableLayoutPanel
    Friend WithEvents CurrentOperationLabel As Label
    Friend WithEvents ApplicationTitle As Label
End Class
