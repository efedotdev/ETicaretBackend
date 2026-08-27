using ETicaretApı.Domain.Entities.Common;

namespace ETicaretApı.Domain.Entities;

public class CompletedOrder : BaseEntity
{
    public Guid OrderId { get; set; }

    public Order Order { get; set; }
}