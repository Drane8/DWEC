Public Class fA6
    Private Sub FA6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numeros(9) As Double
        Dim contador As Integer = 0
        While contador < 9
            If Double.TryParse(InputBox("Introduzca un valor", "Valores", 0), numeros(contador)) Then
                contador += 1
            Else
                MessageBox.Show("Introduzca un valor válido")
            End If
        End While
        Array.Sort(numeros)
        lblResul.Text = "Mayor: " & numeros(9) & vbNewLine & "Menor: " & numeros(0)
        For i As Integer = 0 To 9 Step 1
            lblResul.Text = lblResul.Text & vbNewLine & numeros(i)
        Next
    End Sub
End Class
