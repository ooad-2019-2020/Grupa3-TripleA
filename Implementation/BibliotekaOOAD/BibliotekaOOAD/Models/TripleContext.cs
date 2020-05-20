using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotekaOOAD.Models;
using Microsoft.EntityFrameworkCore;
namespace AspNetCoreMVC.Models
{
    public class TripleContext : DbContext
    {
        public TripleContext(DbContextOptions<TripleContext> options) : base(options)
        {
        }
        public DbSet<AdministratorDb> AdministratorDb { get; set; }
        public DbSet<Biblioteka> Biblioteka { get; set; }
        public DbSet<BibliotekarDb> BibliotekarDb { get; set; }
        public DbSet<Gost> Gost { get; set; }
        public DbSet<Knjiga> Knjiga { get; set; }
        public DbSet<KnjigaZahtjev> KnjigaZahtjev { get; set; }
        public DbSet<Obavjestenje> Obavjestenje { get; set; }
        public DbSet<ObicniKorisnikDb> ObicniKorisnikDb { get; set; }
        public DbSet<Osoba> Osoba { get; set; }
        public DbSet<PlacanjeClanarine> PlacanjeClanarine { get; set; }
        public DbSet<Racun> Racun { get; set; }
        public DbSet<Recenzija> Recenzija { get; set; }
        public DbSet<VipKorisnikDb> VipKorisnikDb { get; set; }

        public DbSet<Zanr> Zanr { get; set; }

        //Ova funkcija se koriste da bi se ukinulo automatsko dodavanje množine u nazive
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdministratorDb>().ToTable("Administrator");
            modelBuilder.Entity<Biblioteka>().ToTable("Biblioteka").HasNoKey();
            modelBuilder.Entity<BibliotekarDb>().ToTable("Bibliotekar");
            modelBuilder.Entity<Gost>().ToTable("Gost");
            modelBuilder.Entity<Knjiga>().ToTable("Knjiga");
            modelBuilder.Entity<KnjigaZahtjev>().ToTable("KnjigaZahtjev").HasNoKey();
            modelBuilder.Entity<Obavjestenje>().ToTable("Obavjestenje");
            modelBuilder.Entity<ObicniKorisnikDb>().ToTable("ObicniKorisnik");
            modelBuilder.Entity<Osoba>().ToTable("Osoba");
            modelBuilder.Entity<PlacanjeClanarine>().ToTable("PlacanjeClanarine").HasNoKey();
            modelBuilder.Entity<Racun>().ToTable("Racun");
            modelBuilder.Entity<Recenzija>().ToTable("Recenzija");
            modelBuilder.Entity<VipKorisnikDb>().ToTable("VipKorisnik");
            modelBuilder.Entity<Zanr>().ToTable("Zanr");
        }
    }
}
