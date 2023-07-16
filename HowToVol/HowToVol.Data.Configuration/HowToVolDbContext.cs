using Microsoft.EntityFrameworkCore;
using HowToVol.Data.Entities;
using Microsoft.Extensions.Configuration;


namespace HowToVol.Data.Configuration
{
    public class HowToVolDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public HowToVolDbContext(DbContextOptions<HowToVolDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInterest>()
                .HasKey(ui => new { ui.UserId, ui.InterestId });

            modelBuilder.Entity<UserInterest>()
                .HasOne(ui => ui.User)
                .WithMany(u => u.UserInterests)
                .HasForeignKey(ui => ui.UserId);

            modelBuilder.Entity<UserInterest>()
                .HasOne(ui => ui.Interest)
                .WithMany(i => i.UserInterests)
                .HasForeignKey(ui => ui.InterestId);

            modelBuilder.Entity<Organization>()
                .HasMany(o => o.Events)
                .WithOne(e => e.Organization)
                .HasForeignKey(e => e.OrganizationId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
