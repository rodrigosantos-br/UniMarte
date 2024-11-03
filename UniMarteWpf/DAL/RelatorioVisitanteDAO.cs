using Microsoft.Data.SqlClient;

namespace UniMarteWpf.DAL
{
    public class RelatorioVisitanteDAO
    {
        public string mensagem;
        public (int totalVisitantes, float mediaRespostas) ObterRelatorio()
        {
            try
            {
                using (SqlConnection con = Conexao.Conectar())
                {
                    SqlCommand cmd = new SqlCommand(@"
            SELECT 
                (SELECT COUNT(DISTINCT idVisitante) FROM Respostas) AS TotalVisitantes,
                
                (SELECT AVG(TRY_CONVERT(float, r.resposta)) 
                 FROM Respostas r 
                 JOIN Perguntas p ON r.idPergunta = p.IdPergunta 
                 WHERE p.tipoResposta = 'Estrelas' 
                   AND r.resposta IS NOT NULL 
                   AND r.resposta <> '' 
                   AND ISNUMERIC(r.resposta) = 1) AS MediaRespostas;", con);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int totalVisitantes = reader.GetInt32(0);
                            // Use GetDouble em vez de GetFloat
                            double mediaRespostas = reader.IsDBNull(1) ? 0 : reader.GetDouble(1);
                            // Converta para float se necessário
                            return (totalVisitantes, (float)mediaRespostas);
                        }
                    }
                }
                return (0, 0);
            }
            catch
            {
                this.mensagem = "Erro ao consultar relatório";
                return (0, 0);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }


    }
}
