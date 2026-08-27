using MediatR;

namespace ETicaretApı.Application.Cqrs.Commands.Baskets.RemoveBasketItem;

public class RemoveBasketItemCommandRequest : IRequest<RemoveBasketItemCommandResponse>
{
    public string BasketItemId { get; set; }
}