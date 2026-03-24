Imports System

Module Program
    Sub Main(args As String())
        dim valor1 as integer
        dim valor2 as integer
        

        console.writeline("Digite o primeiro número:")
        valor1 = Console.readline()

        Console.writeline("Digite o segundo: ")
        valor2 = Console.readline()

        if valor1 > valor2
            Console.writeline("O maior valor é "& valor1)
        else
            console.writeline("O maior valor é "& valor2)
        end if
    End Sub
End Module
