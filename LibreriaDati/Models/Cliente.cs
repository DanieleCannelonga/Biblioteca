using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibreriaDati.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public DateTime DataDiNascita { get; set; }
        public int Telefono { get; set; }
        public virtual BibliotecaCard BibliotecaCard { get; set; }
        public virtual Filiale FilialeDiAppartenenza { get; set; }
    }
}
