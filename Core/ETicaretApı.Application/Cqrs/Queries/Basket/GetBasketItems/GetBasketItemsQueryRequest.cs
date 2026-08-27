using MediatR;

namespace ETicaretApı.Application.Cqrs.Queries.Basket.GetBasketItems;

public class GetBasketItemsQueryRequest : IRequest<List<GetBasketItemsQueryResponse>>
{
}