using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class Knjiga : IKnjiga
    {
        int id;
        string naslov, autor, opis;
        decimal rating;
        List<Zanr> zanrovi = new List<Zanr>();
        ObicniKorisnik korisnikKojiJePosudio;
        List<Recenzija> recenzije = new List<Recenzija>();

        public int Id { get => id; set => id = value; }
        public string Naslov { get => naslov; set => naslov = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Opis { get => opis; set => opis = value; }
        public decimal Rating { get => rating; set => rating = value; }
        public List<Zanr> Zanrovi { get => zanrovi; set => zanrovi = value; }
        public ObicniKorisnik KorisnikKojiJePosudio { get => korisnikKojiJePosudio; set => korisnikKojiJePosudio = value; }
        public List<Recenzija> Recenzije { get => recenzije; set => recenzije = value; }

        public Knjiga dajKnjigu()
        {
            return null;
        }
    }
}
