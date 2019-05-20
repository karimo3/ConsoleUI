﻿using Microsoft.EntityFrameworkCore;
using BestFood.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestFood.Data
{
    public class RestaurantDbContext :DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options)
            : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }





    }
}
