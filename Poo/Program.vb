Imports System

Module Program

    Public Class Gato

        Public raca as String
        Public genero as String

    

        Public sub miar()
            console.writeline("MiAAAAAAAuu")
        End sub

    End Class


    Sub Main(args As String())
        
        dim meugato as new Gato()

        meugato.raca = "Siames"
        meugato.genero = "Macho"

        console.writeline(meugato.raca)
        console.writeline(meugato.genero)

        meugato.miar()



    End Sub
End Module
