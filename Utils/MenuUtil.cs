using System;

namespace senai.Tsushi.mvc.Utils
{
    public class MenuUtil
    {
       /// <summary>Exibe as opções do usuário deslogado</summary>
       
        public static void MenuDeslogado(){
            Console.WriteLine("----------------------------------");
            Console.WriteLine("------------- TSUSHI -------------");
            Console.WriteLine("----- (1) Cadastrar Usuário ------");
            Console.WriteLine("----- (2) Efetuar Login ----------");
            Console.WriteLine("----- (3) Listar -----------------");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("-------- Escolha uma Opção -------");
        }//fim menu deslogado

        
        /// <summary>Exibe as opções do usuário logado</summary>
        public static void MenuLogado(){
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("------------- Restaurante TSUSHI -------------");
            Console.WriteLine("-------------      Cardápio      -------------");
            Console.WriteLine("          (1) Cadastrar Produto               ");
            Console.WriteLine("          (2) Listar todos os produtos        ");
            Console.WriteLine("          (3) Buscar produto por Id           ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("          (0) Sair                            ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("          Escolha uma Opção                   ");
        }
    }
}