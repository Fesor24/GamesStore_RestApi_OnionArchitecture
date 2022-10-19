using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Models;

namespace Repository.Configuration
{
    public class ConsoleConfiguration : IEntityTypeConfiguration<ConsoleDevice>
    {
        public void Configure(EntityTypeBuilder<ConsoleDevice> builder)
        {
            builder.HasData(
                new ConsoleDevice
                {
                    Id = 1,
                    Name = "Xbox360"
                },

                new ConsoleDevice
                {
                    Id = 2,
                    Name = "PS3"
                },

                new ConsoleDevice
                {
                    Id = 3,
                    Name = "PS4"
                },

                new ConsoleDevice
                {
                    Id = 4,
                    Name = "PS5"
                },

                new ConsoleDevice
                {
                    Id = 5,
                    Name = "Xbox"
                }



                );
        }
    }
}
