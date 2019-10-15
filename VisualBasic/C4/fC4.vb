Public Class fC4
    Dim list As List(Of KeyValuePair(Of String, ArrayList)) =
            New List(Of KeyValuePair(Of String, ArrayList))
    Dim total As Integer = 0
    Private Sub FC4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNota_Click(sender As Object, e As EventArgs) Handles btnNota.Click
        Dim nombre As String = tbNombre.Text
        Dim nota As Double
        If nombre = "" Or tbNota.Text = "" Then
            MessageBox.Show("Introduzca todos los numeros")
        ElseIf Not Double.TryParse(tbNota.Text, nota) Then
            MessageBox.Show("Introduzca valores validos")
        ElseIf total < 40 Then
            Dim existe = False
            For Each pair As KeyValuePair(Of String, ArrayList) In list
                Dim key As String = pair.Key
                Dim values As ArrayList = pair.Value
                If nombre = key Then
                    values.Add(nota)
                    existe = True
                End If
            Next
            If Not existe Then
                Dim aux As ArrayList = New ArrayList()
                aux.Add(nota)
                list.Add(New KeyValuePair(Of String, ArrayList)(nombre, aux))
                total += 1
            End If
            lbAlumnos.Items.Clear()
            For Each pair As KeyValuePair(Of String, ArrayList) In list
                Dim key As String = pair.Key
                lbAlumnos.Items.Add(key)
            Next
        Else
            MessageBox.Show("Máximo de alumnos introducido")
        End If
        tbNombre.Text = ""
        tbNota.Text = ""
    End Sub

    Private Sub LbAlumnos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbAlumnos.SelectedIndexChanged
        tbNombre.Text = lbAlumnos.SelectedItem
        tbNota.Text = ""
    End Sub

    Private Sub BtnMedia_Click(sender As Object, e As EventArgs) Handles btnMedia.Click
        Dim media As Double = 0
        Dim contador As Integer = 0
        For Each pair As KeyValuePair(Of String, ArrayList) In list
            Dim notas As ArrayList = pair.Value
            For Each nota As Double In notas
                media += nota
                contador += 1
            Next
        Next
        lblMedia.Text = "Media: " & (media / contador)
    End Sub
End Class