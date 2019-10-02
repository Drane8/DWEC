Public Class fA5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdelantar.Click
        Dim horas, minutos, segundos As Integer
        Dim fmt As String = "00"
        If tbHoras.Text = "" Or tbMinutos.Text = "" Or tbSegundos.Text = "" Then
            MessageBox.Show("Introduzca todos los numeros")
        ElseIf Not Integer.TryParse(tbHoras.Text, horas) Or Not Integer.TryParse(tbMinutos.Text, minutos) Or Not Integer.TryParse(tbSegundos.Text, segundos) Then
            MessageBox.Show("Introduzca valores validos")
        ElseIf horas > 24 Or horas < 0 Or minutos < 0 Or minutos > 60 Or segundos < 0 Or minutos > 60 Then
            MessageBox.Show("Introduzca valores validos")
        Else
            segundos += 1
            If segundos = 60 Then
                segundos = 0
                minutos += 1
            End If
            If minutos = 60 Then
                minutos = 0
                horas += 1
            End If
            If horas = 24 Then
                horas = 0
            End If
            lblHora.Text = horas.ToString(fmt) & ":" & minutos.ToString(fmt) & ":" & segundos.ToString(fmt)
        End If
    End Sub
End Class
