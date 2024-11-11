using System.ComponentModel.DataAnnotations;

namespace UniMarte.Web.Models
{
    public class Obra
    {
        [Key]
        public int IdObra { get; set; }
        public string Titulo { get; set; }
        public string Historico { get; set; }
        public string ImagemUrl { get; set; }
    }
}
