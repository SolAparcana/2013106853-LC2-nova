﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013106853_ENT.Entities
{
    class Bus
    {
        public int BusId { get; set; }
        public TipoBus TipoBus { get; set; }

        public ICollection<Carro> Carro { get; set; }

        public Bus()
        {
            Carro = new List<Carro>();
        }
    }
}
