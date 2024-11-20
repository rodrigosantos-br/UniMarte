using UniMarteWpf.DAL;
using UniMarteWpf.Estatico;
using UniMarteWpf.Modelo;

namespace UniMarteWpf.Controle
{
    public class VisitanteControle
    {
        public string Mensagem { get; private set; }
        public int atualVisitanteId;

        public bool CadastrarVisitante(string nome, DateTime dataNascimento)
        {
            if (!Validacao.ValidarNome(nome))
            {
                Mensagem = "Nome inválido!";
                return false;
            }

            if (!Validacao.ValidarDataNascimento(dataNascimento))
            {
                Mensagem = "Data de nascimento inválida!";
                return false;
            }

            // Obtém a data e hora atual do cadastro
            DateTime dataHoraCadastro = DateTime.Now;

            // Cria um novo visitante com o nome, data de nascimento e data de cadastro
            Visitante novoVisitante = new Visitante(nome, dataNascimento, dataHoraCadastro);
            VisitanteDAO dal = new VisitanteDAO();

            // Tenta inserir o visitante e verifica se a operação foi bem-sucedida
            if (dal.InserirVisitante(novoVisitante))
            {
                Mensagem = "Visitante cadastrado com sucesso!";
                return true;
            }
            else
            {
                Mensagem = "Erro ao cadastrar visitante.";
                return false;
            }
        }
    }
}
