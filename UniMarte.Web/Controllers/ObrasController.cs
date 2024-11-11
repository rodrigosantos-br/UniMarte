using Microsoft.AspNetCore.Mvc;
using UniMarte.Web.Models;

namespace UniMarte.Web.Controllers
{
    public class ObrasController : Controller
    {
        private readonly IObraRepository _obraRepository;

        public ObrasController(IObraRepository obraRepository)
        {
            _obraRepository = obraRepository;
        }

        public async Task<IActionResult> Index()
        {
            var obras = await _obraRepository.ObterTodasAsObras();
            return View(obras);
        }
    }

}
