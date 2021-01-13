using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Radzen;
using DogKeepers.Client.Helpers;
using DogKeepers.Client.Options;
using DogKeepers.Client.Providers;
using Microsoft.AspNetCore.Components.Authorization;
using DogKeepers.Client.Interfaces;

namespace DogKeepers.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            ConfigureServices(builder.Services, builder.Configuration);

            await builder.Build().RunAsync();
        }

        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions();
            services.AddScoped<DialogService>();
            services.AddScoped<LocalStorageHelper>();
            services.AddScoped(c =>
                {
                    return configuration.GetSection("LocalStorage:Jwt").Get<LocalStorageOption>();
                }
            );
            services.AddAuthorizationCore();
            services.AddScoped<JwtProvider>();
            services.AddScoped<AuthenticationStateProvider, JwtProvider>(
                provider =>
                    provider.GetRequiredService<JwtProvider>()
            );
            services.AddScoped<IJwtProvider,JwtProvider>(
                provider =>
                    provider.GetRequiredService<JwtProvider>()
            );
        }

    }
}
