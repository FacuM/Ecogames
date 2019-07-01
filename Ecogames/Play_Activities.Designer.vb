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
        resources.ApplyResources(Me.SettingsActivityType, "SettingsActivityType")
        '
        '
        '
        Me.SettingsActivityType.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription")
        Me.SettingsActivityType.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName")
        Me.SettingsActivityType.CustomButton.Anchor = CType(resources.GetObject("resource.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.SettingsActivityType.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize"), Boolean)
        Me.SettingsActivityType.CustomButton.AutoSizeMode = CType(resources.GetObject("resource.AutoSizeMode"), System.Windows.Forms.AutoSizeMode)
        Me.SettingsActivityType.CustomButton.BackgroundImage = CType(resources.GetObject("resource.BackgroundImage"), System.Drawing.Image)
        Me.SettingsActivityType.CustomButton.BackgroundImageLayout = CType(resources.GetObject("resource.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.SettingsActivityType.CustomButton.Dock = CType(resources.GetObject("resource.Dock"), System.Windows.Forms.DockStyle)
        Me.SettingsActivityType.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.SettingsActivityType.CustomButton.Font = CType(resources.GetObject("resource.Font"), System.Drawing.Font)
        Me.SettingsActivityType.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.SettingsActivityType.CustomButton.ImageAlign = CType(resources.GetObject("resource.ImageAlign"), System.Drawing.ContentAlignment)
        Me.SettingsActivityType.CustomButton.ImageIndex = CType(resources.GetObject("resource.ImageIndex"), Integer)
        Me.SettingsActivityType.CustomButton.ImageKey = resources.GetString("resource.ImageKey")
        Me.SettingsActivityType.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode"), System.Windows.Forms.ImeMode)
        Me.SettingsActivityType.CustomButton.Location = CType(resources.GetObject("resource.Location"), System.Drawing.Point)
        Me.SettingsActivityType.CustomButton.MaximumSize = CType(resources.GetObject("resource.MaximumSize"), System.Drawing.Size)
        Me.SettingsActivityType.CustomButton.Name = ""
        Me.SettingsActivityType.CustomButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.SettingsActivityType.CustomButton.Size = CType(resources.GetObject("resource.Size"), System.Drawing.Size)
        Me.SettingsActivityType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SettingsActivityType.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex"), Integer)
        Me.SettingsActivityType.CustomButton.TextAlign = CType(resources.GetObject("resource.TextAlign"), System.Drawing.ContentAlignment)
        Me.SettingsActivityType.CustomButton.TextImageRelation = CType(resources.GetObject("resource.TextImageRelation"), System.Windows.Forms.TextImageRelation)
        Me.SettingsActivityType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SettingsActivityType.CustomButton.UseSelectable = True
        Me.SettingsActivityType.CustomButton.Visible = CType(resources.GetObject("resource.Visible"), Boolean)
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
        resources.ApplyResources(Me.SettingsActivityName, "SettingsActivityName")
        '
        '
        '
        Me.SettingsActivityName.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription1")
        Me.SettingsActivityName.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName1")
        Me.SettingsActivityName.CustomButton.Anchor = CType(resources.GetObject("resource.Anchor1"), System.Windows.Forms.AnchorStyles)
        Me.SettingsActivityName.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize1"), Boolean)
        Me.SettingsActivityName.CustomButton.AutoSizeMode = CType(resources.GetObject("resource.AutoSizeMode1"), System.Windows.Forms.AutoSizeMode)
        Me.SettingsActivityName.CustomButton.BackgroundImage = CType(resources.GetObject("resource.BackgroundImage1"), System.Drawing.Image)
        Me.SettingsActivityName.CustomButton.BackgroundImageLayout = CType(resources.GetObject("resource.BackgroundImageLayout1"), System.Windows.Forms.ImageLayout)
        Me.SettingsActivityName.CustomButton.Dock = CType(resources.GetObject("resource.Dock1"), System.Windows.Forms.DockStyle)
        Me.SettingsActivityName.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle1"), System.Windows.Forms.FlatStyle)
        Me.SettingsActivityName.CustomButton.Font = CType(resources.GetObject("resource.Font1"), System.Drawing.Font)
        Me.SettingsActivityName.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.SettingsActivityName.CustomButton.ImageAlign = CType(resources.GetObject("resource.ImageAlign1"), System.Drawing.ContentAlignment)
        Me.SettingsActivityName.CustomButton.ImageIndex = CType(resources.GetObject("resource.ImageIndex1"), Integer)
        Me.SettingsActivityName.CustomButton.ImageKey = resources.GetString("resource.ImageKey1")
        Me.SettingsActivityName.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode1"), System.Windows.Forms.ImeMode)
        Me.SettingsActivityName.CustomButton.Location = CType(resources.GetObject("resource.Location1"), System.Drawing.Point)
        Me.SettingsActivityName.CustomButton.MaximumSize = CType(resources.GetObject("resource.MaximumSize1"), System.Drawing.Size)
        Me.SettingsActivityName.CustomButton.Name = ""
        Me.SettingsActivityName.CustomButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft1"), System.Windows.Forms.RightToLeft)
        Me.SettingsActivityName.CustomButton.Size = CType(resources.GetObject("resource.Size1"), System.Drawing.Size)
        Me.SettingsActivityName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SettingsActivityName.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex1"), Integer)
        Me.SettingsActivityName.CustomButton.TextAlign = CType(resources.GetObject("resource.TextAlign1"), System.Drawing.ContentAlignment)
        Me.SettingsActivityName.CustomButton.TextImageRelation = CType(resources.GetObject("resource.TextImageRelation1"), System.Windows.Forms.TextImageRelation)
        Me.SettingsActivityName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SettingsActivityName.CustomButton.UseSelectable = True
        Me.SettingsActivityName.CustomButton.Visible = CType(resources.GetObject("resource.Visible1"), Boolean)
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
        resources.ApplyResources(Me.SettingsActivityDescription, "SettingsActivityDescription")
        '
        '
        '
        Me.SettingsActivityDescription.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription2")
        Me.SettingsActivityDescription.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName2")
        Me.SettingsActivityDescription.CustomButton.Anchor = CType(resources.GetObject("resource.Anchor2"), System.Windows.Forms.AnchorStyles)
        Me.SettingsActivityDescription.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize2"), Boolean)
        Me.SettingsActivityDescription.CustomButton.AutoSizeMode = CType(resources.GetObject("resource.AutoSizeMode2"), System.Windows.Forms.AutoSizeMode)
        Me.SettingsActivityDescription.CustomButton.BackgroundImage = CType(resources.GetObject("resource.BackgroundImage2"), System.Drawing.Image)
        Me.SettingsActivityDescription.CustomButton.BackgroundImageLayout = CType(resources.GetObject("resource.BackgroundImageLayout2"), System.Windows.Forms.ImageLayout)
        Me.SettingsActivityDescription.CustomButton.Dock = CType(resources.GetObject("resource.Dock2"), System.Windows.Forms.DockStyle)
        Me.SettingsActivityDescription.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle2"), System.Windows.Forms.FlatStyle)
        Me.SettingsActivityDescription.CustomButton.Font = CType(resources.GetObject("resource.Font2"), System.Drawing.Font)
        Me.SettingsActivityDescription.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.SettingsActivityDescription.CustomButton.ImageAlign = CType(resources.GetObject("resource.ImageAlign2"), System.Drawing.ContentAlignment)
        Me.SettingsActivityDescription.CustomButton.ImageIndex = CType(resources.GetObject("resource.ImageIndex2"), Integer)
        Me.SettingsActivityDescription.CustomButton.ImageKey = resources.GetString("resource.ImageKey2")
        Me.SettingsActivityDescription.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode2"), System.Windows.Forms.ImeMode)
        Me.SettingsActivityDescription.CustomButton.Location = CType(resources.GetObject("resource.Location2"), System.Drawing.Point)
        Me.SettingsActivityDescription.CustomButton.MaximumSize = CType(resources.GetObject("resource.MaximumSize2"), System.Drawing.Size)
        Me.SettingsActivityDescription.CustomButton.Name = ""
        Me.SettingsActivityDescription.CustomButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft2"), System.Windows.Forms.RightToLeft)
        Me.SettingsActivityDescription.CustomButton.Size = CType(resources.GetObject("resource.Size2"), System.Drawing.Size)
        Me.SettingsActivityDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SettingsActivityDescription.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex2"), Integer)
        Me.SettingsActivityDescription.CustomButton.TextAlign = CType(resources.GetObject("resource.TextAlign2"), System.Drawing.ContentAlignment)
        Me.SettingsActivityDescription.CustomButton.TextImageRelation = CType(resources.GetObject("resource.TextImageRelation2"), System.Windows.Forms.TextImageRelation)
        Me.SettingsActivityDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SettingsActivityDescription.CustomButton.UseSelectable = True
        Me.SettingsActivityDescription.CustomButton.Visible = CType(resources.GetObject("resource.Visible2"), Boolean)
        Me.SettingsActivityDescription.Lines = New String(-1) {}
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
        resources.ApplyResources(Me.ActivityListBox, "ActivityListBox")
        Me.ActivityListBox.FormattingEnabled = True
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
