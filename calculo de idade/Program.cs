using System;

namespace calculo_de_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("exercício 04");
            // Console.WriteLine("----------------");
            // int anoNasc;
            // Console.WriteLine ("informe o ano em que nasceu");
            // anoNasc = int.Parse(Console.ReadLine());
            // int anoAtual = DateTime.Now.Year;
            // int idade = anoAtual-anoNasc;
            // Console.WriteLine ($"você tem {idade} anos");
            // float idadeSemana = (float) idade * 52;
            // Console.WriteLine ($"e viveu por {idadeSemana} semanas");


            // Console.WriteLine("exercício 05");
            // Console.WriteLine("----------------");
            // float n1;
            // Console.WriteLine ("informe um número");
            // n1 = float.Parse(Console.ReadLine().Replace('.',','));
            // float numero = (float) n1 * 3;
            // Console.WriteLine ($"o triplo de {n1} é igual a {numero}");


            // Console.WriteLine("exercício 06");
            // Console.WriteLine("----------------");
            // float precoProd;
            // Console.WriteLine("informe o preço do produto");
            // precoProd = float.Parse(Console.ReadLine());
            // float pctm;
            // Console.WriteLine("informe a porcentagem de desconto");
            // pctm = float.Parse(Console.ReadLine());
            // float valor = precoProd * pctm / 100; 
            // Console.WriteLine ($"o valor de desconto sob o valor {precoProd} é igual a {valor}");


            Console.WriteLine("exercício 07");
            Console.WriteLine("----------------");
            Console.WriteLine("informe o salário");
            float salario;
            salario = float.Parse(Console.ReadLine());
            float comissao;
            Console.WriteLine("informe a quantidade de vendas realizadas");
            comissao = float.Parse(Console.ReadLine());
            comissao = salario * comissao / 100;
            Console.WriteLine ($"o valor de comissão do vendedor é igual a {comissao}");


            // Console.WriteLine("exercício 08");
            // Console.WriteLine("----------------");
            // float dolar;
            // Console.WriteLine("informe o valor atual do dolar");
            // dolar = float.Parse(Console.ReadLine());
            // float real;
            // Console.WriteLine("informe a quantidade em reais para conversão");
            // real = float.Parse(Console.ReadLine());


        }
    }
}
