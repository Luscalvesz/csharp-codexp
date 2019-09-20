using System;

namespace salario_minimo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira o valor do salário :");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("informe a quantidade de horas trabalhadas :");
            float horasTrab = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de dependentes :");
            float dependentes = float.Parse(Console.ReadLine());
            Console.WriteLine("informe a quantidade de horas EXTRAS trabalhadas :");
            float horasExt = float.Parse(Console.ReadLine());


        }
    }
}
