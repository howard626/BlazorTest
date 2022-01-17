using Blazored.LocalStorage;
using BlazorTest.Auth;
using BlazorTest.Service;
using BlazorTest.Stores;
using BlazorTest.Stores.CounterStore;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTest
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<CounterStore>();
            builder.Services.AddScoped<IActionDispatcher, ActionDispatcher>();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddScoped<AuthenticationStateProvider, TestAuthStateProvider>();

            builder.Services.AddScoped<IAuthService, AuthService>();
            //builder.Services.AddOidcAuthentication(options =>
            //{
            //    builder.Configuration.Bind("Local", options.ProviderOptions);
            //});

            await builder.Build().RunAsync();
        }
    }
}
