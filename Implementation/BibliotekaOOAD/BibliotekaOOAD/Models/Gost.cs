﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class Gost
    {
        int id;

        int brojPosjete;

        public int BrojPosjete { get => brojPosjete; set => brojPosjete = value; }
        public int Id { get => id; set => id = value; }
    }
}
