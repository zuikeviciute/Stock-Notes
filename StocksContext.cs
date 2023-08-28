using System;
using Microsoft.EntityFrameworkCore;
using StocksEntities;

namespace StocksContext
{
    public class StocksDatabase : DbContext
    {
        public DbSet<Stocks> Stocks { get; set; }
        public DbSet<OHLC> OHLC { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Stocks.db");
        }
    }
}