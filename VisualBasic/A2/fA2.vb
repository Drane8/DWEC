Public Class fA2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnComprobar.Click
        Dim num1, num2 As Double
        If tbNum1.Text = "" Or tbNum2.Text = "" Then
            MessageBox.Show("Introduzca ambos numeros")
        ElseIf Not Double.TryParse(tbNum1.Text, num1) Or Not Double.TryParse(tbNum2.Text, num2) Then
            MessageBox.Show("Introduzca valores validos")
        Else
            If (num1 > num2) Then
                lblResul.Text = CStr(num1) & " Es mayor"
            ElseIf (num2 > num1) Then
                lblResul.Text = CStr(num2) & " Es mayor"
            End If
        End If
    End Sub
End Class
