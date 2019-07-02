<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirstRun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FirstRun))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.LanguagePickerComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.StatusLabel = New MetroFramework.Controls.MetroLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UsernameTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.QuitButton = New MetroFramework.Controls.MetroButton()
        Me.ContinueButton = New MetroFramework.Controls.MetroButton()
        Me.SecurityWordTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.PasswordVerifyTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.PasswordTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        resources.ApplyResources(Me.MetroLabel1, "MetroLabel1")
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.WrapToLine = True
        '
        'LanguagePickerComboBox
        '
        Me.LanguagePickerComboBox.FormattingEnabled = True
        resources.ApplyResources(Me.LanguagePickerComboBox, "LanguagePickerComboBox")
        Me.LanguagePickerComboBox.Name = "LanguagePickerComboBox"
        Me.LanguagePickerComboBox.UseSelectable = True
        '
        'StatusLabel
        '
        resources.ApplyResources(Me.StatusLabel, "StatusLabel")
        Me.StatusLabel.Name = "StatusLabel"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'UsernameTextBox
        '
        '
        '
        '
        Me.UsernameTextBox.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.UsernameTextBox.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode"), System.Windows.Forms.ImeMode)
        Me.UsernameTextBox.CustomButton.Location = CType(resources.GetObject("resource.Location"), System.Drawing.Point)
        Me.UsernameTextBox.CustomButton.Name = ""
        Me.UsernameTextBox.CustomButton.Size = CType(resources.GetObject("resource.Size"), System.Drawing.Size)
        Me.UsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UsernameTextBox.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex"), Integer)
        Me.UsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UsernameTextBox.CustomButton.UseSelectable = True
        Me.UsernameTextBox.CustomButton.Visible = CType(resources.GetObject("resource.Visible"), Boolean)
        Me.UsernameTextBox.Lines = New String(-1) {}
        resources.ApplyResources(Me.UsernameTextBox, "UsernameTextBox")
        Me.UsernameTextBox.MaxLength = 35
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UsernameTextBox.SelectedText = ""
        Me.UsernameTextBox.SelectionLength = 0
        Me.UsernameTextBox.SelectionStart = 0
        Me.UsernameTextBox.ShortcutsEnabled = True
        Me.UsernameTextBox.UseSelectable = True
        Me.UsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UsernameTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'QuitButton
        '
        Me.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.QuitButton, "QuitButton")
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.UseSelectable = True
        '
        'ContinueButton
        '
        resources.ApplyResources(Me.ContinueButton, "ContinueButton")
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.UseSelectable = True
        '
        'SecurityWordTextBox
        '
        '
        '
        '
        Me.SecurityWordTextBox.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.SecurityWordTextBox.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode1"), System.Windows.Forms.ImeMode)
        Me.SecurityWordTextBox.CustomButton.Location = CType(resources.GetObject("resource.Location1"), System.Drawing.Point)
        Me.SecurityWordTextBox.CustomButton.Name = ""
        Me.SecurityWordTextBox.CustomButton.Size = CType(resources.GetObject("resource.Size1"), System.Drawing.Size)
        Me.SecurityWordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SecurityWordTextBox.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex1"), Integer)
        Me.SecurityWordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SecurityWordTextBox.CustomButton.UseSelectable = True
        Me.SecurityWordTextBox.CustomButton.Visible = CType(resources.GetObject("resource.Visible1"), Boolean)
        Me.SecurityWordTextBox.Lines = New String(-1) {}
        resources.ApplyResources(Me.SecurityWordTextBox, "SecurityWordTextBox")
        Me.SecurityWordTextBox.MaxLength = 64
        Me.SecurityWordTextBox.Name = "SecurityWordTextBox"
        Me.SecurityWordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.SecurityWordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SecurityWordTextBox.SelectedText = ""
        Me.SecurityWordTextBox.SelectionLength = 0
        Me.SecurityWordTextBox.SelectionStart = 0
        Me.SecurityWordTextBox.ShortcutsEnabled = True
        Me.SecurityWordTextBox.UseSelectable = True
        Me.SecurityWordTextBox.UseSystemPasswordChar = True
        Me.SecurityWordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SecurityWordTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PasswordVerifyTextBox
        '
        '
        '
        '
        Me.PasswordVerifyTextBox.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.PasswordVerifyTextBox.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode2"), System.Windows.Forms.ImeMode)
        Me.PasswordVerifyTextBox.CustomButton.Location = CType(resources.GetObject("resource.Location2"), System.Drawing.Point)
        Me.PasswordVerifyTextBox.CustomButton.Name = ""
        Me.PasswordVerifyTextBox.CustomButton.Size = CType(resources.GetObject("resource.Size2"), System.Drawing.Size)
        Me.PasswordVerifyTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PasswordVerifyTextBox.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex2"), Integer)
        Me.PasswordVerifyTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PasswordVerifyTextBox.CustomButton.UseSelectable = True
        Me.PasswordVerifyTextBox.CustomButton.Visible = CType(resources.GetObject("resource.Visible2"), Boolean)
        Me.PasswordVerifyTextBox.Lines = New String(-1) {}
        resources.ApplyResources(Me.PasswordVerifyTextBox, "PasswordVerifyTextBox")
        Me.PasswordVerifyTextBox.MaxLength = 64
        Me.PasswordVerifyTextBox.Name = "PasswordVerifyTextBox"
        Me.PasswordVerifyTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordVerifyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PasswordVerifyTextBox.SelectedText = ""
        Me.PasswordVerifyTextBox.SelectionLength = 0
        Me.PasswordVerifyTextBox.SelectionStart = 0
        Me.PasswordVerifyTextBox.ShortcutsEnabled = True
        Me.PasswordVerifyTextBox.UseSelectable = True
        Me.PasswordVerifyTextBox.UseSystemPasswordChar = True
        Me.PasswordVerifyTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PasswordVerifyTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PasswordTextBox
        '
        '
        '
        '
        Me.PasswordTextBox.CustomButton.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.PasswordTextBox.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode3"), System.Windows.Forms.ImeMode)
        Me.PasswordTextBox.CustomButton.Location = CType(resources.GetObject("resource.Location3"), System.Drawing.Point)
        Me.PasswordTextBox.CustomButton.Name = ""
        Me.PasswordTextBox.CustomButton.Size = CType(resources.GetObject("resource.Size3"), System.Drawing.Size)
        Me.PasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PasswordTextBox.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex3"), Integer)
        Me.PasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PasswordTextBox.CustomButton.UseSelectable = True
        Me.PasswordTextBox.CustomButton.Visible = CType(resources.GetObject("resource.Visible3"), Boolean)
        Me.PasswordTextBox.Lines = New String(-1) {}
        resources.ApplyResources(Me.PasswordTextBox, "PasswordTextBox")
        Me.PasswordTextBox.MaxLength = 64
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PasswordTextBox.SelectedText = ""
        Me.PasswordTextBox.SelectionLength = 0
        Me.PasswordTextBox.SelectionStart = 0
        Me.PasswordTextBox.ShortcutsEnabled = True
        Me.PasswordTextBox.UseSelectable = True
        Me.PasswordTextBox.UseSystemPasswordChar = True
        Me.PasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PasswordTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        resources.ApplyResources(Me.MetroLabel2, "MetroLabel2")
        Me.MetroLabel2.Name = "MetroLabel2"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'FirstRun
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.LanguagePickerComboBox)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.ContinueButton)
        Me.Controls.Add(Me.SecurityWordTextBox)
        Me.Controls.Add(Me.PasswordVerifyTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FirstRun"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LanguagePickerComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents StatusLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents UsernameTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents QuitButton As MetroFramework.Controls.MetroButton
    Friend WithEvents ContinueButton As MetroFramework.Controls.MetroButton
    Friend WithEvents SecurityWordTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PasswordVerifyTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PasswordTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
End Class
