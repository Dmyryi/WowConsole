using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Wow.Core.Models;

namespace Wow.Infrastructure
{
    public class GameDbContext : DbContext
    {
      
        public DbSet<User> Users { get; set; }
       
      

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            string dbPath = System.IO.Path.Combine(folder, "game.db");

            // 3. Используем этот АБСОЛЮТНЫЙ путь
            options.UseSqlite($"Data Source={dbPath}");
        }
    }
}
