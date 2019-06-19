<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label12 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New MetroFramework.Controls.MetroPanel()
        Me.AddColumn = New MetroFramework.Controls.MetroButton()
        Me.SaveActivity = New MetroFramework.Controls.MetroButton()
        Me.RemoveColumn = New MetroFramework.Controls.MetroButton()
        Me.CrosswordDGVStatusLabel = New MetroFramework.Controls.MetroLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(20, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(639, 315)
        Me.DataGridView1.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(20, 375)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 55)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.HorizontalScrollbarBarColor = True
        Me.Panel2.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel2.HorizontalScrollbarSize = 10
        Me.Panel2.Location = New System.Drawing.Point(3, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 36)
        Me.Panel2.TabIndex = 27
        Me.Panel2.VerticalScrollbarBarColor = True
        Me.Panel2.VerticalScrollbarHighlightOnWheel = False
        Me.Panel2.VerticalScrollbarSize = 10
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Columnas: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(95, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 20)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "0"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AddColumn)
        Me.Panel1.Controls.Add(Me.SaveActivity)
        Me.Panel1.Controls.Add(Me.RemoveColumn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.HorizontalScrollbarBarColor = True
        Me.Panel1.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel1.HorizontalScrollbarSize = 10
        Me.Panel1.Location = New System.Drawing.Point(331, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 36)
        Me.Panel1.TabIndex = 26
        Me.Panel1.VerticalScrollbarBarColor = True
        Me.Panel1.VerticalScrollbarHighlightOnWheel = False
        Me.Panel1.VerticalScrollbarSize = 10
        '
        'AddColumn
        '
        Me.AddColumn.Location = New System.Drawing.Point(6, 3)
        Me.AddColumn.Name = "AddColumn"
        Me.AddColumn.Size = New System.Drawing.Size(111, 23)
        Me.AddColumn.TabIndex = 20
        Me.AddColumn.Text = "Agregar columna"
        '
        'SaveActivity
        '
        Me.SaveActivity.Enabled = False
        Me.SaveActivity.Location = New System.Drawing.Point(240, 3)
        Me.SaveActivity.Name = "SaveActivity"
        Me.SaveActivity.Size = New System.Drawing.Size(57, 23)
        Me.SaveActivity.TabIndex = 24
        Me.SaveActivity.Text = "Guardar"
        '
        'RemoveColumn
        '
        Me.RemoveColumn.Location = New System.Drawing.Point(123, 3)
        Me.RemoveColumn.Name = "RemoveColumn"
        Me.RemoveColumn.Size = New System.Drawing.Size(111, 23)
        Me.RemoveColumn.TabIndex = 22
        Me.RemoveColumn.Text = "Remover columna"
        '
        'CrosswordDGVStatusLabel
        '
        Me.CrosswordDGVStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrosswordDGVStatusLabel.Location = New System.Drawing.Point(20, 60)
        Me.CrosswordDGVStatusLabel.Name = "CrosswordDGVStatusLabel"
        Me.CrosswordDGVStatusLabel.Size = New System.Drawing.Size(639, 315)
        Me.CrosswordDGVStatusLabel.TabIndex = 16
        Me.CrosswordDGVStatusLabel.Text = "N/A"
        Me.CrosswordDGVStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CrosswordDGVStatusLabel.Visible = False
        '
        'ActivityType_Crossword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 450)
        Me.Controls.Add(Me.CrosswordDGVStatusLabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ActivityType_Crossword"
        Me.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow
        Me.Text = "ActivityType_Crossword"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents AddColumn As MetroFramework.Controls.MetroButton
    Friend WithEvents SaveActivity As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents RemoveColumn As MetroFramework.Controls.MetroButton
    Friend WithEvents CrosswordDGVStatusLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Panel2 As MetroFramework.Controls.MetroPanel
End Class
