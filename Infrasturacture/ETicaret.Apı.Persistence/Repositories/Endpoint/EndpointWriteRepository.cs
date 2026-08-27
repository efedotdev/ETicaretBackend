using ETicaretApı.Application.Repositories;
using ETicaretApı.Domain.Entities;
using ETicaret.Apı.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Apı.Persistence.Concretes;
using ETicaretApı.Application.Repositories.Endpoint;

namespace ETicaretApı.Persistence.Repositories
{
    public class EndpointWriteRepository : WriteRepository<Endpoint>, IEndpointWriteRepository
    {
        public EndpointWriteRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
