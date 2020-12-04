Option Strict On

Imports System.Drawing.Text
Imports System.Linq
Imports System.Text

Public Class Form1

    Private _generateCCode As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim defaultFont = FontComboBox1.Items.
            Cast(Of FontComboboxItem).
            Where(Function(fontItem) fontItem.FontFamily.Name = "Consolas").
            FirstOrDefault

        FontComboBox1.SelectedItem = defaultFont

        SetPreviewFont()
    End Sub

    Private Sub FontComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FontComboBox1.SelectedIndexChanged
        SetPreviewFont()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles nudFontSize.ValueChanged
        SetPreviewFont()
    End Sub

    Private Sub SetPreviewFont()
        If FontComboBox1.SelectedItem Is Nothing Then
            Return
        End If

        lblPreview.Font = New Font(DirectCast(FontComboBox1.SelectedItem, FontComboboxItem).FontFamily, nudFontSize.Value)
    End Sub

    Private Async Sub btnGenerateCode_Click(sender As Object, e As EventArgs) Handles btnGenerateCode.Click

        Dim sc = New StringBuilder()
        Dim one = CByte(1)

        sc.Append("// Declaring the array for the Character Set.")
        sc.Append(vbCrLf)
        If _generateCCode Then
            sc.Append("unsigned byte charSet[255][16];")
        Else
            sc.Append("private byte[,] charSet=new byte[255,16];")
        End If
        sc.Append(vbCrLf)
        sc.Append(vbCrLf)

        Dim bitmap = New Bitmap(
            picFontRenderSurface.Size.Width,
            picFontRenderSurface.Size.Height)

        Dim font = New Font(DirectCast(FontComboBox1.SelectedItem, FontComboboxItem).FontFamily, 77)
        Dim g = Graphics.FromImage(bitmap)

        For c = 33 To 255
            g.Clear(Color.White)
            For x = 0 To picFontRenderSurface.Width Step 8
                g.DrawLine(Pens.Black, New Point(x, 0), New Point(x, picFontRenderSurface.Height - 1))
            Next
            For y = 0 To picFontRenderSurface.Height Step 8
                g.DrawLine(Pens.Black, New Point(0, y), New Point(picFontRenderSurface.Width - 1, y))
            Next

            g.DrawString(ChrW(c), font, Brushes.Black, New PointF(-22, -8))

            For y = 0 To 15

                Dim value As Byte = 0

                For x = 0 To 7
                    Dim xr = x * 8 + 4
                    Dim yr = y * 8 + 4

                    Dim col = bitmap.GetPixel(xr, yr)
                    value <<= 1
                    If col.ToArgb <> &HFFFFFFFF Then
                        value = value Or one
                    End If
                Next

                If _generateCCode Then
                    sc.Append($"charSet[{c}][{y}] = 0b{Convert.ToString(value, 2).PadLeft(8, "0"c)}")
                Else
                    sc.Append($"charSet[{c},{y}] = 0b{Convert.ToString(value, 2).PadLeft(8, "0"c)}")
                End If
                sc.Append(vbCrLf)
            Next

            sc.Append(vbCrLf)

            picFontRenderSurface.Image = bitmap

            Await Task.Delay(0)
        Next
        Await Task.Delay(100)
    End Sub
End Class
