using System;

namespace exercício_vingadores.CapAmerica
{
    public class UsuarioControllerCap
    {
        int opcao1 = 0;

        public void PrimeiroAtaqueCap()
        {
            Console.WriteLine("Você está sendo atacado por moços ruins");
            Console.WriteLine("O QUE VOCÊ VAI FAZER?");
            Console.WriteLine("---------------------");
            Console.WriteLine("( 1 ) - Defender com o escudo");
            Console.WriteLine("( 2 ) - Jogar o escudo");
            Console.WriteLine("( 0 ) - Entregar-se");
            opcao1 = int.Parse(Console.ReadLine());

            switch (opcao1)
            {
                case 1:
                    Console.WriteLine("As balas ricocheteiam no escudo e voltam em direção aos atiradores. Todos morreram. PARABENS!");
                    break;
                case 2:
                    Console.WriteLine("Você lança o escudo em direção aos inimigos, mas erra o alvo, MORREU");
                    break;
                case 0:
                    Console.WriteLine("VOCÊ MORREU!!!");
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("INFORME UMA OPÇÃO VÁLIDA!!");
                    Console.ResetColor();
                    break;
            }
            
        }


    }
}