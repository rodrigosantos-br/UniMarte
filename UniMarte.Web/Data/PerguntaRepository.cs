using UniMarte.Web.Models;
using UniMarte.Web.Models.Interfaces;

namespace UniMarte.Web.Data
{
    public class PerguntaRepository : IPerguntaRepository
    {
        private readonly ConnectionContext _context;

        // Construtor que recebe o ConnectionContext injetado
        public PerguntaRepository(ConnectionContext context)
        {
            _context = context;
        }

        public List<Pergunta> Buscar()
        {
            return _context.Perguntas.ToList();
        }
    }
}
