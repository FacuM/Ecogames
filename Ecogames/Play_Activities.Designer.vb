<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Play_Activities
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Play_Activities))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SettingsActivityType = New MetroFramework.Controls.MetroTextBox()
        Me.PlayActivity = New MetroFramework.Controls.MetroButton()
        Me.SettingsActivityName = New MetroFramework.Controls.MetroTextBox()
        Me.Label10 = New MetroFramework.Controls.MetroLabel()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.SettingsActivityDescription = New MetroFramework.Controls.MetroTextBox()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.ActivityListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.SettingsActivityType)
        Me.GroupBox2.Controls.Add(Me.PlayActivity)
        Me.GroupBox2.Controls.Add(Me.SettingsActivityName)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.SettingsActivityDescription)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ActivityListBox)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(20, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(347, 505)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actividades"
        '
        'SettingsActivityType
        '
        Me.SettingsActivityType.Enabled = False
        Me.SettingsActivityType.Location = New System.Drawing.Point(114, 374)
        Me.SettingsActivityType.Name = "SettingsActivityType"
        Me.SettingsActivityType.ReadOnly = True
        Me.SettingsActivityType.Size = New System.Drawing.Size(221, 29)
        Me.SettingsActivityType.TabIndex = 26
        '
        'PlayActivity
        '
        Me.PlayActivity.Enabled = False
        Me.PlayActivity.Location = New System.Drawing.Point(239, 466)
        Me.PlayActivity.Name = "PlayActivity"
        Me.PlayActivity.Size = New System.Drawing.Size(96, 23)
        Me.PlayActivity.TabIndex = 24
        Me.PlayActivity.Text = "Jugar"
        '
        'SettingsActivityName
        '
        Me.SettingsActivityName.Enabled = False
        Me.SettingsActivityName.Location = New System.Drawing.Point(114, 339)
        Me.SettingsActivityName.Name = "SettingsActivityName"
        Me.SettingsActivityName.ReadOnly = True
        Me.SettingsActivityName.Size = New System.Drawing.Size(221, 29)
        Me.SettingsActivityName.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 339)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 29)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Nombre: "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 374)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 29)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Tipo:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SettingsActivityDescription
        '
        Me.SettingsActivityDescription.Enabled = False
        Me.SettingsActivityDescription.Location = New System.Drawing.Point(114, 409)
        Me.SettingsActivityDescription.Multiline = True
        Me.SettingsActivityDescription.Name = "SettingsActivityDescription"
        Me.SettingsActivityDescription.ReadOnly = True
        Me.SettingsActivityDescription.Size = New System.Drawing.Size(221, 42)
        Me.SettingsActivityDescription.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 403)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Descripción:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ActivityListBox
        '
        Me.ActivityListBox.FormattingEnabled = True
        Me.ActivityListBox.Location = New System.Drawing.Point(9, 19)
        Me.ActivityListBox.Name = "ActivityListBox"
        Me.ActivityListBox.Size = New System.Drawing.Size(326, 303)
        Me.ActivityListBox.TabIndex = 0
        '
        'Play_Activities
        '
        Me.AcceptButton = Me.PlayActivity
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(387, 585)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Play_Activities"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow
        Me.Text = "Actividades"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SettingsActivityName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SettingsActivityDescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ActivityListBox As ListBox
    Friend WithEvents PlayActivity As MetroFramework.Controls.MetroButton
    Friend WithEvents SettingsActivityType As MetroFramework.Controls.MetroTextBox
End Class
