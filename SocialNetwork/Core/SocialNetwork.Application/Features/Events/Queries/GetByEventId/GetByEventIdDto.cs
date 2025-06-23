namespace SocialNetwork.Application.Features.Events.Queries.GetByEventId;

public class GetByEventIdDto
{
    public int Id { get; set; }
    
    /// <summary>
    /// Название мероприятия
    /// </summary>
    public string EventName { get; set; }
    
    /// <summary>
    /// Фотография с мероприятия
    /// </summary>
    public string Image { get; set; }
    
    /// <summary>
    /// Организатор
    /// </summary>
    public string Author { get; set; }
    
    /// <summary>
    /// Дата проведения
    /// </summary>
    public string EventDate { get; set; }
    
    /// <summary>
    /// Количество заинтересованных людей
    /// </summary>
    public int InterestedCnt { get; set; }
    
    /// <summary>
    /// Количество людей, которые идут на мероприятие
    /// </summary>
    public int GoingCnt { get; set; }
}