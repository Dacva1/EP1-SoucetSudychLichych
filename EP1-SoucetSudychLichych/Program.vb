Imports System

Module Program
    Sub Main()
        Dim pocetcisel As Object
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("Ahoj, kolik ��sel chce�? ")
        pocetcisel = Console.ReadLine
        If IsNumeric(pocetcisel) = False Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Chyba nezadali jste ��slo!")
            Console.ReadKey()
            Main()
        End If
        Dim cistecislo As Integer = pocetcisel
        If cistecislo <= 0 Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Chyba nezadali jste kladn� ��slo!")
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
        Console.Write("Sou�et sud�ch je: " & pocetsudych)
        Console.WriteLine("Sou�et lich�ch je: " & pocetlichych)
        Console.ReadKey()


    End Sub
End Module
