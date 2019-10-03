using System;

namespace Exercício_hortifruti.Models
{

    public class ProdutoModel : BaseModel
    {
        public string Categoria { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
    }

}