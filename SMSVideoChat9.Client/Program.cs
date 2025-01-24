using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http;
using SMSVideoChat9.Client.WebRtc;
using SMSVideoChat9.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
 
builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddAuthenticationStateDeserialization();
builder.Services.AddScoped<WebRtcService>();

builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IFriendService, FriendService>();
// Register HttpClient with a base address (replace with your server's URL)
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) // Or API base URL
}); 

await builder.Build().RunAsync();
