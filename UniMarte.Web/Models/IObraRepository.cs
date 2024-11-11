namespace UniMarte.Web.Models
{
    public interface IObraRepository
    {
        Task<IEnumerable<Obra>> ObterTodasAsObras();
    }
}
