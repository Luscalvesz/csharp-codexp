using System;

namespace Exercício_hortifruti.Models
{
    public class BaseModel
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}