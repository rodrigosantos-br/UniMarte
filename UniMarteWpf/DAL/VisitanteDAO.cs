using Microsoft.Data.SqlClient;
using UniMarteWpf.Modelo;

namespace UniMarteWpf.DAL
{
    public class VisitanteDAO
    {
        public string mensagem;

        public bool InserirVisitante(Visitante visitante)
        {
            SqlConnection con = Conexao.Conectar(); // Declara a conexão aqui
            String sql = @"INSERT INTO Visitante (Nome, DataNascimento, DataHoraCadastro) 
                        VALUES (@Nome, @DataNascimento, @DataHoraCadastro)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Nome", visitante.Nome);
            cmd.Parameters.AddWithValue("@DataNascimento", visitante.DataNascimento);
            cmd.Parameters.AddWithValue("@DataHoraCadastro", visitante.DataHoraCadastro);
            
            try
            {
                cmd.ExecuteNonQuery(); // Tenta executar a consulta
                return true;
            }
            catch (Exception e)
            {
                this.mensagem = "Erro ao inserir visitante: " + e.Message;
                return false;
            }
            finally
            {
                Conexao.Desconectar(); // Desconecta ao final
            }
        }
    }
}
