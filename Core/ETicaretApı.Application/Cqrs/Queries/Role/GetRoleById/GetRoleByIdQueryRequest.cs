using MediatR;

namespace ETicaretApı.Application.Cqrs.Queries.Role.GetRoleById;

public class GetRoleByIdQueryRequest : IRequest<GetRoleByIdQueryResponse>
{
    public string Id { get; set; }
}