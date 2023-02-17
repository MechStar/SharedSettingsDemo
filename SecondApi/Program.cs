using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace SecondApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    var env = hostingContext.HostingEnvironment;
                    var commonPath = Path.Combine(env.ContentRootPath, "..", "Shared");

                    config.AddJsonFile(Path.Combine(commonPath, "commonsettings.json"), true, true)
                        .AddJsonFile("commonsettings.json", true, true)
                        .AddJsonFile("appsettings.json", true, true)
                        .AddJsonFile(Path.Combine(commonPath, $"commonsettings.{env.EnvironmentName}.json"), true, true)
                        .AddJsonFile($"commonsettings.{env.EnvironmentName}.json", true, true)
                        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true)
                        .AddEnvironmentVariables();
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
