using UniMarte.Wpf.DAL;

namespace UniMarte.Wpf.Controle
{
    public class RelatorioControle
    {
        private RelatorioVisitanteDAO relatorioDAO = new RelatorioVisitanteDAO();

        public (int totalVisitantes, float mediaRespostas) GerarRelatorio()
        {
            return relatorioDAO.ObterRelatorio();
        }
    }
}
