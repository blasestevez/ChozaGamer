using ChozaGamer.Business.Services;
using ChozaGamer.DataAccess;
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
                options.UseSqlServer("Server=DESKTOP-JSV8JHV;Database=ChozaGamer;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true"));

            services.AddScoped<ProductRepository>();
            services.AddScoped<ProductService>();

            services.AddSingleton<Form1>();

            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }
    }
}