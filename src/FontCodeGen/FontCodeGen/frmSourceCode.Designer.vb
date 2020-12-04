<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSourceCode
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
        Me.txtGeneratedSourcecode = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtGeneratedSourcecode
        '
        Me.txtGeneratedSourcecode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGeneratedSourcecode.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtGeneratedSourcecode.Location = New System.Drawing.Point(0, 0)
        Me.txtGeneratedSourcecode.Multiline = True
        Me.txtGeneratedSourcecode.Name = "txtGeneratedSourcecode"
        Me.txtGeneratedSourcecode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGeneratedSourcecode.Size = New System.Drawing.Size(800, 450)
        Me.txtGeneratedSourcecode.TabIndex = 0
        '
        'frmSourceCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtGeneratedSourcecode)
        Me.Name = "frmSourceCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Generated Source Code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGeneratedSourcecode As TextBox
End Class
