using Microsoft.Data.SqlClient;

namespace UniMarte.Wpf.DAL
{
    public class Conexao
    {
        public static SqlConnection con = new SqlConnection();
        public static string mensagem = "";
        public static string stringConexao = "workstation id=UniMarte_DB.mssql.somee.com;packet size=4096;user id=rodrigosantos_SQLLogin_1;pwd=7x3lszkbzl;data source=UniMarte_DB.mssql.somee.com;persist security info=False;initial catalog=UniMarte_DB;TrustServerCertificate=True";

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

