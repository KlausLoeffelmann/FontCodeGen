Public Structure FontComboboxItem
    Sub New(fontFamily As FontFamily)
        Me.FontFamily = fontFamily
    End Sub

    Public Property FontFamily As FontFamily

    Public Overrides Function ToString() As String
        Return FontFamily?.Name
    End Function
End Structure
