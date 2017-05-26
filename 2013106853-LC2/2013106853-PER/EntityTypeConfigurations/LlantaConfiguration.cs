using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013106853_PER.EntityTypeConfigurations
{
    class LlantaConfiguration
    {
        public LlantaConfiguration()
        {
            Property(v => v.LlantaId)
                .IsRequired();

        }
    }
}
