Public Class fA4
    Private Sub BtnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim grados As Double
        If tbGrados.Text = "" Then
            MessageBox.Show("Introduzca un numero")
        ElseIf Not Double.TryParse(tbGrados.Text, grados) Then
            MessageBox.Show("Introduzca un valor valido")
        Else
            lblResul.Text = "Fahrenheit: " & CStr(9 / 5 * grados + 32)
        End If
    End Sub
End Class
