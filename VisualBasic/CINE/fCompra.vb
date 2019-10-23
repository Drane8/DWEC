Public Class fCompra

    Dim entradas(3) As Integer
    Dim indice As Integer = 0

    Public Sub setIndice(i As Integer)
        indice = i
    End Sub

    Private Sub BtnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        Dim total As Double = 0
        If rbtn7.Checked Then
            total = numEntradas.Value * 7.2
        ElseIf rbtn6.Checked Then
            total = numEntradas.Value * 6
        ElseIf rbtn5.Checked Then
            total = numEntradas.Value * 5
        End If
        fCine.comprarEntradas(numEntradas.Value)
        tbTotal.Text = total & " €"
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Close()
    End Sub
End Class