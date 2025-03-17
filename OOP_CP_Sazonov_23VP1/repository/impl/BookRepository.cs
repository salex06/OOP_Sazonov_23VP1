using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OOP_CP_Sazonov_23VP1.context;
using OOP_CP_Sazonov_23VP1.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.repository.impl
{
    class BookRepository : IBookRepository
    {
        private readonly LibraryDatabaseContext _context;

        public BookRepository(LibraryDatabaseContext context)
        {
            _context = context;
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.Select(src => src).ToList();
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
