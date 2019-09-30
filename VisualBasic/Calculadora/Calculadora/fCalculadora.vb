Public Class fCalculadora
    Dim resul As Double
    Dim ultimo As Double
    Dim nuevo As Boolean = True
    Dim operacion As String = ""

    Private Sub PNumero(ByVal aa As String)
        If tbResul.Text.Equals("0") Or nuevo Then
            tbResul.Text = aa
            nuevo = False
        Else
            tbResul.AppendText(aa)
        End If
        ultimo = CDbl(tbResul.Text)
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message,
                                           ByVal keyData As System.Windows.Forms.Keys) _
                                           As Boolean
        Select Case msg.WParam.ToInt32()
            Case CInt(Keys.NumPad0)
                btn0.PerformClick()
                Return True
            Case CInt(Keys.NumPad1)
                btn1.PerformClick()
                Return True
            Case CInt(Keys.NumPad2)
                btn2.PerformClick()
                Return True
            Case CInt(Keys.NumPad3)
                btn3.PerformClick()
                Return True
            Case CInt(Keys.NumPad4)
                btn4.PerformClick()
                Return True
            Case CInt(Keys.NumPad5)
                btn5.PerformClick()
                Return True
            Case CInt(Keys.NumPad6)
                btn7.PerformClick()
                Return True
            Case CInt(Keys.NumPad7)
                btn7.PerformClick()
                Return True
            Case CInt(Keys.NumPad8)
                btn8.PerformClick()
                Return True
            Case CInt(Keys.NumPad9)
                btn9.PerformClick()
                Return True
            Case CInt(Keys.Add)
                btnSuma.PerformClick()
                Return True
            Case CInt(Keys.Subtract)
                btnResta.PerformClick()
                Return True
            Case CInt(Keys.Multiply)
                btnMult.PerformClick()
                Return True
            Case CInt(Keys.Divide)
                btnDiv.PerformClick()
                Return True
            Case CInt(Keys.Enter)
                btnResul.PerformClick()
                Return True
            Case CInt(Keys.Back)
                btnBorrar.PerformClick()
                Return True
            Case CInt(Keys.Decimal)
                btnComa.PerformClick()
                Return True
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        PNumero("0")
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        PNumero("1")
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        PNumero("2")
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        PNumero("3")
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        PNumero("4")
    End Sub


    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        PNumero("5")
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        PNumero("6")
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        PNumero("7")
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        PNumero("8")
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        PNumero("9")
    End Sub

    Private Sub BtnComa_Click(sender As Object, e As EventArgs) Handles btnComa.Click
        If Not tbResul.Text.Contains(",") Then
            If tbResul.Text.Length = 0 Then
                tbResul.AppendText("0,")
            Else
                tbResul.AppendText(",")
            End If
        End If

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If Not (tbResul.Text.Length = 0) Then
            tbResul.Text = tbResul.Text.Remove(CInt(tbResul.Text.Length - 1))
            If tbResul.Text.Length = 0 Then
                tbResul.Text = "0"
            End If
        End If
    End Sub

    Private Sub BtnCambio_Click(sender As Object, e As EventArgs) Handles btnCambio.Click
        If tbResul.Text.Contains("-") Then
            tbResul.Text = tbResul.Text.Remove(0, 1)
        Else
            tbResul.Text = "-" & tbResul.Text
        End If
    End Sub

    Private Sub BtnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        BOperacion("+")
    End Sub

    Private Sub BtnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        BOperacion("-")

    End Sub

    Private Sub BtnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        BOperacion("×")
    End Sub

    Private Sub BtnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        BOperacion("÷")
    End Sub

    Private Sub BOperacion(tipo As String)
        ultimo = CDbl(tbResul.Text)
        If Not nuevo Then
            operar()
            tbHistorial.AppendText(tbResul.Text & " " & tipo & " ")
            nuevo = True
        ElseIf nuevo And ultimo = CDbl(tbResul.Text) And Not (tbHistorial.Text.Length = 0) Then
            tbHistorial.Text = tbHistorial.Text.Remove(CInt(tbHistorial.Text.Length - 3)) & " " & tipo & " "
        End If
        operacion = tipo
    End Sub

    Private Sub operar()
        Select Case operacion
            Case "+"
                resul = resul + ultimo
            Case "-"
                resul = resul - ultimo
            Case "×"
                resul = resul * ultimo
            Case "÷"
                resul = resul / ultimo
            Case Else
                resul = tbResul.Text
        End Select
    End Sub

    Private Sub BtnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        tbResul.Text = "0"
        nuevo = False
        If tbHistorial.TextLength = 0 Then
            resul = 0
        End If
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        resul = 0
        ultimo = 0
        nuevo = True
        operacion = ""
        tbResul.Text = "0"
        tbHistorial.Clear()

    End Sub

    Private Sub BtnResul_Click(sender As Object, e As EventArgs) Handles btnResul.Click
        operar()
        tbResul.Text = CStr(resul)
        tbHistorial.Clear()
        nuevo = True
    End Sub
End Class
