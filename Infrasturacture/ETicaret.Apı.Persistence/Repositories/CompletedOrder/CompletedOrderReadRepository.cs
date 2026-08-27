using ETicaret.Apı.Persistence.Concretes;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.Repositories.CompletedOrder;

namespace ETicaret.Apı.Persistence.Repositories.CompletedOrder;

public class CompletedOrderReadRepository : ReadRepository<ETicaretApı.Domain.Entities.CompletedOrder>, ICompletedOrderReadRepository
{
    public CompletedOrderReadRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}