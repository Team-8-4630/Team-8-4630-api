using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Team_8_4630.Data
{
    public class StoreContextFactory
        : IDesignTimeDbContextFactory<StoreContext>
    {
        public StoreContext CreateDbContext(string[] args)
        {
            var optionsBuilder =
                new DbContextOptionsBuilder<StoreContext>();

            optionsBuilder.UseSqlite(
                "Data Source=Registrar.sqlite",
                sqlite => sqlite.MigrationsAssembly("Team-8-4630.Api"));

            return new StoreContext(optionsBuilder.Options);
        }
    }
}