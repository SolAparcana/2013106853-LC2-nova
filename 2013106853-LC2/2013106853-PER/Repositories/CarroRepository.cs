using _2013106853_ENT;
using _2013106853_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013106853_PER.Repositories
{
    public class CarroRepository : Repository<Carro>, ICarroRepository
    {
        private readonly EnsambladoraDbContext _Context;

        public CarroRepository(EnsambladoraDbContext context)
        {
            _Context = context;
        }

        private CarroRepository()
        {

        }
    }
}
