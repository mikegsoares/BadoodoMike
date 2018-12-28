using Microsoft.EntityFrameworkCore;
using BadoodoMike.API.Models;

namespace BadoodoMike.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Value> Values { get; set; }
    }
}