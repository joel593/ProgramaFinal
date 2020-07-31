using Microsoft.AspNetCore.Hosting;


[assembly: HostingStartup(typeof(VintageStuff.Web.Areas.Identity.IdentityHostingStartup))]
namespace VintageStuff.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}