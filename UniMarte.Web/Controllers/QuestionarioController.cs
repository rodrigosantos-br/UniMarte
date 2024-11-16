using Microsoft.AspNetCore.Mvc;
using UniMarte.Web.Data;
using UniMarte.Web.Models;

namespace UniMarte.Web.Controllers
{
    public class QuestionarioController : Controller
    {
        private readonly ConnectionContext _context;

        public QuestionarioController(ConnectionContext context)
        {
            _context = context;
        }

        public IActionResult ExibirPerguntas()
        {
            var perguntas = _context.Perguntas.ToList();

            // Recuperar o IdVisitante da sessão
            var visitanteId = HttpContext.Session.GetInt32("VisitanteId");

            if (visitanteId == null)
            {
                return RedirectToAction("Cadastrar", "Visitantes");
            }

            ViewBag.VisitanteId = visitanteId.Value;

            return View(perguntas);
        }


        [HttpPost]
        public IActionResult SalvarRespostas(int idVisitante, List<Resposta> respostas)
        {
            foreach (var resposta in respostas)
            {
                resposta.IdVisitante = idVisitante;
                _context.Respostas.Add(resposta);
            }

            _context.SaveChanges();
            return RedirectToAction("Confirmacao");
        }

    }
}
