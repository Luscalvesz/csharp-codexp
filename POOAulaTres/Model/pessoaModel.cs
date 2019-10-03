using System;

namespace POOAulaTres.Model
{
    public class PessoaModel
    {
        public string Nome {get; set;}
        public int Idade {get; set;}

        public void Comer()
        {
            Console.WriteLine("Bora comer");
        }
        public void Andar()
        {
            Console.WriteLine("Bora andar");
        }
        public void Dormir()
        {
            Console.WriteLine("Bora dormir");
        }
    }
}