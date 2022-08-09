using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
namespace BlazorGiris.DataContext
{
    public class DataContextDatabaseCreator : IDesignTimeDbContextFactory<UserDataContext>
    {

       public UserDataContext CreateDbContext(string[]? args = null)
        {
            var options = new DbContextOptionsBuilder<UserDataContext>();
            options.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=Cagri.dogan1");
            return new UserDataContext(options.Options);
        }
    }
}
