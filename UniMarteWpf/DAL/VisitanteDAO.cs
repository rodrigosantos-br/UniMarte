using Microsoft.Data.SqlClient;
using UniMarteWpf.Estatico;
using UniMarteWpf.Modelo;

namespace UniMarteWpf.DAL
{
    public class VisitanteDAO
    {
        public string mensagem;

        public bool InserirVisitante(Visitante visitante)
        {
            SqlConnection con = Conexao.Conectar(); // Declara a conexão aqui
            String sql = @"INSERT INTO Visitantes (Nome, DataNascimento, DataHoraCadastro) 
                        OUTPUT INSERTED.IdVisitante
                        VALUES (@Nome, @DataNascimento, @DataHoraCadastro)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Nome", visitante.Nome);
            cmd.Parameters.AddWithValue("@DataNascimento", visitante.DataNascimento);
            cmd.Parameters.AddWithValue("@DataHoraCadastro", visitante.DataHoraCadastro);

            try
            {
                SessaoVisitante.IdVisitante = Convert.ToInt32(cmd.ExecuteScalar());
                return true;
            }
            catch (Exception e)
            {
                this.mensagem = "Erro ao inserir visitante: " + e.Message;
                return false; // Retorna 0 em caso de erro
            }
            finally
            {
                Conexao.Desconectar(); // Desconecta ao final
            }
        }
    }
}
