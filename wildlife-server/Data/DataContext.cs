using Microsoft.EntityFrameworkCore;
using wildlife_server.Models;
namespace wildlife_server.Data
{
    public class DataContext: DbContext
    {
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<wildlife_server.Models.Fish> Fish { get; set; }
    }
}
