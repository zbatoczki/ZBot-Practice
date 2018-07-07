using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZBot.Entities;
using ZBot.Models;

namespace ZBot.Data
{
    /// <summary>
    /// Context class to interact with the database
    /// </summary>
    public class ZBotDbContext : DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Token> Tokens { get; set; }
        public ZBotDbContext(DbContextOptions<ZBotDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Token>().HasKey(t => new { t.Id });
        }
    }
}
