using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Models
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc.Models.Departament> Departament { get; set; }
        public DbSet<SalesWebMvc.Models.SalesRecord> SalesRecord { get; set; }
        public DbSet<SalesWebMvc.Models.Seller> Sellers { get; set; }

    }
}
