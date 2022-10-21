using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BackendLab.Data;
namespace BackendLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
                        var connectionString = builder.Configuration.GetConnectionString("BackendLabContextConnection") ?? throw new InvalidOperationException("Connection string 'BackendLabContextConnection' not found.");

                                    builder.Services.AddDbContext<BackendLabContext>(options =>
                options.UseSqlServer(connectionString));

                                                builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<BackendLabContext>();

            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();
                        app.UseAuthentication();;

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}