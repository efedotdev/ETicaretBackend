using ETicaret.Apı.Persistence.Concretes;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.Repositories.BasketItem;

namespace ETicaret.Apı.Persistence.Repositories.BasketItem;

public class BasketItemReadRepository : ReadRepository<ETicaretApı.Domain.Entities.BasketItem>,
    IBasketItemReadRepository
{
    public BasketItemReadRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}