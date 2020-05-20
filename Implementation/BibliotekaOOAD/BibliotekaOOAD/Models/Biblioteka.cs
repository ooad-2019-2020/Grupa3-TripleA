using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class Biblioteka : IPratilac, IKorisnik
    {
        Gost gost;
        List<Osoba> clanovi = new List<Osoba>();
        List<Knjiga> knjige = new List<Knjiga>();
        Administrator administrator;
        string info;
        IKorisnik factory;
        List<IPratilac> pratioci = new List<IPratilac>();

        public Osoba dajKorisnika()
        {
            return null;
        }

        public void update()
        {
            return;
        }
    }
}
