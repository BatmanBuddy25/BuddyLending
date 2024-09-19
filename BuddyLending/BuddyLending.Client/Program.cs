using BuddyLending.Client.Services.MemberServices;
using BuddyLendingShared.Interfaces.IManpower;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(http => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});

builder.Services.AddScoped<IMemberService, MemberService>();

await builder.Build().RunAsync();
