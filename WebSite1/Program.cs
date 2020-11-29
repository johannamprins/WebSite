using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting; 
using Microsoft.Extensions.Logging;

namespace WebSite1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                // calls application settings json file -> will be read when app starts
                //we use app json when storing connections to the db
                .ConfigureWebHostDefaults(webBuilder =>
                    // will create a web server
                {
                    webBuilder.UseStartup<Startup>();
                    // takes startup as the type of parameter
                });
    }
}