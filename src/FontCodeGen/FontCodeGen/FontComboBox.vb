Imports System.Drawing.Text

Public Class FontComboBox
    Inherits ComboBox

    Private _installedFonts As InstalledFontCollection

    Public Sub New()
        MyBase.New
        DrawMode = DrawMode.OwnerDrawFixed
    End Sub

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        If Me.DesignMode Then
            Return
        End If

        CreateEntries()

    End Sub

    Private Sub CreateEntries()
        _installedFonts = New InstalledFontCollection()
        For Each item In _installedFonts.Families
            Me.Items.Add(New FontComboboxItem(item))
        Next
    End Sub

    Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
        Dim g = e.Graphics
        Dim currentFontFamilyItem = DirectCast(Items(e.Index), FontComboboxItem).FontFamily
        Dim currentFont = New Font(currentFontFamilyItem, Me.Font.Size)
        e.DrawBackground()
        g.DrawString(currentFontFamilyItem.Name, currentFont, Brushes.Black, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
    End Sub

End Class
