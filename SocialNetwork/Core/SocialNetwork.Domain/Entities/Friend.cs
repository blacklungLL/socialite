using SocialNetwork.Domain.Common;

namespace SocialNetwork.Domain.Entities;

public class Friend : BaseAuditableEntity
{
    public UserModel User1 { get; set; }
    public UserModel User2 { get; set; }
}