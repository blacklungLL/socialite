using MediatR;
using Microsoft.AspNetCore.Identity;

namespace SocialNetwork.Application.Features.Auth.Queries;

public class GetUserInfoQueryHandler(UserManager<IdentityUser> userManager)
    : IRequestHandler<GetUserInfoQuery, GetUserInfoDto>
{
    public async Task<GetUserInfoDto> Handle(GetUserInfoQuery request, CancellationToken cancellationToken)
    {
        var user = await userManager.FindByIdAsync(request.UserId);
        if (user == null)
        {
            throw new KeyNotFoundException("Пользователь не найден.");
        }

        var userInfo = new GetUserInfoDto
        {
            UserName = user.UserName,
            Email = user.Email,
            // FirstName = user.FirstName,
            // LastName = user.LastName 
        };

        return userInfo;
    }
}