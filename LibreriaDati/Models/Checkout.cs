using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibreriaDati.Models
{
    public class Checkout
    {
        public int Id { get; set; }
        [Required]
        public RisorseBiblioteca RisorseBiblioteca { get; set; }
        public BibliotecaCard BibliotecaCard { get; set; }
        public DateTime Da { get; set; }
        public DateTime A { get; set; }
    }
}
