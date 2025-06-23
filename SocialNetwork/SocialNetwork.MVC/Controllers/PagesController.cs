using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.MVC.Controllers;

public class PagesController : Controller
{
    public PagesController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
}