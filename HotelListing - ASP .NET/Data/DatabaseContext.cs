﻿using HotelListing___ASP_.NET.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing___ASP_.NET.Data
{
    public class DatabaseContext : IdentityDbContext<ApiUser>
    { 

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        
        }

       

        public DbSet<Country>Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new HotelConfiguration());
        }

    }
}
