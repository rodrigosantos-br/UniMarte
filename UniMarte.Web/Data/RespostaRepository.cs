using UniMarte.Web.Models;

namespace UniMarte.Web.Data
{
    public class RespostaRepository : IRespostaRepository
    {
        private readonly ConnectionContext _context;

        public RespostaRepository(ConnectionContext context)
        {
            _context = context;
        }

        public void AdicionarRespostas(Resposta resposta)
        {
            _context.Respostas.Add(resposta);
            _context.SaveChanges();
        }
    }
}
