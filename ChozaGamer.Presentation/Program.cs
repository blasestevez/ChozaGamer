using ChozaGamer.Business.Services;
using ChozaGamer.DataAccess;
using ChozaGamer.DataAccess.Mappings;
using ChozaGamer.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ChozaGamer.Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var services = new ServiceCollection();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer("Server=PC92;Database=ChozaGamer;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true"));
            
            services.AddAutoMapper(typeof(AutoMapperProfiles));

            services.AddScoped<ProductService>();
            services.AddScoped<ProductRepository>();
            services.AddScoped<UserService>();
            services.AddScoped<UserRepository>();

            services.AddSingleton<LoginForm>();
            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<LoginForm>());
        }
    }
}