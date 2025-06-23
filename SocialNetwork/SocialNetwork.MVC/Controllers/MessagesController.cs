using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.MVC.Controllers;

public class MessagesController : Controller
{
    public MessagesController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
}