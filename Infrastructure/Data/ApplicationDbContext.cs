using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }

        public DbSet<AboutMe> AboutMes { get; set; }
        public DbSet<Addres> Address { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Investment> Investments { get; set; }
        public DbSet<Investor> Investors { get; set; }
        public DbSet<Startup> Startups { get; set; }
        public DbSet<StartupCategory> StartupCategories { get; set; }
        public DbSet<StartupFile> StartupFiles { get; set; }
        public DbSet<StartupFinancialData> StartupFinancialDatas { get; set; }
        public DbSet<User> Users { get; set; }

    }
}