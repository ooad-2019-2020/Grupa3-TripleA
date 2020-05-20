using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class VipKorisnik : ObicniKorisnik
    {
        List<IKnjiga> zatrazeneKnjigeZaDodavanje = new List<IKnjiga>();
        decimal ostvareniPopust;

        public decimal OstvareniPopust { get => ostvareniPopust; set => ostvareniPopust = value; }
        internal List<IKnjiga> ZatrazeneKnjigeZaDodavanje { get => zatrazeneKnjigeZaDodavanje; set => zatrazeneKnjigeZaDodavanje = value; }
    }
}
