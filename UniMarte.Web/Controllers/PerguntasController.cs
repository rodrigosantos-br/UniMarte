using Microsoft.AspNetCore.Mvc;
using UniMarte.Web.Models;

namespace UniMarte.Web.Controllers
{
    public class PerguntasController : Controller
    {
        private readonly IPerguntaRepository _perguntaRepository;

        public PerguntasController(IPerguntaRepository perguntaRepository)
        {
            _perguntaRepository = perguntaRepository;
        }

        public async Task<ActionResult> Index()
        {
            var perguntas = _perguntaRepository.Buscar();
            return View(perguntas);
        }
    }
}
