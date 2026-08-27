using ETicaret.Apı.Persistence.Concretes;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.OrderRepo;
using ETicaretApı.Domain.Entities;

namespace ETicaret.Apı.Persistence;

public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
{
    public OrderReadRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}