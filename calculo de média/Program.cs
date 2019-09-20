using System;

namespace calculo_de_média
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de média");
            int n1;
            int n2;
            int n3;

            Console.WriteLine ("informe a primeira nota");
            n1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine ("Digite o primeiro número");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine ("Digite o primeiro número");
            n3 = int.Parse(Console.ReadLine());

            float resultado = (float) (n1+n2+n3)/3;

            Console.WriteLine ($"A média é igual a: {resultado}");
        }
    }
}
