using UniMarte.Web.Models;

namespace UniMarte.Web.ViewModel
{
    public class QuestionarioViewModel
    {
        public int IdVisitante { get; set; }
        public List<Resposta> Respostas { get; set; }
    }
}
