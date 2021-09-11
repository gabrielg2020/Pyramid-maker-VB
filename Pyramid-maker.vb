Imports System

Module Module1
    Dim n As Integer
    Dim points As Integer
    Dim tPoints As Integer
    Dim pArray(999999) As Integer
    Dim temp As Integer = 0
    Dim counter As Integer = 0
    Dim sCounter As String
    Dim gCounter As Integer = 0
    Dim allCounter As Integer = 0
    Dim allow As Boolean = False
    Sub Main()
        '118 limit for 1920x1080
        Console.ForegroundColor = ConsoleColor.White
        find_Points()
        calculating_Py()
        print_Py()
        Console.ReadLine()

    End Sub
    Sub find_Points()
        Do
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("How big will be your base?")
            Console.WriteLine("The limit for a good looking pyrimid is 118 ")
            n = Console.ReadLine()
            If n > 118 Then
                allow = False
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("You went over the limit")
                Console.WriteLine("Press enter to try again")
                Console.ReadLine()
                Console.Clear
            Else 
                allow = True
            End If
        Loop Until allow = True
        points = (0.5 * n) * (n + 1)
    End Sub
    Sub calculating_Py()
        Console.Clear()
        temp = points
        Do
            For i As Integer = 1 To n
                pArray(i - 1) = i
                tPoints = tPoints + pArray(i - 1)
                temp = temp - i
            Next
        Loop Until temp = 0
        Console.Write("The amount of point will be: ")
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(tPoints)
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine(" ")
    End Sub
    Sub print_Py()
        sCounter = ""
        For i As Integer = 1 To n
            gCounter = n - (n - (n - i))
            For j As Integer = 1 To gCounter
                sCounter = sCounter + " "
            Next
            If pArray(i - 1) > 0 Then
                counter = pArray(i - 1)
                Do
                    Console.Write(sCounter & "* ")
                    sCounter = ""
                    counter = counter - 1
                Loop Until counter = 0
            End If
            Console.WriteLine(" ")
        Next
    End Sub
End Module
