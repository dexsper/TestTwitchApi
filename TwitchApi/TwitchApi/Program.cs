using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using TwitchApi.Twitch;
using TwitchApi.Twitch.Data;

namespace TwitchApi
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }

        private static IHostBuilder CreateHostBuilder()
        {
            var configuration = new ConfigurationBuilder()
                 .AddJsonFile("appsettings.json", optional: true)
                 .AddEnvironmentVariables()
                 .AddUserSecrets(Assembly.GetExecutingAssembly())
                 .Build();


            return Host.CreateDefaultBuilder()
                 .ConfigureAppConfiguration(builder =>
                 {
                     builder.Sources.Clear();
                     builder.AddConfiguration(configuration);
                 })
                .ConfigureServices((context, services) =>
                {
                    var clientId = context.Configuration["Twitch:ClientId"];
                    var clientSecret = context.Configuration["Twitch:ClientSecret"];

                    if (string.IsNullOrWhiteSpace(clientId))
                        throw new InvalidOperationException("Twitch:ClientId is missing in configuration.");

                    if (string.IsNullOrWhiteSpace(clientSecret))
                        throw new InvalidOperationException("Twitch:ClientSecret is missing in configuration.");

                    services.AddSingleton(new ClientTwitchAuth(clientId, clientSecret));
                    services.AddSingleton(new UserAuthStorage("credentials.json"));
                    services.AddSingleton<TwitchApiClient>();

                    services.AddSingleton<MainForm>();
                    services.AddTransient<AuthForm>();
                });
        }
    }
}
