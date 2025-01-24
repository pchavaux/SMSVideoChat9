using SharedLibrary.Models;
using SMSVideoChat9.Client.Services;
using System.Net.Http.Json;

public class FriendService : IFriendService
{
    private readonly HttpClient _httpClient;

    public FriendService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<Friend>> GetFriendsAsync()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<Friend>>("api/Friends");
    }

    public async Task<Friend> GetFriendAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<Friend>($"api/Friends/{id}");
    }

    public async Task CreateFriendAsync(Friend friend)
    {
        await _httpClient.PostAsJsonAsync("api/Friends", friend);
    }

    public async Task UpdateFriendAsync(int id, Friend friend)
    {
        await _httpClient.PutAsJsonAsync($"api/Friends/{id}", friend);
    }

    public async Task DeleteFriendAsync(int id)
    {
        await _httpClient.DeleteAsync($"api/Friends/{id}");
    }
}