using System;
using System.Collections.Generic;
using senai.Tsushi.mvc.ViewModel;

namespace senai.Tsushi.mvc.Repositorio
{
    public class ProdutoRepositorio
    {
        List<ProdutoViewModel> listaDeProdutos = new List<ProdutoViewModel>();

        /// <summary>Armazena os produtos</summary>
        public ProdutoViewModel Inserir(ProdutoViewModel produto){
            produto.Id = listaDeProdutos.Count + 1;
            produto.DataCriacao = DateTime.Now;

            listaDeProdutos.Add(produto);

            return produto;
        }

        /// <summary>Exibe a lista de produtos</summary>
        public List<ProdutoViewModel> Listar(){
            return listaDeProdutos;
        }

        ///<summary>Busca o produto por seu Id</summary>
        
        


    }
}