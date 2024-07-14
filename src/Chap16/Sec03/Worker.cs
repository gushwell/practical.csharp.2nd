// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Hosting;
// using System;
// using System.Threading;
// using System.Threading.Tasks;

// namespace GenericHostJsonConf;

// public class Worker : BackgroundService
// {
//     private readonly ILogger<Worker> _logger;

//     public Worker(ILogger<Worker> logger, IConfiguration configuration)
//     {
//         _logger = logger;

//         Console.WriteLine(this.configuration.GetValue<string>("TestConfig"));
//     }

//     protected override async Task ExecuteAsync(CancellationToken stoppingToken)
//     {
//         while (!stoppingToken.IsCancellationRequested)
//         {
//             _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
//             await Task.Delay(1000, stoppingToken);
//         }
//     }
// }