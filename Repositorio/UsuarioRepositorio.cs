using System;
using System.Collections.Generic;
using senai.Tsushi.mvc.ViewModel;

namespace senai.Tsushi.mvc.Repositorio
{
    public class UsuarioRepositorio
    {
        List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();
        
        /// <summary>Método responsavel por armazenar um usuario</summary>    
        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            usuario.Id = listaDeUsuarios.Count + 1;
            usuario.DataCriacao = DateTime.Now;
            //insere o objeto usuario dentro da lista
            listaDeUsuarios.Add(usuario);

            return usuario;
        }

        /// <summary>Retorna lista de usuários</summary>
        public List<UsuarioViewModel> Listar(){//quando chamar o listar ele trará uma lista UsuarioViewModel
        return listaDeUsuarios;
        }

        /// <summary>Verifica se o usuário é valido</summary>
        /// <param name="email">E-mail do Usuário</param>
        /// <param name="senha">Senha do Usuário</param>
        /// /// <returns>Retorna o usuário caso ele seja encontrado ou null caso não exista</returns>
        
        public UsuarioViewModel BuscarUsuario(string email, string senha)
        {
            foreach (var item in listaDeUsuarios)
            {
                if (item.Email.Equals(email) && item.Senha.Equals(senha))
                {
                    return item;
                }
            }//fim foreach
            return null;
        }
    }
}