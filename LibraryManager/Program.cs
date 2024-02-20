using LibraryManager;
using LibraryManager.Models.Contracts.Contexts;
using LibraryManager.Models.Contracts.Repositories;
using LibraryManager.Models.Contracts.Services;
using LibraryManager.Models.Repositories;

namespace LibraryManager
{
    public class Program
    {

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}





















//var builder = WebApplication.CreateBuilder(args);

//var startup = new Startup(builder.Configuration);
//startup.ConfigureServices(builder.Services);

//// Add services to the container.

//var app = builder.Build();

//startup.Configure(app, app.Environment);


//app.Run();
