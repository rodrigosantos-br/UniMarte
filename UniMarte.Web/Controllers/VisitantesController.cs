using Microsoft.AspNetCore.Mvc;
using UniMarte.Web.Data.Interfaces;
using UniMarte.Web.Models;

namespace UniMarte.Web.Controllers
{
    public class VisitantesController : Controller
    {
        private readonly IVisitanteRepository _visitanteRepository;

        public VisitantesController(IVisitanteRepository visitanteRepository)
        {
            _visitanteRepository = visitanteRepository;
        }

        // Action para exibir o formulário de cadastro (GET)
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View(); 
        }

        // Action para processar o envio do formulário de cadastro (POST)
        [HttpPost]
        public async Task<IActionResult> Cadastrar(Visitante visitante)
        {
            if (ModelState.IsValid)
            {
                visitante.DataHoraCadastro = DateTime.Now;
                await _visitanteRepository.AdicionarVisitante(visitante);
                HttpContext.Session.SetString("VisitanteCadastrado", "true");
                // Salva o ID do visitante na sessão
                HttpContext.Session.SetInt32("VisitanteId", visitante.IdVisitante);
                HttpContext.Session.SetString("VisitanteCadastrado", "true");
                return RedirectToAction("Listar", "Obras");

            }

            return View("Cadastrar", visitante);

        }
    }
}
