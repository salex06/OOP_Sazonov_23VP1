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
    /// <summary>
    /// Контекст базы данных, предоставляющий
    /// API для получения, изменения и сохранения информации
    /// </summary>
    class LibraryDatabaseContext : DbContext
    {
        /// <summary>
        /// Конструктор контекста
        /// </summary>
        /// <param name="options">Параметры контекста</param>
        public LibraryDatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public LibraryDatabaseContext()
        {
        }

        /// <summary>
        /// Таблица с сущностями типа "Книга"
        /// </summary>
        public DbSet<Book> Books { get; set; } = null!;
        /// <summary>
        /// Таблица с сущностями типа "Автор"
        /// </summary>
        public DbSet<Author> Authors { get; set; } = null!;
        /// <summary>
        /// Таблица с сущностями типа "Жанр"
        /// </summary>
        public DbSet<Genre> Genres { get; set; } = null!;
        /// <summary>
        /// Таблица с сущностями типа "Читатель"
        /// </summary>
        public DbSet<Reader> Readers { get; set; } = null!;
        /// <summary>
        /// Таблица с сущностями типа "Выдача книги"
        /// </summary>
        public DbSet<Loan> Loans { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LibraryApp", "library.db");
            Directory.CreateDirectory(Path.GetDirectoryName(dbPath));

            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Reader)
                .WithMany(r => r.Loans)
                .HasForeignKey(l => l.ReaderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Book)
                .WithMany(b => b.Loans)
                .HasForeignKey(l => l.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }

}
