using UniMarte.Web.Models;

namespace UniMarte.Web.Data.Interfaces
{
    public interface IPerguntaRepository
    {
        List<Pergunta> Buscar();
    }
}
