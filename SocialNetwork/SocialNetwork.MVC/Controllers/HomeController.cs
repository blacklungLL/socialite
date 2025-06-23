using System.Diagnostics;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application.Features.Comments.Queries.GetByPostId;
using SocialNetwork.Application.Features.Posts.Queries.GetByUserPageId;
using SocialNetwork.MVC.Models;
using SocialNetwork.MVC.Models.Home;

namespace SocialNetwork.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userPageId = 0; 
            var query = new GetByUserPageIdQuery(userPageId);
            var posts = await _mediator.Send(query);
            var commentsByPostId = new Dictionary<int, IEnumerable<GetByPostIdDto>>();

            foreach (var post in posts)
            {
                var commentQuery = new GetByPostIdQuery(post.Id);
                var comments = await _mediator.Send(commentQuery);
                commentsByPostId[post.Id] = comments;
            }

            var viewModel = new HomeVM
            {
                Feeds = posts,
                CommentsByPostId = commentsByPostId
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}