using Microsoft.EntityFrameworkCore;
using DataCollection.Server.Models; // Ensure this is included

namespace DataCollection.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ProductEntry> ProductEntries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Your SQL Server Connection String");
        }
    }