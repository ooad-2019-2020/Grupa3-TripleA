using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BiblitekaAPI
{
    public partial class BibliotekaDBContext : DbContext
    {
        public BibliotekaDBContext()
        {
        }

        public BibliotekaDBContext(DbContextOptions<BibliotekaDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrator> Administrator { get; set; }
        public virtual DbSet<Biblioteka> Biblioteka { get; set; }
        public virtual DbSet<Bibliotekar> Bibliotekar { get; set; }
        public virtual DbSet<Gost> Gost { get; set; }
        public virtual DbSet<Knjiga> Knjiga { get; set; }
        public virtual DbSet<KnjigaZahtjev> KnjigaZahtjev { get; set; }
        public virtual DbSet<Obavjestenje> Obavjestenje { get; set; }
        public virtual DbSet<ObicniKorisnik> ObicniKorisnik { get; set; }
        public virtual DbSet<Osoba> Osoba { get; set; }
        public virtual DbSet<Racun> Racun { get; set; }
        public virtual DbSet<Recenzija> Recenzija { get; set; }
        public virtual DbSet<VipKorisnik> VipKorisnik { get; set; }
        public virtual DbSet<Zanr> Zanr { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:triplea2019.database.windows.net,1433;Initial Catalog=BibliotekaDB;Persist Security Info=False;User ID=ayalika;Password=VolimoEhlimanu10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Biblioteka>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.AdministratorId);

                entity.HasIndex(e => e.GostId);

                entity.HasOne(d => d.Administrator)
                    .WithMany()
                    .HasForeignKey(d => d.AdministratorId);

                entity.HasOne(d => d.Gost)
                    .WithMany()
                    .HasForeignKey(d => d.GostId);
            });

            modelBuilder.Entity<Knjiga>(entity =>
            {
                entity.HasIndex(e => e.BibliotekarDbId);

                entity.HasIndex(e => e.KorisnikKojiJePosudioId);

                entity.Property(e => e.Rating).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.BibliotekarDb)
                    .WithMany(p => p.Knjiga)
                    .HasForeignKey(d => d.BibliotekarDbId);

                entity.HasOne(d => d.KorisnikKojiJePosudio)
                    .WithMany(p => p.Knjiga)
                    .HasForeignKey(d => d.KorisnikKojiJePosudioId);
            });

            modelBuilder.Entity<KnjigaZahtjev>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.KnjigaId);

                entity.HasIndex(e => e.KorisnikId);

                entity.HasOne(d => d.Knjiga)
                    .WithMany()
                    .HasForeignKey(d => d.KnjigaId);

                entity.HasOne(d => d.Korisnik)
                    .WithMany()
                    .HasForeignKey(d => d.KorisnikId);
            });

            modelBuilder.Entity<Obavjestenje>(entity =>
            {
                entity.HasIndex(e => e.ObicniKorisnikDbId);

                entity.HasIndex(e => e.ObicniKorisnikId);

                entity.HasIndex(e => e.PosiljaocId);

                entity.HasIndex(e => e.PrimaocId);

                entity.HasOne(d => d.ObicniKorisnikDb)
                    .WithMany(p => p.Obavjestenje)
                    .HasForeignKey(d => d.ObicniKorisnikDbId);

                entity.HasOne(d => d.ObicniKorisnik)
                    .WithMany(p => p.ObavjestenjeObicniKorisnik)
                    .HasForeignKey(d => d.ObicniKorisnikId);

                entity.HasOne(d => d.Posiljaoc)
                    .WithMany(p => p.ObavjestenjePosiljaoc)
                    .HasForeignKey(d => d.PosiljaocId);

                entity.HasOne(d => d.Primaoc)
                    .WithMany(p => p.ObavjestenjePrimaoc)
                    .HasForeignKey(d => d.PrimaocId);
            });

            modelBuilder.Entity<ObicniKorisnik>(entity =>
            {
                entity.HasIndex(e => e.RacunId);

                entity.HasOne(d => d.Racun)
                    .WithMany(p => p.ObicniKorisnik)
                    .HasForeignKey(d => d.RacunId);
            });

            modelBuilder.Entity<Osoba>(entity =>
            {
                entity.HasIndex(e => e.RacunId);

                entity.Property(e => e.Discriminator).IsRequired();

                entity.HasOne(d => d.Racun)
                    .WithMany(p => p.Osoba)
                    .HasForeignKey(d => d.RacunId);
            });

            modelBuilder.Entity<Racun>(entity =>
            {
                entity.Property(e => e.Stanje).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Recenzija>(entity =>
            {
                entity.HasIndex(e => e.KnjigaId);

                entity.HasIndex(e => e.KorisnikId);

                entity.HasOne(d => d.Knjiga)
                    .WithMany(p => p.Recenzija)
                    .HasForeignKey(d => d.KnjigaId);

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Recenzija)
                    .HasForeignKey(d => d.KorisnikId);
            });

            modelBuilder.Entity<VipKorisnik>(entity =>
            {
                entity.Property(e => e.OstvareniPopust).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Zanr>(entity =>
            {
                entity.HasIndex(e => e.KnjigaId);

                entity.HasOne(d => d.Knjiga)
                    .WithMany(p => p.Zanr)
                    .HasForeignKey(d => d.KnjigaId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
