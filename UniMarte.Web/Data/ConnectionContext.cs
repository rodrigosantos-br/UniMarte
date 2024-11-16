using Microsoft.EntityFrameworkCore;
using UniMarte.Web.Models;

namespace UniMarte.Web.Data
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext(DbContextOptions<ConnectionContext> options) 
            : base(options) 
        {
        }

        public DbSet<Visitante> Visitantes { get; set; }
        public DbSet<Obra> Obras { get; set; }
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<Resposta> Respostas { get; set; }
    }
}
