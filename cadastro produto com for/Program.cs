using System;

namespace cadastro_produto_com_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de produto com FOR");
            Console.WriteLine("---------------------------");

            string[] produtoNome = new string[3];
            double[] produtoPreco = new double[3];

            for (int i = 0; i < 3; i++)
            {
            Console.WriteLine($"Informe o nome do {i+1}° produto: ");
            produtoNome[i] = Console.ReadLine();
            Console.WriteLine($"Informe o preço do {i+1}° produto: ");
            produtoPreco[i] = double.Parse(Console.ReadLine());
            }

            // for (contador; condição; incremento)
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Produto: {produtoNome[i]} Preço: {produtoPreco[i]}");
            }

        }
    }
}
