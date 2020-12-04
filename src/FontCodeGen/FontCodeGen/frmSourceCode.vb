Public Class frmSourceCode

    Public Overloads Function ShowDialog(sourceCode As String) As DialogResult
        txtGeneratedSourcecode.Text = sourceCode
        Return MyBase.ShowDialog()
    End Function

End Class