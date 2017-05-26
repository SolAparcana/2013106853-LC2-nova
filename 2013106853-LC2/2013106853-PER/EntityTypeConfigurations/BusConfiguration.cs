using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013106853_PER.EntityTypeConfigurations
{
    public class BusConfiguration : EntityTypeConfiguration<Bus>
    {

        public BusConfiguration()
        {
            Property(v => v.BusId)
                .IsRequired();

        }
    }
}
