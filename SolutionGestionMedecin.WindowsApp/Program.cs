using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SolutionGestionMedecin.Core.Interfaces;
using SolutionGestionMedecin.Core.Services;
using SolutionGestionMedecin.Infrastructure;
using SolutionGestionMedecin.Infrastructure.Repositories;
using SolutionGestionMedecin.WindowsApp;
using Travail_2;

namespace SolutionGestionMedecin.WindowsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
             .ConfigureServices((hostContext, services) =>
             {
                 services.AddDbContext<SolutionGestionMedecinContext>(options => options.UseSqlServer(
    @"Server=.;Database=SolutiongestionmedecinsDB;Trusted_Connection=True;"));
                 services.AddSingleton<Form1>();
                 services.AddLogging(configure => configure.AddConsole());
                 services.AddScoped<IPatientRepository, PatientRepository>();
                 services.AddScoped<IGestionMedecinService, GestionMedecinService>();

             });

            var host = builder.Build();


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var forms = services.GetRequiredService<Form1>();
                    Application.Run(forms);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error");
                }
            }


        }
    }
}
