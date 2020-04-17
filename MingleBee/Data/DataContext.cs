using Microsoft.EntityFrameworkCore;
using MingleBee.Models;

namespace MingleBee.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<Value> Values { get; set; }
        
    }
}
