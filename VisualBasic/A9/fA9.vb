Public Class fA9
    Private Sub BtnComprobar_Click(sender As Object, e As EventArgs) Handles btnComprobar.Click
        Dim num As Integer
        If tbNum.Text = "" Then
            MessageBox.Show("Introduzca todos los numeros")
        ElseIf Not Integer.TryParse(tbNum.Text, num) Then
            MessageBox.Show("Introduzca valores validos")
        Else

            Dim numeros As String = CStr(num)
            Dim digitos(Len(numeros) - 1) As Integer
            Dim suma As Double = 0

            For i = 1 To Len(numeros)
                digitos(i - 1) = Mid$(numeros, i, 1)
            Next

            For Each numero As Integer In digitos
                suma += Math.Pow(numero, 3)
            Next

            If suma = num Then
                lblResul.Text = "El numero " & num & " es cubo perfecto"
            Else

                lblResul.Text = "El numero " & num & " no es cubo perfecto"
            End If

        End If

    End Sub
End Class
