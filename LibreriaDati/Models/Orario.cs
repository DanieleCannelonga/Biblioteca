using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibreriaDati.Models
{
    public class Orario
    {
        public int Id { get; set; }
        public Filiale Filiale { get; set; }
        [Range(0,6)]
        public int GiorniSettimanali { get; set; }
        [Range(0, 23)]
        public int OrarioDiApertura { get; set; }
        [Range(0, 23)]
        public int OrarioDiChiusura { get; set; }
    }
}
