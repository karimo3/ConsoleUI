using Microsoft.EntityFrameworkCore;
using Restaurants.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurants.Data
{
    public class PlayerDbContext : DbContext
    {
        public PlayerDbContext(DbContextOptions<PlayerDbContext> options)
            : base(options)
        {

        }

        public DbSet<Player> Restaurants { get; set; }
    }
}
