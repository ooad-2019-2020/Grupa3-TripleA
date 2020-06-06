using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class Knjiga : IKnjiga
    {
        int id;
        string naslov, autor, opis;
        decimal rating;
        ICollection<Zanr> zanrovi;
        ObicniKorisnik korisnikKojiJePosudio;
        ICollection<Recenzija> recenzije;

        public int Id { get => id; set => id = value; }
        [Required(ErrorMessage = "Polje je obavezno")]
        public string Naslov { get => naslov; set => naslov = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Opis { get => opis; set => opis = value; }
        [Range(minimum: 0, maximum: 5, ErrorMessage = "Rating mora biti u intervalu od 0 do 5!")]
        public decimal Rating { get => rating; set => rating = value; }
        
        public ObicniKorisnik KorisnikKojiJePosudio { get => korisnikKojiJePosudio; set => korisnikKojiJePosudio = value; }
        
        public ICollection<Zanr> Zanrovi { get => zanrovi; set => zanrovi = value; }
        public ICollection<Recenzija> Recenzije { get => recenzije; set => recenzije = value; }

        public Knjiga dajKnjigu()
        {
            return null;
        }
    }
}
