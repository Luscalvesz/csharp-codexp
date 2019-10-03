using System;
using Cadastro_MVC.Controllers;

namespace Cadastro_MVC
{
    /// <summary>
    /// Cadastro de usuários usando lista, csv e autenticação
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            UsuarioController usuarioController = new UsuarioController();

            int opcao = 0;

            do
            {
                Console.WriteLine("( 1 ) - Cadastrar usuários");
                Console.WriteLine("( 2 ) - Listar usuários");
                Console.WriteLine("( 0 ) - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        //cadastrar
                        usuarioController.CadastroUsuario();
                        break;
                    case 2:
                        //listar
                        usuarioController.ListarUsuarios();
                        break;
                    case 0:
                        //sair
                        Console.WriteLine("tchau");
                        break;
                    default:
                    Console.WriteLine("Opção invalida");
                    break;
                }

            } while (opcao != 0);
        }
    }
}
