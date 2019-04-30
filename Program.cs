using System;
using senai.Tsushi.mvc.Utils;
using senai.Tsushi.mvc.ViewController;
using senai.Tsushi.mvc.ViewModel;

namespace senai.Tsushi.mvc
{
    class Program
    {

        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
            int opcaoLogado = 0;
            do
            {
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());
                switch (opcaoDeslogado)
                {
                    case 1:
                    //Cadastra usuario
                    UsuarioViewController.CadastrarUsuario();
                    break;
                    case 2:
                    //Efetua login
                    UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin();
                    if (usuarioRecuperado != null)
                    {
                        Console.WriteLine($"Seja bem vindo - {usuarioRecuperado.Nome}");
                        do
                        {     
                            MenuUtil.MenuLogado();
                            opcaoLogado = int.Parse(Console.ReadLine());
                            switch (opcaoLogado)
                            {
                                case 1:
                                //Cadastra o produto
                                ProdutoViewController.CadastrarProduto();
                                break;
                                case 2:
                                //Lista os produtos
                                ProdutoViewController.ListarProduto();
                                break;
                                case 3:
                                //Busca por Id
                                ProdutoViewController.BuscaPorId();
                                break;
                                case 0:
                                //Sair
                                break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                break;
                            }
                        } while (opcaoLogado != 0);
                        
                    }
                    break;
                    case 3:
                    //Listar
                    UsuarioViewController.ListarUsuario();
                    break;
                    case 0:
                    //sair
                    Console.WriteLine("Obrigado, volte sempre!");
                    
                    break;
                    default:
                        Console.WriteLine("Opção Inválida");
                    break;
                }

            } while (opcaoDeslogado != 0);
        }
    }
}
