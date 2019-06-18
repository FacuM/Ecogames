<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivityType_Hangman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActivityType_Hangman))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SaveActivity = New MetroFramework.Controls.MetroButton()
        Me.Label16 = New MetroFramework.Controls.MetroLabel()
        Me.HangmanMaxTryAmount = New System.Windows.Forms.NumericUpDown()
        Me.HangmanDefaultLetterAmount = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New MetroFramework.Controls.MetroLabel()
        Me.HangmanTimePerLetter = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New MetroFramework.Controls.MetroLabel()
        Me.HangmanScorePerLetter = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New MetroFramework.Controls.MetroLabel()
        Me.Label11 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HangmanWordTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox4.SuspendLayout()
        CType(Me.HangmanMaxTryAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HangmanDefaultLetterAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HangmanTimePerLetter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HangmanScorePerLetter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.SaveActivity)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.HangmanMaxTryAmount)
        Me.GroupBox4.Controls.Add(Me.HangmanDefaultLetterAmount)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.HangmanTimePerLetter)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.HangmanScorePerLetter)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(23, 247)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(381, 259)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ajustes"
        '
        'SaveActivity
        '
        Me.SaveActivity.Location = New System.Drawing.Point(101, 216)
        Me.SaveActivity.Name = "SaveActivity"
        Me.SaveActivity.Size = New System.Drawing.Size(116, 23)
        Me.SaveActivity.TabIndex = 10
        Me.SaveActivity.Text = "Guardar"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(6, 174)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(187, 20)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Número máximo de intentos: "
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HangmanMaxTryAmount
        '
        Me.HangmanMaxTryAmount.Location = New System.Drawing.Point(199, 174)
        Me.HangmanMaxTryAmount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.HangmanMaxTryAmount.Name = "HangmanMaxTryAmount"
        Me.HangmanMaxTryAmount.Size = New System.Drawing.Size(171, 20)
        Me.HangmanMaxTryAmount.TabIndex = 8
        Me.HangmanMaxTryAmount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'HangmanDefaultLetterAmount
        '
        Me.HangmanDefaultLetterAmount.Location = New System.Drawing.Point(199, 125)
        Me.HangmanDefaultLetterAmount.Name = "HangmanDefaultLetterAmount"
        Me.HangmanDefaultLetterAmount.Size = New System.Drawing.Size(171, 20)
        Me.HangmanDefaultLetterAmount.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(6, 125)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(187, 20)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Cantidad por defecto: "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HangmanTimePerLetter
        '
        Me.HangmanTimePerLetter.Location = New System.Drawing.Point(199, 77)
        Me.HangmanTimePerLetter.Name = "HangmanTimePerLetter"
        Me.HangmanTimePerLetter.Size = New System.Drawing.Size(171, 20)
        Me.HangmanTimePerLetter.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(6, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(187, 20)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Tiempo por letra (s):"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HangmanScorePerLetter
        '
        Me.HangmanScorePerLetter.Location = New System.Drawing.Point(199, 30)
        Me.HangmanScorePerLetter.Name = "HangmanScorePerLetter"
        Me.HangmanScorePerLetter.Size = New System.Drawing.Size(171, 20)
        Me.HangmanScorePerLetter.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(6, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(187, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Puntaje por letra:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(181, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 19)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Texto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ecogames.My.Resources.Resources.drawing
        Me.PictureBox1.Location = New System.Drawing.Point(23, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 178)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'HangmanWordTextBox
        '
        Me.HangmanWordTextBox.Location = New System.Drawing.Point(181, 147)
        Me.HangmanWordTextBox.MaxLength = 45
        Me.HangmanWordTextBox.Name = "HangmanWordTextBox"
        Me.HangmanWordTextBox.Size = New System.Drawing.Size(223, 20)
        Me.HangmanWordTextBox.TabIndex = 4
        '
        'ActivityType_Hangman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 524)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.HangmanWordTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ActivityType_Hangman"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow
        Me.Text = "ActivityType_Hangman"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.HangmanMaxTryAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HangmanDefaultLetterAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HangmanTimePerLetter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HangmanScorePerLetter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents HangmanMaxTryAmount As NumericUpDown
    Friend WithEvents HangmanDefaultLetterAmount As NumericUpDown
    Friend WithEvents HangmanTimePerLetter As NumericUpDown
    Friend WithEvents HangmanScorePerLetter As NumericUpDown
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HangmanWordTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents SaveActivity As MetroFramework.Controls.MetroButton
    Friend WithEvents Label16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label11 As MetroFramework.Controls.MetroLabel
End Class
