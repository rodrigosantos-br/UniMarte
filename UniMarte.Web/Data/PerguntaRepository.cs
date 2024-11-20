using UniMarte.Web.Data.Interfaces;
using UniMarte.Web.Models;

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
