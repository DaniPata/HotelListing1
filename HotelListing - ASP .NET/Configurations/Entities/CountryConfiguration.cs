﻿using HotelListing___ASP_.NET.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing___ASP_.NET.Configurations.Entities
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
       
        public void Configure (EntityTypeBuilder<Country> builder)
        {
            builder.HasData(

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

        }
    }
}