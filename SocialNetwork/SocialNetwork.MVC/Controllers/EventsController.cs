using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.MVC.Controllers;

public class EventsController : Controller
{
    public EventsController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
}