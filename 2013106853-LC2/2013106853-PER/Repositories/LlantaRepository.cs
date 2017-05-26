﻿using _2013106853_ENT;
using _2013106853_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2013106853_PER.Repositories
{
    public class LlantaRepository : Repository<Llanta>, ILlantaRepository
    {
        private readonly EnsambladoraDbContext _Context;

        public LlantaRepository(EnsambladoraDbContext context)
        {
            _Context = context;
        }

        private LlantaRepository()
        {

        }
    }
}