using Falcons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Functions
{
    public class FnB_CRUD
    {
        private readonly FalconsDBContext _context;

        public FnB_CRUD(FalconsDBContext context)
        {
            _context = context;
        }
    }
}
