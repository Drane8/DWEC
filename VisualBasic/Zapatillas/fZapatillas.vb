Public Class fZapatillas
    Dim indice As Integer = -1
    Private Sub LbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbMarca.SelectedIndexChanged
        indice = lbMarca.SelectedIndex
        lbRun.SelectedIndex = indice
        lbTrail.SelectedIndex = indice
        lbTotal.SelectedIndex = indice
        If indice >= 0 Then tbMarca.Text = lbMarca.Items(indice).ToString
    End Sub

    Private Sub RbtnRun_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRun.CheckedChanged, rbtnTrail.CheckedChanged
        Dim total As Integer = 0
        If rbtnRun.Checked Then
            tbFormato.Text = "RUNNING"
            For i = 0 To lbRun.Items.Count - 1
                total += CInt(lbRun.Items(i).ToString)
            Next
        Else
            tbFormato.Text = "TRAIL"
            For i = 0 To lbTrail.Items.Count - 1
                total += CInt(lbTrail.Items(i).ToString)
            Next
        End If
        tbDisp.Text = total
    End Sub

    Private Sub ChbTotal_CheckedChanged(sender As Object, e As EventArgs) Handles chbTotal.CheckedChanged
        If chbTotal.Checked Then
            Dim total As Integer = 0
            For i = 0 To lbTrail.Items.Count - 1
                total += CInt(lbTrail.Items(i).ToString)
                total += CInt(lbRun.Items(i).ToString)
            Next
            tbTotal.Text = total
        Else
            tbTotal.Text = ""
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If indice < 0 Then
            MsgBox("No hay album seleccionado")
        ElseIf tbUnidades.Text = "" Then
            MsgBox("No se ha introducido cantidad a comprar")
        ElseIf (rbtnRun.Checked And CInt(tbUnidades.Text) > CInt(lbRun.Items(indice).ToString)) Or
                (rbtnTrail.Checked And CInt(tbUnidades.Text) > CInt(lbTrail.Items(indice).ToString)) Then
            MsgBox("No disponemos de esa cantidad de artículos")
        Else
            If rbtnRun.Checked Then
                lbRun.Items(indice) = CInt(lbRun.Items(indice)) - CInt(tbUnidades.Text)
            Else
                lbTrail.Items(indice) = CInt(lbTrail.Items(indice)) - CInt(tbUnidades.Text)
            End If
            lbTotal.Items(indice) = CInt(lbTotal.Items(indice)) - CInt(tbUnidades.Text)
        End If
    End Sub

    Private Sub tbUnidades_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbUnidades.KeyPress
        If e.KeyChar <> vbBack And Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim nombre = InputBox("Nombre del album").ToUpper
        If lbMarca.Items.Contains(nombre) Then
            MsgBox("Ese album ya esta registrada")
        Else
            Dim confirmacion = MsgBox("¿Desea añadir el album " & nombre & "?", vbOKCancel, "NUEVA MARCA")
            If confirmacion = vbOK Then
                lbMarca.Items.Add(nombre)
                lbRun.Items.Add(10)
                lbTrail.Items.Add(10)
                lbTotal.Items.Add(20)
            End If
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If indice < 0 Then
            MsgBox("No hay album seleccionado")
        Else
            Dim confirmacion = MsgBox("¿Desea eliminar el album?", vbOKCancel, "ELIMINAR")
            If confirmacion = vbOK Then
                lbRun.Items.RemoveAt(indice)
                lbTrail.Items.RemoveAt(indice)
                lbTotal.Items.RemoveAt(indice)
                lbMarca.Items.RemoveAt(indice)
            End If
        End If
    End Sub
End Class
