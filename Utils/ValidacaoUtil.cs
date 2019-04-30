namespace senai.Tsushi.mvc.Utils
{
    public static class ValidacaoUtil
    {
        /// <summary> Retornar true caso o email possua @ e .static e false se não possuir</summary>

        public static bool ValidarEmail(string email){
            if (email.Contains("@") && email.Contains("."))
            {
                return true;
            }return false;
        }
        
        /// <summary>Retorna true caso a senha sejam iguais e contenha mais de 6 caracteres e false caso contrario</summary>
        public static bool ConfirmacaoSenha(string senha, string confirmaSenha){
            if (senha.Equals(confirmaSenha) && senha.Length > 6)
            {
                return true;                
            }return false;
        }
    }
}