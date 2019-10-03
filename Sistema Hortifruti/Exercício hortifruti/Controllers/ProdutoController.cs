using System;
using System.Collections.Generic;
using Exercício_hortifruti.Models;

namespace Exercício_hortifruti.Controllers
{
    public class ProdutoController
    {
        List<ProdutoModel> listaDeProdutos = new List<ProdutoModel>();
        public void CadastroProduto()
        {
            Console.WriteLine("Informe o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a categoria do produto: ");
            string categoria = Console.ReadLine();

            Console.WriteLine("informe o preço do produto: ");
            double preco = double.Parse (Console.ReadLine());

            Console.WriteLine("Informe a quantidade do produto: ");
            int Quantidade = int.Parse(Console.ReadLine());

            //instanciando o produto
            ProdutoModel produto = new ProdutoModel();

            produto.Id = listaDeProdutos.Count + 1;
            produto.Nome = nome;
            produto.Preco = preco;
            produto.DataCriacao = DateTime.Now;

            listaDeProdutos.Add(produto);

        }//final do cadastro de produto

        public void ListarProdutos()
        {
            foreach (var item in listaDeProdutos)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine($"Id: {item.Id++}");
                Console.WriteLine($"Produto: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine($"Categoria: {item.Categoria}");
                Console.WriteLine($"Quantidade em estoque: {item.Quantidade}");
                Console.WriteLine($"Data do Cadastro: {item.DataCriacao}");

            }
        }//final da listagem de produto


        public void SomarProdutos()
        {
            

        }
    }
}