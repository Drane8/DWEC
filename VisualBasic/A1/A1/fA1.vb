Public Class fA1

    Dim operacion As String = ""
    Private Sub RbSum_CheckedChanged(sender As Object, e As EventArgs) Handles rbSum.CheckedChanged
        operacion = "+"
    End Sub

    Private Sub RbRes_CheckedChanged(sender As Object, e As EventArgs) Handles rbRes.CheckedChanged
        operacion = "-"
    End Sub

    Private Sub RbMul_CheckedChanged(sender As Object, e As EventArgs) Handles rbMul.CheckedChanged
        operacion = "*"
    End Sub

    Private Sub RbDiv_CheckedChanged(sender As Object, e As EventArgs) Handles rbDiv.CheckedChanged
        operacion = "/"
    End Sub

    Private Sub RbMa_CheckedChanged(sender As Object, e As EventArgs) Handles rbMa.CheckedChanged
        operacion = ">"
    End Sub

    Private Sub RbMe_CheckedChanged(sender As Object, e As EventArgs) Handles rbMe.CheckedChanged
        operacion = "<"
    End Sub

    Private Sub RbMayIg_CheckedChanged(sender As Object, e As EventArgs) Handles rbMayIg.CheckedChanged
        operacion = ">="
    End Sub

    Private Sub RbMenIg_CheckedChanged(sender As Object, e As EventArgs) Handles rbMenIg.CheckedChanged
        operacion = "<="
    End Sub

    Private Sub RbIg_CheckedChanged(sender As Object, e As EventArgs) Handles rbIg.CheckedChanged
        operacion = "="
    End Sub

    Private Sub RbDis_CheckedChanged(sender As Object, e As EventArgs) Handles rbDis.CheckedChanged
        operacion = "<>"
    End Sub

    Private Sub BtnOpe_Click(sender As Object, e As EventArgs) Handles btnOpe.Click
        Dim num1, num2 As Double
        If tb1.Text = "" Or tb2.Text = "" Then
            MessageBox.Show("Introduzca ambos numeros")
        ElseIf Not Double.TryParse(tb1.Text, num1) Or Not Double.TryParse(tb2.Text, num2) Then
            MessageBox.Show("Introduzca valores validos")
        Else
            Select Case operacion
                Case "+"
                    lblResul.Text = CStr(num1 + num2)
                Case "-"
                    lblResul.Text = CStr(num1 - num2)
                Case "*"
                    lblResul.Text = CStr(num1 * num2)
                Case "/"
                    lblResul.Text = CStr(num1 / num2)
                Case ">"
                    If num1 > num2 Then
                        lblResul.Text = "El numero es mayor"
                    Else
                        lblResul.Text = "El numero no es mayor"
                    End If
                Case "<"
                    If num1 < num2 Then
                        lblResul.Text = "El numero es menor"
                    Else
                        lblResul.Text = "El numero no es menor"
                    End If
                Case ">="
                    If num1 >= num2 Then
                        lblResul.Text = "El numero es mayor o igual"
                    Else
                        lblResul.Text = "El numero no es mayor o igual"
                    End If
                Case "<="
                    If num1 >= num2 Then
                        lblResul.Text = "El numero es menor o igual"
                    Else
                        lblResul.Text = "El numero no es menor o igual"
                    End If
                Case "="
                    If num1 = num2 Then
                        lblResul.Text = "El numero es igual"
                    Else
                        lblResul.Text = "El numero no es igual"
                    End If
                Case "<>"
                    If num1 <> num2 Then
                        lblResul.Text = "El numero es distinto"
                    Else
                        lblResul.Text = "El numero no es distinto"
                    End If
            End Select
        End If
    End Sub
End Class
