using System;
using System.Collections.Generic;

namespace BiblitekaAPI
{
    public partial class Zanr
    {
        public int Id { get; set; }
        public string Tip { get; set; }
        public string Vrsta { get; set; }
        public int? KnjigaId { get; set; }

        public virtual Knjiga Knjiga { get; set; }
    }
}
