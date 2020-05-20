﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class VipKorisnik : ObicniKorisnik
    {
        ICollection<IKnjiga> zatrazeneKnjigeZaDodavanje;
        decimal ostvareniPopust;

        public decimal OstvareniPopust { get => ostvareniPopust; set => ostvareniPopust = value; }
        internal ICollection<IKnjiga> ZatrazeneKnjigeZaDodavanje { get => zatrazeneKnjigeZaDodavanje; set => zatrazeneKnjigeZaDodavanje = value; }
    }
}
