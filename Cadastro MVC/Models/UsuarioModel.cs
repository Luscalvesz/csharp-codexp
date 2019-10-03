using System;

namespace Cadastro_MVC.Models
{
    public class UsuarioModel : BaseModel
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        
    }
}