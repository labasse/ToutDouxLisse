using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ToutDouxLisse;
using ToutDouxMetier;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddSingleton<IDataContext, DataContextImpl>();
builder.Services.AddSingleton<IDataContext>(sp => {
    var data = new DataContextImpl();
    data.InitDummy();
    return data;
});


await builder.Build().RunAsync();
