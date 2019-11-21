using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibreriaDati.Models
{
    public abstract class RisorseBiblioteca
    {
        public int Id { get; set; }
        [Required]
        public string Titolo { get; set; }
        [Required]
        public int Anno { get; set; }
        [Required]
        public Stato Stato { get; set; }
        [Required]
        public Decimal Costo { get; set; }
        public string ImmagineUrl { get; set; }
        public int NumeroDiCopie { get; set; }
        public string Discriminator { get; set; }
        public virtual Filiale Filiale { get; set; }
    }
}
