using MediatR;

namespace ETicaretApı.Application.Cqrs.Commands.Order.CompleteOrder;

public class CompleteOrderCommandRequest : IRequest<CompleteOrderCommandResponse>
{
    public string Id { get; set; }
}