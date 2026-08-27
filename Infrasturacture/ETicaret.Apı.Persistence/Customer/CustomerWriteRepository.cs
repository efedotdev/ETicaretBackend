using ETicaret.Apı.Persistence.Concretes;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.CustomerRepo;
using ETicaretApı.Domain.Entities;

namespace ETicaret.Apı.Persistence;

public class CustomerWriteRepository : WriteRepository<Customer>,ICustomerWriteRepository
{
    public CustomerWriteRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}