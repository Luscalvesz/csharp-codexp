using System;
using CadastroMVC.Controllers;

namespace CadastroMVC {
    /// <summary>
    /// Cadastro de usuário usando lista e csv
    /// E autenticação
    /// </summary>
    class Program {
        static void Main (string[] args) {
            UsuarioController usuarioController = new UsuarioController ();
            int opcao = 0;
            do {
                Console.WriteLine ("1 - Cadastrar Usuários");
                Console.WriteLine ("2 - Listar Usuários");
                Console.WriteLine ("0 - Sair");
                opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        //Cadastrar
                        usuarioController.CadastroUsuario();
                        break;
                    case 2:
                        //listar
                        usuarioController.ListarUsuarios();
                        break;
                    case 0:
                        //Sair
                        Console.WriteLine("Tchau");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                    break;
                }
            } while (opcao != 0);

        }
    }
}