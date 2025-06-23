using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.MVC.Controllers;

public class RegistrationController: Controller
{
    public RegistrationController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
}