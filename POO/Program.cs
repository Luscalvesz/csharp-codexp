using System;
using POO.models;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoModel aluno = new AlunoModel();

            Console.Clear();

            Console.WriteLine("Insira o nome do Aluno");
            aluno.nome = Console.ReadLine();

            Console.WriteLine("Insira o curso");
            aluno.curso = Console.ReadLine();

            Console.WriteLine("Insira o RG");
            aluno.rg = Console.ReadLine();

            Console.WriteLine("Insira a idade");
            aluno.idade = int.Parse(Console.ReadLine());

            Console.WriteLine($@"
            Nome: {aluno.nome}
            Curso: {aluno.curso}
            Idade: {aluno.idade}
            Rg: {aluno.rg}
            ");

        }
    }
}
