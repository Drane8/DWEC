Public Class fLibreria

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub BtnOpc_Click(sender As Object, e As EventArgs) Handles btnOpc.Click
        If rbtnAlta.Checked Then
            gbAlta.Enabled = True
            gbOpcion.Enabled = False
            btnOpc.Enabled = False
        ElseIf rbtnBaja.Checked Then
            If lbUnidades.SelectedIndex < 0 Then
                MsgBox("Selecciona un libro")
            Else
                gbBaja.Enabled = True
                gbOpcion.Enabled = False
                btnOpc.Enabled = False
            End If
        Else
            If lbUnidades.SelectedIndex < 0 Then
                MsgBox("Selecciona un libro")
            Else
                gbMod.Enabled = True
                gbOpcion.Enabled = False
                btnOpc.Enabled = False
            End If
        End If
    End Sub

    Private Sub opcionTerminada()
        gbOpcion.Enabled = True
        btnOpc.Enabled = True
        gbAlta.Enabled = False
        gbMod.Enabled = False
        gbBaja.Enabled = False
        tbAltaUni.Clear()
        tbAltaTit.Clear()
        tbModUni.Clear()
    End Sub

    Private Sub BtnAltaConfirmar_Click(sender As Object, e As EventArgs) Handles btnAltaConfirmar.Click
        lbLibros.Items.Add(tbAltaTit.Text)
        lbUnidades.Items.Add(tbAltaUni.Text)
        opcionTerminada()
    End Sub

    Private Sub BtnModConf_Click(sender As Object, e As EventArgs) Handles btnModConf.Click
        lbUnidades.Items(lbUnidades.SelectedIndex) = tbModUni.Text
        opcionTerminada()
    End Sub

    Private Sub BtnCanc_Click(sender As Object, e As EventArgs) Handles btnModCanc.Click, btnBajCan.Click, btnAltaCancelar.Click
        opcionTerminada()
    End Sub

    Private Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        Dim mensaje = MsgBox("¿Estas seguro de que deseas borrar?", MsgBoxStyle.OkCancel, "Warning!")
        If mensaje = vbOK Then
            lbUnidades.Items.Remove(lbUnidades.SelectedItem)
            lbLibros.Items.Remove(lbLibros.SelectedItem)
            opcionTerminada()
        End If
    End Sub

    Private Sub LbLibros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbLibros.SelectedIndexChanged
        lbUnidades.SelectedIndex = lbLibros.SelectedIndex
    End Sub

    Private Sub VerPortadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerPortadasToolStripMenuItem.Click
        If lbLibros.SelectedIndex < 0 Then
            MsgBox("No se ha seleccionado nigun libro", vbOKOnly, "WARNING!!")
        Else
            fPortada.Text = lbLibros.SelectedItem.ToString
            fPortada.ShowDialog()
        End If
    End Sub
End Class
