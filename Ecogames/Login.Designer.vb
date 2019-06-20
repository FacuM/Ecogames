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
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.PasswordTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.ContinueButton = New MetroFramework.Controls.MetroButton()
        Me.QuitButton = New MetroFramework.Controls.MetroButton()
        Me.PasswordStatusPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(20, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Para continuar, ingresá tu contraseña."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(23, 108)
        Me.PasswordTextBox.MaxLength = 64
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(203, 20)
        Me.PasswordTextBox.TabIndex = 1
        '
        'ContinueButton
        '
        Me.ContinueButton.Enabled = False
        Me.ContinueButton.Location = New System.Drawing.Point(59, 147)
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.Size = New System.Drawing.Size(93, 23)
        Me.ContinueButton.TabIndex = 3
        Me.ContinueButton.Text = "Continuar"
        '
        'QuitButton
        '
        Me.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.QuitButton.Location = New System.Drawing.Point(159, 147)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(93, 23)
        Me.QuitButton.TabIndex = 4
        Me.QuitButton.Text = "Salir"
        '
        'PasswordStatusPanel
        '
        Me.PasswordStatusPanel.BackColor = System.Drawing.Color.Red
        Me.PasswordStatusPanel.Location = New System.Drawing.Point(232, 108)
        Me.PasswordStatusPanel.Name = "PasswordStatusPanel"
        Me.PasswordStatusPanel.Size = New System.Drawing.Size(20, 20)
        Me.PasswordStatusPanel.TabIndex = 13
        '
        'Login
        '
        Me.AcceptButton = Me.ContinueButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.QuitButton
        Me.ClientSize = New System.Drawing.Size(272, 193)
        Me.Controls.Add(Me.PasswordStatusPanel)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.ContinueButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.Resizable = False
        Me.Text = "Iniciá sesión"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PasswordTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ContinueButton As MetroFramework.Controls.MetroButton
    Friend WithEvents QuitButton As MetroFramework.Controls.MetroButton
    Friend WithEvents PasswordStatusPanel As System.Windows.Forms.Panel
End Class
