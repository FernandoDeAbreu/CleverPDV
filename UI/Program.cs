using Clever.Application;
using Clever.Application.AutoMapperProfile;
using Clever.Application.Interfaces;
using Clever.Domain.Core.Interfaces.Repositorys;
using Clever.Domain.Core.Interfaces.Services;
using Clever.Domain.Services.Service;
using Clever.Infra.Data.EntityFrameworkCore;
using Clever.Infra.Data.EntityFrameworkCore.Repositorys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms.Design;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceProvider = ConfigureServices();

            var form = serviceProvider.GetService<MenuForm>();
            Application.Run(form);
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<CleverDbContext>(options =>
            {
                options.UseInMemoryDatabase("SuaStringDeConexao");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();

            services.AddScoped<ICategoriaAppService, CategoriaAppService>();
            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();

            services.AddAutoMapper(typeof(MappingProfile));

            services.AddTransient<MenuForm>();

            return services.BuildServiceProvider();
        }
    }
}