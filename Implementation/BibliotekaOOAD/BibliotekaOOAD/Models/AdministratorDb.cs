using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class AdministratorDb
    {
        int id;
        int brojLoginova;

        public int BrojLoginova { get => brojLoginova; set => brojLoginova = value; }
        public int Id { get => id; set => id = value; }
    }
}

