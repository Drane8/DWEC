Public Class fC5

    Dim numeros(99) As Integer
    Private Sub FC5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Dim maximo, pos As Integer
        For i As Integer = 0 To 99
            numeros(i) = Int(1001 * Rnd())
        Next
        maximo = numeros.Max()
        pos = Array.IndexOf(numeros, maximo)
        lblResul.Text = "El máximo es " & maximo & " y ocupa la posicion " & pos
    End Sub
End Class
