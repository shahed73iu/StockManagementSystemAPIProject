using Microsoft.EntityFrameworkCore;
using StockMarket.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Data
{
    public class StockMarketContext : DbContext
    {
        private string _connectionString;
        private string _migrationAssemblyName;
        public StockMarketContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_migrationAssemblyName));
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Company2>()
                .HasMany(x => x.StockPrices)
                .WithOne(y => y.Company2)
                .HasForeignKey(fk => fk.ComapnyId);
            base.OnModelCreating(builder);
        }
        public DbSet<Company2> Company2s { get; set; }
        public DbSet<StockPrice> StockPrices { get; set; }
    }
}