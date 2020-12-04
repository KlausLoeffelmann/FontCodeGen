<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.FontComboBox1 = New FontCodeGen.FontComboBox()
        Me.picFontRenderSurface = New System.Windows.Forms.PictureBox()
        Me.nudFontSize = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerateCode = New System.Windows.Forms.Button()
        Me.optGenerateCSharp = New System.Windows.Forms.RadioButton()
        Me.optGenerateCCode = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picFontRenderSurface, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Font:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPreview)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 292)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preview:"
        '
        'lblPreview
        '
        Me.lblPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPreview.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPreview.Location = New System.Drawing.Point(17, 37)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(739, 227)
        Me.lblPreview.TabIndex = 3
        Me.lblPreview.Text = "the quick brown fox jumps over the lazy dog." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "THE QUICK BROWN FOX JUMPS OVER THE " &
    "LAZY DOG."
        Me.lblPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FontComboBox1
        '
        Me.FontComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.FontComboBox1.FormattingEnabled = True
        Me.FontComboBox1.Location = New System.Drawing.Point(88, 14)
        Me.FontComboBox1.Name = "FontComboBox1"
        Me.FontComboBox1.Size = New System.Drawing.Size(431, 28)
        Me.FontComboBox1.TabIndex = 5
        '
        'picFontRenderSurface
        '
        Me.picFontRenderSurface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFontRenderSurface.Location = New System.Drawing.Point(18, 435)
        Me.picFontRenderSurface.Name = "picFontRenderSurface"
        Me.picFontRenderSurface.Size = New System.Drawing.Size(769, 154)
        Me.picFontRenderSurface.TabIndex = 6
        Me.picFontRenderSurface.TabStop = False
        '
        'nudFontSize
        '
        Me.nudFontSize.Location = New System.Drawing.Point(596, 16)
        Me.nudFontSize.Maximum = New Decimal(New Integer() {36, 0, 0, 0})
        Me.nudFontSize.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.nudFontSize.Name = "nudFontSize"
        Me.nudFontSize.Size = New System.Drawing.Size(134, 27)
        Me.nudFontSize.TabIndex = 7
        Me.nudFontSize.Value = New Decimal(New Integer() {24, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(551, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Size:"
        '
        'btnGenerateCode
        '
        Me.btnGenerateCode.Location = New System.Drawing.Point(596, 377)
        Me.btnGenerateCode.Name = "btnGenerateCode"
        Me.btnGenerateCode.Size = New System.Drawing.Size(165, 37)
        Me.btnGenerateCode.TabIndex = 9
        Me.btnGenerateCode.Text = "Generate Code..."
        Me.btnGenerateCode.UseVisualStyleBackColor = True
        '
        'optGenerateCSharp
        '
        Me.optGenerateCSharp.AutoSize = True
        Me.optGenerateCSharp.Location = New System.Drawing.Point(105, 383)
        Me.optGenerateCSharp.Name = "optGenerateCSharp"
        Me.optGenerateCSharp.Size = New System.Drawing.Size(150, 24)
        Me.optGenerateCSharp.TabIndex = 10
        Me.optGenerateCSharp.Text = "generate C# Code"
        Me.optGenerateCSharp.UseVisualStyleBackColor = True
        '
        'optGenerateCCode
        '
        Me.optGenerateCCode.AutoSize = True
        Me.optGenerateCCode.Checked = True
        Me.optGenerateCCode.Location = New System.Drawing.Point(320, 383)
        Me.optGenerateCCode.Name = "optGenerateCCode"
        Me.optGenerateCCode.Size = New System.Drawing.Size(141, 24)
        Me.optGenerateCCode.TabIndex = 11
        Me.optGenerateCCode.TabStop = True
        Me.optGenerateCCode.Text = "generate C Code"
        Me.optGenerateCCode.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 619)
        Me.Controls.Add(Me.optGenerateCCode)
        Me.Controls.Add(Me.optGenerateCSharp)
        Me.Controls.Add(Me.btnGenerateCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudFontSize)
        Me.Controls.Add(Me.picFontRenderSurface)
        Me.Controls.Add(Me.FontComboBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FontCodeGen - Generating Byte-Array from rasterzized Fonts"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picFontRenderSurface, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFontSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPreview As Label
    Friend WithEvents FontComboBox1 As FontComboBox
    Friend WithEvents picFontRenderSurface As PictureBox
    Friend WithEvents nudFontSize As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGenerateCode As Button
    Friend WithEvents optGenerateCSharp As RadioButton
    Friend WithEvents optGenerateCCode As RadioButton
End Class
