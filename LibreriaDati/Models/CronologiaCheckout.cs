using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibreriaDati.Models
{
    public class CronologiaCheckout
    {
        public int Id { get; set; }
        [Required]
        public RisorseBiblioteca RisorseBiblioteca { get; set; }
        [Required]
        public BibliotecaCard BibliotecaCard { get; set; }
        [Required]
        public DateTime Entrata { get; set; }
        public DateTime? Uscita { get; set; }
    }
}
