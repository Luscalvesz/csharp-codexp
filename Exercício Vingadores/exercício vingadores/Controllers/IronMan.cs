using System;

namespace exercício_vingadores.IronMan
{
    public class UsuarioControllerIron
    {
        int opcao3 = 0;
        public void PrimeiroAtaqueIron()
        {
            // Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Você está encurralado");
            Console.WriteLine("O QUE VOCÊ VAI FAZER?");
            Console.WriteLine("---------------------");
            Console.WriteLine("( 1 ) - Voar");
            Console.WriteLine("( 2 ) - Atirar");
            Console.WriteLine("( 0 ) - Entregar-se");
            opcao3 = int.Parse(Console.ReadLine());

            switch (opcao3)
            {
                case 1:
                    Console.WriteLine("Ao voar, os homens maus atiram em ti. MORREU!");
                    break;
                case 2:
                    Console.WriteLine("Você atira e mata os homens maus, PARABENS!");
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