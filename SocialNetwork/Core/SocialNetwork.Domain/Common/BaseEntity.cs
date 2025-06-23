using System.ComponentModel.DataAnnotations.Schema;
using SocialNetwork.Domain.Common.Interfaces;

namespace SocialNetwork.Domain.Common;

public abstract class BaseEntity : IEntity
{
    /// <summary>
    /// Уникальный индентификатор поста на странице пользователя
    /// </summary>
    public int Id { get; set; }
}