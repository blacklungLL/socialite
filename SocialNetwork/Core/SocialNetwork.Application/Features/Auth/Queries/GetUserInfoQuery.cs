using MediatR;

namespace SocialNetwork.Application.Features.Auth.Queries;

public class GetUserInfoQuery : IRequest<GetUserInfoDto>
{
    public string UserId { get; set; }
}