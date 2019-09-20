using System;

namespace validação_e_mail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação de e-mail");

            string email;

            do
            {
                Console.WriteLine("digite seu e-mail: ");
                email = Console.ReadLine();
            }while (!email.Contains("@") || !email.Contains("."));

            string senha;

            do
            {
                Console.WriteLine("digite a sua senha: ");
                senha = Console.ReadLine();
            }while(senha.Length <= 6);

        }
    }
}
