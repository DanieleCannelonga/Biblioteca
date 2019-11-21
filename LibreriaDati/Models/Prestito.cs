using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaDati.Models
{
    public class Prestito
    {
        public int Id { get; set; }
        public virtual RisorseBiblioteca RisorseBiblioteca { get; set; }
        public virtual BibliotecaCard BibliotecaCard { get; set; }
        public DateTime DataPrestito { get; set; }

        public string risorsa { get; set; }
    }
}
