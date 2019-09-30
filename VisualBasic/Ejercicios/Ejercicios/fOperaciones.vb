Public Class fOperaciones
    Dim estado As Integer = 0
    Private Sub BtnOpe_Click(sender As Object, e As EventArgs) Handles btnOpe.Click
        Dim num1, num2 As Integer

        Dim bool1 As Boolean = Integer.TryParse(tb1.Text, num1)
        Dim bool2 As Boolean = Integer.TryParse(tb2.Text, num2)

        If Not bool1 Then
            MessageBox.Show("El primer numero es incorrecto")
        ElseIf Not bool2 Then
            MessageBox.Show("El segundo numero es incorrecto")
        Else
            If estado = 0 Then
                lblResul.Text = num1 + num2
                estado += 1
                btnOpe.Text = "-"
            ElseIf estado = 1 Then
                lblResul.Text = num1 - num2
                estado += 1
                btnOpe.Text = "*"
            ElseIf estado = 2 Then
                lblResul.Text = num1 * num2
                estado += 1
                btnOpe.Text = "/"
            Else
                If num2 = 0 Then
                    MessageBox.Show("No es posible dividir entre 0")
                Else
                    lblResul.Text = num1 / num2
                    btnOpe.Text = "+"
                    estado = 0
                End If
            End If
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
