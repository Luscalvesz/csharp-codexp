using System;
using exercício_vingadores.CapAmerica;
using exercício_vingadores.IronMan;

namespace exercício_vingadores
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioControllerCap acao = new UsuarioControllerCap();
            UsuarioControllerIron acao2 = new UsuarioControllerIron();

            int opcao = 0;

            do
            {
                Console.WriteLine("COM QUEM DESEJA JOGAR?");
                Console.WriteLine("----------------------");
                Console.WriteLine("( 1 ) - Capitão América");
                Console.WriteLine("( 2 ) - Homem de Ferro");
                Console.WriteLine("( 0 ) - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        acao.PrimeiroAtaqueCap();
                        Console.ResetColor();

                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        acao2.PrimeiroAtaqueIron();
                        Console.ResetColor();
                        break;
                    case 0:
                        Console.WriteLine("Obrigado por jogar :)");
                        break;
                    default:
                        Console.WriteLine("INFORME UMA OPÇÃO VÁLIDA!!");
                        break;
                }

            } while (opcao != 0);


        }
    }
}
