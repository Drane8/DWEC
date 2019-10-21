Public Class fC8
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()

        Dim array(9) As Integer
        Dim duplicados As Integer = 0
        Dim positivos As Integer = 0
        Dim negativos As Integer = 0
        Dim ceros As Integer = 0

        For i = 0 To 9
            array(i) = CInt((Rnd() * Math.Pow(-1, CInt(Rnd() * 10))) * 9)
            lblResul.Text &= array(i) & "   "
        Next
        For i = 0 To 9
            If array(i) < 0 Then
                negativos += 1
            ElseIf array(i) > 0 Then
                positivos += 1
            Else
                ceros += 1
            End If
        Next

        Dim arrayUnicos = array.Distinct()
        For Each num As Integer In arrayUnicos
            If array.Count(Function(numero) numero = num) > 1 Then duplicados += 1
        Next

        lblResul.Text &= vbNewLine & vbNewLine & "Positivos: " & positivos &
            vbNewLine & "Ceros: " & ceros &
            vbNewLine & "Negativos: " & negativos &
            vbNewLine & "Duplicados: " & duplicados
    End Sub
End Class
