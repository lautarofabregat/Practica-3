Module ConsoleApp2
    Sub Main()
        Dim num, cont1, cont2 As Integer
        Dim i As Integer
        For i = 1 To 3
            Console.WriteLine("Ingrese un número del 100 al 1000")
            num = Console.ReadLine()
            If num < 100 Or num > 1000 Then
                Console.WriteLine("ERROR, el numero tiene que estar entre el 100 y el 1000")
            End If
            If num >= 100 And num <= 500 Then
                cont1 = cont1 + 1
            End If
            If num > 500 Then
                cont2 = cont2 + 1
            End If
        Next i
        Console.WriteLine("Los numeros que se encuentran entre el 100 y 500 son: " & cont1)
        Console.WriteLine("Los numeros mayores a 500 son: " & cont2)
    End Sub
End Module