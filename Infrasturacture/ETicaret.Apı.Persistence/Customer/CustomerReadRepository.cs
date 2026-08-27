using ETicaret.Apı.Persistence.Concretes;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.CustomerRepo;
using ETicaretApı.Domain.Entities;

namespace ETicaret.Apı.Persistence;

public class CustomerReadRepository : ReadRepository<Customer>,ICustomerReadRepository
{
    public CustomerReadRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}