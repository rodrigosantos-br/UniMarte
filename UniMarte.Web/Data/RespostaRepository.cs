using System.Diagnostics;
using UniMarte.Web.Data.Interfaces;
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

        // Adicione logs no RespostaRepository
        public void AdicionarRespostas(Resposta resposta)
        {
            try
            {
                _context.Respostas.Add(resposta);
                Debug.WriteLine($"Tentando salvar resposta: Visitante {resposta.IdVisitante}, Pergunta {resposta.IdPergunta}");
                _context.SaveChanges();
                Debug.WriteLine("Resposta salva com sucesso");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Erro ao salvar no banco: {ex.Message}");
                throw;
            }
        }

    }
}
