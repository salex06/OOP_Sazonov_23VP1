using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using OOP_CP_Sazonov_23VP1.context;
using OOP_CP_Sazonov_23VP1.model.orm;
using OOP_CP_Sazonov_23VP1.repository.impl;
using System.Windows.Forms.Design;
using OOP_CP_Sazonov_23VP1.repository;
using OOP_CP_Sazonov_23VP1.forms;
using Microsoft.VisualBasic.ApplicationServices;
using AutoMapper;
using OOP_CP_Sazonov_23VP1.tools;
using OOP_CP_Sazonov_23VP1.tools.form_factories.add_book;
using OOP_CP_Sazonov_23VP1.tools.form_factories.add_author;
using OOP_CP_Sazonov_23VP1.service;
using OOP_CP_Sazonov_23VP1.tools.form_factories.add_genre;

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
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainLibraryForm = serviceProvider.GetRequiredService<MainLibraryForm>();
                Application.Run(mainLibraryForm);
            }
        }


        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperProfile));
            services.AddTransient<IAuthorRepository, AuthorRepository>();
            services.AddTransient<IAddBookFormFactory, AddBookFormFactory>();
            services.AddTransient<IAddAuthorFormFactory, AddAuthorFormFactory>();
            services.AddTransient<IAddGenreFormFactory, AddGenreFormFactory>();
            services.AddTransient<IGenreRepository, GenreRepository>();
            services.AddTransient<IBookRepository, BookRepository>();

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

            services.AddDbContext<LibraryDatabaseContext>();
        }
    }
}