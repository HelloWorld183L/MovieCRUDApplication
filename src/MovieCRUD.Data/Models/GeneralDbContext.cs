using System.Data.Entity;

namespace MovieCRUD.Data.Models
{
    public class GeneralDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }    
        public DbSet<Account> Accounts { get; set; }
        private readonly string _connectionString;

        public GeneralDbContext(string connectionString) : base()
        {
            _connectionString = connectionString;
            var ensureDllIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}