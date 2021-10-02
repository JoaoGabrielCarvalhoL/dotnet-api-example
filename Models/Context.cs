using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Context : DbContext
    {
        
        public DbSet<Category> Catogories { get; set; }

        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(connectionString: @"Server=JOAOGABRIELCARV\SQLEXPRESS;Database=mvc;Integrated Security=true");
        }
    }
}
