using System;

namespace validação_com_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação com do while");

            string nome;

            do
            {
                Console.WriteLine("digite seu nome: ");
                nome = Console.ReadLine();
            }while (nome.Length <= 1);

            string senha;

            do
            {
                Console.WriteLine("digite a sua senha: ");
                senha = Console.ReadLine();
            }while(senha.Length <= 6);

            
            

        }
    }
}
