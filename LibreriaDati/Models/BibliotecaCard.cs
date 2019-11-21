using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibreriaDati.Models
{
    public class BibliotecaCard
    {
        public int Id { get; set; }
        [Required]
        public string Seriale { get; set; }
        [Required]
        public DateTime DataDiCreazione { get; set; }
        [Required]
        public virtual IEnumerable<Checkout> Checkouts { get; set; }
    }
}
