using System;
using System.Collections.Generic;

namespace BiblitekaAPI
{
    public partial class Bibliotekar
    {
        public Bibliotekar()
        {
            Knjiga = new HashSet<Knjiga>();
        }

        public int Id { get; set; }

        public virtual ICollection<Knjiga> Knjiga { get; set; }
    }
}
