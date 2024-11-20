using UniMarte.Web.Data.Interfaces;
using UniMarte.Web.Models;

namespace UniMarte.Web.Data
{
    public class VisitanteRepository : IVisitanteRepository
    {
        private readonly ConnectionContext _context;

        public VisitanteRepository(ConnectionContext context)
        {
            _context = context;
        }

        public async Task AdicionarVisitante(Visitante visitante)
        {
            _context.Visitantes.Add(visitante);
            await _context.SaveChangesAsync();
        }
    }
}
