using BlazorApp.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public class MyDBContext:DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options):base(options) { }
        public DbSet<User> users { get; set; }
    }
}
