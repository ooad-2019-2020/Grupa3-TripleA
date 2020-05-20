﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaOOAD.Models
{
    public class Racun
    {
        int id;
        int brojRacuna;
        decimal stanje;

        public int BrojRacuna { get => brojRacuna; set => brojRacuna = value; }
        public decimal Stanje { get => stanje; set => stanje = value; }
        public int Id { get => id; set => id = value; }
    }
}
