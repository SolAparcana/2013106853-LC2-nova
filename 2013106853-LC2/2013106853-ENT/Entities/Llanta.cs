﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013106853_ENT.Entities
{
    class Llanta
    {
        public int LlantaId { get; set; }
        public string NumSerie { get; set; }

        public ICollection<Carro> Carro { get; set; }

        public Llanta()
        {
            Carro = new List<Carro>();
        }
    }
}
