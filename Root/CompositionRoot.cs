using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Data;
using Microsoft.EntityFrameworkCore;

namespace Root
{
    /// <summary>
    /// The composition root.
    /// </summary>
    public class CompositionRoot
    {
        /// <summary>
        /// Inject the dependencies.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="connectionString">The connection string.</param>
        public static void InjectDependencies(IServiceCollection services, string connectionString)
        {
            #region // databases injection
            services.AddDbContext<MyDbContext>(opts => opts.UseSqlServer(connectionString, b => b.MigrationsAssembly("Data")));
            services.AddScoped<MyDbContext>();
            #endregion

            #region repositories injection
            #endregion

            #region services injection
            #endregion

            #region others injection
            #endregion

        }

    }
}
