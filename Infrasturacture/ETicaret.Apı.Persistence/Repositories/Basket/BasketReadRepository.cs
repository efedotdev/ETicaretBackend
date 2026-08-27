using ETicaret.Apı.Persistence.Concretes;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.Repositories.Basket;

namespace ETicaret.Apı.Persistence.Repositories.Basket;

public class BasketReadRepository : ReadRepository<ETicaretApı.Domain.Entities.Basket>, IBasketReadRepository
{
    public BasketReadRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}