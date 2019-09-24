using System;

namespace média_de_notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média de notas");
            Console.WriteLine("--------------------");

            float[] nota1 = new float [10];
            float[] nota2 = new float [10];
            float[] media = new float [10];
            int contador = 0;
            int aprovados = 0;
            int reprovados = 0;
            float somatoria = 0;
            float mediaclasse = 0;

             while(contador < 10){

                Console.WriteLine("informe a sua PRIMEIRA nota: ");
                nota1[contador] = float.Parse(Console.ReadLine());

                Console.WriteLine("informe a sua SEGUNDA nota: ");
                nota2[contador] = float.Parse(Console.ReadLine());

                media[contador] = (nota1[contador]+nota2[contador])/2;

                somatoria += nota1[contador]+nota2[contador];


                if( media[contador] >= 7){
                    aprovados++;
                }else{
                    reprovados++;
                }
                contador++;
            
                
            }
                mediaclasse = somatoria/20;
                System.Console.WriteLine($"a média da sala é igual a {mediaclasse}");
            Console.WriteLine($"temos {aprovados} alunos APROVADOS");
            Console.WriteLine($"temos {reprovados} alunos REPROVADOS");

        }
    }
}
