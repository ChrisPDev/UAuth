using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using UAuthWebApi.DbModels;

namespace UAuthWebApi.Data
{
    public class UAuthDbContext : DbContext
    {
        public UAuthDbContext(DbContextOptions<UAuthDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}
