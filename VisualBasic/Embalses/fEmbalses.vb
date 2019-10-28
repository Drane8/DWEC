Public Class fEmbalses
    Dim total = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbTotal.Text = total
    End Sub

    Private Sub BtnEmbalse_Click(sender As Object, e As EventArgs) Handles btnEmbalse.Click
        Dim embalse = tbEmbalse.Text
        If lbEmbalse.Items.Contains(embalse) Then
            lbEmbalse.SelectedIndex = lbEmbalse.Items.IndexOf(embalse)
            Dim porcentaje As Double = CDbl(lbEmbalsado.SelectedItem.ToString) / CDbl(lbCapacidad.SelectedItem.ToString)
            tbPorcentaje.Text = porcentaje.ToString("n2")
        Else
            Dim capacidad = InputBox("Introduce la capacidad del embalse")
            While Not IsNumeric(capacidad)
                MsgBox("Introduzca un valor numerico")
                capacidad = InputBox("Introduce la capacidad del embalse")
            End While
            Dim embalsado = InputBox("Introduce la cantidad embalsada")

        End If
    End Sub

    Private Sub tbEmbalse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbEmbalse.KeyPress
        If e.KeyChar <> vbBack And e.KeyChar <> " " And Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
