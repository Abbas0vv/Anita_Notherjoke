using Anita_Notherjoke.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace Anita_Notherjoke
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            //Services
            builder.Services
                            .AddDbContext<Anita_NotherjokeDbContext>(o =>
                            {
                                var connectionString = "Server=localhost;Port=5432;Database=Pustok;User Id=postgres;Password=postgres;";

                                o.UseNpgsql(connectionString);
                            });


            //app builder
            var app = builder.Build();


            //Middleware
            app.UseStaticFiles();

            app.MapControllerRoute(

                name: "default",
                pattern: "{controller=Dashboard}/{action=Index}/{id?}"
                );

            app.Run();
        }
    }
}