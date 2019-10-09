Public Class fB2
    Private Sub BtnInvertir_Click(sender As Object, e As EventArgs) Handles btnInvertir.Click
        Dim numero As Integer
        If tbNum.Text = "" Then
            MessageBox.Show("Introduzca un numero")
        ElseIf Not Integer.TryParse(tbNum.Text, numero) Then
            MessageBox.Show("Introduzca un valor valido")
        Else
            tbResul.Text = CStr(invertirNumero(numero))
        End If
    End Sub

    Private Function invertirNumero(numero As Integer) As Integer
        Dim aux As String = CStr(numero)
        Dim invertido As String = ""
        For i = (aux.Length - 1) To 0 Step -1
            invertido = invertido & aux.Substring(i, 1)
        Next
        Return CInt(invertido)
    End Function

End Class
