using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OOP_CP_Sazonov_23VP1.model.orm;

namespace OOP_CP_Sazonov_23VP1.context
{
    class LibraryDatabaseContext : DbContext
    {
        public LibraryDatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public LibraryDatabaseContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<BookDb> Books { get; set; }
        public DbSet<AuthorDb> Authors { get; set; }
        public DbSet<ReaderDb> Readers { get; set; }
        public DbSet<GenreDb> Genres { get; set; }
        public DbSet<LoanDb> Loans { get; set; }
        public DbSet<AuthorshipDb> Authorships { get; set; }
        public DbSet<BookGenresDb> BookGenres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=..\\..\\..\\library.db");
        }
    }

}
