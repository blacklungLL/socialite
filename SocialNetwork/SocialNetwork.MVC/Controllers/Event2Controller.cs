using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application.Features.Events.Queries.GetByEventId;
using SocialNetwork.MVC.Models.Event_2;

namespace SocialNetwork.MVC.Controllers
{
    public class Event2Controller : Controller
    {
        private readonly IMediator _mediator;

        public Event2Controller(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var eventId = 0;
            var query = new GetByEventIdQuery(eventId);
            var events = await _mediator.Send(query);
            
            var viewModel = new Event2VM
            {
                Feeds = events,
            };

            return View(viewModel);
        }
    }
}