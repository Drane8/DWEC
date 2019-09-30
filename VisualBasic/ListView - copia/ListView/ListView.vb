Public Class frmListView

    ' Cada columna de un lstview, es un sub-elemento 
    '
    '   lstVPrincipal.SelectedItems.Item(0).Text)                'Coindide con .SubItems(0).Text 
    '   lstVPrincipal.SelectedItems.Item(0).SubItems(1).Text
    '   lstVPrincipal.SelectedItems.Item(0).SubItems(2).Text
    ' Siendo el primer indice la fila seleccionada y el segundo (1,2) los elementos. el subindice 0 podemos omitirlo

    ' Los indices podemos saberlos con el array de lstVPrincipal.SelectedIndices
    ' **** los selecteditems como selectedindices, son arrays nuevos con los elementos seleccionados
    ' sus indices no coinciden con los del items(0).add
    ' ***
    ' almacena los inidice de los elementos seleccionados.
    ' Para saber uno de ellos lstVPrincipal.SelectedIndices.item(0)
    ' lstVPrincipal.SelectedIndices.Count para saber cuantos elementos tenemos seleccionados
    ' Para ver los valores podemos usar un for each o un for hasta el Count

    ' For Each aa In lstVPrincipal.SelectedIndices
    '        MsgBox(lstVPrincipal.SelectedItems.Item(aa - 1).Text) 
    '        MsgBox(lstVPrincipal.SelectedItems.Item(aa - 1).SubItems(1).Text)
    '        MsgBox(lstVPrincipal.SelectedItems.Item(aa - 1).SubItems(2).Text)
    ' Next



    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Static Dim iIndice As Integer = 0

        lstVPrincipal.Items.Add(txtCampo1.Text)

        lstVPrincipal.Items(iIndice).SubItems.Add(txtCampo2.Text)

        lstVPrincipal.Items(iIndice).SubItems.Add(txtCampo3.Text)

        txtCampo1.Text = "" : txtCampo2.Text = "" : txtCampo3.Text = ""   ' El caracter ":" nos vale para poner más de una instrucción por linea

        iIndice += 1
    End Sub


    Private Sub BtnActualiza_Click(sender As Object, e As EventArgs) Handles btnActualiza.Click


    End Sub

    Private Sub FrmLisView_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub BtnBorra_Click(sender As Object, e As EventArgs) Handles btnBorra.Click



    End Sub

    Private Sub LstVPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstVPrincipal.SelectedIndexChanged

        ''MsgBox(lstVPrincipal.FocusedItem.Index)   ' *** focuseditem, nos recoge el elemento que toma el foco.

        'For aa As Integer = 0 To lstVPrincipal.SelectedIndices.Count - 1
        '    MsgBox(lstVPrincipal.SelectedIndices.Item(aa) & " " & aa)
        '    MsgBox(lstVPrincipal.SelectedItems.Item(aa).SubItems(0).Text)                'Coindide con .SubItems(0).Text 
        '    MsgBox(lstVPrincipal.SelectedItems.Item(aa).SubItems(1).Text)
        '    MsgBox(lstVPrincipal.SelectedItems.Item(aa).SubItems(2).Text)
        'Next


    End Sub
End Class
