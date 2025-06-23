using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.MVC.Controllers;

public class LoginController: Controller
{
    public LoginController()
    {
        
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}