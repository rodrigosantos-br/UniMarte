using UniMarte.Web.Models;

namespace UniMarte.Web.Data.Interfaces
{
    public interface IObraRepository
    {
        Task<IEnumerable<Obra>> ObterTodasAsObras();
    }
}
