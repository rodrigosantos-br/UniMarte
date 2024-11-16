using Microsoft.AspNetCore.Mvc;
using UniMarte.Web.Models;
using UniMarte.Web.Models.Interfaces;
using System.Linq;
using UniMarte.Web.ViewModel;
using System.Diagnostics;

namespace UniMarte.Web.Controllers
{
    public class QuestionarioController : Controller
    {
        private readonly IRespostaRepository _respostaRepository;
        private readonly IPerguntaRepository _perguntaRepository;
        private readonly IObraRepository _obraRepository;

        public QuestionarioController(IRespostaRepository respostaRepository,
                                      IPerguntaRepository perguntaRepository,
                                      IObraRepository obraRepository)
        {
            _respostaRepository = respostaRepository;
            _perguntaRepository = perguntaRepository;
            _obraRepository = obraRepository;
        }

        // Exibe as perguntas para o visitante
        public IActionResult ExibirPerguntas()
        {
            var perguntas = _perguntaRepository.Buscar();
            var visitanteId = HttpContext.Session.GetInt32("VisitanteId");

            if (visitanteId == null)
            {
                return RedirectToAction("Cadastrar", "Visitantes");
            }

            // Recuperar a lista de obras
            var obras = _obraRepository.ObterTodasAsObras().Result;

            ViewBag.VisitanteId = visitanteId.Value;
            ViewBag.Obras = obras;

            return View(perguntas);
        }

        [HttpPost]
        public IActionResult SalvarRespostas(QuestionarioViewModel viewModel)
        {
            var visitanteId = HttpContext.Session.GetInt32("VisitanteId");
            if (visitanteId == null)
            {
                return RedirectToAction("Cadastrar", "Visitantes");
            }

            // Debug: Imprime os dados recebidos
            Debug.WriteLine($"VisitanteId: {visitanteId}");
            if (viewModel?.Respostas != null)
            {
                foreach (var resp in viewModel.Respostas)
                {
                    Debug.WriteLine($"Pergunta: {resp.IdPergunta}, Resposta: {resp.RespostaTexto}");
                }
            }
            else
            {
                Debug.WriteLine("viewModel.Respostas é nulo!");
            }

            try
            {
                if (viewModel?.Respostas != null)
                {
                    foreach (var respostaVM in viewModel.Respostas.Where(r => !string.IsNullOrEmpty(r.RespostaTexto)))
                    {
                        var resposta = new Resposta
                        {
                            IdVisitante = visitanteId.Value,
                            IdPergunta = respostaVM.IdPergunta,
                            RespostaTexto = respostaVM.RespostaTexto
                        };

                        _respostaRepository.AdicionarRespostas(resposta);
                        Debug.WriteLine($"Resposta salva - Visitante: {resposta.IdVisitante}, Pergunta: {resposta.IdPergunta}, Resposta: {resposta.RespostaTexto}");
                    }
                }

                return RedirectToAction("ObterRelatorio", "Relatorio");
            }
            catch (System.Exception ex)
            {
                Debug.WriteLine($"Erro ao salvar respostas: {ex.Message}");
                Debug.WriteLine($"StackTrace: {ex.StackTrace}");

                ModelState.AddModelError("", "Ocorreu um erro ao salvar as respostas.");
                var perguntas = _perguntaRepository.Buscar();
                var obras = _obraRepository.ObterTodasAsObras().Result;
                ViewBag.VisitanteId = visitanteId.Value;
                ViewBag.Obras = obras;
                return View("ExibirPerguntas", perguntas);
            }
        }

    }
}
