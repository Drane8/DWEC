Public Class fA8

    Dim dias, medMax, medMin, errores As Integer
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim min, max As Integer
        If tbMax.Text = "" Or tbMin.Text = "" Then
            MessageBox.Show("Introduzca todos los numeros")
        ElseIf Not Integer.TryParse(tbMax.Text, max) Or Not Integer.TryParse(tbMin.Text, min) Then
            MessageBox.Show("Introduzca valores validos")
        Else
            If max = 0 And min = 0 Then
                lblResul.Text = "Total dias: " & dias & vbNewLine &
                " Media temperatura máxima: " & medMax & vbNewLine &
                "Media temperatura mínima: " & medMin & vbNewLine& &
                "Errores: " & errores & vbNewLine &
                "Porcentaje de errores: " & errores / (dias * 2) * 100 & "%"
                btnGuardar.Enabled = False
            Else
                medMax += max
                medMin += min
                If max = 0 Or min = 0 Then errores += 1
                dias += 1
            End If
        End If
    End Sub

    Private Sub FA8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dias = 0
        medMax = 0
        medMin = 0
        errores = 0
    End Sub
End Class
