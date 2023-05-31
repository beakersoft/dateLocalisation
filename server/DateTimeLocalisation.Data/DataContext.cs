using DateTimeLocalisation.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DateTimeLocalisation.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<LukeOrders> Orders { get; set; }
    }
}