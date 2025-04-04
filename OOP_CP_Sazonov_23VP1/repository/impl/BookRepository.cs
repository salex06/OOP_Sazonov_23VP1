using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OOP_CP_Sazonov_23VP1.context;
using OOP_CP_Sazonov_23VP1.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace OOP_CP_Sazonov_23VP1.repository.impl
{
    class BookRepository : IBookRepository
    {
        private readonly LibraryDatabaseContext _context;

        public BookRepository(LibraryDatabaseContext context)
        {
            _context = context;
        }

        public KeyValuePair<List<Book>, int> GetAllBooks(string orderBy_value, bool isAscending, dto.BookFilterOptions filters)
        {
            var query = _context.Books
                    .Include(src => src.Authors)
                    .Include(src => src.Genres)
                    .Include(src => src.Loans)
                    .Where(src => filters.Title == null || src.Title == filters.Title)
                    .Where(src => filters.YearOfPublication == null || src.YearOfPublication == filters.YearOfPublication)
                    .Where(src => filters.Publisher == null || src.Publisher == filters.Publisher)
                    .Where(src => filters.Author == null || src.Authors.Any(author => author.Name == filters.Author))
                    .Where(src => filters.Genre == null || src.Genres.Any(genre => genre.Name == filters.Genre))
                    .Where(src => filters.ISBN == null || src.ISBN == filters.ISBN);

            if (isAscending)
                return new KeyValuePair<List<Book>, int>(query
                    .OrderBy(src => EF.Property<Book>(src!, orderBy_value))
                    .ToList(), _context.Books.Count());

            return new KeyValuePair<List<Book>, int>(query
                .OrderByDescending(src => EF.Property<Book>(src!, orderBy_value))
                .ToList(), _context.Books.Count());
        }

        public Book? GetBookById(long id)
        {
            return _context.Books
                .Include(b => b.Authors)  
                .Include(b => b.Genres)   
                .FirstOrDefault(b => b.Id == id);
        }

        public Book? SaveBook(Book book, List<long> authorIds, List<long> genreIds)
        {
            if (GetBookById(book.Id) != null)
            {
                return null;
            }
            
            _context.Books.Add(book);

            foreach (long authorId in authorIds) {
                Author? author = _context.Authors.Find(authorId);
                if (author != null) {
                    book.Authors.Add(author);
                    author.Books.Add(book);
                }
            }

            foreach (long genreId in genreIds)
            {
                Genre? genre = _context.Genres.Find(genreId);
                if (genre != null)
                {
                    book.Genres.Add(genre);
                    genre.Books.Add(book);
                }
            }


            _context.SaveChanges();
            
            return book;
        }

        public void AddAuthorship(Book book, Author author)
        {
            book.Authors.Add(author);
            author.Books.Add(book);
            _context.SaveChanges();
        }

        public Book UpdateBook(Book book, List<long> authorIds, List<long> genreIds)
        {
            foreach (long authorId in authorIds)
            {
                Author? author = _context.Authors.Find(authorId);
                if (author != null)
                {
                    book.Authors.Add(author);
                    author.Books.Add(book);
                }
            }

            foreach (long genreId in genreIds)
            {
                Genre? genre = _context.Genres.Find(genreId);
                if (genre != null)
                {
                    book.Genres.Add(genre);
                    genre.Books.Add(book);
                }
            }


            _context.SaveChanges();

            return book;
        }

        public void RemoveBook(Book book)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}
