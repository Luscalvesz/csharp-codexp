using System;

namespace forEachExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ForEach Exemplo");

            string[] nomes = new string[10];
            nomes[0] = "lucas";
            nomes[1] = "bruna";

            foreach (var item in nomes)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    Console.WriteLine(item);
                }

            }


            int[] numeros = new int[10];
            numeros[0] = 100;
            numeros[1] = 200;

            foreach (var item in numeros)
            {
                if (item !=0 )
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}
