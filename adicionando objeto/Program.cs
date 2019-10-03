using System;
using adicionando_objeto.models;

namespace adicionando_objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            modelObjeto objeto = new modelObjeto();
            

            Console.WriteLine("Informe (em litros) a capacidade da garrafa: ");
            objeto.capacidade = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o material da garrafa: ");
            objeto.material = Console.ReadLine();

            Console.WriteLine("Informe a cor da garrafa: ");
            objeto.cor = Console.ReadLine();

            Console.WriteLine($@"
            Capacidade : {objeto.capacidade}L
            Material: {objeto.material}
            Cor: {objeto.cor}
            ");

            Console.Clear();
        }
    }
}
