using ETicaret.Apı.Persistence.Concretes;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.OrderRepo;
using ETicaretApı.Domain.Entities;

namespace ETicaret.Apı.Persistence;

public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
{
    public OrderWriteRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}