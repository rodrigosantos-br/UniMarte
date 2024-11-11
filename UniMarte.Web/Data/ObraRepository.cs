using Microsoft.EntityFrameworkCore;
using UniMarte.Web.Models;

namespace UniMarte.Web.Data
{
    public class ObraRepository : IObraRepository
    {
        private readonly ConnectionContext _context;

        public ObraRepository(ConnectionContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Obra>> ObterTodasAsObras()
        {
            return await _context.Obras.ToListAsync();
        }
    }
}
