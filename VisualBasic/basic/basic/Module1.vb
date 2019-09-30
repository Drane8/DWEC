Imports System.Console

Module Module1

    Sub Main()
        Dim sNombre As String = "Dani"
        Dim dFecha As Date
        Dim otra As Integer = 2

        dFecha = #11/14/2019 5:10#

        WriteLine(sNombre & " " & dFecha)
        sNombre = sNombre & " " & ReadLine()
        sNombre = sNombre & " " & CStr(otra) & CType(otra + 5, String)
        WriteLine(sNombre)
        ReadKey()
    End Sub

End Module
