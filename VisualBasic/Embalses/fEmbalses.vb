Public Class fEmbalses
    Dim total = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbTotal.Text = total
    End Sub

    Private Sub BtnEmbalse_Click(sender As Object, e As EventArgs) Handles btnEmbalse.Click
        Dim embalse = tbEmbalse.Text
        If lbEmbalse.Items.Contains(embalse) Then
            lbEmbalse.SelectedIndex = lbEmbalse.Items.IndexOf(embalse)
            Dim porcentaje As Double = CDbl(lbEmbalsado.SelectedItem.ToString) / CDbl(lbCapacidad.SelectedItem.ToString) * 100
            tbPorcentaje.Text = porcentaje.ToString("n2")
        Else
            Dim capacidad = InputBox("Introduce la capacidad del embalse")
            While Not IsNumeric(capacidad)
                MsgBox("Introduzca un valor numerico")
                capacidad = InputBox("Introduce la capacidad del embalse")
            End While
            Dim embalsado = InputBox("Introduce la cantidad embalsada")
            While Not IsNumeric(embalsado) Or CDbl(embalsado) > CDbl(capacidad)
                If Not IsNumeric(embalsado) Then
                    MsgBox("Introduzca un valor numerico")
                Else
                    MsgBox("La cantidad de embalsado no puede ser mayor a la capacidad del embalse")
                End If
                embalsado = InputBox("Introduce la cantidad embalsada")
            End While
            lbEmbalse.Items.Add(embalse)
            lbCapacidad.Items.Add(capacidad)
            lbEmbalsado.Items.Add(embalsado)
            total += 1
        End If
        tbTotal.Text = total
    End Sub

    Private Sub tbEmbalse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbEmbalse.KeyPress
        If e.KeyChar <> vbBack And e.KeyChar <> " " And Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub LbEmbalse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbEmbalse.SelectedIndexChanged
        lbCapacidad.SelectedIndex = lbEmbalse.SelectedIndex
        lbEmbalsado.SelectedIndex = lbEmbalse.SelectedIndex
    End Sub

    Private Sub LbCapacidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbCapacidad.SelectedIndexChanged
        lbEmbalse.SelectedIndex = lbCapacidad.SelectedIndex
        lbEmbalsado.SelectedIndex = lbCapacidad.SelectedIndex
    End Sub

    Private Sub LbEmbalsado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbEmbalsado.SelectedIndexChanged
        lbEmbalse.SelectedIndex = lbEmbalsado.SelectedIndex
        lbCapacidad.SelectedIndex = lbEmbalsado.SelectedIndex
    End Sub

    Private Sub BtnOpcion_Click(sender As Object, e As EventArgs) Handles btnOpcion.Click
        If lbEmbalse.SelectedIndex < 0 Then
            MsgBox("No hay embalse seleccionado")
        Else
            If rbtnModificar.Checked Then
                tbCapacidad.Text = ""
                tbEmbalsado.Text = ""
                Dim embalsado = InputBox("Introduce la cantidad embalsada")
                Dim capacidad = lbCapacidad.SelectedItem.ToString
                While Not IsNumeric(embalsado) Or CDbl(embalsado) > CDbl(capacidad)
                    If Not IsNumeric(embalsado) Then
                        MsgBox("Introduzca un valor numerico")
                    Else
                        MsgBox("La cantidad de embalsado no puede ser mayor a la capacidad del embalse")
                    End If
                    embalsado = InputBox("Introduce la cantidad embalsada")
                End While
                lbEmbalsado.Items(lbEmbalsado.SelectedIndex) = embalsado
            ElseIf rbtnEliminar.Checked Then
                tbCapacidad.Text = ""
                tbEmbalsado.Text = ""
                Dim eliminar = MsgBox("¿Desea eliminar?", vbOKCancel)
                If eliminar = vbOK Then
                    lbEmbalsado.Items.RemoveAt(lbEmbalsado.SelectedIndex)
                    lbEmbalse.Items.RemoveAt(lbEmbalse.SelectedIndex)
                    lbCapacidad.Items.RemoveAt(lbCapacidad.SelectedIndex)
                End If
            Else
                Dim totalC, totalE As Double
                For i = 0 To lbEmbalse.Items.Count - 1
                    totalC += CDbl(lbCapacidad.Items(i).ToString)
                    totalE += CDbl(lbEmbalsado.Items(i).ToString)
                Next
                tbCapacidad.Text = totalC
                tbEmbalsado.Text = totalE
            End If
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
