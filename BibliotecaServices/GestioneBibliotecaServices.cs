using LibreriaDati;
using LibreriaDati.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaServices
{
    public class GestioneBibliotecaServices : GestioneBiblioteca
    {
        private BibliotecaContext _context;
        public GestioneBibliotecaServices(BibliotecaContext context)
        {
            _context = context;
        }
        public void add(RisorseBiblioteca newRisorsaBiblioteca)
        {
            _context.Add(newRisorsaBiblioteca);
            _context.SaveChanges();
        }

        public IEnumerable<RisorseBiblioteca> GetAll()
        {
            return _context.RisorseBiblioteca
                .Include(asset => asset.Stato)
                .Include(asset => asset.Filiale);
        }

        public RisorseBiblioteca GetById(int Id)
        {
            return GetAll()
                .FirstOrDefault(asset => asset.Id == Id);
        }

        public Filiale GetCurrentLocation(int Id)
        {
            return GetById(Id).Filiale;
        }

        public string GetCodice(int Id)
        {
            if(_context.Libro.Any(a => a.Id == Id))
            {
                return _context.Libro
                    .FirstOrDefault(Libro => Libro.Id == Id)
                    .Codice;
            }
            else
            {
                return "";
            }
        }

        public string GetGenere(int Id)
        {
            
            return _context.Libro
                .FirstOrDefault(Libro => Libro.Id == Id)
                .Genere;
        
        }

        public string GetTitolo(int Id)
        {
            return _context.RisorseBiblioteca
                .FirstOrDefault(a => a.Id == Id)
                .Titolo;
        }
        public string GetAutore(int Id)
        {
            return _context.Libro
                .FirstOrDefault(Libro => Libro.Id == Id)
                .Autore;
        }

        public string GetCasaEditrice(int Id)
        {
            return _context.Libro
                .FirstOrDefault(Libro => Libro.Id == Id)
                .CasaEditrice;
        }

        //public string GetAutoreORegista(int Id)
        //{
        //    var isLibro = _context.RisorseBiblioteca.OfType<Libro>()
        //        .Where(asset => asset.Id == Id).Any();
        //    var isVideo = _context.RisorseBiblioteca.OfType<Video>()
        //        .Where(asset => asset.Id == Id).Any();
        //    return isLibro ?
        //    _context.Libro.FirstOrDefault(book => book.Id == Id).Autore :
        //    _context.Video.FirstOrDefault(video => video.Id == Id).Regista
        //    ?? "Unknown";
        //}
        //public string GetTipo(int Id)
        //{
        //    var Libro = _context.RisorseBiblioteca.OfType<Libro>()
        //        .Where(l => l.Id == Id);
        //    
        //    return isLibro.Any() ?
        //    "Libro" :
        //    "Video";
        //}
    }
}
