using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UniMarte.Web.Data.Interfaces;
using UniMarte.Web.Models;
using UniMarte.Web.ViewModel;

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
            // Obtém o ID do visitante da sessão
            var visitanteId = HttpContext.Session.GetInt32("VisitanteId");
            if (visitanteId == null)
            {
                return RedirectToAction("Cadastrar", "Visitantes");
            }

            // Verifica se o modelo é válido e todas as respostas foram fornecidas
            if (viewModel?.Respostas == null || viewModel.Respostas.Any(r => string.IsNullOrWhiteSpace(r.RespostaTexto)))
            {
                ModelState.AddModelError("", "Por favor, responda todas as perguntas antes de enviar.");

                // Recupera perguntas e obras novamente para a exibição da página
                var perguntas = _perguntaRepository.Buscar();
                var obras = _obraRepository.ObterTodasAsObras().Result;
                ViewBag.VisitanteId = visitanteId.Value;
                ViewBag.Obras = obras;

                return View("ExibirPerguntas", perguntas);
            }

            try
            {
                // Salva as respostas no repositório
                foreach (var respostaVM in viewModel.Respostas)
                {
                    var resposta = new Resposta
                    {
                        IdVisitante = visitanteId.Value,
                        IdPergunta = respostaVM.IdPergunta,
                        RespostaTexto = respostaVM.RespostaTexto
                    };

                    _respostaRepository.AdicionarRespostas(resposta);
                }

                // Redireciona para o relatório ao finalizar o salvamento
                return RedirectToAction("ObterRelatorio", "Relatorio");
            }
            catch (Exception ex)
            {
                // Log do erro para depuração
                Debug.WriteLine($"Erro ao salvar respostas: {ex.Message}");
                Debug.WriteLine($"StackTrace: {ex.StackTrace}");

                // Mensagem de erro para o usuário
                ModelState.AddModelError("", "Ocorreu um erro ao salvar as respostas. Por favor, tente novamente.");

                return RedirectToAction("Cadastrar", "Visitantes");
            }
        }
    }
}
