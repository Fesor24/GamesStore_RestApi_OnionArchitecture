using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
   
        }

        public DbSet<Game>? Games { get; set; }
        public DbSet<Genre>? Genres { get; set; }

        public DbSet<ConsoleDevice>? ConsoleDevices { get; set; }
    }
}
