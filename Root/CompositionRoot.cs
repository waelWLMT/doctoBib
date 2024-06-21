using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Data;
using Microsoft.EntityFrameworkCore;
using Data.RepositoryPatterns;
using Data.RepositoryPatterns.Impl;
using BLL.Pattern.Impl;
using BLL.Pattern;
using Data.Repositories.ReadRepositories;
using Data.Repositories.ReadRepositories.Impl;
using Data.Repositories.WriteRepositories;
using Data.Repositories.WriteRepositories.Impl;
using BLL.Services.ReadServices;
using BLL.Services.ReadServices.Impl;
using BLL.Services.WriteServices;
using BLL.Services.WriteServices.Impl;
using BLL.Services.Usefull;
using BLL.Services.Usefull.Impl;

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

            #region generic repositories and services injection

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped(typeof(IReadServicePattern<>), typeof(ReadServicePattern<>));
            services.AddScoped(typeof(IServicePattern<>), typeof(ServicePattern<>));

            #endregion

            #region Read repositories injection

            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IAdresseReadRepository, AdresseReadRepository>();    

            services.AddScoped<ICalendrierReadRepository, CalendrierReadRepository>();
            services.AddScoped<IDepartementReadRepository, DepartementReadRepository>();

            services.AddScoped<IMenuReadRepository, MenuReadRepository>();
            services.AddScoped<IMotifReadRepository, MotifReadRepository>();

            services.AddScoped<IPatientReadRepository, PatientReadRepository>();
            services.AddScoped<IPraticienReadRepository, PraticienReadRepository>();

            services.AddScoped<IRoleReadRepository, RoleReadRepository>();
            services.AddScoped<ISpecialiteReadRepository, SpecialiteReadRepository>();

            
            #endregion

            #region Write repositories

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAdresseRepository, AdresseRepository>();

            services.AddScoped<ICalendrierRepository, CalendrierRepository>();
            services.AddScoped<IPatientRepository, PatientRepository>();

            services.AddScoped<IPraticienRepository, PraticienRepository>();
            services.AddScoped<IRendezVousRepository, RendezVousRepository>();

            #endregion

            #region Read services injection

            services.AddScoped<IUserReadService, UserReadService>();

            services.AddScoped<IAdresseReadService, AdresseReadService>();
            services.AddScoped<ICalendrierReadService, CalendrierReadService>();

            services.AddScoped<IDepartementReadService, DepartementReadService>();
            services.AddScoped<IMenuReadService, MenuReadService>();

            services.AddScoped<IMotifReadService, MotifReadService>();
            services.AddScoped<IPatientReadService, PatientReadService>();

            services.AddScoped<IPraticienReadService, PraticienReadService>();
            services.AddScoped<ISpecialiteReadService, SpecialiteReadService>();

            services.AddScoped<ICommuneReadService, CommuneReadService>();


            #endregion

            #region Write services injection

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAdresseService, AdresseService>();

            services.AddScoped<ICalendrierService, CalendrierService>();
            services.AddScoped<IPatientService, PatientService>();

            services.AddScoped<IPraticienService, PraticienService>();
            services.AddScoped<IRendezVousService, RendezVousService>();


            #endregion

            #region others injection
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<HttpClient, HttpClient>();
            

            services.AddScoped<IAuthenticationService, AuthenticationService>();

            #endregion

        }

    }
}
