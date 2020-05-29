using System;
using System.Collections.Generic;

namespace BiblitekaAPI
{
    public partial class Osoba
    {
        public Osoba()
        {
            Knjiga = new HashSet<Knjiga>();
            ObavjestenjeObicniKorisnik = new HashSet<Obavjestenje>();
            ObavjestenjePosiljaoc = new HashSet<Obavjestenje>();
            ObavjestenjePrimaoc = new HashSet<Obavjestenje>();
            Recenzija = new HashSet<Recenzija>();
        }

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public string Discriminator { get; set; }
        public int? BrojLoginova { get; set; }
        public string KorisnickoIme { get; set; }
        public int? RacunId { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public DateTime? KrajVazenjaClanarine { get; set; }

        public virtual Racun Racun { get; set; }
        public virtual ICollection<Knjiga> Knjiga { get; set; }
        public virtual ICollection<Obavjestenje> ObavjestenjeObicniKorisnik { get; set; }
        public virtual ICollection<Obavjestenje> ObavjestenjePosiljaoc { get; set; }
        public virtual ICollection<Obavjestenje> ObavjestenjePrimaoc { get; set; }
        public virtual ICollection<Recenzija> Recenzija { get; set; }
    }
}
