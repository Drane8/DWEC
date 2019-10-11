Public Class fC2
    Private Sub BtnNumeros_Click(sender As Object, e As EventArgs) Handles btnNumeros.Click
        Dim numeros(19) As Double
        Dim contador, ceros, positivos, negativos As Integer
        contador = 0
        ceros = 0
        positivos = 0
        negativos = 0
        While contador < 19
            If Integer.TryParse(InputBox("Introduzca un valor", "Valores", 0), numeros(contador)) Then
                contador += 1
            Else
                MessageBox.Show("Introduzca un valor válido")
            End If
        End While
        Array.Sort(numeros)
        For i As Integer = 0 To 19 Step 1
            If (numeros(i) = 0) Then
                ceros += 1
            ElseIf (numeros(i) > 0) Then
                positivos += 1
            Else
                negativos += 1
            End If
        Next

        lblResul.Text = "Positivos: " & positivos & vbNewLine &
        "Ceros: " & ceros & vbNewLine & "Negativos: " & negativos
    End Sub
End Class
