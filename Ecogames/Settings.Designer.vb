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
        Me.RefreshButton = New MetroFramework.Controls.MetroButton()
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
        resources.ApplyResources(Me.ActivityListBox, "ActivityListBox")
        Me.ActivityListBox.Name = "ActivityListBox"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        resources.ApplyResources(Me.MetroTabControl1, "MetroTabControl1")
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.RefreshButton)
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
        resources.ApplyResources(Me.MetroTabPage1, "MetroTabPage1")
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'RefreshButton
        '
        resources.ApplyResources(Me.RefreshButton, "RefreshButton")
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.UseSelectable = True
        '
        'DeleteActivity
        '
        resources.ApplyResources(Me.DeleteActivity, "DeleteActivity")
        Me.DeleteActivity.Name = "DeleteActivity"
        Me.DeleteActivity.UseSelectable = True
        '
        'ModifyActivity
        '
        resources.ApplyResources(Me.ModifyActivity, "ModifyActivity")
        Me.ModifyActivity.Name = "ModifyActivity"
        Me.ModifyActivity.UseSelectable = True
        '
        'AddActivity
        '
        resources.ApplyResources(Me.AddActivity, "AddActivity")
        Me.AddActivity.Name = "AddActivity"
        Me.AddActivity.UseSelectable = True
        '
        'SettingsActivityName
        '
        '
        '
        '
        Me.SettingsActivityName.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.SettingsActivityName.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode"), System.Windows.Forms.ImeMode)
        Me.SettingsActivityName.CustomButton.Location = CType(resources.GetObject("resource.Location"), System.Drawing.Point)
        Me.SettingsActivityName.CustomButton.Name = ""
        Me.SettingsActivityName.CustomButton.Size = CType(resources.GetObject("resource.Size"), System.Drawing.Size)
        Me.SettingsActivityName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SettingsActivityName.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex"), Integer)
        Me.SettingsActivityName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SettingsActivityName.CustomButton.UseSelectable = True
        Me.SettingsActivityName.CustomButton.Visible = CType(resources.GetObject("resource.Visible"), Boolean)
        resources.ApplyResources(Me.SettingsActivityName, "SettingsActivityName")
        Me.SettingsActivityName.Lines = New String(-1) {}
        Me.SettingsActivityName.MaxLength = 32767
        Me.SettingsActivityName.Name = "SettingsActivityName"
        Me.SettingsActivityName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
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
        'SettingsActivityType
        '
        Me.SettingsActivityType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.SettingsActivityType, "SettingsActivityType")
        Me.SettingsActivityType.FormattingEnabled = True
        Me.SettingsActivityType.Name = "SettingsActivityType"
        Me.SettingsActivityType.UseSelectable = True
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
        Me.SettingsActivityDescription.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.SettingsActivityDescription.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode1"), System.Windows.Forms.ImeMode)
        Me.SettingsActivityDescription.CustomButton.Location = CType(resources.GetObject("resource.Location1"), System.Drawing.Point)
        Me.SettingsActivityDescription.CustomButton.Name = ""
        Me.SettingsActivityDescription.CustomButton.Size = CType(resources.GetObject("resource.Size1"), System.Drawing.Size)
        Me.SettingsActivityDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SettingsActivityDescription.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex1"), Integer)
        Me.SettingsActivityDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SettingsActivityDescription.CustomButton.UseSelectable = True
        Me.SettingsActivityDescription.CustomButton.Visible = CType(resources.GetObject("resource.Visible1"), Boolean)
        resources.ApplyResources(Me.SettingsActivityDescription, "SettingsActivityDescription")
        Me.SettingsActivityDescription.Lines = New String(-1) {}
        Me.SettingsActivityDescription.MaxLength = 32767
        Me.SettingsActivityDescription.Multiline = True
        Me.SettingsActivityDescription.Name = "SettingsActivityDescription"
        Me.SettingsActivityDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
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
        resources.ApplyResources(Me.MetroTabPage2, "MetroTabPage2")
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.Panel8, "Panel8")
        Me.Panel8.Name = "Panel8"
        '
        'UserRepCust3Btn
        '
        resources.ApplyResources(Me.UserRepCust3Btn, "UserRepCust3Btn")
        Me.UserRepCust3Btn.Name = "UserRepCust3Btn"
        Me.UserRepCust3Btn.UseSelectable = True
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.Panel7, "Panel7")
        Me.Panel7.Name = "Panel7"
        '
        'UserRepCust2Btn
        '
        resources.ApplyResources(Me.UserRepCust2Btn, "UserRepCust2Btn")
        Me.UserRepCust2Btn.Name = "UserRepCust2Btn"
        Me.UserRepCust2Btn.UseSelectable = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.Panel6, "Panel6")
        Me.Panel6.Name = "Panel6"
        '
        'UserRepCust1Btn
        '
        resources.ApplyResources(Me.UserRepCust1Btn, "UserRepCust1Btn")
        Me.UserRepCust1Btn.Name = "UserRepCust1Btn"
        Me.UserRepCust1Btn.UseSelectable = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.Panel5, "Panel5")
        Me.Panel5.Name = "Panel5"
        '
        'UserRepRegularColorBtn
        '
        resources.ApplyResources(Me.UserRepRegularColorBtn, "UserRepRegularColorBtn")
        Me.UserRepRegularColorBtn.Name = "UserRepRegularColorBtn"
        Me.UserRepRegularColorBtn.UseSelectable = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'UserRepWrongColorBtn
        '
        resources.ApplyResources(Me.UserRepWrongColorBtn, "UserRepWrongColorBtn")
        Me.UserRepWrongColorBtn.Name = "UserRepWrongColorBtn"
        Me.UserRepWrongColorBtn.UseSelectable = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'UserRepOkColorBtn
        '
        resources.ApplyResources(Me.UserRepOkColorBtn, "UserRepOkColorBtn")
        Me.UserRepOkColorBtn.Name = "UserRepOkColorBtn"
        Me.UserRepOkColorBtn.UseSelectable = True
        '
        'Settings
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroTabControl1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Settings"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
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
    Friend WithEvents RefreshButton As MetroFramework.Controls.MetroButton
End Class
