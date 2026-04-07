Imports System

Module Program
    Sub Main(args As String())
        dim n1, n2, resultado as integer

        Console.writeline("Digite um numero")
        n1 = console.readline()

        Console.writeline("Digite outro valor")
        n2 = console.readline()

        resultado = somar(n1, n2)
        console.writeline("A soma dos resultados é "&resultado)
    end sub

    function Somar(a as integer, b as integer) as integer
        return a + b 
    End function




End Module
