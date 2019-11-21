using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibreriaDati.Models
{
    public class Filiale
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [StringLength (30)]
        public string Indirizzo { get; set; }
        [Required]
        public int Telefono { get; set; }
        public string Descrizione { get; set; }
        public DateTime DataDiApertura { get; set; }
        public virtual IEnumerable<Cliente> Clienti { get; set; }
        public virtual IEnumerable<RisorseBiblioteca> RisorseBiblioteca { get; set; }
        public string ImmagineUrl { get; set; }
    }
}
