Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Triangulo de Pascal!") ' Cono
        Dim ma(10, 46) As Integer ' Declaración de variables Array
        For a = 0 To 10
            For b = 0 To 46
                ma(a, b) = 0
            Next
        Next
        ma(0, 23) = 1
        For a = 1 To 7 ' Para Cada
            For b = 1 To 45 ' Para Cada
                ma(a, b) = ma(a - 1, b - 1) + ma(a - 1, b + 1) ' Asignación - Rectangulo
            Next
        Next
        For a = 0 To 10
            For b = 0 To 46
                If ma(a, b) = 0 Then
                    Console.Write("   ")
                Else
                    Console.Write(ma(a, b).ToString("###"))
                End If
            Next
            Console.WriteLine("")
        Next
        Console.ReadKey()
    End Sub
End Module
