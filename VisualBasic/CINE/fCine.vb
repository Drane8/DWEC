Imports System.IO

Public Class fCine
    Dim entradas(3) As Integer
    Dim aula, cines As String
    Dim contador = 1
    Private Sub MnuFin_Click(sender As Object, e As EventArgs) Handles mnuFin.Click
        btnTerminar.PerformClick()
    End Sub

    Private Sub BtnTerminar_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        End
    End Sub

    Private Sub CbSalas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSalas.SelectedIndexChanged
        lbPeliculas.SelectedIndex = cbSalas.SelectedIndex
    End Sub

    Private Sub MnuSala1_Click(sender As Object, e As EventArgs) Handles mnuSala1.Click
        cbSalas.SelectedIndex = 0
    End Sub

    Private Sub MnuSala2_Click(sender As Object, e As EventArgs) Handles mnuSala2.Click
        cbSalas.SelectedIndex = 1
    End Sub

    Private Sub MnuSala3_Click(sender As Object, e As EventArgs) Handles mnuSala3.Click
        cbSalas.SelectedIndex = 2
    End Sub

    Private Sub MnuSala4_Click(sender As Object, e As EventArgs) Handles mnuSala4.Click
        cbSalas.SelectedIndex = 3
    End Sub

    Private Sub LbPeliculas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPeliculas.SelectedIndexChanged
        Try
            pbCartel.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "..\..\Resources\cartel_peliculas\" & lbPeliculas.SelectedItem.ToString & ".jpg")
        Catch ex As FileNotFoundException
            pbCartel.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "..\..\Resources\cartel_peliculas\NO DISPONIBLE.jpg")
        End Try
        Try
            rtbSinopsis.LoadFile(AppDomain.CurrentDomain.BaseDirectory & "..\..\Resources\sinopsis_peliculas\" & lbPeliculas.SelectedItem.ToString & ".rtf")
        Catch ex As FileNotFoundException
            rtbSinopsis.Text = "Sinopsis no disponible"
        End Try
        lblEntradas.Text = entradas(lbPeliculas.SelectedIndex)
    End Sub

    Private Sub CompraDeLocalidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraDeLocalidadesToolStripMenuItem.Click
        If cbSalas.SelectedIndex < 0 Then
            MsgBox("No se ha seleccionado niguna pelicula", vbOKOnly, "WARNING!!")
        Else
            fCompra.tbPeliculaSelec.Text = lbPeliculas.SelectedItem.ToString
            fCompra.ShowDialog()
        End If
    End Sub

    Public Sub comprarEntradas(cantidad As Integer)
        entradas(lbPeliculas.SelectedIndex) += cantidad
        lblEntradas.Text = entradas(lbPeliculas.SelectedIndex)
    End Sub

    Private Sub FCine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        aula = "AULA --- 27"
        cines = "CINES"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If contador < aula.Length Then
            lblTitulo.Text = aula.Substring(0, contador)
            contador += 1
        Else
            If lblTitulo.Text = aula Then
                lblTitulo.Text = cines
            Else
                lblTitulo.Text = aula
            End If
        End If
    End Sub
End Class
