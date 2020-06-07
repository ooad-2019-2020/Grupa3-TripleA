using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class VipKorisnik : ObicniKorisnik
    {
        ICollection<IKnjiga> zatrazeneKnjigeZaDodavanje;
        decimal ostvareniPopust;
        [Range(minimum: 0, maximum: 100, ErrorMessage = "Popust moze biti od 0 do 100%!")]
        public decimal OstvareniPopust { get => ostvareniPopust; set => ostvareniPopust = value; }
        internal ICollection<IKnjiga> ZatrazeneKnjigeZaDodavanje { get => zatrazeneKnjigeZaDodavanje; set => zatrazeneKnjigeZaDodavanje = value; }
    }
}
