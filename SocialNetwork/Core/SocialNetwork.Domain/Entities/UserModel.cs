using SocialNetwork.Domain.Common;

namespace SocialNetwork.Domain.Entities;

public class UserModel : BaseAuditableEntity
{
    // Personal Info
    public string Username { get; set; }
    public string Email { get; set; }
    public string Bio { get; set; }
    public string Gender { get; set; }
    public string RelationshipStatus { get; set; }

    // Social Links
    public string Facebook { get; set; }
    public string Instagram { get; set; }
    public string Twitter { get; set; }
    public string YouTube { get; set; }
    public string GitHub { get; set; }

    // Notifications
    public bool NotifyOnMessage { get; set; }
    public bool NotifyOnLike { get; set; }
    public bool NotifyOnShare { get; set; }
    public bool NotifyOnFollow { get; set; }
    public bool NotifyOnPostLike { get; set; }
    public bool NotifyOnMention { get; set; }
    public bool NotifyOnFollowRequest { get; set; }

    // Privacy
    public string WhoCanFollow { get; set; }
    public string WhoCanMessage { get; set; }
    public bool ShowActivities { get; set; }
    public string StatusVisibility { get; set; }

    // Password
    public string CurrentPassword { get; set; }
    public string NewPassword { get; set; }
    public string ConfirmPassword { get; set; }
    public bool TwoFactorAuthentication { get; set; }
}