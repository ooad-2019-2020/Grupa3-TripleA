using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    interface IFiltriranje
    {
        public List<Knjiga> filtrirajPoZanru(List<Knjiga> knjige, Zanr zanr);
    }
}
