Public Class fVuelos
    Dim origen() = {"BARCELONA", "BILBAO", "MADRID", "SANTANDER", "VITORIA", "ZARAGOZA"}
    Dim destNac() = {"BARCELONA", "BILBAO", "MADRID", "SANTANDER", "VITORIA", "ZARAGOZA"}
    Dim destInt() = {"AMSTERDAN", "ESTOCOLMO", "LONDRES", "NEW YORK", "PARIS", "SIDNEY"}
    Dim tarifas() = {150, 200, 300, 500}
    Private Sub FVuelos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To origen.Count - 1
            ComboBox1.Items.Add(origen(i))
        Next
        For i As Integer = 0 To destNac.Count - 1
            ListBox1.Items.Add(destNac(i))
        Next

        For i As Integer = 0 To destInt.Count - 1
            ListBox2.Items.Add(destInt(i))
        Next
        ComboBox2.SelectedIndex = 0
    End Sub

End Class
