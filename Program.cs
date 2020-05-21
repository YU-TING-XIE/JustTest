using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace website
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults((webBuilder,ConfigurationBinder) =>
                {
                    ConfigurationBinder.AddJsonFile("appsettings.json",optional : True);
                })
               .UseStartup<Startup>();
    }
}