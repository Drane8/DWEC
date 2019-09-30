Public Class frmListbox

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

        ' Añadirmos los textos de los textbox a los distintos listbox en el mismo orden
        'lstBN1.Items.Add(txtCampo1.Text)
        'lstBN2.Items.Add(txtCampo2.Text)
        'lstBN3.Items.Add(txtCampo3.Text)  Añaderian elementos en blanco si el txtCampo=""

        If txtCampo1.Text <> "" Then lstBN1.Items.Add(txtCampo1.Text)
        If txtCampo2.Text <> "" Then lstBN2.Items.Add(txtCampo2.Text)
        If txtCampo3.Text <> "" Then lstBN3.Items.Add(txtCampo3.Text)

        If lstBN1.Items.Count + lstBN2.Items.Count + lstBN3.Items.Count > 0 Then
            btnCopiar.Enabled = True
            ' activo los correspondientes radiobuttons si hay datos
            If lstBN1.Items.Count > 0 Then rbLista1.Enabled = True
            If lstBN2.Items.Count > 0 Then rbLista2.Enabled = True
            If lstBN3.Items.Count > 0 Then rbLista3.Enabled = True
        End If

        Contadores()
        BorrarTxt()

    End Sub
    Private Sub BorrarTxt()

        txtCampo1.Text = "" : txtCampo2.Text = "" : txtCampo3.Text = ""   ' El caracter ":" nos vale para poner más de una instrucción por linea

    End Sub
    Private Sub Contadores()

        'Actualiza los contadores de elemtos en los lsibox...
        lblCon1.Text = "ListBox 1: " & CStr(lstBN1.Items.Count)
        lblCon2.Text = "ListBox 2: " & CStr(lstBN2.Items.Count)
        lblCon3.Text = "ListBox 3: " & CStr(lstBN3.Items.Count)

    End Sub
    Private Sub LstBN1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBN1.SelectedIndexChanged

        ' Asigno el valor seleccionado a txt correspondiente
        txtCampo1.Text = lstBN1.SelectedItem
        ' Activo resto de botones
        btnActualiza.Enabled = True
        btnBorra.Enabled = True

    End Sub

    Private Sub LstBN2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBN2.SelectedIndexChanged
        ' Asigno el valor seleccionado a txt correspondiente
        txtCampo2.Text = lstBN2.SelectedItem
        btnActualiza.Enabled = True
        btnBorra.Enabled = True

    End Sub

    Private Sub LstBN3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBN3.SelectedIndexChanged
        ' Asigno el valor seleccionado a txt correspondiente
        txtCampo3.Text = lstBN3.SelectedItem
        btnActualiza.Enabled = True
        btnBorra.Enabled = True


    End Sub

    Private Sub BtnActualiza_Click(sender As Object, e As EventArgs) Handles btnActualiza.Click

        Dim iIndice1, iIndice2, iIndice3 As Integer   ' Para guardar los indices de los elemento seleccionado

        'Que elemento está seleccionado...
        iIndice1 = lstBN1.SelectedIndex
        iIndice2 = lstBN2.SelectedIndex
        iIndice3 = lstBN3.SelectedIndex

        'Actualizo el elemnto seleccionado siempre y cuando este cambie y este seleccionado
        'si el indice es -1, no hay nada seleccionado
        If iIndice1 > -1 AndAlso txtCampo1.Text <> lstBN1.SelectedItem Then
            lstBN1.Items(iIndice1) = txtCampo1.Text
        End If

        If iIndice2 > -1 AndAlso txtCampo2.Text <> lstBN2.SelectedItem Then
            lstBN2.Items(iIndice2) = txtCampo2.Text
        End If

        If iIndice3 > -1 AndAlso txtCampo3.Text <> lstBN3.SelectedItem Then
            lstBN3.Items(iIndice3) = txtCampo3.Text
        End If

    End Sub

    Private Sub FrmListbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnActualiza.Enabled = False
        btnBorra.Enabled = False
        btnCopiar.Enabled = False

        ' Desactivo todos los radiobuttons y checkbox

        rbLista1.Checked = False : rbLista1.Enabled = False
        rbLista2.Checked = False : rbLista2.Enabled = False
        rbLista3.Checked = False : rbLista3.Enabled = False

        cbLista1.Checked = False : cbLista1.Enabled = False
        cbLista2.Checked = False : cbLista2.Enabled = False
        cbLista3.Checked = False : cbLista3.Enabled = False

    End Sub

    Private Sub BtnBorra_Click(sender As Object, e As EventArgs) Handles btnBorra.Click

        ' Borro los elementos seleccionados

        If lstBN1.SelectedIndex > -1 Then lstBN1.Items.Remove(lstBN1.SelectedItem)

        If lstBN2.SelectedIndex > -1 Then lstBN2.Items.Remove(lstBN2.Items(lstBN2.SelectedIndex))

        If lstBN3.SelectedIndex > -1 Then lstBN3.Items.Remove(lstBN3.SelectedItem)


        Contadores()    ' Actualizo los contadores
    End Sub

    Private Sub BtnCopiar_Click(sender As Object, e As EventArgs) Handles btnCopiar.Click
        Static Dim boolFuente As Boolean = True

        If rbLista1.Checked Then
            If cbLista2.CheckState = CheckState.Checked Then lstBN2.Items.AddRange(lstBN1.Items)
            If cbLista3.CheckState = CheckState.Checked Then lstBN3.Items.AddRange(lstBN1.Items)
        End If
        If rbLista2.Checked Then
            If cbLista1.CheckState = CheckState.Checked Then lstBN1.Items.AddRange(lstBN2.Items)
            If cbLista3.CheckState = CheckState.Checked Then lstBN3.Items.AddRange(lstBN2.Items)
        End If
        If rbLista3.Checked Then
            If cbLista1.CheckState = CheckState.Checked Then lstBN1.Items.AddRange(lstBN3.Items)
            If cbLista2.CheckState = CheckState.Checked Then lstBN2.Items.AddRange(lstBN3.Items)
        End If

    End Sub

    Private Sub RbLista1_CheckedChanged(sender As Object, e As EventArgs) Handles rbLista1.CheckedChanged
        ' Activo los check correspondientes y los desmarco
        cbLista1.Enabled = False
        cbLista2.Enabled = True
        cbLista3.Enabled = True

        QuitaChecks()
    End Sub


    Private Sub RbLista2_CheckedChanged(sender As Object, e As EventArgs) Handles rbLista2.CheckedChanged
        ' Activo los chek correspondientes
        cbLista1.Enabled = True
        cbLista2.Enabled = False
        cbLista3.Enabled = True

        QuitaChecks()
    End Sub

    Private Sub RbLista3_CheckedChanged(sender As Object, e As EventArgs) Handles rbLista3.CheckedChanged
        ' Activo los chek correspondientes
        cbLista2.Enabled = True
        cbLista1.Enabled = True
        cbLista3.Enabled = False

        QuitaChecks()
    End Sub
    Private Sub QuitaChecks()
        cbLista1.Checked = False
        cbLista2.Checked = False
        cbLista3.Checked = False
    End Sub

End Class
