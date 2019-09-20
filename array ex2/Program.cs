using System;

namespace array_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exercício 2");

            string[] nome = new string[3];
            string[] telefone = new string[3];
            string[] email = new string[3];
            int contador = 0;

            while(contador <= 2)
            {
                Console.WriteLine("informe o seu nome :");
                nome[contador] = Console.ReadLine();
            
                Console.WriteLine("informe o número de telefone :");
                telefone[contador] = Console.ReadLine();
          
                Console.WriteLine("informe o seu e-mail :");
                email[contador] = Console.ReadLine();
                
                contador++;
            }

            int contadorB = 0; 
            while(contadorB <= 2)
            {
                Console.WriteLine($"Cliente número {contadorB+1} - Nome: {nome[contadorB]}, Telefone: {telefone[contadorB]}, E-mail: {email[contadorB]}");
                contadorB++;
            }

        }
    }
}
