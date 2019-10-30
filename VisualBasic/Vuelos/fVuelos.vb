Public Class fVuelos
    Dim origen() = {"BARCELONA", "BILBAO", "MADRID", "SANTANDER", "VITORIA", "ZARAGOZA"}
    Dim destNac() = {"BARCELONA", "BILBAO", "MADRID", "SANTANDER", "VITORIA", "ZARAGOZA"}
    Dim destInt() = {"AMSTERDAN", "ESTOCOLMO", "LONDRES", "NEW YORK", "PARIS", "SIDNEY"}
    Dim tarifas() = {"", 150, 200, 300, 500}
    Dim tarifasTexto() = {"---seleccione tarifa---", "Básica.....", "Clásica....", "Extra.......", "VIP........."}
    Dim total As Double = 0
    Private Sub FVuelos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To origen.Count - 1
            cbOrigen.Items.Add(origen(i))
        Next
        For i As Integer = 0 To destNac.Count - 1
            lbNacional.Items.Add(destNac(i))
        Next

        For i As Integer = 0 To destInt.Count - 1
            lbInternacional.Items.Add(destInt(i))
        Next
    End Sub

    Private Sub actualizarTarifa()
        cbTarifa.Items.Clear()
        cbTarifa.Items.Add(tarifasTexto(0))
        For i As Integer = 1 To tarifas.Count - 1
            Dim resul As String = tarifasTexto(i)
            If rbtnInternacional.Checked And i > 0 Then
                resul &= CStr(tarifas(i) * 2) & " €"
            Else
                resul &= CStr(tarifas(i)) & " €"
            End If
            cbTarifa.Items.Add(resul)
        Next
        cbTarifa.SelectedIndex = 0
    End Sub

    Private Sub RbtnNacional_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnNacional.CheckedChanged, rbtnInternacional.CheckedChanged
        If rbtnNacional.Checked Then
            lbNacional.Enabled = True
            lbInternacional.Enabled = False
            lbInternacional.SelectedIndex = -1
        Else
            lbNacional.Enabled = False
            lbInternacional.Enabled = True
            lbNacional.SelectedIndex = -1
        End If
        actualizarTarifa()
    End Sub

    Private Sub LbVuelos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbVuelos.SelectedIndexChanged
        lbPrecios.SelectedIndex = lbVuelos.SelectedIndex
    End Sub


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If cbOrigen.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar el origen")
        ElseIf lbInternacional.SelectedIndex < 0 And lbNacional.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar el destino")
        ElseIf cbTarifa.SelectedIndex <= 0 Then
            MsgBox("Debe seleccionar una tarifa")
        Else
            Dim origen = cbOrigen.SelectedItem.ToString
            Dim destino As String
            If rbtnInternacional.Checked Then
                destino = lbInternacional.SelectedItem.ToString
            Else
                destino = lbNacional.SelectedItem.ToString
            End If

            If origen.Equals(destino) Then
                MsgBox("El origen es el mismo que el destino")
            Else
                lbVuelos.Items.Add(origen & " ✈ " & destino)
                Dim precio = tarifas(cbTarifa.SelectedIndex) * numBilletes.Value
                If rbtnInternacional.Checked Then precio *= 2
                lbPrecios.Items.Add(precio)
                total += precio
                lblPrecio.Text = total.ToString("n2")
            End If
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If lbVuelos.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar un vuelo a eliminar")
        Else
            Dim confirmacion = MsgBox("¿Deseas eliminar el viaje seleccionado?", vbOKCancel)
            If confirmacion = vbOK Then
                total -= CInt(lbPrecios.SelectedItem.ToString)
                lblPrecio.Text = total.ToString("n2")
                lbPrecios.Items.RemoveAt(lbPrecios.SelectedIndex)
                lbVuelos.Items.RemoveAt(lbVuelos.SelectedIndex)
            End If
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        MsgBox("Has realizado una compra de: " & vbNewLine &
               total.ToString("n2") & "€" & vbNewLine & "en viajes")
        limpiarDatos()
    End Sub

    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Dim confirmacion = MsgBox("¿Deseas eliminar TODOS los viajes?", vbOKCancel)
        If confirmacion = vbOK Then
            limpiarDatos()
        End If
    End Sub

    Private Sub limpiarDatos()
        lbVuelos.Items.Clear()
        lbPrecios.Items.Clear()
        total = 0
        lblPrecio.Text = total.ToString("n2")
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
