Imports System

Module Program
  Sub Main(args As String())
        Dim cislo, cislo2 As String
        Dim cisl, cisl2, vysledek As Integer
        Do
            Console.WriteLine("Napi� ��slo")
            cislo = Console.ReadLine
            Console.WriteLine("Napi� 2. ��slo")
            cislo2 = Console.ReadLine
            vysledek = cislo + cislo2
            Console.WriteLine($"V�sledek t�chto ��sel je {vysledek}")
            If Integer.TryParse(cislo, cisl) And
                    Integer.TryParse(cislo2, cisl2) Then
                If cisl >= 0 And cisl2 >= 0 Then
                    vysledek = cisl + cisl2
                    Console.WriteLine($"V�sledek je: {vysledek}")
                Else
                    Console.WriteLine(" Zad�vejte pouze cel� ��sla!!!")
                End If
            End If
        Loop



    End Sub
End Module
