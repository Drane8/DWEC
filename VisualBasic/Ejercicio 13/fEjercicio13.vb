Public Class fEjercicio13
    Dim indice As Integer = -1
    Dim tipos() As String = {"Camisetas", "Zapatillas", "Gorras", "Pantalones", "Chaquetas"}
    Dim total As Double = 0
    Private Sub LbArticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbArticulo.SelectedIndexChanged
        indice = lbArticulo.SelectedIndex
        lbPrecio.SelectedIndex = indice
        lbTipo.SelectedIndex = indice
        lbUnidades.SelectedIndex = indice
    End Sub

    Private Sub FEjercicio13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each tipo In tipos
            cbTipo.Items.Add(tipo)
        Next
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If Not IsNumeric(tbUds.Text) Or Not IsNumeric(tbPrecio.Text) Then
            MsgBox("Introduzca valores correctos")
        ElseIf cbTipo.SelectedIndex < 0 Then
            MsgBox("Seleccione un tipo de producto")
        Else
            lbArticulo.Items.Add(tbArticulo.Text.ToUpper)
            lbTipo.Items.Add(cbTipo.SelectedItem.ToString)
            lbPrecio.Items.Add(tbPrecio.Text)
            lbUnidades.Items.Add(tbUds.Text)
            cbProductos.Items.Add(tbArticulo.Text.ToUpper)
        End If
    End Sub

    Private Sub BtnEliArt_Click(sender As Object, e As EventArgs) Handles btnEliArt.Click
        If indice < 0 Then
            MsgBox("Selecciona un articulo")
        Else
            lbPrecio.Items.RemoveAt(indice)
            lbUnidades.Items.RemoveAt(indice)
            lbTipo.Items.RemoveAt(indice)
            cbProductos.Items.RemoveAt(indice)
            lbArticulo.Items.RemoveAt(indice)
        End If
    End Sub

    Private Sub BtnEliPro_Click(sender As Object, e As EventArgs) Handles btnEliPro.Click
        Dim productoSelecc As Integer = cbProductos.SelectedIndex
        If productoSelecc < 0 Then
            MsgBox("Selecciona un producto de la lista")
        Else
            lbPrecio.Items.RemoveAt(productoSelecc)
            lbUnidades.Items.RemoveAt(productoSelecc)
            lbTipo.Items.RemoveAt(productoSelecc)
            lbArticulo.Items.RemoveAt(productoSelecc)
            cbProductos.Items.RemoveAt(productoSelecc)
        End If
    End Sub

    Private Sub BtnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        If Not IsNumeric(tbUnidades.Text) Then
            MsgBox("Introduzca un valor numérico")
        ElseIf indice < 0 Then
            MsgBox("Seleccione un artículo")
        ElseIf CInt(tbUnidades.Text) > CInt(lbUnidades.SelectedItem.ToString) Then
            MsgBox("No hay tantas unidades disponibles")
        Else
            Dim precio = CDbl(lbPrecio.SelectedItem.ToString) * CDbl(tbUnidades.Text)
            If cbDto.Checked Then precio *= 0.9
            lbCompras.Items.Add(String.Format("{0,-40} --- {1,6} --- {2,6}", lbArticulo.SelectedItem.ToString, tbUnidades.Text, precio.ToString("n2")))
            total += precio
            lbUnidades.Items(indice) = CInt(lbUnidades.Items(indice)) - CInt(tbUnidades.Text)
            cbDto.Checked = False
        End If
    End Sub

    Private Sub BtnCompra_Click(sender As Object, e As EventArgs) Handles btnCompra.Click
        Dim compra = MsgBox("¿Desea realizar la compra?", vbOKCancel)
        If compra = vbOK Then
            lbTotal.Text = "Importe Total:     " & total.ToString("n2") & "€"
        End If
        total = 0
        lbCompras.Items.Clear()
    End Sub
End Class
