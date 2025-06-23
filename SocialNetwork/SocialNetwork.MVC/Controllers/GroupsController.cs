using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.MVC.Controllers;

public class GroupsController : Controller
{
    public GroupsController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
}