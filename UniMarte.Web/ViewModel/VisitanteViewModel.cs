using System;
using System.ComponentModel.DataAnnotations;

namespace UniMarte.Web.ViewModel
{
    public class VisitanteViewModel
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}
