namespace NCloud.EF.Core.DbContext
{
    using Fur.DatabaseAccessor;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Defines the <see cref="SqliteDbContext" />.
    /// </summary>
    [AppDbContext("sqlitedb")]
    public class SqliteDbContext : AppDbContext<SqliteDbContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqliteDbContext"/> class.
        /// </summary>
        /// <param name="options">The options<see cref="DbContextOptions{SqliteDbContext}"/>.</param>
        public SqliteDbContext(DbContextOptions<SqliteDbContext> options) : base(options)
        {
        }
    }
}
