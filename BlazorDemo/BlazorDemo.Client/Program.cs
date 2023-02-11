using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorDemo.Client;
using BlazorDemo.Client.Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<ContactsClient>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7140");
});

await builder.Build().RunAsync();