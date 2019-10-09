Public Class fB7
    Private Sub BtnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click
        Dim cadena As String = tbCadena.Text

        lblResul.Text = contarVocales(cadena)
    End Sub

    Private Function contarVocales(cad) As Integer
        Dim total As Integer = 0
        Dim vocales As String = "aeiou"
        For i As Integer = 1 To Len(cad)
            If InStr(vocales, Mid(cad, i, 1)) Then total += 1
        Next
        Return total
    End Function
End Class
