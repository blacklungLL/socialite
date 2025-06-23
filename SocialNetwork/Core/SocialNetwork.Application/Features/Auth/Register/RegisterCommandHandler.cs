using MediatR;
using SocialNetwork.Application.Interfaces.Services;

namespace SocialNetwork.Application.Features.Auth.Register;

public class RegisterCommandHandler(IAuthService _authService) : IRequestHandler<RegisterCommand, bool>
{
    public async Task<bool> Handle(RegisterCommand command, CancellationToken cancellationToken) 
        => await _authService.RegisterAsync(command.FirstName, command.LastName, command.Email, command.Password);
}