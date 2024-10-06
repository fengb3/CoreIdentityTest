using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CoreIdentityTest2;
using Microsoft.AspNetCore.Components.Authorization;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5246") });
builder.Services.AddApiAuthorization();

builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
//builder.Services.AddScoped<ILocalStorageService, LocalStorageService>();
builder.Services.AddBlazoredLocalStorage();


//builder.Services.AddOidcAuthentication(options =>
//{
//    // Configure your authentication provider options here.
//    // For more information, see https://aka.ms/blazor-standalone-auth
//    builder.Configuration.Bind("Local", options.ProviderOptions);

//    options.ProviderOptions.Authority = "http://localhost:5246";
//    options.ProviderOptions.ClientId = "CoreIdentityTest2";
//    options.ProviderOptions.ResponseType = "code";
//});

await builder.Build().RunAsync();
