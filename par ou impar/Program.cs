using System;

namespace par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            Console.WriteLine("Digite o primeiro número :");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número :");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 % 2 == 0){
                Console.WriteLine("O primeiro número informado é par");
                Console.Read();
            }else{
                Console.WriteLine("O primeiro número informado é ímpar");
                Console.Read();
            }
            if (numero2 % 2 == 0){
                Console.WriteLine("O segundo número informado é par");
                Console.Read();
            }else{
                Console.WriteLine("O segundo número informado é ímpar");
                Console.Read();
            }

            double operacao;
            operacao = (numero1 - numero2);

            if (operacao > 0){ 
            Console.WriteLine("O Primeiro Número é Maior"); 
            } 
            if (operacao < 0){ 
            Console.WriteLine("O Segundo Número é Maior"); 
            }           
            if (operacao == 0){ 
            Console.WriteLine("Os Números São Iguais"); 
            } 
        }
    }
}
