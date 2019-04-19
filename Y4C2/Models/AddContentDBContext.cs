using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Y4C2.Models;

namespace Y4C2.Models
{
    public class AddContentDBContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddContent>()
                .Property(prop => prop.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<AddContent>()
            .HasMany(p => p.Survey).WithOne(p => p.Theme)
            .IsRequired(false);

            base.OnModelCreating(modelBuilder);
        }

        public AddContentDBContext(DbContextOptions<AddContentDBContext> options) : base(options) { }
        public DbSet<AddContent> AC { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Survey> Survey { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Answer> Answer { get; set; }
    }

}
