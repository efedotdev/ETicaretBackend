using ETicaretApı.Application.Repositories;
using ETicaretApı.Domain.Entities;

namespace ETicaretApı.Application.OrderRepo;

public interface IOrderWriteRepository : IWriteRepository<Order>
{
}