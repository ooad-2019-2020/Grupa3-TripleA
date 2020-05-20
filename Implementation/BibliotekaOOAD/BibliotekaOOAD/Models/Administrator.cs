using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class Administrator : Osoba
    {
        int brojLoginova;

        public int BrojLoginova { get => brojLoginova; set => brojLoginova = value; }
    }
}
