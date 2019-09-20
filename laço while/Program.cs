using System;

namespace laço_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");
            Console.WriteLine("-------------------");

            Console.WriteLine("informe a tabuada:");
            int tabuada = int.Parse(Console.ReadLine());

            Console.WriteLine("informe em qual número deseja começar:");
            int inicio = int.Parse(Console.ReadLine());

            Console.WriteLine("informe até onde deseja ir :");
            int limite = int.Parse(Console.ReadLine());


            while(limite >= inicio)
            {
                Console.WriteLine($"{tabuada} x {inicio} = {tabuada*inicio}");
                
                inicio++;
            }
        }
    }
}
