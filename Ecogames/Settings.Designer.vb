﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DeleteActivity = New MetroFramework.Controls.MetroButton()
        Me.ModifyActivity = New MetroFramework.Controls.MetroButton()
        Me.AddActivity = New MetroFramework.Controls.MetroButton()
        Me.SettingsActivityName = New MetroFramework.Controls.MetroTextBox()
        Me.Label10 = New MetroFramework.Controls.MetroLabel()
        Me.SettingsActivityType = New MetroFramework.Controls.MetroComboBox()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.SettingsActivityDescription = New MetroFramework.Controls.MetroTextBox()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.ActivityListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.DeleteActivity)
        Me.GroupBox2.Controls.Add(Me.ModifyActivity)
        Me.GroupBox2.Controls.Add(Me.AddActivity)
        Me.GroupBox2.Controls.Add(Me.SettingsActivityName)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.SettingsActivityType)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.SettingsActivityDescription)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ActivityListBox)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(20, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(347, 305)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actividades"
        '
        'DeleteActivity
        '
        Me.DeleteActivity.Location = New System.Drawing.Point(137, 278)
        Me.DeleteActivity.Name = "DeleteActivity"
        Me.DeleteActivity.Size = New System.Drawing.Size(96, 23)
        Me.DeleteActivity.TabIndex = 26
        Me.DeleteActivity.Text = "Eliminar"
        Me.DeleteActivity.Visible = False
        '
        'ModifyActivity
        '
        Me.ModifyActivity.Location = New System.Drawing.Point(239, 278)
        Me.ModifyActivity.Name = "ModifyActivity"
        Me.ModifyActivity.Size = New System.Drawing.Size(96, 23)
        Me.ModifyActivity.TabIndex = 25
        Me.ModifyActivity.Text = "Modificar"
        Me.ModifyActivity.Visible = False
        '
        'AddActivity
        '
        Me.AddActivity.Enabled = False
        Me.AddActivity.Location = New System.Drawing.Point(239, 278)
        Me.AddActivity.Name = "AddActivity"
        Me.AddActivity.Size = New System.Drawing.Size(96, 23)
        Me.AddActivity.TabIndex = 24
        Me.AddActivity.Text = "Añadir"
        '
        'SettingsActivityName
        '
        Me.SettingsActivityName.Enabled = False
        Me.SettingsActivityName.Location = New System.Drawing.Point(114, 160)
        Me.SettingsActivityName.Name = "SettingsActivityName"
        Me.SettingsActivityName.Size = New System.Drawing.Size(221, 29)
        Me.SettingsActivityName.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 29)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Nombre: "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SettingsActivityType
        '
        Me.SettingsActivityType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SettingsActivityType.Enabled = False
        Me.SettingsActivityType.FormattingEnabled = True
        Me.SettingsActivityType.ItemHeight = 23
        Me.SettingsActivityType.Location = New System.Drawing.Point(114, 195)
        Me.SettingsActivityType.Name = "SettingsActivityType"
        Me.SettingsActivityType.Size = New System.Drawing.Size(221, 29)
        Me.SettingsActivityType.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 29)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Tipo:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SettingsActivityDescription
        '
        Me.SettingsActivityDescription.Enabled = False
        Me.SettingsActivityDescription.Location = New System.Drawing.Point(114, 230)
        Me.SettingsActivityDescription.Multiline = True
        Me.SettingsActivityDescription.Name = "SettingsActivityDescription"
        Me.SettingsActivityDescription.Size = New System.Drawing.Size(221, 42)
        Me.SettingsActivityDescription.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 224)
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
        Me.ActivityListBox.Size = New System.Drawing.Size(326, 134)
        Me.ActivityListBox.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Panel8)
        Me.GroupBox1.Controls.Add(Me.UserRepCust3Btn)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Panel7)
        Me.GroupBox1.Controls.Add(Me.UserRepCust2Btn)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Panel6)
        Me.GroupBox1.Controls.Add(Me.UserRepCust1Btn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.UserRepRegularColorBtn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.UserRepWrongColorBtn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.UserRepOkColorBtn)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(20, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 191)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Colores de respuesta"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 23)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Personalizado 3:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Location = New System.Drawing.Point(210, 161)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(23, 23)
        Me.Panel8.TabIndex = 17
        '
        'UserRepCust3Btn
        '
        Me.UserRepCust3Btn.Location = New System.Drawing.Point(239, 161)
        Me.UserRepCust3Btn.Name = "UserRepCust3Btn"
        Me.UserRepCust3Btn.Size = New System.Drawing.Size(96, 23)
        Me.UserRepCust3Btn.TabIndex = 15
        Me.UserRepCust3Btn.Text = "Cambiar"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Personalizado 2:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Location = New System.Drawing.Point(210, 132)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(23, 23)
        Me.Panel7.TabIndex = 14
        '
        'UserRepCust2Btn
        '
        Me.UserRepCust2Btn.Location = New System.Drawing.Point(239, 132)
        Me.UserRepCust2Btn.Name = "UserRepCust2Btn"
        Me.UserRepCust2Btn.Size = New System.Drawing.Size(96, 23)
        Me.UserRepCust2Btn.TabIndex = 12
        Me.UserRepCust2Btn.Text = "Cambiar"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Personalizado 1:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(210, 103)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(23, 23)
        Me.Panel6.TabIndex = 11
        '
        'UserRepCust1Btn
        '
        Me.UserRepCust1Btn.Location = New System.Drawing.Point(239, 103)
        Me.UserRepCust1Btn.Name = "UserRepCust1Btn"
        Me.UserRepCust1Btn.Size = New System.Drawing.Size(96, 23)
        Me.UserRepCust1Btn.TabIndex = 9
        Me.UserRepCust1Btn.Text = "Cambiar"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Regular:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(210, 74)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(23, 23)
        Me.Panel5.TabIndex = 8
        '
        'UserRepRegularColorBtn
        '
        Me.UserRepRegularColorBtn.Location = New System.Drawing.Point(239, 74)
        Me.UserRepRegularColorBtn.Name = "UserRepRegularColorBtn"
        Me.UserRepRegularColorBtn.Size = New System.Drawing.Size(96, 23)
        Me.UserRepRegularColorBtn.TabIndex = 6
        Me.UserRepRegularColorBtn.Text = "Cambiar"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Incorrecta:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(210, 45)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(23, 23)
        Me.Panel4.TabIndex = 5
        '
        'UserRepWrongColorBtn
        '
        Me.UserRepWrongColorBtn.Location = New System.Drawing.Point(239, 45)
        Me.UserRepWrongColorBtn.Name = "UserRepWrongColorBtn"
        Me.UserRepWrongColorBtn.Size = New System.Drawing.Size(96, 23)
        Me.UserRepWrongColorBtn.TabIndex = 3
        Me.UserRepWrongColorBtn.Text = "Cambiar"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Correcta: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(210, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(23, 23)
        Me.Panel3.TabIndex = 2
        '
        'UserRepOkColorBtn
        '
        Me.UserRepOkColorBtn.Location = New System.Drawing.Point(239, 16)
        Me.UserRepOkColorBtn.Name = "UserRepOkColorBtn"
        Me.UserRepOkColorBtn.Size = New System.Drawing.Size(96, 23)
        Me.UserRepOkColorBtn.TabIndex = 0
        Me.UserRepOkColorBtn.Text = "Cambiar"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(387, 576)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Settings"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow
        Me.Text = "Configuración"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DeleteActivity As MetroFramework.Controls.MetroButton
    Friend WithEvents ModifyActivity As MetroFramework.Controls.MetroButton
    Friend WithEvents AddActivity As MetroFramework.Controls.MetroButton
    Friend WithEvents SettingsActivityName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SettingsActivityType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SettingsActivityDescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ActivityListBox As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents UserRepCust3Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents Label5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents UserRepCust2Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents Label4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents UserRepCust1Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents UserRepRegularColorBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UserRepWrongColorBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UserRepOkColorBtn As MetroFramework.Controls.MetroButton
End Class
