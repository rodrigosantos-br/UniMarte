using Microsoft.Data.SqlClient;

namespace UniMarteWpf.DAL
{
    public class Conexao
    {
        public static SqlConnection con = new SqlConnection();
        public static string mensagem = "";
        public static string stringConexao = "Data Source=RODRIGO_STUDIE;Initial Catalog=UniMarte_DB;Persist Security Info=True;User ID=sa;Password=Sa123!@#;Trust Server Certificate=True";

        public static SqlConnection Conectar()
        {
            mensagem = "";
            con.ConnectionString = stringConexao;
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (SqlException e)
            {
                mensagem = "Erro ao conectar com BD: " + e.Message;
            }
            return con;
        }

        public static void Desconectar()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (SqlException e)
            {
                mensagem = "Erro ao desconectar o BD: " + e.Message;
            }
        }
    }
}

