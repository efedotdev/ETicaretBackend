namespace ETicaretApı.Application.Cqrs.Queries.GetAllOrders;

public class GetAllOrdersQueryResponse
{
    public int TotalOrderCount { get; set; }
    public object Orders { get; set; }
}