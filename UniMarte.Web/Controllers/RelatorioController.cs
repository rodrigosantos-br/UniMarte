using Microsoft.AspNetCore.Mvc;
using UniMarte.Web.Models.Interfaces;
using UniMarte.Web.Models;

namespace UniMarte.Web.Controllers
{
    [Route("relatorio")]
    public class RelatorioController : Controller
    {
        private readonly IRelatorioRepository _relatorioRepository;

        public RelatorioController(IRelatorioRepository relatorioRepository)
        {
            _relatorioRepository = relatorioRepository;
        }

        [Route("obterRelatorio")]
        public IActionResult Relatorio()
        {
            var totalVisitantes = _relatorioRepository.ObterNumeroTotalDeVisitantes();
            var mediaEstrelas = _relatorioRepository.ObterMediaEstrelas();

            var relatorio = new Relatorio
            {
                TotalVisitantes = totalVisitantes,
                MediaEstrelas = mediaEstrelas
            };

            return View(relatorio); // Passa o modelo para a view
        }
    }
}
