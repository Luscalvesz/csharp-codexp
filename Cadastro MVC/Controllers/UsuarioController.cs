using System;
using System.Collections.Generic;
using Cadastro_MVC.Models;

namespace Cadastro_MVC.Controllers
{
    /// <summary>
    /// Método para cadastro de usuários
    /// </summary>
    public class UsuarioController
    {   
        List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();
        public void CadastroUsuario()
        {
            Console.WriteLine("Digite o seu nome:  ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o seu e-mail: ");
            string email = Console.ReadLine();

            Console.WriteLine("Digite a sua senha: ");
            string senha = Console.ReadLine();
            
            
        // instanciando um novo usuário
            UsuarioModel usuario = new UsuarioModel();

        // populando o objeto    
            usuario.Id = 1;
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;
            usuario.DataCriacao = DateTime.Now;

            listaDeUsuarios.Add(usuario);

        }//fim cadastro

        public void ListarUsuarios()
        {
            foreach (var item in listaDeUsuarios)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine($"Usuário: {item.Nome}");
                Console.WriteLine($"Id: {item.Id}");
                Console.WriteLine($"E-mail: {item.Email}");
                Console.WriteLine($"Data do Cadastro: {item.DataCriacao}");
                Console.WriteLine("---------------------");

            }

        }
    }
}