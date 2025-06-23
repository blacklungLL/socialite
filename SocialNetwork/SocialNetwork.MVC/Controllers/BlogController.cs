using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.MVC.Controllers;

public class BlogController : Controller
{
    public BlogController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
}