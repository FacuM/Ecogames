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
        Me.SettingsActivityType = New MetroFramework.Controls.MetroTextBox()
        Me.PlayActivity = New MetroFramework.Controls.MetroButton()
        Me.SettingsActivityName = New MetroFramework.Controls.MetroTextBox()
        Me.Label10 = New MetroFramework.Controls.MetroLabel()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.SettingsActivityDescription = New MetroFramework.Controls.MetroTextBox()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.ActivityListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'SettingsActivityType
        '
        '
        '
        '
        Me.SettingsActivityType.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.SettingsActivityType.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode"), System.Windows.Forms.ImeMode)
        Me.SettingsActivityType.CustomButton.Location = CType(resources.GetObject("resource.Location"), System.Drawing.Point)
        Me.SettingsActivityType.CustomButton.Name = ""
        Me.SettingsActivityType.CustomButton.Size = CType(resources.GetObject("resource.Size"), System.Drawing.Size)
        Me.SettingsActivityType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SettingsActivityType.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex"), Integer)
        Me.SettingsActivityType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SettingsActivityType.CustomButton.UseSelectable = True
        Me.SettingsActivityType.CustomButton.Visible = CType(resources.GetObject("resource.Visible"), Boolean)
        resources.ApplyResources(Me.SettingsActivityType, "SettingsActivityType")
        Me.SettingsActivityType.Lines = New String(-1) {}
        Me.SettingsActivityType.MaxLength = 32767
        Me.SettingsActivityType.Name = "SettingsActivityType"
        Me.SettingsActivityType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SettingsActivityType.ReadOnly = True
        Me.SettingsActivityType.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SettingsActivityType.SelectedText = ""
        Me.SettingsActivityType.SelectionLength = 0
        Me.SettingsActivityType.SelectionStart = 0
        Me.SettingsActivityType.ShortcutsEnabled = True
        Me.SettingsActivityType.UseSelectable = True
        Me.SettingsActivityType.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SettingsActivityType.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PlayActivity
        '
        resources.ApplyResources(Me.PlayActivity, "PlayActivity")
        Me.PlayActivity.Name = "PlayActivity"
        Me.PlayActivity.UseSelectable = True
        '
        'SettingsActivityName
        '
        '
        '
        '
        Me.SettingsActivityName.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.SettingsActivityName.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode1"), System.Windows.Forms.ImeMode)
        Me.SettingsActivityName.CustomButton.Location = CType(resources.GetObject("resource.Location1"), System.Drawing.Point)
        Me.SettingsActivityName.CustomButton.Name = ""
        Me.SettingsActivityName.CustomButton.Size = CType(resources.GetObject("resource.Size1"), System.Drawing.Size)
        Me.SettingsActivityName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SettingsActivityName.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex1"), Integer)
        Me.SettingsActivityName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SettingsActivityName.CustomButton.UseSelectable = True
        Me.SettingsActivityName.CustomButton.Visible = CType(resources.GetObject("resource.Visible1"), Boolean)
        resources.ApplyResources(Me.SettingsActivityName, "SettingsActivityName")
        Me.SettingsActivityName.Lines = New String(-1) {}
        Me.SettingsActivityName.MaxLength = 32767
        Me.SettingsActivityName.Name = "SettingsActivityName"
        Me.SettingsActivityName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SettingsActivityName.ReadOnly = True
        Me.SettingsActivityName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SettingsActivityName.SelectedText = ""
        Me.SettingsActivityName.SelectionLength = 0
        Me.SettingsActivityName.SelectionStart = 0
        Me.SettingsActivityName.ShortcutsEnabled = True
        Me.SettingsActivityName.UseSelectable = True
        Me.SettingsActivityName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SettingsActivityName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'SettingsActivityDescription
        '
        '
        '
        '
        Me.SettingsActivityDescription.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.SettingsActivityDescription.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode2"), System.Windows.Forms.ImeMode)
        Me.SettingsActivityDescription.CustomButton.Location = CType(resources.GetObject("resource.Location2"), System.Drawing.Point)
        Me.SettingsActivityDescription.CustomButton.Name = ""
        Me.SettingsActivityDescription.CustomButton.Size = CType(resources.GetObject("resource.Size2"), System.Drawing.Size)
        Me.SettingsActivityDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SettingsActivityDescription.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex2"), Integer)
        Me.SettingsActivityDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SettingsActivityDescription.CustomButton.UseSelectable = True
        Me.SettingsActivityDescription.CustomButton.Visible = CType(resources.GetObject("resource.Visible2"), Boolean)
        Me.SettingsActivityDescription.Lines = New String(-1) {}
        resources.ApplyResources(Me.SettingsActivityDescription, "SettingsActivityDescription")
        Me.SettingsActivityDescription.MaxLength = 32767
        Me.SettingsActivityDescription.Multiline = True
        Me.SettingsActivityDescription.Name = "SettingsActivityDescription"
        Me.SettingsActivityDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SettingsActivityDescription.ReadOnly = True
        Me.SettingsActivityDescription.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SettingsActivityDescription.SelectedText = ""
        Me.SettingsActivityDescription.SelectionLength = 0
        Me.SettingsActivityDescription.SelectionStart = 0
        Me.SettingsActivityDescription.ShortcutsEnabled = True
        Me.SettingsActivityDescription.UseSelectable = True
        Me.SettingsActivityDescription.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SettingsActivityDescription.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'ActivityListBox
        '
        Me.ActivityListBox.FormattingEnabled = True
        resources.ApplyResources(Me.ActivityListBox, "ActivityListBox")
        Me.ActivityListBox.Name = "ActivityListBox"
        '
        'Play_Activities
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SettingsActivityType)
        Me.Controls.Add(Me.PlayActivity)
        Me.Controls.Add(Me.SettingsActivityName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.SettingsActivityDescription)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ActivityListBox)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Play_Activities"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SettingsActivityType As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PlayActivity As MetroFramework.Controls.MetroButton
    Friend WithEvents SettingsActivityName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SettingsActivityDescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ActivityListBox As ListBox
End Class
