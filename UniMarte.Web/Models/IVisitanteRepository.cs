namespace UniMarte.Web.Models
{
    public interface IVisitanteRepository
    {
        Task AdicionarVisitante(Visitante visitante);
    }
}
