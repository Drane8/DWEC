Public Class fC7
    Dim matrizOriginal(3, 3) As Integer
    Private Sub FC7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        For i As Integer = 0 To 3
            For j As Integer = 0 To 3
                matrizOriginal(i, j) = CInt(9 * Rnd())
            Next
        Next
        For i As Integer = 0 To 3
            lvArrayOriginal.Columns.Add("")
            lvArrayOriginal.Columns(i).Width() = 20
            lvArrayOriginal.Items.Add(matrizOriginal(i, 0))
            For j As Integer = 1 To 3
                lvArrayOriginal.Items(i).SubItems.Add(matrizOriginal(i, j))
            Next
        Next
    End Sub
End Class
