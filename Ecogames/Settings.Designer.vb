<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.ActivityListBox = New System.Windows.Forms.ListBox()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.DeleteActivity = New MetroFramework.Controls.MetroButton()
        Me.ModifyActivity = New MetroFramework.Controls.MetroButton()
        Me.AddActivity = New MetroFramework.Controls.MetroButton()
        Me.SettingsActivityName = New MetroFramework.Controls.MetroTextBox()
        Me.Label10 = New MetroFramework.Controls.MetroLabel()
        Me.SettingsActivityType = New MetroFramework.Controls.MetroComboBox()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.SettingsActivityDescription = New MetroFramework.Controls.MetroTextBox()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.UserRepCust3Btn = New MetroFramework.Controls.MetroButton()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.UserRepCust2Btn = New MetroFramework.Controls.MetroButton()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.UserRepCust1Btn = New MetroFramework.Controls.MetroButton()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.UserRepRegularColorBtn = New MetroFramework.Controls.MetroButton()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.UserRepWrongColorBtn = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UserRepOkColorBtn = New MetroFramework.Controls.MetroButton()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ActivityListBox
        '
        Me.ActivityListBox.FormattingEnabled = True
        Me.ActivityListBox.Location = New System.Drawing.Point(0, 6)
        Me.ActivityListBox.Name = "ActivityListBox"
        Me.ActivityListBox.Size = New System.Drawing.Size(333, 134)
        Me.ActivityListBox.TabIndex = 0
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(20, 60)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 1
        Me.MetroTabControl1.Size = New System.Drawing.Size(347, 333)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.DeleteActivity)
        Me.MetroTabPage1.Controls.Add(Me.ModifyActivity)
        Me.MetroTabPage1.Controls.Add(Me.AddActivity)
        Me.MetroTabPage1.Controls.Add(Me.SettingsActivityName)
        Me.MetroTabPage1.Controls.Add(Me.Label10)
        Me.MetroTabPage1.Controls.Add(Me.SettingsActivityType)
        Me.MetroTabPage1.Controls.Add(Me.Label9)
        Me.MetroTabPage1.Controls.Add(Me.SettingsActivityDescription)
        Me.MetroTabPage1.Controls.Add(Me.Label8)
        Me.MetroTabPage1.Controls.Add(Me.ActivityListBox)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(339, 291)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Actividades"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'DeleteActivity
        '
        Me.DeleteActivity.Location = New System.Drawing.Point(135, 264)
        Me.DeleteActivity.Name = "DeleteActivity"
        Me.DeleteActivity.Size = New System.Drawing.Size(96, 23)
        Me.DeleteActivity.TabIndex = 4
        Me.DeleteActivity.Text = "Eliminar"
        Me.DeleteActivity.UseSelectable = True
        Me.DeleteActivity.Visible = False
        '
        'ModifyActivity
        '
        Me.ModifyActivity.Location = New System.Drawing.Point(237, 264)
        Me.ModifyActivity.Name = "ModifyActivity"
        Me.ModifyActivity.Size = New System.Drawing.Size(96, 23)
        Me.ModifyActivity.TabIndex = 5
        Me.ModifyActivity.Text = "Modificar"
        Me.ModifyActivity.UseSelectable = True
        Me.ModifyActivity.Visible = False
        '
        'AddActivity
        '
        Me.AddActivity.Enabled = False
        Me.AddActivity.Location = New System.Drawing.Point(237, 264)
        Me.AddActivity.Name = "AddActivity"
        Me.AddActivity.Size = New System.Drawing.Size(96, 23)
        Me.AddActivity.TabIndex = 33
        Me.AddActivity.Text = "Añadir"
        Me.AddActivity.UseSelectable = True
        '
        'SettingsActivityName
        '
        '
        '
        '
        Me.SettingsActivityName.CustomButton.Image = Nothing
        Me.SettingsActivityName.CustomButton.Location = New System.Drawing.Point(197, 1)
        Me.SettingsActivityName.CustomButton.Name = ""
        Me.SettingsActivityName.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.SettingsActivityName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SettingsActivityName.CustomButton.TabIndex = 1
        Me.SettingsActivityName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SettingsActivityName.CustomButton.UseSelectable = True
        Me.SettingsActivityName.CustomButton.Visible = False
        Me.SettingsActivityName.Enabled = False
        Me.SettingsActivityName.Lines = New String(-1) {}
        Me.SettingsActivityName.Location = New System.Drawing.Point(108, 146)
        Me.SettingsActivityName.MaxLength = 32767
        Me.SettingsActivityName.Name = "SettingsActivityName"
        Me.SettingsActivityName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SettingsActivityName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SettingsActivityName.SelectedText = ""
        Me.SettingsActivityName.SelectionLength = 0
        Me.SettingsActivityName.SelectionStart = 0
        Me.SettingsActivityName.ShortcutsEnabled = True
        Me.SettingsActivityName.Size = New System.Drawing.Size(225, 29)
        Me.SettingsActivityName.TabIndex = 1
        Me.SettingsActivityName.UseSelectable = True
        Me.SettingsActivityName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SettingsActivityName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(0, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 29)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Nombre: "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SettingsActivityType
        '
        Me.SettingsActivityType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SettingsActivityType.Enabled = False
        Me.SettingsActivityType.FormattingEnabled = True
        Me.SettingsActivityType.ItemHeight = 23
        Me.SettingsActivityType.Location = New System.Drawing.Point(108, 181)
        Me.SettingsActivityType.Name = "SettingsActivityType"
        Me.SettingsActivityType.Size = New System.Drawing.Size(225, 29)
        Me.SettingsActivityType.TabIndex = 2
        Me.SettingsActivityType.UseSelectable = True
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(0, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 29)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Tipo:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SettingsActivityDescription
        '
        '
        '
        '
        Me.SettingsActivityDescription.CustomButton.Image = Nothing
        Me.SettingsActivityDescription.CustomButton.Location = New System.Drawing.Point(185, 2)
        Me.SettingsActivityDescription.CustomButton.Name = ""
        Me.SettingsActivityDescription.CustomButton.Size = New System.Drawing.Size(37, 37)
        Me.SettingsActivityDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SettingsActivityDescription.CustomButton.TabIndex = 1
        Me.SettingsActivityDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SettingsActivityDescription.CustomButton.UseSelectable = True
        Me.SettingsActivityDescription.CustomButton.Visible = False
        Me.SettingsActivityDescription.Enabled = False
        Me.SettingsActivityDescription.Lines = New String(-1) {}
        Me.SettingsActivityDescription.Location = New System.Drawing.Point(108, 216)
        Me.SettingsActivityDescription.MaxLength = 32767
        Me.SettingsActivityDescription.Multiline = True
        Me.SettingsActivityDescription.Name = "SettingsActivityDescription"
        Me.SettingsActivityDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SettingsActivityDescription.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SettingsActivityDescription.SelectedText = ""
        Me.SettingsActivityDescription.SelectionLength = 0
        Me.SettingsActivityDescription.SelectionStart = 0
        Me.SettingsActivityDescription.ShortcutsEnabled = True
        Me.SettingsActivityDescription.Size = New System.Drawing.Size(225, 42)
        Me.SettingsActivityDescription.TabIndex = 3
        Me.SettingsActivityDescription.UseSelectable = True
        Me.SettingsActivityDescription.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SettingsActivityDescription.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(0, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Descripción:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.Label6)
        Me.MetroTabPage2.Controls.Add(Me.Panel8)
        Me.MetroTabPage2.Controls.Add(Me.UserRepCust3Btn)
        Me.MetroTabPage2.Controls.Add(Me.Label5)
        Me.MetroTabPage2.Controls.Add(Me.Panel7)
        Me.MetroTabPage2.Controls.Add(Me.UserRepCust2Btn)
        Me.MetroTabPage2.Controls.Add(Me.Label4)
        Me.MetroTabPage2.Controls.Add(Me.Panel6)
        Me.MetroTabPage2.Controls.Add(Me.UserRepCust1Btn)
        Me.MetroTabPage2.Controls.Add(Me.Label3)
        Me.MetroTabPage2.Controls.Add(Me.Panel5)
        Me.MetroTabPage2.Controls.Add(Me.UserRepRegularColorBtn)
        Me.MetroTabPage2.Controls.Add(Me.Label2)
        Me.MetroTabPage2.Controls.Add(Me.Panel4)
        Me.MetroTabPage2.Controls.Add(Me.UserRepWrongColorBtn)
        Me.MetroTabPage2.Controls.Add(Me.Label1)
        Me.MetroTabPage2.Controls.Add(Me.Panel3)
        Me.MetroTabPage2.Controls.Add(Me.UserRepOkColorBtn)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(339, 291)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Respuestas"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(0, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(208, 23)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Personalizado 3:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Location = New System.Drawing.Point(214, 199)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(23, 23)
        Me.Panel8.TabIndex = 35
        '
        'UserRepCust3Btn
        '
        Me.UserRepCust3Btn.Location = New System.Drawing.Point(243, 199)
        Me.UserRepCust3Btn.Name = "UserRepCust3Btn"
        Me.UserRepCust3Btn.Size = New System.Drawing.Size(96, 23)
        Me.UserRepCust3Btn.TabIndex = 5
        Me.UserRepCust3Btn.Text = "Cambiar"
        Me.UserRepCust3Btn.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(0, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 23)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Personalizado 2:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Location = New System.Drawing.Point(214, 161)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(23, 23)
        Me.Panel7.TabIndex = 32
        '
        'UserRepCust2Btn
        '
        Me.UserRepCust2Btn.Location = New System.Drawing.Point(243, 161)
        Me.UserRepCust2Btn.Name = "UserRepCust2Btn"
        Me.UserRepCust2Btn.Size = New System.Drawing.Size(96, 23)
        Me.UserRepCust2Btn.TabIndex = 4
        Me.UserRepCust2Btn.Text = "Cambiar"
        Me.UserRepCust2Btn.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 23)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Personalizado 1:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(214, 123)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(23, 23)
        Me.Panel6.TabIndex = 29
        '
        'UserRepCust1Btn
        '
        Me.UserRepCust1Btn.Location = New System.Drawing.Point(243, 123)
        Me.UserRepCust1Btn.Name = "UserRepCust1Btn"
        Me.UserRepCust1Btn.Size = New System.Drawing.Size(96, 23)
        Me.UserRepCust1Btn.TabIndex = 3
        Me.UserRepCust1Btn.Text = "Cambiar"
        Me.UserRepCust1Btn.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(0, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 23)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Regular:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(214, 85)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(23, 23)
        Me.Panel5.TabIndex = 26
        '
        'UserRepRegularColorBtn
        '
        Me.UserRepRegularColorBtn.Location = New System.Drawing.Point(243, 85)
        Me.UserRepRegularColorBtn.Name = "UserRepRegularColorBtn"
        Me.UserRepRegularColorBtn.Size = New System.Drawing.Size(96, 23)
        Me.UserRepRegularColorBtn.TabIndex = 2
        Me.UserRepRegularColorBtn.Text = "Cambiar"
        Me.UserRepRegularColorBtn.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Incorrecta:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(214, 47)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(23, 23)
        Me.Panel4.TabIndex = 23
        '
        'UserRepWrongColorBtn
        '
        Me.UserRepWrongColorBtn.Location = New System.Drawing.Point(243, 47)
        Me.UserRepWrongColorBtn.Name = "UserRepWrongColorBtn"
        Me.UserRepWrongColorBtn.Size = New System.Drawing.Size(96, 23)
        Me.UserRepWrongColorBtn.TabIndex = 1
        Me.UserRepWrongColorBtn.Text = "Cambiar"
        Me.UserRepWrongColorBtn.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 23)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Correcta: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(214, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(23, 23)
        Me.Panel3.TabIndex = 20
        '
        'UserRepOkColorBtn
        '
        Me.UserRepOkColorBtn.Location = New System.Drawing.Point(243, 9)
        Me.UserRepOkColorBtn.Name = "UserRepOkColorBtn"
        Me.UserRepOkColorBtn.Size = New System.Drawing.Size(96, 23)
        Me.UserRepOkColorBtn.TabIndex = 0
        Me.UserRepOkColorBtn.Text = "Cambiar"
        Me.UserRepOkColorBtn.UseSelectable = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 413)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Settings"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Configuración"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ActivityListBox As ListBox
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents DeleteActivity As MetroFramework.Controls.MetroButton
    Friend WithEvents ModifyActivity As MetroFramework.Controls.MetroButton
    Friend WithEvents AddActivity As MetroFramework.Controls.MetroButton
    Friend WithEvents SettingsActivityName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SettingsActivityType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SettingsActivityDescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents UserRepCust3Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents Label5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents UserRepCust2Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents Label4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents UserRepCust1Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents UserRepRegularColorBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents UserRepWrongColorBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents UserRepOkColorBtn As MetroFramework.Controls.MetroButton
End Class
