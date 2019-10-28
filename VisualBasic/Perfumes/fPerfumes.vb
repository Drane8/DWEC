Public Class fPerfumes
    Dim indice = -1
    Dim perfumes() As String = {"4711", "Di Gio", "Versace", "Noche de rosas", "Clinique", "Blackxs", "Lacoste", "Gucci", "Burberry", "Adidas"}
    Dim precios() As Integer = {24, 54, 35, 29, 52, 46, 22, 49, 25, 12}
    Dim unidades() As Integer = {3, 20, 12, 10, 8, 10, 3, 25, 10, 7}

    Private Sub FPerfumes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 9
            lbPerfumes.Items.Add(perfumes(i))
            lbPrecio.Items.Add(precios(i))
            lbUnidades.Items.Add(unidades(i))
        Next
    End Sub

    Private Sub LbPerfumes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPerfumes.SelectedIndexChanged
        indice = lbPerfumes.SelectedIndex
        lbPrecio.SelectedIndex = indice
        lbUnidades.SelectedIndex = indice
        Try
            pbPerfume.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "..\..\Resources\img\" & lbPerfumes.SelectedItem.ToString & ".jpg")
        Catch ex As System.IO.FileNotFoundException
            pbPerfume.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "..\..\Resources\img\NODISP.jpg")
        End Try
    End Sub

    Private Sub BtnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        Dim unidadesCompra = CInt(tbUnidades.Text)
        Dim totalVenta As Double = 0
        If lbPerfumes.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar un perfume")
        ElseIf Not IsNumeric(tbUnidades.Text) Then
            MsgBox("Debe introducir valores numéricos")
        ElseIf unidadesCompra > unidades(indice) Then
            MsgBox("No hay tantas unidades para vender")
        Else
            Dim confirmacion = MsgBox("¿Desea aplicar el descuento seleccionado", vbOKCancel, "AVISO")
            unidades(indice) -= unidadesCompra
            lbUnidades.Items(indice) = unidades(indice)
            totalVenta = unidadesCompra * precios(indice)
            If confirmacion = vbOK Then
                If rbtn10.Checked Then
                    totalVenta *= 0.9
                ElseIf rbtn20.Checked Then
                    totalVenta *= 0.8
                Else
                    totalVenta *= 0.5
                End If
            End If
            lbVentas.Items.Add(totalVenta)
            lblTotal.Text = CDbl(lblTotal.Text) + totalVenta
        End If
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If lbVentas.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar una venta")
        Else
            lblTotal.Text = CDbl(lblTotal.Text) - CDbl(lbVentas.SelectedItem.ToString)
            lbVentas.Items.RemoveAt(lbVentas.SelectedIndex)
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
