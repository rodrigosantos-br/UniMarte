using System.ComponentModel.DataAnnotations;
using UniMarte.Web.Models;

namespace UniMarte.Web.ViewModel
{
    public class QuestionarioViewModel
    {
        public int IdVisitante { get; set; }
        
        [Required(ErrorMessage = "Todos os campos precisam ser preenchidos")]
        public List<Resposta> Respostas { get; set; }
    }
}
