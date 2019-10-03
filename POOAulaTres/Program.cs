using System;
using System.Collections.Generic;
using POOAulaTres.Model;

namespace POOAulaTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo Herança");
            FuncionarioModel funcionario = new FuncionarioModel();
            List<FuncionarioModel> listaDeFuncionarios = new List<FuncionarioModel>();

            int opcao;
            do
            {
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("( 1 ) - cadastrar funcionário");
                Console.WriteLine("( 2 ) - Executar Ações");
                Console.WriteLine("( 0 ) - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        // cadastrar
                        FuncionarioModel funcionarioCadastrado = funcionario.CadastrarFuncionario();
                        listaDeFuncionarios.Add(funcionarioCadastrado);

                        // Vamos listar
                        foreach (var item in listaDeFuncionarios)
                        {
                            Console.WriteLine($"Funcionário: {item.Nome}, Cargo: {item.Cargo} ");
                            
                        }

                        break;
                    case 2:
                        // Executar
                        int acao = 0;
                        do
                        {
                            Console.WriteLine($"Selecione uma ação para o {funcionario.Nome}");
                            Console.WriteLine("( 1 ) - Andar");
                            Console.WriteLine("( 2 ) - Comer");
                            Console.WriteLine("( 3 ) - Trabalhar");
                            Console.WriteLine("( 0 ) - Sair");
                            acao = int.Parse(Console.ReadLine());

                            switch (acao)
                            {
                                case 1:
                                    funcionario.Andar();
                                    break;

                                case 2:
                                    funcionario.Comer();
                                    break;

                                case 3:
                                    funcionario.Trabalhar();
                                    break;

                                case 0:
                                    Console.WriteLine("Tchau");
                                    break;

                                default:
                                    Console.WriteLine("opção inváida");
                                    break;
                            }

                        } while (acao != 0);
                        break;
                    case 0:
                        // sair
                        Console.WriteLine("Obrigado por usar o nosso sístema");
                        break;

                    default:
                        // diferente de 0, 1 e 2
                        break;
                }

            } while (opcao != 0);
            ProfessorModel professor = new ProfessorModel();

            professor.Nome = "lucas";
            professor.Idade = 1;
            professor.Turma = "CodeXP";




        }
    }
}
