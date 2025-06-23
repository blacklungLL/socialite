using MediatR;

namespace SocialNetwork.Application.Features.Auth.Register;

public class RegisterCommand : IRequest<bool>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; init; }
    public string Password { get; init; }
}