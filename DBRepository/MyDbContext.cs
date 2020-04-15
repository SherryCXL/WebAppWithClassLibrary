using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepository
{
    public class MyDbContext:DbContext
    {
        public MyDbContext (DbContextOptions<MyDbContext> options):base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=WebAppCore;Trusted_Connection=True;ConnectRetryCount=0");

            }
        }
        public DbSet<User> User { get; set; }
    }
}
