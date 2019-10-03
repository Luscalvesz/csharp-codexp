using System;
using System.Collections.Generic;

namespace POOAulaTres.Model
{
    public class FuncionarioModel : PessoaModel
    {
        public string Cargo { get; set; }


        public void Trabalhar()
        {
            System.Console.WriteLine("Agora vamos trabalhar!");
        }

        public FuncionarioModel CadastrarFuncionario()
        {   
            FuncionarioModel funcionario = new FuncionarioModel();

            Console.WriteLine("Digite o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Digite a idade do funcionário: ");
            funcionario.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o cargo do funcionário: ");
            funcionario.Cargo = Console.ReadLine();

            return funcionario;
        }

    }
}