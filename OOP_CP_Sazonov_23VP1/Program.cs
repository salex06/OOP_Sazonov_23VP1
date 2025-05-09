using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using OOP_CP_Sazonov_23VP1.context;
using OOP_CP_Sazonov_23VP1.repository.impl;
using System.Windows.Forms.Design;
using OOP_CP_Sazonov_23VP1.repository;
using OOP_CP_Sazonov_23VP1.forms;
using Microsoft.VisualBasic.ApplicationServices;
using OOP_CP_Sazonov_23VP1.tools;
using OOP_CP_Sazonov_23VP1.tools.form_factories.add_book;
using OOP_CP_Sazonov_23VP1.tools.form_factories.add_author;
using OOP_CP_Sazonov_23VP1.service;
using OOP_CP_Sazonov_23VP1.tools.form_factories.add_genre;
using OOP_CP_Sazonov_23VP1.model.entity;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using OOP_CP_Sazonov_23VP1.tools.form_factories.edit_book;
using OOP_CP_Sazonov_23VP1.tools.form_factories.remove_book;
using OOP_CP_Sazonov_23VP1.tools.form_factories.add_reader;
using OOP_CP_Sazonov_23VP1.tools.form_factories.remove_reader;
using OOP_CP_Sazonov_23VP1.tools.form_factories.edit_reader;
using OOP_CP_Sazonov_23VP1.tools.form_factories.lend_book;
using OOP_CP_Sazonov_23VP1.tools.form_factories.return_book;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace OOP_CP_Sazonov_23VP1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            SQLitePCL.Batteries_V2.Init();
            var services = new ServiceCollection();

            ConfigureServices(services, GetDatabaseFilePath());

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                using (var scope = serviceProvider.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<LibraryDatabaseContext>();

                    if ((dbContext.Database.GetPendingMigrations()).Any())
                    {
                        dbContext.Database.MigrateAsync();
                    }
                }

                var mainLibraryForm = serviceProvider.GetRequiredService<MainLibraryForm>();
                Application.Run(mainLibraryForm);
            }
        }


        private static void ConfigureServices(IServiceCollection services, string? sourcePath)
        {
            services.AddTransient<IAddBookFormFactory, AddBookFormFactory>();
            services.AddTransient<IAddAuthorFormFactory, AddAuthorFormFactory>();
            services.AddTransient<IAddGenreFormFactory, AddGenreFormFactory>();
            services.AddTransient<IEditBookFormFactory, EditBookFormFactory>();
            services.AddTransient<IRemoveBookFormFactory, RemoveBookFormFactory>();
            services.AddTransient<IAddReaderFormFactory, AddReaderFormFactory>();
            services.AddTransient<IRemoveReaderFormFactory, RemoveReaderFormFactory>();
            services.AddTransient<IEditReaderInfoFormFactory, EditReaderInfoFormFactory>();
            services.AddTransient<ILendBookFormFactory, LendBookFormFactory>();
            services.AddTransient<IReturnBookFormFactory, ReturnBookFormFactory>();

            services.AddTransient<IAuthorRepository, AuthorRepository>();
            services.AddTransient<IGenreRepository, GenreRepository>();
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IReaderRepository, ReaderRepository>();
            services.AddTransient<ILoanRepository, LoanRepository>();

            services.AddTransient<MainLibraryForm>();
            services.AddTransient<AddBookForm>();
            services.AddTransient<AddGenreForm>();
            services.AddTransient<AddReaderForm>();
            services.AddTransient<EditBookInfoForm>();
            services.AddTransient<EditReaderInfoForm>();
            services.AddTransient<GiveOutABookForm>();
            services.AddTransient<NewAuthorForm>();
            services.AddTransient<RemoveBookForm>();
            services.AddTransient<RemoveReaderForm>();
            services.AddTransient<ReturnBookForm>();
            services.AddTransient<StartForm>();

            services.AddTransient<AuthorService>();
            services.AddTransient<GenreService>();
            services.AddTransient<BookService>();
            services.AddTransient<ReaderService>();
            services.AddTransient<LoanService>();
            services.AddTransient<ReportService>();
            services.AddTransient<ContextService>();

            services.AddDbContext<LibraryDatabaseContext>(options =>
            {
                var dbPath = sourcePath;
                if (dbPath == null) {
                    dbPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LibraryApp", "library.db");
                }
                Directory.CreateDirectory(Path.GetDirectoryName(dbPath));

                options.UseSqlite($"Data Source={dbPath}");
            });
        }

        private static string? GetDatabaseFilePath() {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "SQLite Database Files (*.db;*.sqlite;*.s3db)|*.db;*.sqlite;*.s3db|All files (*.*)|*.*";
            openFileDialog.Title = "�������� ���� ���� ������ SQLite";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            MessageBox.Show("���� �� ������. ����� ������� ���� ������ �� ���������",
                "����������� ���� ������...",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            return null;
        }
    }
}