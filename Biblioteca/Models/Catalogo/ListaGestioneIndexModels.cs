using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models.Catalogo
{
    public class ListaGestioneIndexModels
    {
        public int Id { get; set; }
        public string ImmagineUrl { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public string Genere { get; set; }
        public string CasaEditrice { get; set; }
        public string NumeroDiCopie { get; set; }

    }
}
