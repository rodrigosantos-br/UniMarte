using System.Text.RegularExpressions;
using UniMarte.Wpf.Modelo;

namespace UniMarte.Wpf.Estatico
{
    public static class Validacao
    {
        public static bool ValidarNome(string nome)
        {
            if (nome.Length >= 3 && nome.Length <= 50)
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

        public static bool ValidarRespostas(List<Resposta> respostas, out string mensagemErro)
        {
            mensagemErro = "";

            foreach (var resposta in respostas)
            {
                // Verifica se a resposta individual está em branco
                if (string.IsNullOrWhiteSpace(resposta.RespostaTexto))
                {
                    mensagemErro = "Todas as perguntas devem ser respondidas antes de avançar.";
                    return false; // Retorna falso se encontrar uma resposta vazia
                }
            }

            return true; // Retorna verdadeiro se todas as respostas estão preenchidas
        }

    }
}
