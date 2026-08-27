using ETicaretApı.Domain.Entities.Common;
using ETicaretApı.Domain.Entities.Identity;

namespace ETicaretApı.Domain.Entities;

public class BasketItem : BaseEntity
{
    public Guid BasketId { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public Basket Basket { get; set; }
    public Product Product { get; set; }
}