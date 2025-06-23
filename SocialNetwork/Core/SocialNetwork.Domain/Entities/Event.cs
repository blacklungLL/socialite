using SocialNetwork.Domain.Common;

namespace SocialNetwork.Domain.Entities;

public class Event : BaseAuditableEntity
{
    public string EventName { get; set; }
    public string Image { get; set; }
    public string Author { get; set; }
    public string EventDate { get; set; }
    public int InterestedCnt { get; set; }
    public int GoingCnt { get; set; }
}