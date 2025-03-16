using OOP_CP_Sazonov_23VP1.model.entity;

namespace OOP_CP_Sazonov_23VP1.repository
{
    public interface IBookRepository
    {
        public Book? SaveBook(Book book);
        public Book? GetBookById(long id);
        public List<Book> GetAllBooks();
        public void UpdateBook(Book book);
        public Authorship? SaveAuthorship(Authorship authorship);
        public BookGenres? SaveBookGenre(BookGenres bookGenres);
    }
}