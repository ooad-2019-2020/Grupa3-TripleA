using System;
using System.Collections.Generic;

namespace BiblitekaAPI
{
    public partial class Biblioteka
    {
        public int? GostId { get; set; }
        public int? AdministratorId { get; set; }
        public string Info { get; set; }

        public virtual Osoba Administrator { get; set; }
        public virtual Gost Gost { get; set; }
    }
}
