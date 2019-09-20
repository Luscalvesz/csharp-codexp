using System;

namespace cargo_funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome: ");
            string nome = Console.ReadLine();
            System.Console.WriteLine("informe o seu salário: ");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Digite o número conforme o seu cargo: ");
            Console.WriteLine("( 1 ) - Escriturário");
            Console.WriteLine("( 2 ) - Secretário");
            Console.WriteLine("( 3 ) - Caixa");
            Console.WriteLine("( 4 ) - Gerente");
            Console.WriteLine("( 5 ) - Diretor");
            Console.WriteLine("--------------------------------");
            string resposta = Console.ReadLine();

            switch(resposta){
            case "1":
                float escriturario = salario*50/100;
                float escriturarioAum = salario + escriturario;
                Console.WriteLine($"Olá {nome}, o seu valor de aumento é igual a {escriturario}, e seu novo salário é de {escriturarioAum}");
                break;
            case "2":
                float secretario = salario*35/100;
                float secretarioAum = salario + secretario;
                Console.WriteLine($"Olá {nome}, o seu valor de aumento é igual a {secretario}, e seu novo salário é de {secretarioAum}");
                break; 
            case "3":
                float caixa = salario*20/100;
                float caixaAum = salario + caixa;
                Console.WriteLine($"Olá {nome}, o seu valor de aumento é igual a {caixa}, e seu novo salário é de {caixaAum}");
                break;
            case "4":
                float gerente = salario*10/100;
                float gerenteAum = salario + gerente;
                Console.WriteLine($"Olá {nome}, o seu valor de aumento é igual a {gerente}, e seu novo salário é de {gerenteAum}");
                break;
            case "5":
                Console.WriteLine($"Olá {nome}, o cargo de diretor não possui aumento salarial");
                break;
            default:
                System.Console.WriteLine("Informe um valor entre 1 e 5");
                break;                  
            }
        }
    }
}
