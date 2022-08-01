using Entidades.Core;
using Microsoft.EntityFrameworkCore;

namespace Data.Model
{
    public class DataContext : DbContext
    {
        //public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Product> products { set; get; }

        public DataContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //builder.UseSqlServer("Server=tcp:portalviadbcat.database.windows.net,1433;Initial Catalog=EComerce;Persist Security Info=False;User ID=Administrador;Password=Baloto2020*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            builder.UseSqlServer(@"server=(LocalDB)\MSSQLLocalDB;database=ECommerce;integrated security = true");

        }
    }
}
