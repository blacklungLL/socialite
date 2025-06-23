namespace SocialNetwork.Application.Interfaces.Services;

public interface IAuthService
{
    Task<bool> RegisterAsync(string firstName, string lastName, string email, string password);
    
    Task<bool> LoginAsync(string email, string password);
}