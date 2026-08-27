using ETicaretApı.Domain.Entities.Common;

namespace ETicaretApı.Application.Repositories;

public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
{
    Task<bool> AddAsync(T model);
    Task<bool> AddRangeAsync(IEnumerable<T> datas);
    bool Remove(T model);
    bool RemoveRange(IEnumerable<T> datas);
    Task<bool> RemoveAsync(string id);
    bool Update(T model);
    Task<int> SaveChangesAsync();
}