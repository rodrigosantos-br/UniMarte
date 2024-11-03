﻿using Microsoft.Data.SqlClient;
using UniMarteWpf.DAL;

namespace UniMarteWpf.DataAccess
{
    public class RelatorioAdmDAO
    {
        public string mensagem;
        public int ObterTotalVisitantes()
        {
            try
            {
                var con = Conexao.Conectar();

                var command = new SqlCommand("SELECT COUNT(*) FROM Visitantes", con);
                return (int)command.ExecuteScalar();
            }
            catch
            {
                this.mensagem = "Erro ao obter total de visitantes!";
                return 0;
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        public int ObterQuestionariosRespondidos()
        {
            try
            {
                var con = Conexao.Conectar();
                
                var command = new SqlCommand("SELECT \r\n    COUNT(DISTINCT idVisitante) AS TotalVisitantesQueResponderam\r\nFROM \r\n    Respostas\r\nWHERE \r\n    idVisitante IS NOT NULL;", con);
                return (int)command.ExecuteScalar();
            }
            catch
            {
                this.mensagem = "Erro";
                return 0;
            }
            finally
            {
                Conexao.Desconectar();
            }

        }

        public float ObterMediaAvaliacao()
        {
            try
            {
                var con = Conexao.Conectar();

                var cmd = new SqlCommand(@"
        SELECT 
            AVG(TRY_CONVERT(float, r.resposta)) AS MediaRespostas
        FROM 
            Respostas r
        JOIN 
            Perguntas p ON r.idPergunta = p.IdPergunta
        WHERE 
            p.tipoResposta = 'Estrelas' 
            AND r.resposta IS NOT NULL 
            AND r.resposta <> '' 
            AND ISNUMERIC(r.resposta) = 1;
        ", con);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Acesse a coluna de índice 0
                    double mediaRespostas = reader.IsDBNull(0) ? 0 : reader.GetDouble(0);
                    return (float)Math.Round(mediaRespostas, 2); // Retorne o valor da média
                }

                return 0; // Retorne 0 caso não haja resultados
            }
            catch
            {
                this.mensagem = "Erro ao consultar relatório";
                return 0; // Retorne 0 em caso de erro
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        public (double PorcentagemSim, double PorcentagemNao) ObterPorcentagemRespostasSimNao()
        {
            try
            {
                var con = Conexao.Conectar();
                var commandSim = new SqlCommand("SELECT COUNT(*) FROM Respostas WHERE Resposta = 'Sim'", con);
                var commandNao = new SqlCommand("SELECT COUNT(*) FROM Respostas WHERE Resposta = 'Não'", con);

                int totalSim = (int)commandSim.ExecuteScalar();
                int totalNao = (int)commandNao.ExecuteScalar();
                int total = totalSim + totalNao;

                double porcentagemSim = total > 0 ? (double)totalSim / total * 100 : 0;
                double porcentagemNao = total > 0 ? (double)totalNao / total * 100 : 0;

                return (porcentagemSim, porcentagemNao);
            }
            catch
            {
                this.mensagem = "Erro ao obter porcetagem";
                return (0, 0);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        public IEnumerable<(string Resposta, int TotalSelecionado)> ObterQuantidadeVotosPorObra()
        {
            var resultados = new List<(string Resposta, int TotalSelecionado)>();

            string sql = @"
        SELECT r.Resposta, COUNT(*) AS TotalSelecionado
        FROM Respostas r
        JOIN Perguntas p ON r.IdPergunta = p.IdPergunta
        WHERE p.TipoResposta = 'EscolhaObra'
        GROUP BY r.Resposta
        ORDER BY TotalSelecionado DESC;";

            try
            {
                var con = Conexao.Conectar();
                var cmd = new SqlCommand(sql, con);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    resultados.Add((reader.GetString(0), reader.GetInt32(1))); // Ler a resposta e o total
                }
            }
            catch (Exception ex) // Capture a exceção para obter mais informações
            {
                this.mensagem = "Erro ao obter Votos: " + ex.Message; // Adiciona detalhes do erro
                                                                      // Você pode também usar um log para registrar a exceção, se necessário
            }
            finally
            {
                Conexao.Desconectar(); // Certifique-se de que a conexão será fechada
            }

            return resultados; // Retorna a lista, que pode estar vazia se ocorreu um erro
        }

        public Dictionary<string, List<(DateTime Data, double Nota)>> ObterAvaliacoesPorPerguntaUltimos7Dias()
        {
            var resultados = new Dictionary<string, List<(DateTime Data, double Nota)>>();

            // Inicializa as listas para cada pergunta
            var perguntas = new List<string> { "Arquitetura", "Ambiente e Limpeza", "Atendimento dos Funcionários", "Qualidade das Obras" };
            foreach (var pergunta in perguntas)
            {
                resultados[pergunta] = new List<(DateTime, double)>();
            }

            using (var con = Conexao.Conectar())
            {
                var cmd = new SqlCommand(@"
            SELECT p.TextoPergunta, CAST(v.DataHoraCadastro AS DATE) AS Data, AVG(CAST(r.Resposta AS FLOAT)) AS Media
            FROM Respostas r
            JOIN Perguntas p ON r.IdPergunta = p.IdPergunta
            JOIN Visitantes v ON r.IdVisitante = v.IdVisitante
            WHERE p.TipoResposta = 'Estrelas' AND v.DataHoraCadastro >= DATEADD(DAY, -7, GETDATE())
            GROUP BY p.TextoPergunta, CAST(v.DataHoraCadastro AS DATE)
            ORDER BY p.TextoPergunta, Data", con);

                try
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var pergunta = reader.GetString(0);
                            var data = reader.GetDateTime(1);
                            var mediaNota = reader.IsDBNull(2) ? 0 : reader.GetDouble(2);

                            if (resultados.ContainsKey(pergunta))
                            {
                                resultados[pergunta].Add((data, mediaNota));
                            }
                            else
                            {
                                resultados[pergunta] = new List<(DateTime, double)> { (data, mediaNota) };
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    this.mensagem = "Erro ao obter as avaliações diárias: " + ex.Message;
                }
            }
            foreach (var pergunta in resultados)
            {
                Console.WriteLine($"Pergunta: {pergunta.Key} - Total de Avaliações: {pergunta.Value.Count}");

                foreach (var (data, mediaNota) in pergunta.Value)
                {
                    Console.WriteLine($"  Data: {data.ToShortDateString()}, Média: {mediaNota}");
                }
            }
            return resultados;
        }
    }
}
