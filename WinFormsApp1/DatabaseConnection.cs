using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class DatabaseConnection : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlite("Data Source=C:\\Databases\\mydatabase.db");
        }

        public DbSet<CollisionCheck> collisionChecks { get; set; }
    }
}
