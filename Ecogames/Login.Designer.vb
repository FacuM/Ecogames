<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.HelperLabel = New MetroFramework.Controls.MetroLabel()
        Me.PasswordTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.ContinueButton = New MetroFramework.Controls.MetroButton()
        Me.QuitButton = New MetroFramework.Controls.MetroButton()
        Me.PasswordStatusPanel = New System.Windows.Forms.Panel()
        Me.ForgotPasswordLink = New MetroFramework.Controls.MetroLink()
        Me.SuspendLayout()
        '
        'HelperLabel
        '
        resources.ApplyResources(Me.HelperLabel, "HelperLabel")
        Me.HelperLabel.Name = "HelperLabel"
        Me.HelperLabel.WrapToLine = True
        '
        'PasswordTextBox
        '
        resources.ApplyResources(Me.PasswordTextBox, "PasswordTextBox")
        '
        '
        '
        Me.PasswordTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription")
        Me.PasswordTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName")
        Me.PasswordTextBox.CustomButton.Anchor = CType(resources.GetObject("resource.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.PasswordTextBox.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize"), Boolean)
        Me.PasswordTextBox.CustomButton.AutoSizeMode = CType(resources.GetObject("resource.AutoSizeMode"), System.Windows.Forms.AutoSizeMode)
        Me.PasswordTextBox.CustomButton.BackgroundImage = CType(resources.GetObject("resource.BackgroundImage"), System.Drawing.Image)
        Me.PasswordTextBox.CustomButton.BackgroundImageLayout = CType(resources.GetObject("resource.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.PasswordTextBox.CustomButton.Dock = CType(resources.GetObject("resource.Dock"), System.Windows.Forms.DockStyle)
        Me.PasswordTextBox.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.PasswordTextBox.CustomButton.Font = CType(resources.GetObject("resource.Font"), System.Drawing.Font)
        Me.PasswordTextBox.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.PasswordTextBox.CustomButton.ImageAlign = CType(resources.GetObject("resource.ImageAlign"), System.Drawing.ContentAlignment)
        Me.PasswordTextBox.CustomButton.ImageIndex = CType(resources.GetObject("resource.ImageIndex"), Integer)
        Me.PasswordTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey")
        Me.PasswordTextBox.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode"), System.Windows.Forms.ImeMode)
        Me.PasswordTextBox.CustomButton.Location = CType(resources.GetObject("resource.Location"), System.Drawing.Point)
        Me.PasswordTextBox.CustomButton.MaximumSize = CType(resources.GetObject("resource.MaximumSize"), System.Drawing.Size)
        Me.PasswordTextBox.CustomButton.Name = ""
        Me.PasswordTextBox.CustomButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.PasswordTextBox.CustomButton.Size = CType(resources.GetObject("resource.Size"), System.Drawing.Size)
        Me.PasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PasswordTextBox.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex"), Integer)
        Me.PasswordTextBox.CustomButton.TextAlign = CType(resources.GetObject("resource.TextAlign"), System.Drawing.ContentAlignment)
        Me.PasswordTextBox.CustomButton.TextImageRelation = CType(resources.GetObject("resource.TextImageRelation"), System.Windows.Forms.TextImageRelation)
        Me.PasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PasswordTextBox.CustomButton.UseSelectable = True
        Me.PasswordTextBox.CustomButton.Visible = CType(resources.GetObject("resource.Visible"), Boolean)
        Me.PasswordTextBox.Lines = New String(-1) {}
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
        'ContinueButton
        '
        resources.ApplyResources(Me.ContinueButton, "ContinueButton")
        Me.ContinueButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.UseSelectable = True
        '
        'QuitButton
        '
        resources.ApplyResources(Me.QuitButton, "QuitButton")
        Me.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.UseSelectable = True
        '
        'PasswordStatusPanel
        '
        resources.ApplyResources(Me.PasswordStatusPanel, "PasswordStatusPanel")
        Me.PasswordStatusPanel.BackColor = System.Drawing.Color.Red
        Me.PasswordStatusPanel.Name = "PasswordStatusPanel"
        '
        'ForgotPasswordLink
        '
        resources.ApplyResources(Me.ForgotPasswordLink, "ForgotPasswordLink")
        Me.ForgotPasswordLink.Name = "ForgotPasswordLink"
        Me.ForgotPasswordLink.UseSelectable = True
        '
        'Login
        '
        Me.AcceptButton = Me.ContinueButton
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.QuitButton
        Me.Controls.Add(Me.ForgotPasswordLink)
        Me.Controls.Add(Me.PasswordStatusPanel)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.ContinueButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.HelperLabel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PasswordTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents HelperLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents ContinueButton As MetroFramework.Controls.MetroButton
    Friend WithEvents QuitButton As MetroFramework.Controls.MetroButton
    Friend WithEvents PasswordStatusPanel As System.Windows.Forms.Panel
    Friend WithEvents ForgotPasswordLink As MetroFramework.Controls.MetroLink
End Class
