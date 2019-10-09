Public Class fB3

    Dim numAl1, numAl2 As Integer
    Private Sub BtnComprobar_Click(sender As Object, e As EventArgs) Handles btnComprobar.Click
        Dim numero As Integer
        If tbNum.Text = "" Then
            MessageBox.Show("Introduzca un numero")
        ElseIf Not Integer.TryParse(tbNum.Text, numero) Then
            MessageBox.Show("Introduzca un valor valido")
        Else
            If numero = numAl1 * numAl2 Then
                lblRespuesta.Text = "Muy Bien"
                generarPregunta()
            Else
                lblRespuesta.Text = "No. Por favor inténtalo de nuevo"
            End If
        End If
    End Sub

    Private Sub FB3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        generarPregunta()
    End Sub

    Private Sub generarPregunta()
        numAl1 = CInt(10 * VBMath.Rnd() + 1)
        numAl2 = CInt(10 * VBMath.Rnd() + 1)
        lblPregunta.Text = "¿Cuanto es " & CDbl(numAl1) &
            " por " & CDbl(numAl2) & "?"
    End Sub
End Class
