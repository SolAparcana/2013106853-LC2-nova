using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013106853_ENT.Entities
{
    class Automovil
    {
        public int AutomovilId { get; set; }
        public TipoAuto TipoAuto { get; set; }

        public ICollection<Carro> Carro { get; set; }

        public Automovil()
        {
            Carro = new List<Carro>();
        }
    }
}
