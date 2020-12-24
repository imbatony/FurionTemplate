namespace NCloud.EF.Core
{
    using Furion.DatabaseAccessor;
    using Microsoft.Extensions.DependencyInjection;
    using NCloud.EF.Core.DbContext;

    /// <summary>
    /// Defines the <see cref="NCloudEFCoreStartUp" />.
    /// </summary>
    public class NCloudEFCoreStartUp : Furion.AppStartup
    {
        /// <summary>
        /// The ConfigureServices.
        /// </summary>
        /// <param name="services">The services<see cref="IServiceCollection"/>.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDatabaseAccessor(opt =>
            {
                opt.AddDb<SqliteDbContext>(DbProvider.Sqlite);
            }, "NCloud.DB.Migrations");
        }
    }
}
