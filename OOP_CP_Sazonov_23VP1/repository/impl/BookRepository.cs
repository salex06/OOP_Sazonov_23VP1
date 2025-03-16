using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OOP_CP_Sazonov_23VP1.context;
using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.model.orm;
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
        private readonly IMapper _mapper;

        public BookRepository(LibraryDatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.Select(src => _mapper.Map<Book>(src)).ToList();
        }

        public Book? GetBookById(long id)
        {
            BookDb? bookDb = _context.Books.Find(id);
            return (bookDb != null) ? _mapper.Map<Book>(bookDb) : null;
        }

        public Book? SaveBook(Book book)
        {
            if (GetBookById(book.Id) != null)
            {
                return null;
            }

            var bookDb = _mapper.Map<BookDb>(book);
            _context.Books.Add(bookDb);
            _context.SaveChanges();
            
            var savedBook = _mapper.Map<Book>(bookDb);
            return savedBook;
        }

        public void UpdateBook(Book book)
        {
            var bookDb = _mapper.Map<BookDb>(book);

            var existingAuthorships = _context.Authorships.Where(a => a.BookId == bookDb.Id).ToList();

            foreach (var authorship in existingAuthorships)
            {
                if (!book.Authorships.Any(a => a.Id == authorship.AuthorId)) 
                {
                    _context.Authorships.Remove(authorship);
                }
            }

            foreach (var author in book.Authorships)
            {
                if (!existingAuthorships.Any(a => a.AuthorId == author.Id))
                {
                    var authorshipDb = new AuthorshipDb { BookId = bookDb.Id, AuthorId = author.Id }; 
                    _context.Authorships.Add(authorshipDb);
                }
            }

            var existingGenre = _context.BookGenres.Where(a => a.BookId == bookDb.Id).ToList(); 

            foreach (var genre in existingGenre)
            {
                if (!book.Genres.Any(a => a.Id == genre.GenreId))
                {
                    _context.BookGenres.Remove(genre); 
                }
            }

            foreach (var genre in book.Genres)
            {
                if (!existingGenre.Any(a => a.GenreId == genre.Id))
                {
                    var bookGenreDb = new BookGenresDb { BookId = bookDb.Id, GenreId = genre.Id };
                    _context.BookGenres.Add(bookGenreDb);
                }
            }

            _context.SaveChanges();
        }

        public Authorship? SaveAuthorship(Authorship authorship)
        {
            var authorshipDb = _mapper.Map<AuthorshipDb>(authorship);
            _context.Authorships.Add(authorshipDb);
            _context.SaveChanges();

            var savedAuthorship = _mapper.Map<Authorship>(authorshipDb);
            return savedAuthorship;
        }

        public BookGenres? SaveBookGenre(BookGenres bookGenres)
        {
            var bookGenresDb = _mapper.Map<BookGenresDb>(bookGenres);
            _context.BookGenres.Add(bookGenresDb);
            _context.SaveChanges();

            var savedGenres = _mapper.Map<BookGenres>(bookGenresDb);
            return savedGenres;
        }
    }
}
