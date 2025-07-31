using Code_First_Yaklaşımında_Tablo_İlişkilendirme.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Reflection;

namespace Code_First_Yaklaşımında_Tablo_İlişkilendirme.Context
{
    public class PatikaSecondDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Post> Posts { get; private set; }
        public DbSet<User> Users { get; private set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }

    internal class AppDbContextFactory : IDesignTimeDbContextFactory<PatikaSecondDbContext>
    {
        public PatikaSecondDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PatikaSecondDbContext>();
            builder.UseSqlServer("Data Source=localhost;Initial Catalog=PatikaCodeFirstDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            return new PatikaSecondDbContext(builder.Options);
        }
    }
}
