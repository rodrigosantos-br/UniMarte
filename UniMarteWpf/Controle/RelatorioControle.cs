using UniMarteWpf.DAL;

namespace UniMarteWpf.Controle
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
