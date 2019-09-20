using System;

namespace entrada_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("entrada cinema");
            Console.WriteLine("--------------");

            System.Console.WriteLine("informe a sua idade :");
            int idade = int.Parse(Console.ReadLine());

            if(idade<18||idade>=60){
                System.Console.WriteLine("Você irá pagar meia");
            }else{
                System.Console.WriteLine("Você irá pagar inteira");
            } 
            
        }
    }
}
