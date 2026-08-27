using MediatR;

namespace ETicaretApı.Application.Cqrs.Queries.Order.GetOrderById;

public class GetOrderByIdQueryRequest : IRequest<GetOrderByIdQueryResponse>
{
    public string Id { get; set; }
}