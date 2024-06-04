Imports System

Module Program
  Sub Main(args As String())
        Dim cislo, cislo2 As String
        Dim cisl, cisl2, vysledek As Integer
        Do
            Console.WriteLine("Napiš èíslo")
            cislo = Console.ReadLine
            Console.WriteLine("Napiš 2. èíslo")
            cislo2 = Console.ReadLine
            vysledek = cislo + cislo2
            Console.WriteLine($"Výsledek tìchto èísel je {vysledek}")
            If Integer.TryParse(cislo, cisl) And
                    Integer.TryParse(cislo2, cisl2) Then
                If cisl >= 0 And cisl2 >= 0 Then
                    vysledek = cisl + cisl2
                    Console.WriteLine($"Výsledek je: {vysledek}")
                Else
                    Console.WriteLine(" Zadávejte pouze celá èísla!!!")
                End If
            End If
        Loop



    End Sub
End Module
