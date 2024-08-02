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

            var form = serviceProvider.GetService<ProdutoForm>();
            Application.Run(form);
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<CleverDbContext>(options =>
                options.UseInMemoryDatabase("SuaStringDeConexao"));

            services.AddTransient<IProdutoAppService, ProdutoAppService>();
            services.AddTransient<IProdutoService, ProdutoService>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();

            services.AddAutoMapper(typeof(MappingProfile));

            services.AddTransient<ProdutoForm>();

            return services.BuildServiceProvider();
        }
    }
}