using UniMarte.Web.Models;

namespace UniMarte.Web.Data.Interfaces
{
    public interface IVisitanteRepository
    {
        Task AdicionarVisitante(Visitante visitante);
    }
}
