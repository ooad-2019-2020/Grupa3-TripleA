using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class VipKorisnikDb
    {
        int id;
        ICollection<IKnjiga> zatrazeneKnjigeZaDodavanje;
        decimal ostvareniPopust;

        public decimal OstvareniPopust { get => ostvareniPopust; set => ostvareniPopust = value; }
        public int Id { get => id; set => id = value; }
        internal ICollection<IKnjiga> ZatrazeneKnjigeZaDodavanje { get => zatrazeneKnjigeZaDodavanje; set => zatrazeneKnjigeZaDodavanje = value; }
    }
}
