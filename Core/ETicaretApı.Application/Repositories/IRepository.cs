using Microsoft.EntityFrameworkCore;
using ETicaretApı.Domain.Entities.Common;

namespace ETicaretApı.Application.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    DbSet<T> Table { get; }
}