using HotelListing___ASP_.NET.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing___ASP_.NET.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(

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
