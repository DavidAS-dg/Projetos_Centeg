Imports System

Module Program
    Sub Main(args As String())
        dim mb as double
        dim gb as double
        
        
        console.writeline("Digite um valor em MegaBytes: ")
        mb = console.readline()

        gb = mb / 1024

        console.writeline("Seu valor em GB é "& gb)



    End Sub
End Module
