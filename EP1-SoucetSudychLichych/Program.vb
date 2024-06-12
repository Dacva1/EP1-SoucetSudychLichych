Imports System

Module Program
    Sub Main()
        Dim pocetcisel As Object
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("Ahoj, kolik èísel chceš? ")
        pocetcisel = Console.ReadLine
        If IsNumeric(pocetcisel) = False Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Chyba nezadali jste èíslo!")
            Console.ReadKey()
            Main()
        End If
        Dim cistecislo As Integer = pocetcisel
        If cistecislo <= 0 Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Chyba nezadali jste kladné èíslo!")
            Console.ReadKey()
            Main()
        End If
        Dim nahoda As Integer
        Dim pocetsudych, pocetlichych As Double
        Console.Clear()
        For x = 1 To cistecislo
            nahoda = Rnd() * 1000
            Console.WriteLine(nahoda)
            If nahoda Mod 2 = 0 Then
                pocetsudych += nahoda
            Else
                pocetlichych += nahoda
            End If
        Next
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("Souèet sudých je: " & pocetsudych)
        Console.WriteLine("Souèet lichých je: " & pocetlichych)
        Console.ReadKey()


    End Sub
End Module
