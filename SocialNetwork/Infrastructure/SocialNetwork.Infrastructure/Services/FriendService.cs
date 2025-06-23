using Microsoft.EntityFrameworkCore;
using SocialNetwork.Application.Interfaces.Services;
using SocialNetwork.Domain.Entities;
using SocialNetwork.Persistence.Contexts;

namespace SocialNetwork.Infrastructure.Services;

public class FriendService(ApplicationDbContext context) : IFriendService
{
    public async Task<bool> AddFriend(int userId, int friendId)
    {
        var user = await context.Users.FirstOrDefaultAsync(x => x.Id == userId);
        var friend = await context.Users.FirstOrDefaultAsync(x => x.Id == friendId);

        if (user == null || friend == null)
        {
            throw new Exception("User not found");
        }
        
        using var transaction = await context.Database.BeginTransactionAsync();
        
        var friendship = new Friend() {User1 = user, User2 = friend};
        await context.AddAsync(friendship);
        
        // user.Friends.Add(friendship);
        // friend.Friends.Add(friendship);
        
        var rows = await context.SaveChangesAsync();
        await transaction.CommitAsync();

        return rows > 0;


    }
}