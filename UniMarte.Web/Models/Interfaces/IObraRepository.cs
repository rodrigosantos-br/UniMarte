namespace UniMarte.Web.Models.Interfaces
{
    public interface IObraRepository
    {
        Task<IEnumerable<Obra>> ObterTodasAsObras();
    }
}
