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
    public class LibraryDatabaseContext : DbContext
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
        public virtual DbSet<Book> Books { get; set; } = null!;
        /// <summary>
        /// Таблица с сущностями типа "Автор"
        /// </summary>
        public virtual DbSet<Author> Authors { get; set; } = null!;
        /// <summary>
        /// Таблица с сущностями типа "Жанр"
        /// </summary>
        public virtual DbSet<Genre> Genres { get; set; } = null!;
        /// <summary>
        /// Таблица с сущностями типа "Читатель"
        /// </summary>
        public virtual DbSet<Reader> Readers { get; set; } = null!;
        /// <summary>
        /// Таблица с сущностями типа "Выдача книги"
        /// </summary>
        public virtual DbSet<Loan> Loans { get; set; } = null!;

        /// <summary>
        /// Очистить текущую базу данных
        /// </summary>
        public void ClearDatabase()
        {
            ChangeTracker.AutoDetectChangesEnabled = false; 

            try
            {
                Database.ExecuteSqlRaw("DELETE FROM Loans");
                Database.ExecuteSqlRaw("DELETE FROM Books");
                Database.ExecuteSqlRaw("DELETE FROM Authors");
                Database.ExecuteSqlRaw("DELETE FROM Genres");
                Database.ExecuteSqlRaw("DELETE FROM Readers");

                SaveChanges();
            }
            finally
            {
                ChangeTracker.AutoDetectChangesEnabled = true;
            }
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var dbPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LibraryApp", "library.db");
        //    Directory.CreateDirectory(Path.GetDirectoryName(dbPath));

        //    optionsBuilder.UseSqlite($"Data Source={dbPath}");
        //}

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
