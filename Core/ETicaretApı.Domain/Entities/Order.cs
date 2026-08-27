using ETicaretApı.Domain.Entities.Common;

namespace ETicaretApı.Domain.Entities;

public class Order : BaseEntity
{
    // public Guid CustomerId { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public string OrderCode { get; set; }

    // ICollection<Product> Products { get; set; }
    public Basket Basket { get; set; }
    public CompletedOrder CompletedOrder { get; set; }

}