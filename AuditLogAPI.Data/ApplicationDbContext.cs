using Audit.EntityFramework;
using AuditLogAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AuditLogAPI.Data
{
    public class ApplicationDbContext : AuditDbContext
    {
        protected ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        // DB Tables
        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<AuditLog> AuditLogs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
