﻿// <auto-generated />
using System;
using AspNetCoreMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BibliotekaOOAD.Migrations
{
    [DbContext(typeof(TripleContext))]
    [Migration("20200607121325_Migracija5")]
    partial class Migracija5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BibliotekaOOAD.Models.AdministratorDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojLoginova")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.Biblioteka", b =>
                {
                    b.Property<int?>("AdministratorId")
                        .HasColumnType("int");

                    b.Property<int?>("GostId")
                        .HasColumnType("int");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("AdministratorId");

                    b.HasIndex("GostId");

                    b.ToTable("Biblioteka");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.BibliotekarDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Bibliotekar");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.Gost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojPosjete")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Gost");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.Knjiga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BibliotekarDbId")
                        .HasColumnType("int");

                    b.Property<int?>("KorisnikKojiJePosudioId")
                        .HasColumnType("int");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BibliotekarDbId");

                    b.HasIndex("KorisnikKojiJePosudioId");

                    b.ToTable("Knjiga");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.KnjigaZahtjev", b =>
                {
                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KnjigaId")
                        .HasColumnType("int");

                    b.Property<int?>("KorisnikId")
                        .HasColumnType("int");

                    b.HasIndex("KnjigaId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("KnjigaZahtjev");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.Obavjestenje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumSlanja")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ObicniKorisnikDbId")
                        .HasColumnType("int");

                    b.Property<int?>("ObicniKorisnikId")
                        .HasColumnType("int");

                    b.Property<int?>("PosiljaocId")
                        .HasColumnType("int");

                    b.Property<int?>("PrimaocId")
                        .HasColumnType("int");

                    b.Property<string>("Tekst")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ObicniKorisnikDbId");

                    b.HasIndex("ObicniKorisnikId");

                    b.HasIndex("PosiljaocId");

                    b.HasIndex("PrimaocId");

                    b.ToTable("Obavjestenje");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.ObicniKorisnikDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KrajVazenjaClanarine")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RacunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RacunId");

                    b.ToTable("ObicniKorisnik");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.Osoba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Osoba");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Osoba");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.PlacanjeClanarine", b =>
                {
                    b.ToTable("PlacanjeClanarine");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.Racun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojRacuna")
                        .HasColumnType("int");

                    b.Property<decimal>("Stanje")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Racun");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.Recenzija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojZvjezdica")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumObjave")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KnjigaId")
                        .HasColumnType("int");

                    b.Property<int?>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<bool>("NeprimjerenSadrzaj")
                        .HasColumnType("bit");

                    b.Property<string>("TekstRecenzije")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KnjigaId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Recenzija");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.VipKorisnikDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("OstvareniPopust")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("VipKorisnik");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.Zanr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KnjigaId")
                        .HasColumnType("int");

                    b.Property<string>("Tip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vrsta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KnjigaId");

                    b.ToTable("Zanr");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.Administrator", b =>
                {
                    b.HasBaseType("BibliotekaOOAD.Models.Osoba");

                    b.Property<int>("BrojLoginova")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Administrator");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.ObicniKorisnik", b =>
                {
                    b.HasBaseType("BibliotekaOOAD.Models.Osoba");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KrajVazenjaClanarine")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RacunId")
                        .HasColumnType("int");

                    b.HasIndex("RacunId");

                    b.HasDiscriminator().HasValue("ObicniKorisnik");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.Biblioteka", b =>
                {
                    b.HasOne("BibliotekaOOAD.Models.Administrator", "Administrator")
                        .WithMany()
                        .HasForeignKey("AdministratorId");

                    b.HasOne("BibliotekaOOAD.Models.Gost", "Gost")
                        .WithMany()
                        .HasForeignKey("GostId");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.Knjiga", b =>
                {
                    b.HasOne("BibliotekaOOAD.Models.BibliotekarDb", null)
                        .WithMany("KnjigeIzSedmicnePreporuke")
                        .HasForeignKey("BibliotekarDbId");

                    b.HasOne("BibliotekaOOAD.Models.ObicniKorisnik", "KorisnikKojiJePosudio")
                        .WithMany()
                        .HasForeignKey("KorisnikKojiJePosudioId");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.KnjigaZahtjev", b =>
                {
                    b.HasOne("BibliotekaOOAD.Models.Knjiga", "Knjiga")
                        .WithMany()
                        .HasForeignKey("KnjigaId");

                    b.HasOne("BibliotekaOOAD.Models.ObicniKorisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.Obavjestenje", b =>
                {
                    b.HasOne("BibliotekaOOAD.Models.ObicniKorisnikDb", null)
                        .WithMany("Obavjestenja")
                        .HasForeignKey("ObicniKorisnikDbId");

                    b.HasOne("BibliotekaOOAD.Models.ObicniKorisnik", null)
                        .WithMany("Obavjestenja")
                        .HasForeignKey("ObicniKorisnikId");

                    b.HasOne("BibliotekaOOAD.Models.Osoba", "Posiljaoc")
                        .WithMany()
                        .HasForeignKey("PosiljaocId");

                    b.HasOne("BibliotekaOOAD.Models.Osoba", "Primaoc")
                        .WithMany()
                        .HasForeignKey("PrimaocId");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.ObicniKorisnikDb", b =>
                {
                    b.HasOne("BibliotekaOOAD.Models.Racun", "Racun")
                        .WithMany()
                        .HasForeignKey("RacunId");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.Recenzija", b =>
                {
                    b.HasOne("BibliotekaOOAD.Models.Knjiga", "Knjiga")
                        .WithMany("Recenzije")
                        .HasForeignKey("KnjigaId");

                    b.HasOne("BibliotekaOOAD.Models.ObicniKorisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.Zanr", b =>
                {
                    b.HasOne("BibliotekaOOAD.Models.Knjiga", null)
                        .WithMany("Zanrovi")
                        .HasForeignKey("KnjigaId");
                });

            modelBuilder.Entity("BibliotekaOOAD.Models.ObicniKorisnik", b =>
                {
                    b.HasOne("BibliotekaOOAD.Models.Racun", "Racun")
                        .WithMany()
                        .HasForeignKey("RacunId");
                });
#pragma warning restore 612, 618
        }
    }
}
