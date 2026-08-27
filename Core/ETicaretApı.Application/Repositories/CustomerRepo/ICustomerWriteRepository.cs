using ETicaretApı.Application.Repositories;
using ETicaretApı.Domain.Entities;

namespace ETicaretApı.Application.CustomerRepo;

public interface ICustomerWriteRepository : IWriteRepository<Customer>
{
}