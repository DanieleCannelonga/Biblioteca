using LibreriaDati.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaDati
{
    public interface GestioneBiblioteca
    {
        IEnumerable<RisorseBiblioteca> GetAll();
        RisorseBiblioteca GetById(int Id);
        void add(RisorseBiblioteca newRisorsaBiblioteca);
        string GetAutore(int Id);
        string GetGenere(int Id);
        string GetTitolo(int Id);
        string GetCasaEditrice(int Id);
        Filiale GetCurrentLocation(int Id);
    }
}
