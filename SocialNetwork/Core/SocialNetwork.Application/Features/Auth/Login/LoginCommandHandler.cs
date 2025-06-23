using MediatR;
using SocialNetwork.Application.Interfaces.Services;

namespace SocialNetwork.Application.Features.Auth.Login;

public class LoginCommandHandler(IAuthService _authService) : IRequestHandler<LoginCommand, bool>
{
    public async Task<bool> Handle(LoginCommand command, CancellationToken cancellationToken) 
        => await _authService.LoginAsync(command.Email, command.Password);
}