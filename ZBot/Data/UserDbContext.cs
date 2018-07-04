using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZBot.Models;

namespace ZBot.Data
{
    /// <summary>
    /// Context class to interact with the database
    /// </summary>
    public class UserDbContext : DbContext
    {
        DbSet<ZBotUser> users { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
