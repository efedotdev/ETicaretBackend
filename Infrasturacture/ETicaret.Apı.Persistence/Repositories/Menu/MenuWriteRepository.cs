using ETicaretApı.Application.Repositories;
using ETicaretApı.Domain.Entities;
using ETicaret.Apı.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Apı.Persistence.Concretes;

namespace ETicaretApı.Persistence.Repositories
{
    public class MenuWriteRepository : WriteRepository<Menu>, IMenuWriteRepository
    {
        public MenuWriteRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
