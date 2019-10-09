Public Class fB5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cadena As String = tbCadena.Text
        Dim caracter As Char = tbCaracter.Text
        lblResul.Text = borrarCaracter(cadena, caracter)
    End Sub

    Private Function borrarCaracter(cad, car) As String
        Return Replace(cad, car, "")
    End Function
End Class
