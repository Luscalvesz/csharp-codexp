using System;

namespace calculo_de_media_e_falta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de média e falta");
            Console.WriteLine("------------------------");

            System.Console.WriteLine("informe a primeira nota :");
            int nota1 = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("informe a segunda nota  :");
            int nota2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("informe a quantidade de faltas");
            int faltas = int.Parse(Console.ReadLine());

            double media = (nota1 + nota2)/2;

            if(media>=50 && faltas<=30){
                Console.WriteLine("Parabéns, você foi aprovado");    
            }else{
                Console.WriteLine("parabéns, você foi reprovado");
            }
        }
    }
}
