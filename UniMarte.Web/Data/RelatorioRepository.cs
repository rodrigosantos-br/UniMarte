using Microsoft.EntityFrameworkCore;
using UniMarte.Web.Data.Interfaces;

namespace UniMarte.Web.Data
{
    public class RelatorioRepository : IRelatorioRepository
    {
        private readonly ConnectionContext _context;

        public RelatorioRepository(ConnectionContext context)
        {
            _context = context;
        }

        public double ObterMediaEstrelas()
        {
            // Primeiro, pegue as perguntas e respostas relacionadas ao tipo "Estrelas"
            var respostas = _context.Perguntas
                                    .Join(_context.Respostas,
                                        p => p.IdPergunta,
                                        r => r.IdPergunta,
                                        (p, r) => new { p, r })
                                    .Where(x => x.p.TipoResposta == "Estrelas")
                                    .Select(x => x.r.RespostaTexto)
                                    .ToList();  // Executa a consulta no banco e traz os dados para memória

            // Depois, converta e calcule a média na memória
            var mediaEstrelas = respostas
                                .Select(resposta => double.TryParse(resposta, out var result) ? result : 0)
                                .DefaultIfEmpty(0)
                                .Average();

            return Math.Round(mediaEstrelas, 1);
        }

        public int ObterNumeroVisitantesQueResponderam()
        {
            var totalVisitantesQueResponderam = _context.Respostas
                                                        .Join(_context.Perguntas, r => r.IdPergunta, p => p.IdPergunta, (r, p) => new { r, p })
                                                        .Where(x => !string.IsNullOrEmpty(x.r.RespostaTexto) &&
                                                                    x.p.TipoResposta == "Estrelas" &&
                                                                    EF.Functions.IsNumeric(x.r.RespostaTexto)) // Usa a função IsNumeric do EF
                                                        .Select(x => x.r.IdVisitante)
                                                        .Distinct()
                                                        .Count();

            return totalVisitantesQueResponderam;
        }

    }
}
