﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BibliotekaOOAD.Models
{

        public class ObicniKorisnik : Osoba, IPratilac, IKnjiga, IPlacanjeDodatak
        {
            string korisnickoIme;
            Racun racun = new Racun();
            IKnjiga trenutnoIznajmljenjaKnjiga;
            DateTime datumRodjenja;
            ICollection<Obavjestenje> obavjestenja;
            ICollection<IKnjiga> procitaneKnjige;
            DateTime krajVazenjaClanarine;
        [RegularExpression("^[A-Za-z0-9_-]*$", ErrorMessage = "Korisnicko ime smije sadrzavati samo slova i cifre!")]
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public Racun Racun { get => racun; set => racun = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public DateTime KrajVazenjaClanarine { get => krajVazenjaClanarine; set => krajVazenjaClanarine = value; }
        public ICollection<Obavjestenje> Obavjestenja { get => obavjestenja; set => obavjestenja = value; }
        internal IKnjiga TrenutnoIznajmljenjaKnjiga { get => trenutnoIznajmljenjaKnjiga; set => trenutnoIznajmljenjaKnjiga = value; }
        internal ICollection<IKnjiga> ProcitaneKnjige1 { get => procitaneKnjige; set => procitaneKnjige = value; }

        public decimal dajDodatak()
        {
            return 0;
        }

        public Knjiga dajKnjigu()
        {
            return null;
        }

        public void update()
        {
            return;
        }
    }
}