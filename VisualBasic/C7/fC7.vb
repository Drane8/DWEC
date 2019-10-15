Public Class fC7
    Dim matrizOriginal(1, 3) As Integer
    Private Sub FC7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        For i As Integer = 0 To 1
            For j As Integer = 0 To 3
                matrizOriginal(i, j) = CInt(10 * Rnd())
            Next
        Next

        For i As Integer = 0 To 3
            lvArrayOriginal.Items.Add(matrizOriginal(0, i))
            lvArrayOriginal.Items(i).SubItems.Add(matrizOriginal(1, i))
        Next
    End Sub
End Class
