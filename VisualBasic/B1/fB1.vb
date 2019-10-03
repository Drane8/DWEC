Public Class fB1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim grados As Double
        If tbCe.Text = "" Then
            MessageBox.Show("Introduzca un numero")
        ElseIf Not Double.TryParse(tbCe.Text, grados) Then
            MessageBox.Show("Introduzca un valor valido")
        Else
            tbFa.Text = CStr(conversionGrados(grados))
        End If
    End Sub

    Private Function conversionGrados(grados As Double) As Double
        Return 9 / 5 * grados + 32
    End Function
End Class
