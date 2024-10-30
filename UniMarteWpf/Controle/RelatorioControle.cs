using UniMarteWpf.DAL;

namespace UniMarteWpf.Controle
{
    public class RelatorioControle
    {
        private RelatorioDAO relatorioDAO = new RelatorioDAO();

        public (int totalVisitantes, float mediaRespostas) GerarRelatorio()
        {
            return relatorioDAO.ObterRelatorio();
        }
    }
}
