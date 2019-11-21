using LibreriaDati.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LibreriaDati
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options) { }

        public DbSet<Orario> Orario { get; set; }
        public DbSet<Checkout> Checkout { get; set; }
        public DbSet<CronologiaCheckout> CronologiaCheckout { get; set; }
        public DbSet<Libro> Libro { get; set; }
        public DbSet<RisorseBiblioteca> RisorseBiblioteca { get; set; }
        public DbSet<Filiale> Filiale { get; set; }
        public DbSet<Prestito> Prestito { get; set; }
        public DbSet<BibliotecaCard> BibliotecaCard { get; set; }
        public DbSet<Stato> Stato { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
    }
}
