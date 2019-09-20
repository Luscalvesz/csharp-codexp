using System;

namespace cargos_com_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("switch case");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("informe o número do cargo para descobrir o salário");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("( 1 ) - Diretor");
            Console.WriteLine("( 2 ) - Gerente");
            Console.WriteLine("( 3 ) - Professor");
            Console.WriteLine("( 4 ) - Coordenador");
            Console.WriteLine("( 5 ) - Atendente");
            Console.WriteLine("--------------------------------");

            string resposta = Console.ReadLine();

            switch(resposta){
                case "1":
                Console.WriteLine("O salário de diretor é de 18.000,00");
                break;

                case "2":
                Console.WriteLine("O salário de gerente é de 15.000,00");
                break;

                case "3":
                Console.WriteLine("O salário de professor é de 1.000,00");
                break;

                case "4":
                Console.WriteLine("O salário de coordenador é de 9.000,00");
                break;

                case "5":
                Console.WriteLine("O salário de atendente é de 1.500,00");
                break;

                default:
                System.Console.WriteLine("Informe um valor entre 1 e 5");
                break;
            }   
        }
    }
}
