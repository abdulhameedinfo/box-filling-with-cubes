using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BoxFillingWithCubes.Models;
using BoxFillingWithCubes.Services;
using BoxFillingWithCubes.Utils;

public class Program
{
    public static void Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                // Register your services here
                services.AddSingleton<IBoxFillingService, BoxFillingService>();
                services.AddSingleton<IInputParser, InputParser>();
                services.AddSingleton<BoxFillingApp>();
            })
            .Build();

        // Use the service provider to resolve and run your main app
        var app = host.Services.GetRequiredService<BoxFillingApp>();
        app.Run(args);
    }
}
