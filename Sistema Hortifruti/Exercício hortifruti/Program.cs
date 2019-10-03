using System;
using Exercício_hortifruti.Controllers;

namespace Exercício_hortifruti
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtoController = new ProdutoController();
            int opcao = 0;

            do
            {
                Console.WriteLine("1 - Cadastrar Produtos");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Soma dos produtos cadastrados");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        //Cadastrar
                        produtoController.CadastroProduto();
                        break;
                    case 2:
                        //listar
                        produtoController.ListarProdutos();
                        break;
                    case 3:
                        produtoController.SomarProdutos();
                        break;
                    case 0:
                        //Sair
                        Console.WriteLine("Obrigado :)");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

            } while (opcao != 0);
        }
    }
}
