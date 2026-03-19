Imports System

Module Program
    Sub Main(args As String())
        dim base as double
        dim altura as double
        dim area as double

        Console.writeline("Digite a base do triângulo: ")
        base =Console.readline()

        Console.writeline("Digite a altura do triangulo: ")
        altura = Console.readline()

        area = base * altura
        Console.writeline("A área do triangulo é " & area )

    End Sub
End Module
