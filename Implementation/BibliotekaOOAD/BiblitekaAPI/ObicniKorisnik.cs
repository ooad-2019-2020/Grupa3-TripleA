using System;
using System.Collections.Generic;

namespace BiblitekaAPI
{
    public partial class ObicniKorisnik
    {
        public ObicniKorisnik()
        {
            Obavjestenje = new HashSet<Obavjestenje>();
        }

        public int Id { get; set; }
        public string KorisnickoIme { get; set; }
        public int? RacunId { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime KrajVazenjaClanarine { get; set; }

        public virtual Racun Racun { get; set; }
        public virtual ICollection<Obavjestenje> Obavjestenje { get; set; }
    }
}
