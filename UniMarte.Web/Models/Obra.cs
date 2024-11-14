using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniMarte.Web.Models
{
    [Table("Obras")]
    public class Obra
    {
        [Key]
        public int IdObra { get; set; }
        public string Titulo { get; set; }
        public string Historico { get; set; }
        public string ImagemUrl { get; set; }
    }
}
