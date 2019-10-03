using System;

namespace exercicio_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício for");
            Console.WriteLine("--------------");

            string[] nome = new string[2];
            int[] idade = new int[2];
            double[] peso = new double[2];
            string[] sexo = new string[2];
            double[] altura = new double[2];
            int homem = 0;
            int mulher = 0;
            int idadeHomem = 0;
            int idadeMulher = 0;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"informe o nome da {i + 1}° pessoa: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine($"informe o peso da {i + 1}° pessoa: ");
                peso[i] = double.Parse(Console.ReadLine());
                Console.WriteLine($"informe a altura da {i + 1}° pessoa: ");
                altura[i] = double.Parse(Console.ReadLine().Replace('.',','));

                Console.WriteLine($"{nome[i]}. Você é: ");
                Console.WriteLine("( H ) - Homem");
                Console.WriteLine("( M ) - Mulher");
                Console.WriteLine("--------------------------------");

                string resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "H":

                        Console.WriteLine($"informe a sua idade: ");
                        idadeHomem = int.Parse(Console.ReadLine());
                        homem++;

                        break;

                    case "M":

                        Console.WriteLine($"informe a sua idade: ");
                        idadeMulher = int.Parse(Console.ReadLine());
                        mulher++;

                        break;

                    
                    default:
                        System.Console.WriteLine("Informe se é H ou M");
                        break;

                }
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine($"O usuário {nome[i]}, possui o IMC igual a: {peso[i] / (altura[i] * altura[i])}");
                    Console.WriteLine($"{homem} homens cadastrados");
                    Console.WriteLine($"{mulher} mulheres cadastradas");
                }

            }
        }
    }
}
