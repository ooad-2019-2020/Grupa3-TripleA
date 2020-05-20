using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class Zanr
    {
        int id;
        string tip, vrsta;

        public int Id { get => id; set => id = value; }
        public string Tip { get => tip; set => tip = value; }
        public string Vrsta { get => vrsta; set => vrsta = value; }
    }
}
