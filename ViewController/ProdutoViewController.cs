using System;
using System.Collections.Generic;
using senai.Tsushi.mvc.Repositorio;
using senai.Tsushi.mvc.ViewModel;

namespace senai.Tsushi.mvc.ViewController
{
    public class ProdutoViewController
    {
        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
        public static void CadastrarProduto(){
            string nome, descricao, categoria;
            float preco;

            do{
                Console.WriteLine("Digite o nome do produto");
                nome = Console.ReadLine();

                if (String.IsNullOrEmpty(nome))
                {
                    Console.WriteLine("Digite o nome");
                }
            } while (string.IsNullOrEmpty(nome));

            do{
                Console.WriteLine("Insira a descrição do produto");
                descricao = Console.ReadLine();
            } while (string.IsNullOrEmpty(descricao));    

            Console.WriteLine("Coloque o preço do produto");
            preco = float.Parse(Console.ReadLine());

            do{
                Console.WriteLine("Digite sua categoria");
                categoria = Console.ReadLine();
            } while (string.IsNullOrEmpty(categoria));

            //Cria um objeto do tipo produto
            ProdutoViewModel produtoViewModel = new ProdutoViewModel();
            produtoViewModel.Nome = nome;
            produtoViewModel.Descricao = descricao;
            produtoViewModel.Preco = preco;
            produtoViewModel.Categoria = categoria;

            //Instanciar Produto

            //metodo para inserir no banco de dados
            
            produtoRepositorio.Inserir(produtoViewModel);

            Console.WriteLine("Cadastro efetuado com sucesso!");
                
        }//fim cadastrar produto

        public static void ListarProduto(){
            List<ProdutoViewModel> listaDeProdutos = produtoRepositorio.Listar();
            
            foreach (var item in listaDeProdutos)
            {
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Descrição: {item.Descricao} - Preço: {item.Preco} - Categoria: {item.Categoria} - Data de criação: {item.DataCriacao}");
            }
        }

        public static void BuscaPorId(){
            Console.WriteLine("Digite o Id do produto que deseja encontrar");
            int procura = int.Parse(Console.ReadLine());
            List<ProdutoViewModel> listaDeProdutos = produtoRepositorio.Listar();
            foreach (var item in listaDeProdutos)
            {
                if (item == null)
                {
                    Console.WriteLine("Item não cadastrado");
                }
                if (procura.Equals(item.Id))
                {
                    Console.WriteLine($"Id: {item.Id}");
                    Console.WriteLine($"Nome: {item.Nome}");
                    Console.WriteLine($"Descrição: {item.Descricao}");
                    Console.WriteLine($"Preço: {item.Preco}");
                    Console.WriteLine($"Categoria: {item.Categoria}");
                    Console.WriteLine($"Data de criação: {item.DataCriacao}");
                }
            }
        }
    }
}