﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ActivityType_Crossword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActivityType_Crossword))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New MetroFramework.Controls.MetroPanel()
        Me.TimePerRowCheckBox = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.TimePerRowNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.ColumnCountLabel = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New MetroFramework.Controls.MetroPanel()
        Me.AddColumn = New MetroFramework.Controls.MetroButton()
        Me.SaveActivity = New MetroFramework.Controls.MetroButton()
        Me.RemoveColumn = New MetroFramework.Controls.MetroButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TimePerRowNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.Name = "DataGridView1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TimePerRowCheckBox)
        Me.Panel2.Controls.Add(Me.MetroLabel1)
        Me.Panel2.Controls.Add(Me.TimePerRowNumericUpDown)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.ColumnCountLabel)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.HorizontalScrollbarBarColor = True
        Me.Panel2.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel2.HorizontalScrollbarSize = 10
        Me.Panel2.Name = "Panel2"
        Me.Panel2.VerticalScrollbarBarColor = True
        Me.Panel2.VerticalScrollbarHighlightOnWheel = False
        Me.Panel2.VerticalScrollbarSize = 10
        '
        'TimePerRowCheckBox
        '
        Me.TimePerRowCheckBox.Checked = True
        Me.TimePerRowCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        resources.ApplyResources(Me.TimePerRowCheckBox, "TimePerRowCheckBox")
        Me.TimePerRowCheckBox.Name = "TimePerRowCheckBox"
        Me.TimePerRowCheckBox.UseSelectable = True
        '
        'MetroLabel1
        '
        resources.ApplyResources(Me.MetroLabel1, "MetroLabel1")
        Me.MetroLabel1.Name = "MetroLabel1"
        '
        'TimePerRowNumericUpDown
        '
        resources.ApplyResources(Me.TimePerRowNumericUpDown, "TimePerRowNumericUpDown")
        Me.TimePerRowNumericUpDown.Name = "TimePerRowNumericUpDown"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'ColumnCountLabel
        '
        resources.ApplyResources(Me.ColumnCountLabel, "ColumnCountLabel")
        Me.ColumnCountLabel.Name = "ColumnCountLabel"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AddColumn)
        Me.Panel1.Controls.Add(Me.SaveActivity)
        Me.Panel1.Controls.Add(Me.RemoveColumn)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.HorizontalScrollbarBarColor = True
        Me.Panel1.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel1.HorizontalScrollbarSize = 10
        Me.Panel1.Name = "Panel1"
        Me.Panel1.VerticalScrollbarBarColor = True
        Me.Panel1.VerticalScrollbarHighlightOnWheel = False
        Me.Panel1.VerticalScrollbarSize = 10
        '
        'AddColumn
        '
        resources.ApplyResources(Me.AddColumn, "AddColumn")
        Me.AddColumn.Name = "AddColumn"
        Me.AddColumn.UseSelectable = True
        '
        'SaveActivity
        '
        resources.ApplyResources(Me.SaveActivity, "SaveActivity")
        Me.SaveActivity.Name = "SaveActivity"
        Me.SaveActivity.UseSelectable = True
        '
        'RemoveColumn
        '
        resources.ApplyResources(Me.RemoveColumn, "RemoveColumn")
        Me.RemoveColumn.Name = "RemoveColumn"
        Me.RemoveColumn.UseSelectable = True
        '
        'ActivityType_Crossword
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ActivityType_Crossword"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.TimePerRowNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ColumnCountLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents AddColumn As MetroFramework.Controls.MetroButton
    Friend WithEvents SaveActivity As MetroFramework.Controls.MetroButton
    Friend WithEvents RemoveColumn As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Panel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TimePerRowNumericUpDown As NumericUpDown
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TimePerRowCheckBox As MetroFramework.Controls.MetroCheckBox
End Class
