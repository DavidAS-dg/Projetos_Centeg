Imports System

Module Program
    Sub Main(args As String())
        
        dim alunos as new list(Of String)
        dim quantidade as integer
        dim nome as String

        console.writeline("Quantos alunos irás cadastrar?")
        quantidade = Console.readline()

        for i as integer = 1 to quantidade
            console.write("Digite o nome do aluno: ")
            nome = Console.readline()
            alunos.add(nome)
        Next

        for each aluno in alunos
            console.writeline(aluno)
        Next

    End Sub
End Module
