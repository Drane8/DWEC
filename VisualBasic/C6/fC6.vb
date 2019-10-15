Public Class fC6

    Dim array As List(Of String) = New List(Of String)

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim indice As Integer = lbArray.SelectedIndex
        If indice >= 0 Then
            array.RemoveAt(indice)
        Else
            MessageBox.Show("Selecciona un elemento de la lista")
        End If

        listarArray()

    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If tbValor.Text = "" Then
            MessageBox.Show("Introduzca un valor")
        Else
            Dim indice As Integer = lbArray.SelectedIndex
            If indice >= 0 Then
                array.Insert(indice + 1, tbValor.Text)
            Else
                array.Add(tbValor.Text)
            End If
            listarArray()
        End If
    End Sub
    Private Sub listarArray()
        lbArray.Items.Clear()
        For Each valor In array
            lbArray.Items.Add(valor)
        Next
    End Sub

End Class
