using System;

namespace tabuada_com_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tabuada com for");
            Console.WriteLine("----------------");
            Console.WriteLine("informe qual tabuada deseja saber: ");
            float tabuada = float.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{tabuada} x {i} = {tabuada*i}");
            }

        }
    }
}
