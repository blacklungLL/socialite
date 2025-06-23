namespace SocialNetwork.Application.Features.Auth.Queries;

public class GetUserInfoDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
}