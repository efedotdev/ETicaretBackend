using MediatR;

namespace ETicaretApı.Application.Cqrs.Queries.AppUser.GetRolesToUser;

public class GetRolesToUserQueryRequest : IRequest<GetRolesToUserQueryResponse>
{
    public string UserId { get; set; }
}