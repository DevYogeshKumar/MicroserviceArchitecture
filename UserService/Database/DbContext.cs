using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Database.Entities;

namespace UserService.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-K5JL5EF\LOCALSERVER;initial catalog=UserDatabase;persist security info=true;user id=sa;password=root;");
        }
    }
}
