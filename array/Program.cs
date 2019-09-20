using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do while e array :");

            string[] nomes = new string[3];
            int contador = 0;

            while(contador<3)
            {
                Console.WriteLine($"Digite o {contador+1}° nome");
                nomes[contador] = Console.ReadLine();
                contador++;
            }
               contador = 0;
            while(contador<3){
                System.Console.WriteLine($"o nome na posição {contador} é {nomes[contador]}");
                contador++;
            }
            
               
        }
    }
}
