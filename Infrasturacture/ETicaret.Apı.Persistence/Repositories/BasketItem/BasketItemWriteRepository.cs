using ETicaret.Apı.Persistence.Concretes;
using ETicaret.Apı.Persistence.Contexts;
using ETicaret.Apı.Persistence.Repositories.Basket;
using ETicaretApı.Application.Repositories.BasketItem;

namespace ETicaret.Apı.Persistence.Repositories.BasketItem;

public class BasketItemWriteRepository : WriteRepository<ETicaretApı.Domain.Entities.BasketItem>,
    IBasketItemWriteRepository
{
    public BasketItemWriteRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}