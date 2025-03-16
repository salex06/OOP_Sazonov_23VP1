using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using OOP_CP_Sazonov_23VP1.model.entity;

namespace OOP_CP_Sazonov_23VP1.context
{
    class LibraryDatabaseContext : DbContext
    {
        public LibraryDatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public LibraryDatabaseContext()
        {
            //Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(AppContext.BaseDirectory, "library.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }

}
