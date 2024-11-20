using Microsoft.Data.SqlClient;
using UniMarte.Wpf.Modelo;

namespace UniMarte.Wpf.DAL
{
    public class UsuarioDAO
    {
        public string mensagem;
        public bool InserirUsuario(Usuario usuario)
        {
            
            SqlConnection con = Conexao.Conectar();
            
            String sql = "INSERT INTO Usuarios (NomeUsuario, Senha, NomeCompleto, Idade, Email) VALUES (@NomeUsuario, @Senha, @NomeCompleto, @Idade, @Email)";
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

        public List<Usuario> ObterTodosUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (SqlConnection con = Conexao.Conectar())
            {
                string sql = "SELECT * FROM Usuarios";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    usuarios.Add(new Usuario
                    {
                        Id = (int)reader["IdUsuario"],
                        NomeUsuario = reader["NomeUsuario"].ToString(),
                        Senha = reader["Senha"].ToString(),
                        NomeCompleto = reader["NomeCompleto"].ToString(),
                        Idade = (int)reader["Idade"],
                        Email = reader["Email"].ToString()
                    });
                }
                Conexao.Desconectar();
            }
            return usuarios;
        }

        public Usuario ObterUsuarioPorNome(string nomeUsuario)
        {
            SqlConnection con = Conexao.Conectar();
        
            string sql = "SELECT * FROM Usuarios WHERE NomeUsuario = @NomeUsuario";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);

            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    return new Usuario
                    {
                        Id = (int)reader["IdUsuario"],
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
            
            string sql = "UPDATE Usuarios SET NomeCompleto = @NomeCompleto, Idade = @Idade, Senha = @Senha, Email = @Email WHERE NomeUsuario = @NomeUsuario";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@NomeUsuario", usuario.NomeUsuario);
            cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
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
            
            string sql = "DELETE FROM Usuarios WHERE NomeUsuario = @NomeUsuario";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                this.mensagem = "Erro ao excluir usuário";
                return false;
            }
            finally
            {
                Conexao.Desconectar();
            }
        }
    }
}
