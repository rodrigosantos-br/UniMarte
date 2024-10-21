using Microsoft.Data.SqlClient;
using UniMarteWpf.Modelo;

namespace UniMarteWpf.DAL
{
    public class UsuarioDAO
    {
        public string mensagem;
        public bool InserirUsuario(Usuario usuario)
        {
            
            SqlConnection con = Conexao.Conectar();
            
            String sql = "INSERT INTO Usuario (NomeUsuario, Senha, NomeCompleto, Idade, Email) VALUES NomeUsuario, @Senha, @NomeCompleto, @Idade, @Email)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@NomeUsuario", usuario.NomeUsuario);
            cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
            cmd.Parameters.AddWithValue("@NomeCompleto", usuario.NomeCompleto);
            cmd.Parameters.AddWithValue("@Idade", usuario.Idade);
            cmd.Parameters.AddWithValue("@Email", usuario.Email);

            try
            {
                int result = cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                this.mensagem = "Erro no cadastro";
                return false;
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        public Usuario ObterUsuarioPorNome(string nomeUsuario)
        {
            SqlConnection con = Conexao.Conectar();
        
            string sql = "SELECT * FROM Usuario WHERE NomeUsuario = @NomeUsuario";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);

            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    return new Usuario
                    {
                        Id = (int)reader["Id"],
                        NomeUsuario = reader["NomeUsuario"].ToString(),
                        Senha = reader["Senha"].ToString(),
                        NomeCompleto = reader["NomeCompleto"].ToString(),
                        Idade = (int)reader["Idade"],
                        Email = reader["Email"].ToString()
                    };
                }
                return null;
            }
            catch
            {
                this.mensagem = "Erro na pesquisa";
                return null;
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        public bool AtualizarUsuario(Usuario usuario)
        {
            SqlConnection con = Conexao.Conectar();
            
            string sql = "UPDATE Usuario SET NomeCompleto = @NomeCompleto, Idade = @Idade, Email = @Email WHERE NomeUsuario = @NomeUsuario";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@NomeUsuario", usuario.NomeUsuario);
            cmd.Parameters.AddWithValue("@NomeCompleto", usuario.NomeCompleto);
            cmd.Parameters.AddWithValue("@Idade", usuario.Idade);
            cmd.Parameters.AddWithValue("@Email", usuario.Email);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                this.mensagem = "Erro ao atualizar usuário.";
            }
            finally
            {
                Conexao.Desconectar();
            }
            return true;
        }

        public bool ExcluirUsuario(string nomeUsuario)
        {
            SqlConnection con = Conexao.Conectar();
            
            string sql = "DELETE FROM Usuario WHERE NomeUsuario = @NomeUsuario";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);

            cmd.ExecuteNonQuery();
            return true;
        }
    }
}
