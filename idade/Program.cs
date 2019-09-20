using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculo de idade");

            int n1;

            Console.WriteLine ("informe a sua idade");
            n1 = int.Parse(Console.ReadLine());

            float meses = (float) n1 * 12;

            Console.WriteLine ($"você já viveu por {meses} meses");

            float dias = (float) meses * 30;

            Console.WriteLine ($"{dias} dias");  

            float horas = (float) dias * 24;

            Console.WriteLine ($"{horas} horas");

            double minutos = (double) horas * 60;

            Console.WriteLine ($"{minutos} minutos");

        }
    }
}
