using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.MVC.Controllers;

public class MarketController : Controller
{
    public MarketController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
}