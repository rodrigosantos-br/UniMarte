using System.Text.RegularExpressions;

namespace UniMarteWpf.Modelo
{
    public static class Validacao
    {
        public static bool ValidarNome(string nome)
        {
            if(nome.Length >= 3 && nome.Length <= 50)
            {
                return !string.IsNullOrWhiteSpace(nome);
            }
            return false;
        }

        public static bool ValidarDataNascimento(DateTime dataNascimento)
        {
            // Verifica se a data de nascimento é razoável (por exemplo, maior que 1900)
            return dataNascimento > new DateTime(1900, 1, 1) && dataNascimento <= DateTime.Now;
        }

        public static bool ValidarUsuario(Usuario usuario)
        {
            // Validações básicas
            if (string.IsNullOrWhiteSpace(usuario.NomeUsuario) || string.IsNullOrWhiteSpace(usuario.Senha))
                return false;

            if (!Regex.IsMatch(usuario.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return false;

            if (usuario.Idade <= 0)
                return false;

            return true;
        }
    }
}
