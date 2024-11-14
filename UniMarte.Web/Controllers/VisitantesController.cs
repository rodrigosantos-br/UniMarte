using Microsoft.AspNetCore.Mvc;
using UniMarte.Web.Models;

namespace UniMarte.Web.Controllers
{
    [Route("Cadastro")]
    public class VisitantesController : Controller
    {
        private readonly IVisitanteRepository _visitanteRepository;

        public VisitantesController(IVisitanteRepository visitanteRepository)
        {
            _visitanteRepository = visitanteRepository;
        }

        // Action para exibir o formulário de cadastro (GET)
        [HttpGet]
        public IActionResult Cadastro()
        {
            return View(new Visitante());
        }

        // Action para processar o envio do formulário de cadastro (POST)
        [HttpPost]
        public async Task<IActionResult> Cadastro(Visitante visitante)
        {
            if (!ModelState.IsValid)
            {
                return View(visitante);
            }

            visitante.DataHoraCadastro = DateTime.Now;
            await _visitanteRepository.AdicionarVisitante(visitante);

            // Redireciona para a página inicial ou qualquer página de sucesso desejada
            return RedirectToAction("Index", "Obras");
        }
    }
}
