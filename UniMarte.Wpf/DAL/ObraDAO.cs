using Microsoft.Data.SqlClient;
using UniMarte.Wpf.Modelo;

namespace UniMarte.Wpf.DAL
{
    public class ObraDAO
    {
        public Dictionary<string, Obra> ObterInformacoesObras()
        {
            var obrasDict = new Dictionary<string, Obra>();
            var con = Conexao.Conectar();

            try
            {
                using (var cmd = new SqlCommand("SELECT IdObra, Titulo, Historico FROM Obras", con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var obra = new Obra
                        {
                            IdObra = reader.GetInt32(0),
                            Titulo = reader.GetString(1),
                            Historico = reader.GetString(2)
                        };

                        // Usando o IdObra para determinar qual imagem corresponde à obra
                        string imagemPath = "";
                        switch (obra.IdObra)
                        {
                            case 1: imagemPath = "chegada_marte.jpg"; break;
                            case 2: imagemPath = "colonia_espacial.jpg"; break;
                            case 3: imagemPath = "crateras_vulcoes.jpg"; break;
                            case 4: imagemPath = "exploracao_robotica.jpg"; break;
                            case 5: imagemPath = "horizonte_marte.jpg"; break;
                            case 6: imagemPath = "paisagens_noturnas.jpg"; break;
                            case 7: imagemPath = "primeira_base_marte.jpg"; break;
                            case 8: imagemPath = "solo_formacao_marte.jpg"; break;
                            case 9: imagemPath = "solo_vermelho.jpg"; break;
                            case 10: imagemPath = "tecnologia_colonizacao.jpg"; break;
                            case 11: imagemPath = "vales_marte.jpg"; break;
                            case 12: imagemPath = "viagem_marte.jpg"; break;
                        }

                        obrasDict[imagemPath] = obra;
                    }
                }
            }
            finally
            {
                Conexao.Desconectar();
            }

            return obrasDict;
        }
    }
}