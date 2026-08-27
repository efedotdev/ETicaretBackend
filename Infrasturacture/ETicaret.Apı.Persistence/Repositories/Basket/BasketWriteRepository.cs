using ETicaret.Apı.Persistence.Concretes;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.Repositories.Basket;

namespace ETicaret.Apı.Persistence.Repositories.Basket;

public class BasketWriteRepository : WriteRepository<ETicaretApı.Domain.Entities.Basket>, IBasketWriteRepository
{
    public BasketWriteRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}