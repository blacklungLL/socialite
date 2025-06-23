using SocialNetwork.Application.Features.Events.Queries.GetByEventId;

namespace SocialNetwork.MVC.Models.Event_2;

public class Event2VM
{
    public IEnumerable<GetByEventIdDto> Feeds { get; set; }
}