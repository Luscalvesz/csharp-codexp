using System;

namespace Exercício_nota_alunos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Média de idade");
            Console.WriteLine("--------------------");

            int[] idade = new int [10];
            int contador = 0;
            int maior = 0;
            int menor = 0;

            while(contador < 10){

                Console.WriteLine("informe a sua idade: ");
                idade[contador] = int.Parse(Console.ReadLine());

                if(idade[contador] >= 18){
                    maior++;
                }else{
                    menor++;
                }
                contador++;
            }
            Console.WriteLine($"temos {maior} pessoas maiores de idade");
            Console.WriteLine($"temos {menor} pessoas menores de idade");


        }
    }
}
