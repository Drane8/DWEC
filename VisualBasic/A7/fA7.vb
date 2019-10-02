Public Class fA7
    Private Sub FA7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim primo As Boolean = True
        tbPrimos.Text = “Prime Numbers are : “
        For num As Integer = 1 To 100 Step 1
            For i As Integer = 2 To num - 1 Step 1
                If num Mod i = 0 Then
                    primo = False
                    Exit For
                Else
                    primo = True
                End If
            Next
            If primo = True Then
                tbPrimos.AppendText(num & " ")
            End If
        Next

    End Sub
End Class
