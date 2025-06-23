using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application.Features.Auth.Login;
using SocialNetwork.Application.Features.Auth.Register;
using SocialNetwork.MVC.Models.Auth;

namespace SocialNetwork.MVC.Controllers;

public class AuthController : Controller
{
    private readonly IMediator _mediator;

    public AuthController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public ActionResult Login()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }    
    
    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        var command = new RegisterCommand
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Email = model.Email,
            Password = model.Password
        };
        var IsSuccess = await _mediator.Send(command);
        
        if (IsSuccess)
            return RedirectToAction("Index", "Home");
    
        //ModelState.AddModelError(string.Empty, IsSuccess.Error);
        return RedirectToAction("Index", "Registration");
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
    {
        var command = new LoginCommand
        {
            Email = model.Email,
            Password = model.Password,
        };
        
        var IsSuccess = await _mediator.Send(command);

        if (IsSuccess)
        {
            returnUrl ??= Url.Content("~/"); // Если returnUrl не указан, перенаправляем на главную страницу
            return LocalRedirect(returnUrl);
        }

        ModelState.AddModelError(string.Empty, "Неверный логин или пароль.");
        return View(model);
    }
}