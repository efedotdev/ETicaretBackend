using ETicaret.Apı.Persistence.Concretes;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.Repositories.CompletedOrder;

namespace ETicaret.Apı.Persistence.Repositories.CompletedOrder;

public class CompletedOrderWriteRepository : WriteRepository<ETicaretApı.Domain.Entities.CompletedOrder>, ICompletedOrderWriteRepository
{
    public CompletedOrderWriteRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}