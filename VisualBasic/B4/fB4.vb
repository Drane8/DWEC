Public Class fB4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer
        If tbNum.Text = "" Then
            MessageBox.Show("Introduzca un numero")
        ElseIf Not Integer.TryParse(tbNum.Text, numero) Then
            MessageBox.Show("Introduzca un valor valido")
        Else
            contarDigitos(numero)
        End If
    End Sub

    Private Sub contarDigitos(num)
        lblResul.Text = CStr(CStr(Math.Abs(num)).Length)
    End Sub
End Class
