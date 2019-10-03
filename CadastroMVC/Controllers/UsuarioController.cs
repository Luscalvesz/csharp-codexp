using System;
using System.Collections.Generic;
using CadastroMVC.Models;

namespace CadastroMVC.Controllers
{
    public class UsuarioController
    {
        List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();
        /// <summary>
        /// Método para cadastro de usuários
        /// </summary>
        public void CadastroUsuario ()
        {
            Console.WriteLine("Informe o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe seu E-Mail");
            string email = Console.ReadLine();
            
            Console.WriteLine("Informe sua Senha");
            string senha = Console.ReadLine();
            //Instanciando um novo usuário
            UsuarioModel usuario = new UsuarioModel();
            //Populando o objeto
            usuario.Id = 1;
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;
            usuario.DataCriacao = DateTime.Now;

            listaDeUsuarios.Add(usuario);

        }//fim cadastroUsuario

        public void ListarUsuarios()
        {
            foreach (var item in listaDeUsuarios)
            {
               Console.WriteLine("-------------------------------------");
               Console.WriteLine($"Usuario: {item.Nome}");
               Console.WriteLine($"Id: {item.Id}");
               Console.WriteLine($"E-Mail: {item.Email}");
               Console.WriteLine($"Data do Cadastro: {item.DataCriacao}");
               Console.WriteLine("-------------------------------------");

            }

        }//fim ListarUsuarios
        
    }
}
