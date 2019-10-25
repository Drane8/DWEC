Public Class fPortada
    Private Sub FPortada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            pbPortada.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "..\..\Resources\libreria\" & fLibreria.lbLibros.SelectedItem.ToString & ".jpg")
        Catch ex As System.IO.FileNotFoundException
            pbPortada.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "..\..\Resources\libreria\NODISP.jpg")
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class