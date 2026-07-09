using BlazorClientDemoApp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient 
{
    //BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) 
    BaseAddress = new Uri("https://localhost:5009")
});

await builder.Build().RunAsync();
