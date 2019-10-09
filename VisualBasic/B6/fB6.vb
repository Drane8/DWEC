Public Class fB6
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim numero As Integer
        If tbNum.Text = "" Then
            MessageBox.Show("Introduzca un numero")
        ElseIf Not Integer.TryParse(tbNum.Text, numero) Then
            MessageBox.Show("Introduzca un valor valido")
        Else
            lblResul.Text = sumaImpares(numero)
        End If
    End Sub

    Private Function sumaImpares(num) As Integer
        Dim suma As Integer = 0
        If num Mod 2 = 0 Then num -= 1
        For i As Integer = num To 0 Step -2
            suma += i
        Next

        Return suma
    End Function
End Class
