using Microsoft.Data.SqlClient;
using UniMarteWpf.Estatico;
using UniMarteWpf.Modelo;

namespace UniMarteWpf.DAL
{
    public class PerguntaDAO
    {
        public string mensagem;

        public List<Pergunta> ObterPerguntas()
        {
            // Verifica se as perguntas já foram carregadas e estão no cache
            if (PerguntasCache._perguntasCache == null || PerguntasCache._perguntasCache.Count == 0)
            {
                // Se não, carrega do banco de dados
                PerguntasCache._perguntasCache = CarregarPerguntasDoBanco();
            }

            return PerguntasCache._perguntasCache;
        }

        private List<Pergunta> CarregarPerguntasDoBanco()
        {
            List<Pergunta> perguntas = new List<Pergunta>();

            // Aqui você faz a conexão com o banco de dados, busca as perguntas e armazena em "perguntas"
            // Exemplo simplificado:
            SqlConnection con = Conexao.Conectar();
            {
                string sql = "SELECT IdPergunta, TextoPergunta, TipoResposta FROM Perguntas";
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Pergunta pergunta = new Pergunta
                    {
                        Id = reader.GetInt32(0),
                        Texto = reader.GetString(1),
                        TipoResposta = reader.GetString(2)
                    };
                    perguntas.Add(pergunta);
                }
                Conexao.Desconectar();
            }

            return perguntas; // Retorna as perguntas carregadas do banco de dados
        }

        public void SalvarRespostas(List<Resposta> respostas)
        {
            using (SqlConnection con = Conexao.Conectar())
            {
                foreach (var resposta in respostas)
                {
                    string sql = "INSERT INTO Respostas (IdVisitante, IdPergunta, Resposta) VALUES (@idVisitante, @idPergunta, @resposta)";
                    SqlCommand command = new SqlCommand(sql, con);
                    command.Parameters.AddWithValue("@idVisitante", resposta.IdVisitante);
                    command.Parameters.AddWithValue("@idPergunta", resposta.IdPergunta);
                    command.Parameters.AddWithValue("@resposta", resposta.RespostaTexto);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        this.mensagem = "Erro ao salvar as respostas: " + ex.Message;
                    }
                }
                Conexao.Desconectar();
            }
        }
    }
}

