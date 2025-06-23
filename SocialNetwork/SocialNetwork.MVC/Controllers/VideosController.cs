using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.MVC.Controllers;

public class VideosController : Controller
{
    public VideosController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
}