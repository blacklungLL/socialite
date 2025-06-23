using Microsoft.AspNetCore.Identity;
using SocialNetwork.Application.Interfaces.Services;

namespace SocialNetwork.Infrastructure.Services;

public class AuthService : IAuthService
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly IEmailSender _emailSender;
 
    public AuthService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IEmailSender emailSender)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _emailSender = emailSender;
    }
 
    public async Task<bool> RegisterAsync(string firstName, string lastName,string email, string password)
    {
        var user = new IdentityUser { Email = email, UserName = email };
        var result = await _userManager.CreateAsync(user, password);

        if (!result.Succeeded)
            return false;
 
        await _signInManager.SignInAsync(user, isPersistent: false);
        
        // Отправка письма
        await _emailSender.SendAsync(email, "Регистрация", $"Ваш логин: {email}\nВаш пароль: {password}");
        
        return true;
    }
 
    public async Task<bool> LoginAsync(string email, string password)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null)
            return false;
        
        await _signInManager.PasswordSignInAsync(user, password, false, false);
        
        return true;
    }
}