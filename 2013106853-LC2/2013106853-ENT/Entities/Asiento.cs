﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013106853_ENT
{
    public class Asiento

    {
        public int AsientoId { get; set; }
        public string NumSerie { get; set; }
        public Cinturon Cinturon { get; set; }

        public ICollection<Carro> Carro { get; set; }

        public Asiento()
        {
            Carro = new List<Carro>();

        }
    }

    public class Carro
    {
    }

    public class Cinturon
    {
    }
}
