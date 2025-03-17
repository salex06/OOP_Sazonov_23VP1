using OOP_CP_Sazonov_23VP1.model.entity;

namespace OOP_CP_Sazonov_23VP1.repository
{
    public interface IBookRepository
    {
        public Book? SaveBook(Book book, List<long> authorIds, List<long> genreIds);
        public Book? GetBookById(long id);
        public List<Book> GetAllBooks();
        public void AddAuthorship(Book book, Author author);
        public Book UpdateBook(Book book, List<long> authorIds, List<long> genreIds);
        public void RemoveBook(Book book);
    }
}