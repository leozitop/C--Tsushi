using System;
using System.Collections.Generic;
using senai.Tsushi.mvc.Repositorio;
using senai.Tsushi.mvc.Utils;
using senai.Tsushi.mvc.ViewModel;


namespace senai.Tsushi.mvc.ViewController
{
    public class UsuarioViewController
    {
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        public static void CadastrarUsuario(){
            string nome, email, senha, confirmaSenha;


            do
            {
                Console.WriteLine("Digite o nome do usuário:");
                nome = Console.ReadLine();

                if (String.IsNullOrEmpty(nome))
                {
                    Console.WriteLine("Nome não certo");
                }
            } while (string.IsNullOrEmpty(nome));
        
            do
            {
                Console.WriteLine("Digite o email do usuário");
                email = Console.ReadLine();
                
                if (!ValidacaoUtil.ValidarEmail(email))
                { 
                Console.WriteLine("Email inválido, o email deve conter @ e .");
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            do
            {
                Console.WriteLine("Digite a senha do usuário");
                senha = Console.ReadLine();

                Console.WriteLine("Confirme a senha");
                confirmaSenha = Console.ReadLine();

                if (!ValidacaoUtil.ConfirmacaoSenha(senha,confirmaSenha))
                {
                    Console.WriteLine("As senhas não são iguais");
                }
            } while (!ValidacaoUtil.ConfirmacaoSenha(senha,confirmaSenha));

            //Cria um objeto do tipo usuário
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;

            //Instanciar o repositorio

            //metodo para inserir no banco de dados
            
            usuarioRepositorio.Inserir(usuarioViewModel);

            Console.WriteLine("Cadastro efetuado com sucesso!");

        }//fim cadastrar usuário

        public static void ListarUsuario()
        {
            List<UsuarioViewModel> listaDeusuarios = usuarioRepositorio.Listar();//pegou o Listar de usuarioRepositorio e armazenou

            foreach (var item in listaDeusuarios)
            {
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Email: {item.Email} - Senha: {item.Senha} - Data de Criação: {item.DataCriacao}");
            }
        }

        public static UsuarioViewModel EfetuarLogin(){
            string email, senha;
            do
            {
                Console.WriteLine("Insira o email");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail(email))
                {
                    Console.WriteLine("Email inválido");
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            Console.WriteLine("Digite a senha");
            senha = Console.ReadLine();

            UsuarioViewModel usuarioRecuperado = usuarioRepositorio.BuscarUsuario(email, senha);
            if (usuarioRecuperado != null)
            {
                return usuarioRecuperado;
            }else
            {
                Console.WriteLine("E-mail ou senha inválida");
                return null;
            }

        }
    }
}