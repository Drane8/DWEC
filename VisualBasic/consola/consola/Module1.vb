
Imports System

Module Module1
    Dim pepe As Date
    Sub Main()
        ' Declaracion de 3 cadenas con su inicialización
        Dim strCadenaA As String = "hola", strCadenaB As String = "que tal ", strCadenaC As String = "estas"

        ' Declaracion de variable tipo fecha e inicializaciones
        ' clase DateTime: parámetros año, mes, dia, hora, minuto, segundo
        Dim dateFechaA As New Date(2012, 12, 16, 12, 0, 0)
        'o tambien 
        Dim dateFechaB As Date = #12/16/2012 12:00:52 AM#
        ' Son equivalentes tanto Date (antiguo) como DateTime (actual)
        Dim dateFechaC As Date = Date.Now
        Dim dateFechaC2 As Date = System.DateTime.Now
        Dim dateFechaD As Date = Date.UtcNow
        Dim dateFechaD2 As Date = System.DateTime.UtcNow
        Dim dateFechaE As Date = Date.Today
        Dim dateFechaE2 As Date = System.DateTime.Today


        ' el método subtract, necesita un objeto TimeSpan, no funciona con objeto Date
        ' TimeSpan es una estructura que contiene UNA DIFERENCIA DE 2 TIEMPOS/FECHAS + o -
        Dim aa As TimeSpan
        aa = dateFechaC.Subtract(dateFechaB)

        System.Console.WriteLine(dateFechaD.ToString)
        System.Console.WriteLine(aa.ToString)

        'Estruturas de control
        'If expresion Then sentencia
        If strCadenaA <> "aa" Then System.Console.WriteLine("no")

        'If expresion Then
        '    sentencia
        '    ...
        '[Else
        '    sentencia
        '    ...]

        'End If

        If strCadenaA <> "aa" Then
            System.Console.WriteLine("no")
        End If

        'If expresion Then
        '    sentencia
        '    ...
        'ElseIf expresion Then
        '    sentencia
        '    ...
        'Else
        '    sentencia
        '    ...
        'End If
        If strCadenaA <> "aa" Then
            System.Console.WriteLine("no")
        ElseIf strCadenaA = "ab" Then
            System.Console.WriteLine("no")
        End If

        'Select Case variable
        '    Case valor - valor2
        '        sentencias
        '        ...
        '    Case valor
        '        sentencias
        '        ...
        '    Case valor1, valor2, valor3
        '    [Case Else
        '        sentencias
        '        ....]
        'End Select
        Select Case strCadenaB
            Case "aa"
                System.Console.WriteLine("AA")
            Case 1 - 5
                System.Console.WriteLine("de 1 a 5")
            Case 1, "aa", 2, 4, strCadenaC
                System.Console.WriteLine("uff")
            Case Else
                System.Console.WriteLine("na")
        End Select


        'Bucles
        'Do { While | Until } condicion  
        '    [ sentencia ]  
        '       [ Continue Do ]  
        '    [ sentencia ]  
        '       [ Exit Do ]  
        '    [ sentencia ]  
        'Loop

        'Do
        '    [ sentencia ]  
        '       [ Continue Do ]  
        '    [ sentencia ]  
        '       [ Exit Do ]  
        '    [ sentencia ]  
        'Loop { While | Until } condicion  

        'While condition
        '    [ sentencia ]  
        '       [ Continue while ]  
        '    [ sentencia ]  
        '       [ Exit while ]  
        '    [ sentencia ]  
        'End While


        'For coontador [ As datatype ] = ValorInicial To ValorFinal [ Step ValorSalto ]
        '    [ sentencia ]  
        '       [ Continue for ]  
        '    [ sentencia ]  
        '       [ Exit for ]  
        '    [ sentencia ]  
        'Next [ contador ]

        For i As Short = 0 To 1000 Step 2
            System.Console.Write(i & " ")
        Next
        System.Console.WriteLine()


        'Repite un grupo de instrucciones para cada elemento de una colección
        'For Each elemento [ As datatype ] In coleccion
        '    [ sentencia ]  
        '       [ Continue for ]  
        '    [ sentencia ]  
        '       [ Exit for ]  
        '    [ sentencia ]  
        'Next [ elemento ]

        Dim iArray As Array = {1, 2, 3, 4, 5, 6, 7, 8}  'Objeto array (cualquier cosa, en este caso enteros)
        For Each i As Integer In iArray
            System.Console.Write(i & " ")
        Next
        System.Console.WriteLine("Elementos totales del vector: " & iArray.Length)

        Dim strArray(,) As String = {{"a1a", "a2"}, {"b1b", "b2"}, {"c1c", "c3"}, {"d1d", "d2"}, {"e1e", "e2"}} ' dim strArray(5,2)

        ' Cuantas dimensiones?
        System.Console.WriteLine()
        System.Console.WriteLine("Dimensiones que tiene la tabla: " & strArray.Rank)
        System.Console.WriteLine("Elementos en todas las dimensiones: " & strArray.Length)
        System.Console.WriteLine("Elementos en una de las dimensiones: " & strArray.Length / strArray.Rank)
        System.Console.WriteLine("Indice maximo de la dimension: " & strArray.GetUpperBound(1))

        'Listar tabla
        For Each ss As String In strArray
            System.Console.Write(ss & " ")
        Next

        System.Console.WriteLine("Por dimensiones")
        For Each ss As String In strArray(0, 0)
            System.Console.Write(ss & "--") ' caracter a caracter...
        Next

        For Each strA As String In strCadenaA & strCadenaB & strCadenaC
            System.Console.WriteLine(strA)
        Next

        Console.ReadKey()

    End Sub

End Module
