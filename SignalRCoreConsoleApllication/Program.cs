using System;
using System.Net.NetworkInformation;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace SignalRCoreConsoleApllication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
    }
}