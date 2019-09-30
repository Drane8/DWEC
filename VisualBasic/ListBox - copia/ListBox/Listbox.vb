Public Class frmListbox


    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

        ' Añadirmos los textos de los textbox a los distintos listbox en el mismo orden
        'lstBN1.Items.Add(txtCampo1.Text)
        'lstBN2.Items.Add(txtCampo2.Text)
        'lstBN3.Items.Add(txtCampo3.Text)  Añaderian elementos en blanco si el txtCampo=""

        If txt1LB1.Text <> "" Then lstBN1.Items.Add(txt1LB1.Text)
        If txt2LB1.Text <> "" Then lstBN1.Items.Add(txt2LB1.Text)
        If txt3LB1.Text <> "" Then lstBN1.Items.Add(txt3LB1.Text)

        If txt1LB2.Text <> "" Then lstBN2.Items.Add(txt1LB2.Text)
        If txt2LB2.Text <> "" Then lstBN2.Items.Add(txt2LB2.Text)
        If txt3LB2.Text <> "" Then lstBN2.Items.Add(txt3LB2.Text)

        If txt1LB3.Text <> "" Then lstBN3.Items.Add(txt1LB3.Text)
        If txt2LB3.Text <> "" Then lstBN3.Items.Add(txt2LB3.Text)
        If txt3LB3.Text <> "" Then lstBN3.Items.Add(txt3LB3.Text)

        If lstBN1.Items.Count + lstBN2.Items.Count + lstBN3.Items.Count > 0 Then
            btnCopiar.Enabled = True
            ' activo los correspondientes radiobuttons si hay datos
            If lstBN1.Items.Count > 0 Then rbLista1.Enabled = True
            If lstBN2.Items.Count > 0 Then rbLista2.Enabled = True
            If lstBN3.Items.Count > 0 Then rbLista3.Enabled = True
        End If

        Contadores()
        BorrarTxt()
        lstBN1.ClearSelected()
        lstBN2.ClearSelected()
        lstBN3.ClearSelected()

    End Sub
    Private Sub BorrarTxt()

        ' El caracter ":" nos vale para poner más de una instrucción por linea
        txt1LB1.Text = "" : txt2LB1.Text = "" : txt3LB1.Text = ""
        txt1LB2.Text = "" : txt2LB2.Text = "" : txt3LB2.Text = ""
        txt1LB3.Text = "" : txt2LB3.Text = "" : txt3LB3.Text = ""

    End Sub
    Private Sub Contadores()

        'Actualiza los contadores de elemtos en los lsibox...
        lblCon1.Text = "ListBox 1: " & CStr(lstBN1.Items.Count)
        lblCon2.Text = "ListBox 2: " & CStr(lstBN2.Items.Count)
        lblCon3.Text = "ListBox 3: " & CStr(lstBN3.Items.Count)

    End Sub
    Private Sub LstBN1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBN1.SelectedIndexChanged

        ' Asigno el valor seleccionado a txt correspondiente
        If lstBN1.SelectedItems.Count = 1 Then
            txt1LB1.Text = lstBN1.SelectedItems(0)
            txt2LB1.Text = ""
            txt3LB1.Text = ""
        ElseIf lstBN1.SelectedItems.Count = 2 Then
            txt1LB1.Text = lstBN1.SelectedItems(0)
            txt2LB1.Text = lstBN1.SelectedItems(1)
            txt3LB1.Text = ""
        ElseIf lstBN1.SelectedItems.Count = 3 Then
            txt1LB1.Text = lstBN1.SelectedItems(0)
            txt2LB1.Text = lstBN1.SelectedItems(1)
            txt3LB1.Text = lstBN1.SelectedItems(2)
        ElseIf lstBN1.SelectedItems.Count = 4 Then
            'coger el indice del ultimo seleccionado y eliminarlo de la seleccion
            lstBN1.SelectedItems.Remove(lstBN1.SelectedItems(3))
            txt1LB1.Text = lstBN1.SelectedItems(0)
            txt2LB1.Text = lstBN1.SelectedItems(1)
            txt3LB1.Text = lstBN1.SelectedItems(2)
        Else
            txt1LB1.Text = ""
            txt2LB1.Text = ""
            txt3LB1.Text = ""
        End If
        ' Activo resto de botones
        btnActualiza.Enabled = True
        btnBorra.Enabled = True

    End Sub

    Private Sub LstBN2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBN2.SelectedIndexChanged
        ' Asigno el valor seleccionado a txt correspondiente
        If lstBN2.SelectedItems.Count = 1 Then
            txt1LB2.Text = lstBN2.SelectedItems(0)
            txt2LB2.Text = ""
            txt3LB2.Text = ""
        ElseIf lstBN2.SelectedItems.Count = 2 Then
            txt1LB2.Text = lstBN2.SelectedItems(0)
            txt2LB2.Text = lstBN2.SelectedItems(1)
            txt3LB2.Text = ""
        ElseIf lstBN2.SelectedItems.Count = 3 Then
            txt1LB2.Text = lstBN2.SelectedItems(0)
            txt2LB2.Text = lstBN2.SelectedItems(1)
            txt3LB2.Text = lstBN2.SelectedItems(2)
        ElseIf lstBN2.SelectedItems.Count = 4 Then
            'coger el indice del ultimo seleccionado y eliminarlo de la seleccion
            lstBN2.SelectedItems.Remove(lstBN2.SelectedItems(3))
            txt1LB2.Text = lstBN2.SelectedItems(0)
            txt2LB2.Text = lstBN2.SelectedItems(1)
            txt3LB2.Text = lstBN2.SelectedItems(2)
        Else
            txt1LB2.Text = ""
            txt2LB2.Text = ""
            txt3LB2.Text = ""
        End If
        btnActualiza.Enabled = True
        btnBorra.Enabled = True

    End Sub

    Private Sub LstBN3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBN3.SelectedIndexChanged
        ' Asigno el valor seleccionado a txt correspondiente
        If lstBN3.SelectedItems.Count = 1 Then
            txt1LB3.Text = lstBN3.SelectedItems(0)
            txt2LB3.Text = ""
            txt3LB3.Text = ""
        ElseIf lstBN3.SelectedItems.Count = 2 Then
            txt1LB3.Text = lstBN3.SelectedItems(0)
            txt2LB3.Text = lstBN3.SelectedItems(1)
            txt3LB3.Text = ""
        ElseIf lstBN3.SelectedItems.Count = 3 Then
            txt1LB3.Text = lstBN3.SelectedItems(0)
            txt2LB3.Text = lstBN3.SelectedItems(1)
            txt3LB3.Text = lstBN3.SelectedItems(2)
        ElseIf lstBN3.SelectedItems.Count = 4 Then
            'coger el indice del ultimo seleccionado y eliminarlo de la seleccion
            lstBN3.SelectedItems.Remove(lstBN3.SelectedItems(3))
            txt1LB3.Text = lstBN3.SelectedItems(0)
            txt2LB3.Text = lstBN3.SelectedItems(1)
            txt3LB3.Text = lstBN3.SelectedItems(2)
        Else
            txt1LB3.Text = ""
            txt2LB3.Text = ""
            txt3LB3.Text = ""
        End If
        btnActualiza.Enabled = True
        btnBorra.Enabled = True


    End Sub

    Private Sub BtnActualiza_Click(sender As Object, e As EventArgs) Handles btnActualiza.Click

        Dim text1, text2, text3 As String   ' Para guardar los indices de los elemento seleccionado

        'Que elemento está seleccionado...
        text1 = txt1LB1.Text
        text2 = txt2LB1.Text
        text3 = txt3LB1.Text

        'Actualizo el elemnto seleccionado siempre y cuando este cambie y este seleccionado
        'si el indice es -1, no hay nada seleccionado
        If lstBN1.SelectedItems.Count = 1 And text1 <> "" Then
            lstBN1.Items(lstBN1.SelectedIndices(0)) = text1
        End If
        If lstBN1.SelectedItems.Count = 2 Then
            If text2 <> "" Then lstBN1.Items(lstBN1.SelectedIndices(1)) = text2
            If text1 <> "" Then lstBN1.Items(lstBN1.SelectedIndices(0)) = text1
        End If
        If lstBN1.SelectedItems.Count = 3 Then
            If text3 <> "" Then lstBN1.Items(lstBN1.SelectedIndices(2)) = text3
            If text2 <> "" Then lstBN1.Items(lstBN1.SelectedIndices(1)) = text2
            If text1 <> "" Then lstBN1.Items(lstBN1.SelectedIndices(0)) = text1
        End If

        lstBN1.ClearSelected()

        text1 = txt1LB2.Text
        text2 = txt2LB2.Text
        text3 = txt3LB2.Text

        If lstBN2.SelectedItems.Count = 1 And text1 <> "" Then
            lstBN2.Items(lstBN2.SelectedIndices(0)) = text1
        End If
        If lstBN2.SelectedItems.Count = 2 Then
            If text2 <> "" Then lstBN2.Items(lstBN2.SelectedIndices(1)) = text2
            If text1 <> "" Then lstBN2.Items(lstBN2.SelectedIndices(0)) = text1
        End If
        If lstBN2.SelectedItems.Count = 3 Then
            If text3 <> "" Then lstBN2.Items(lstBN2.SelectedIndices(2)) = text3
            If text2 <> "" Then lstBN2.Items(lstBN2.SelectedIndices(1)) = text2
            If text1 <> "" Then lstBN2.Items(lstBN2.SelectedIndices(0)) = text1
        End If

        lstBN2.ClearSelected()

        text1 = txt1LB3.Text
        text2 = txt2LB3.Text
        text3 = txt3LB3.Text

        If lstBN3.SelectedItems.Count = 1 And text1 <> "" Then
            lstBN3.Items(lstBN3.SelectedIndices(0)) = text1
        End If
        If lstBN3.SelectedItems.Count = 2 Then
            If text2 <> "" Then lstBN3.Items(lstBN3.SelectedIndices(1)) = text2
            If text1 <> "" Then lstBN3.Items(lstBN3.SelectedIndices(0)) = text1
        End If
        If lstBN3.SelectedItems.Count = 3 Then
            If text3 <> "" Then lstBN3.Items(lstBN3.SelectedIndices(2)) = text3
            If text2 <> "" Then lstBN3.Items(lstBN3.SelectedIndices(1)) = text2
            If text1 <> "" Then lstBN3.Items(lstBN3.SelectedIndices(0)) = text1
        End If

        lstBN3.ClearSelected()

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

        'If lstBN1.SelectedIndex > -1 Then lstBN1.Items.Remove(lstBN1.SelectedItem)

        'If lstBN2.SelectedIndex > -1 Then lstBN2.Items.Remove(lstBN2.Items(lstBN2.SelectedIndex))

        'If lstBN3.SelectedIndex > -1 Then lstBN3.Items.Remove(lstBN3.SelectedItem)

        If lstBN1.SelectedItems.Count > 0 Then
            For i As Integer = lstBN1.SelectedIndices.Count - 1 To 0 Step -1
                Dim indice As Integer = lstBN1.SelectedIndices(i)
                lstBN1.Items.RemoveAt(indice)
            Next
        End If

        If lstBN2.SelectedItems.Count > 0 Then
            For i As Integer = lstBN2.SelectedIndices.Count - 1 To 0 Step -1
                Dim indice As Integer = lstBN2.SelectedIndices(i)
                lstBN2.Items.RemoveAt(indice)
            Next
        End If

        If lstBN3.SelectedItems.Count > 0 Then
            For i As Integer = lstBN3.SelectedIndices.Count - 1 To 0 Step -1
                Dim indice As Integer = lstBN3.SelectedIndices(i)
                lstBN3.Items.RemoveAt(indice)
            Next
        End If

        If lstBN1.Items.Count = 0 And lstBN2.Items.Count = 0 And lstBN3.Items.Count = 0 Then
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
        End If


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

        Contadores()
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
