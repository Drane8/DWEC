Public Class fA3
    Private Sub BtnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click
        Dim num1, num2, num3, max, min As Double
        If tbNum1.Text = "" Or tbNum2.Text = "" Or tbNum3.Text = "" Then
            MessageBox.Show("Introduzca todos los numeros")
        ElseIf Not Double.TryParse(tbNum1.Text, num1) Or Not Double.TryParse(tbNum2.Text, num2) Or Not Double.TryParse(tbNum3.Text, num3) Then
            MessageBox.Show("Introduzca valores validos")
        Else
            max = Math.Max(num1, num2)
            max = Math.Max(max, num3)
            lblMayor.Text = "Mayor: " & CStr(max)

            min = Math.Min(num1, num2)
            min = Math.Min(min, num3)
            lblMenor.Text = "Menor: " & CStr(min)

            If num1 <> max And num1 <> min Then
                lblMedio.Text = "Mediano: " & CStr(num1)
            ElseIf num2 <> max And num2 <> min Then
                lblMedio.Text = "Mediano: " & CStr(num2)
            Else
                lblMedio.Text = "Mediano: " & CStr(num3)
            End If

        End If
    End Sub
End Class
