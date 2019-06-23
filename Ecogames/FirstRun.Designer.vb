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
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.PasswordTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.PasswordVerifyTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.Button2 = New MetroFramework.Controls.MetroButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UsernameTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(20, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Para continuar, regístrese."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(20, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Contraseña: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(20, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Repetir contraseña: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordTextBox
        '
        '
        '
        '
        Me.PasswordTextBox.CustomButton.Image = Nothing
        Me.PasswordTextBox.CustomButton.Location = New System.Drawing.Point(173, 2)
        Me.PasswordTextBox.CustomButton.Name = ""
        Me.PasswordTextBox.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.PasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PasswordTextBox.CustomButton.TabIndex = 1
        Me.PasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PasswordTextBox.CustomButton.UseSelectable = True
        Me.PasswordTextBox.CustomButton.Visible = False
        Me.PasswordTextBox.Lines = New String(-1) {}
        Me.PasswordTextBox.Location = New System.Drawing.Point(169, 134)
        Me.PasswordTextBox.MaxLength = 64
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PasswordTextBox.SelectedText = ""
        Me.PasswordTextBox.SelectionLength = 0
        Me.PasswordTextBox.SelectionStart = 0
        Me.PasswordTextBox.ShortcutsEnabled = True
        Me.PasswordTextBox.Size = New System.Drawing.Size(191, 20)
        Me.PasswordTextBox.TabIndex = 1
        Me.PasswordTextBox.UseSelectable = True
        Me.PasswordTextBox.UseSystemPasswordChar = True
        Me.PasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PasswordTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PasswordVerifyTextBox
        '
        '
        '
        '
        Me.PasswordVerifyTextBox.CustomButton.Image = Nothing
        Me.PasswordVerifyTextBox.CustomButton.Location = New System.Drawing.Point(173, 2)
        Me.PasswordVerifyTextBox.CustomButton.Name = ""
        Me.PasswordVerifyTextBox.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.PasswordVerifyTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PasswordVerifyTextBox.CustomButton.TabIndex = 1
        Me.PasswordVerifyTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PasswordVerifyTextBox.CustomButton.UseSelectable = True
        Me.PasswordVerifyTextBox.CustomButton.Visible = False
        Me.PasswordVerifyTextBox.Lines = New String(-1) {}
        Me.PasswordVerifyTextBox.Location = New System.Drawing.Point(169, 160)
        Me.PasswordVerifyTextBox.MaxLength = 64
        Me.PasswordVerifyTextBox.Name = "PasswordVerifyTextBox"
        Me.PasswordVerifyTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordVerifyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PasswordVerifyTextBox.SelectedText = ""
        Me.PasswordVerifyTextBox.SelectionLength = 0
        Me.PasswordVerifyTextBox.SelectionStart = 0
        Me.PasswordVerifyTextBox.ShortcutsEnabled = True
        Me.PasswordVerifyTextBox.Size = New System.Drawing.Size(191, 20)
        Me.PasswordVerifyTextBox.TabIndex = 2
        Me.PasswordVerifyTextBox.UseSelectable = True
        Me.PasswordVerifyTextBox.UseSystemPasswordChar = True
        Me.PasswordVerifyTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PasswordVerifyTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(106, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Continuar"
        Me.Button1.UseSelectable = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(206, 200)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Location = New System.Drawing.Point(366, 134)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(20, 20)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Location = New System.Drawing.Point(366, 160)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(20, 20)
        Me.Panel2.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Red
        Me.Panel3.Location = New System.Drawing.Point(366, 108)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(20, 20)
        Me.Panel3.TabIndex = 16
        '
        'UsernameTextBox
        '
        '
        '
        '
        Me.UsernameTextBox.CustomButton.Image = Nothing
        Me.UsernameTextBox.CustomButton.Location = New System.Drawing.Point(173, 2)
        Me.UsernameTextBox.CustomButton.Name = ""
        Me.UsernameTextBox.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.UsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UsernameTextBox.CustomButton.TabIndex = 1
        Me.UsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UsernameTextBox.CustomButton.UseSelectable = True
        Me.UsernameTextBox.CustomButton.Visible = False
        Me.UsernameTextBox.Lines = New String(-1) {}
        Me.UsernameTextBox.Location = New System.Drawing.Point(169, 108)
        Me.UsernameTextBox.MaxLength = 35
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UsernameTextBox.SelectedText = ""
        Me.UsernameTextBox.SelectionLength = 0
        Me.UsernameTextBox.SelectionStart = 0
        Me.UsernameTextBox.ShortcutsEnabled = True
        Me.UsernameTextBox.Size = New System.Drawing.Size(191, 20)
        Me.UsernameTextBox.TabIndex = 0
        Me.UsernameTextBox.UseSelectable = True
        Me.UsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UsernameTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(20, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nombre:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FirstRun
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(410, 239)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PasswordVerifyTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FirstRun"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Primer inicio"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PasswordTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PasswordVerifyTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents UsernameTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Button1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Button2 As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
End Class
