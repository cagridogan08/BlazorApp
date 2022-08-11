using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using BlazorGiris.Data;
namespace BlazorGiris.DataContext
{
    public class UserDataContext : DbContext
    {
        public UserDataContext(DbContextOptions options) : base(options) { }

        public UserDataContext()
        {
        }
        public DbSet<UserModel> Users { get; set; }
        /// <summary>
        /// Code first ile database creation sırasında oluşan tanımlamalar
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserModel>().HasKey(e=>new {e.ID});// ef primary key definitions
            builder.Entity<UserModel>().Property(e => e.ID).ValueGeneratedOnAdd(); // auto increment after add new data
        }
        /// <summary>
        /// Database Connection
        /// </summary>
        /// <param name="optionsBuilder"></param>
        /// <exception cref="ArgumentNullException"></exception>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder is null)
            {
                throw new ArgumentNullException(nameof(optionsBuilder));
            }

            optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=Cagri.dogan1");
        }
    }
}
