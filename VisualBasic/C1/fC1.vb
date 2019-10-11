Public Class fC1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNumeros.Click
        Dim numeros(9) As Double
        Dim contador As Integer = 0
        While contador < 9
            If Integer.TryParse(InputBox("Introduzca un valor", "Valores", 0), numeros(contador)) Then
                contador += 1
            Else
                MessageBox.Show("Introduzca un valor válido")
            End If
        End While
        Array.Sort(numeros)
        For i As Integer = 0 To 9 Step 1
            If (numeros(i) >= 0) Then lblResul.Text = lblResul.Text & vbNewLine & numeros(i)
        Next
    End Sub
End Class
