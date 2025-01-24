using SharedLibrary.Models;

namespace SMSVideoChat9.Client.Services
{
    public interface IFriendService
    {
        Task<IEnumerable<Friend>> GetFriendsAsync();
        Task<Friend> GetFriendAsync(int id);
        Task CreateFriendAsync(Friend friend);
        Task UpdateFriendAsync(int id, Friend friend);
        Task DeleteFriendAsync(int id);
    }
}
