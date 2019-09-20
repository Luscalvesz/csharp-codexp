using System;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o primeiro valor");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            Console.WriteLine("informe o segundo valor");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Digite o número conforme a ação desejada: ");
            Console.WriteLine("( 1 ) - Soma de dois valores");
            Console.WriteLine("( 2 ) - Subtração do primeiro pelo segundo");
            Console.WriteLine("( 3 ) - Subtração do segundo pelo primeiro");
            Console.WriteLine("( 4 ) - Multiplicação dos dois valores");
            Console.WriteLine("( 5 ) - Divisão do primeiro pelo segundo");
            Console.WriteLine("( 6 ) - Divisão do segundo pelo primeiro");
            Console.WriteLine("--------------------------------");
            string resposta = Console.ReadLine();
            switch(resposta){
                case "1":
                Console.WriteLine($"O resultado é igual a {valor1 + valor2}");
                break;
                case "2":
                Console.WriteLine($"O resultado é igual a {valor1 - valor2}");
                break;
                case "3":
                Console.WriteLine($"O resultado é igual a {valor2 - valor1}");
                break;
                case "4":
                Console.WriteLine($"O resultado é igual a {valor1 * valor2}");
                break;
                case "5":
                if (valor2 == 0){
                Console.WriteLine("não podemos realizar uma divisão por 0");
                }else{
                Console.WriteLine($"O resultado é igual a {valor1 / valor2}");
                }
                break;
                case "6":
                if (valor1 == 0){
                Console.WriteLine("não podemos realizar uma divisão por 0");
                }else{
                Console.WriteLine($"O resultado é igual a {valor2 / valor1}");
                }
                break;
                default:
                System.Console.WriteLine("Informe um valor entre 1 e 6");
                break;
            }   
        }
    }
}
