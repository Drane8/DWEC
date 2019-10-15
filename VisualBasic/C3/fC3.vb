Public Class fC3
    Private Sub FC3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Dim matriz(2, 2) As Integer
        Dim total As Integer = 0
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                matriz(i, j) = CInt(100 * Rnd() + 1)
            Next
        Next

        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                lblMatriz.Text &= matriz(i, j) & " "
            Next
            lblMatriz.Text &= vbNewLine
        Next

        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                If i = j Then total += matriz(i, j)
                If i + j = matriz.GetLength(0) Then total += matriz(i, j)
            Next
        Next
        lblResul.Text = "Suma: " & total
    End Sub
End Class
