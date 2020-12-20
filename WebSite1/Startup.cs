using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebSite1.Models;

namespace WebSite1
{

public class Startup //startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        // called by .net core automatically 
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllersWithViews(); // we have to add support to MVC 
            // adding our own custom service
            // NB the addscope method means that an instance will be created in each request and
            // it will remain active for the whole request! - needed to work with database!
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<ShoppingCart>(sc => ShoppingCart.GetCart(sc));
            services.AddScoped<IOrderRepository, OrderRepository>();

            services.AddHttpContextAccessor();
            services.AddSession();

            //controllers create responses in MVC

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        //tells the app what environment it should run in
        // IApplicationBuilder - tells we want the application to run in HTTPS
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // allows us to display error messages - disable before you deploy the app live
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles(); // will automatically search for directory wwwroot - enables images and js
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();

            app.UseEndpoints(endpoints => // enable MVC to respond to request
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    ); // allows our app to route through the request and return a response
            });
        }
    }
}
