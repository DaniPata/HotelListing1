using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing___ASP_.NET.Data
{
    public class DatabaseContext : DbContext
    { 

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        
        }

       

        public DbSet<Country>Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(

                new Country

                {
                    Id = 1,
                    Name = " Jamaica",
                    ShortName = "JM"

                },

                  new Country

                  {
                      Id = 2,
                      Name = "Bahamas",
                      ShortName = "BS"
                  },



                new Country

                {
                    Id = 3,
                    Name = " Island",
                    ShortName = "I"


                }

                );



            builder.Entity<Hotel>().HasData(

               new Hotel

               {
                   Id = 1,
                   Name = " Continental",
                   Address = "Vasile Blaga",
                   CountryId = 1,
                   Rating = 4.5

               },

                 new Hotel

                 {
                     Id = 2,
                     Name = " Flora",
                     Address = "Vasile Blaga",
                     CountryId = 2,
                     Rating = 4.5
                 },



               new Hotel

               {
                   Id = 3,
                   Name = " Continental",
                   Address = "Vasile Blaga",
                   CountryId = 3,
                   Rating = 4


               }

               );
        }

    }
}
