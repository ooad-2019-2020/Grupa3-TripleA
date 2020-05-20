using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class Kontekst : IFiltriranje
    {
        IFiltriranje filter;
        public List<Knjiga> filtrirajPoZanru(List<Knjiga> knjige, Zanr zanr)
        {
            return null;
        }
    }
}
