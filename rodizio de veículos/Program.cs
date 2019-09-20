using System;

namespace rodizio_de_veículos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o número final da placa de seu veículo");
            string placa = Console.ReadLine();

            int caracteres = placa.Length;

            int final = int.Parse(placa.Substring(caracteres - 1));

            if (final==0||final==1){
                Console.WriteLine("seu carro não pode rodar na SEGUNDA FEIRA");
            }else if (final==2||final==3){
                Console.WriteLine("seu carro não pode rodar na TERÇA FEIRA");
            }else if (final==4||final==5){
                Console.WriteLine("seu carro não pode rodar na QUARTA FEIRA");
            }else if(final==6||final==7){
                Console.WriteLine("seu carro não pode rodar na QUINTA FEIRA");
            }else if(final==8||final==9){
                Console.WriteLine("seu carro não pode rodar na SEXTA FEIRA");
            }else{
                Console.WriteLine("insira apenas o último dígito");
            }
            
        }
    }
}
