using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Y4C2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       // protected override void OnModelCreating(ModelBuilder modelBuilder)
       // {
        //    modelBuilder.Entity<AddContent>()
         //       .Property(prop => prop.Id)
         //       .ValueGeneratedOnAdd();

          //  base.OnModelCreating(modelBuilder);
      //  }

      //  public AddContentDBContext(DbContextOptions<AddContentDBContext> options) : base(options) { }
       // public DbSet<AddContent> AC { get; set; }
       // public DbSet<Account> Account { get; set; }
        //public DbSet<Y4C2.Models.Survey> Survey { get; set; }
    //}
}
}
