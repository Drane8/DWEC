Public Class fEstopa
    Dim indice As Integer = -1
    Private Sub LbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbAlbum.SelectedIndexChanged
        indice = lbAlbum.SelectedIndex
        lbCD.SelectedIndex = indice
        lbVinilo.SelectedIndex = indice
        lbTotal.SelectedIndex = indice
    End Sub

    Private Sub RbtnRun_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCD.CheckedChanged, rbtnVinilo.CheckedChanged
        Dim total As Integer = 0
        If rbtnCD.Checked Then
            For i = 0 To lbCD.Items.Count - 1
                total += CInt(lbCD.Items(i).ToString)
            Next
        Else
            For i = 0 To lbVinilo.Items.Count - 1
                total += CInt(lbVinilo.Items(i).ToString)
            Next
        End If
        tbDisp.Text = total
    End Sub

    Private Sub ChbTotal_CheckedChanged(sender As Object, e As EventArgs) Handles chbTotal.CheckedChanged
        If chbTotal.Checked Then
            Dim total As Integer = 0
            For i = 0 To lbVinilo.Items.Count - 1
                total += CInt(lbVinilo.Items(i).ToString)
                total += CInt(lbCD.Items(i).ToString)
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
            MsgBox("No hay artículo seleccionado")
        ElseIf tbUnidades.Text = "" Then
            MsgBox("No se ha introducido cantidad a comprar")
        ElseIf (rbtnCD.Checked And CInt(tbUnidades.Text) > CInt(lbCD.Items(indice).ToString)) Or
                (rbtnVinilo.Checked And CInt(tbUnidades.Text) > CInt(lbVinilo.Items(indice).ToString)) Then
            MsgBox("No disponemos de esa cantidad de artículos")
        Else
            If rbtnCD.Checked Then
                lbCD.Items(indice) = CInt(lbCD.Items(indice)) - CInt(tbUnidades.Text)
            Else
                lbVinilo.Items(indice) = CInt(lbVinilo.Items(indice)) - CInt(tbUnidades.Text)
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
        Dim nombre = InputBox("Nombre de la marca").ToUpper
        If lbAlbum.Items.Contains(nombre) Then
            MsgBox("Esa marca ya esta registrada")
        Else
            Dim confirmacion = MsgBox("¿Desea añadir la marca " & nombre & "?", vbOKCancel, "NUEVA MARCA")
            If confirmacion = vbOK Then
                lbAlbum.Items.Add(nombre)
                lbCD.Items.Add(10)
                lbVinilo.Items.Add(10)
                lbTotal.Items.Add(20)
            End If
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If indice < 0 Then
            MsgBox("No hay marca seleccionada")
        Else
            Dim confirmacion = MsgBox("¿Desea eliminar la marca?", vbOKCancel, "ELIMINAR")
            If confirmacion = vbOK Then
                lbCD.Items.RemoveAt(indice)
                lbVinilo.Items.RemoveAt(indice)
                lbTotal.Items.RemoveAt(indice)
                lbAlbum.Items.RemoveAt(indice)
            End If
        End If
    End Sub
End Class
