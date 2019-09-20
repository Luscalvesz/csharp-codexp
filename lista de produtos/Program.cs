using System;

namespace lista_de_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de compras");

            string[] frutas = new string [6];
            string[] legumes = new string [6];
            string[] mercearia = new string [6];
            int contador = 0;

            while(contador <= 5)
            {   
                Console.WriteLine("informe qual fruta comprou: ");
                frutas[contador] = Console.ReadLine();

                Console.WriteLine("informe qual legume comprou: ");
                legumes[contador] = Console.ReadLine();
                
                Console.WriteLine("informe qual item de mercearia comprou: ");
                mercearia[contador] = Console.ReadLine();
                contador++;

            }

            int contador2 = 0;
            while(contador2 <= 5)
            {
                Console.WriteLine($"De frutas, você comprou: {frutas[contador2]}. De legumes: {legumes[contador2]}. Na mercearia: {mercearia[contador2]}");
                contador2++;
            }

        }
    }
}
