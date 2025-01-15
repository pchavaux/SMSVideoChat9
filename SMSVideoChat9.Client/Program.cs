using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SMSVideoChat9.Client.WebRtc;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddAuthenticationStateDeserialization();
builder.Services.AddScoped<WebRtcService>();
await builder.Build().RunAsync();
