using Biblioteca.Models.Catalogo;
using LibreriaDati;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Biblioteca.Controllers
{
    public class CatalogoController : Controller
    {
        private GestioneBiblioteca _gestione;
        public CatalogoController(GestioneBiblioteca gestione)
        {
            _gestione = gestione;
        }
        public IActionResult Index()
        {
            var gestioneModels = _gestione.GetAll();
            var listaRisultati = gestioneModels
                .Select(result => new ListaGestioneIndexModels
                {
                    Id = result.Id,
                    ImmagineUrl = result.ImmagineUrl,
                    Autore = _gestione.GetAutore(result.Id),
                    Titolo = result.Titolo,
                    Genere = _gestione.GetGenere(result.Id),
                    CasaEditrice = _gestione.GetCasaEditrice(result.Id)
                });
            var model = new GestioneIndexModels()
            {
                gestione = listaRisultati
            };
            return View(model);
        }
    }
}
