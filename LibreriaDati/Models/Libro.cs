using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibreriaDati.Models
{
    public class Libro : RisorseBiblioteca
    {
        [Required]
        public string Codice { get; set; }
        [Required]
        public string Autore { get; set; }
        [Required]
        public string CasaEditrice { get; set; }
        [Required]
        public string Genere { get; set; }
    }
}
