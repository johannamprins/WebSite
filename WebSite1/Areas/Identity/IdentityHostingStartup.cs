using Microsoft.AspNetCore.Hosting;


[assembly: HostingStartup(typeof(WebSite1.Areas.Identity.IdentityHostingStartup))]
namespace WebSite1.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }

    } 
}