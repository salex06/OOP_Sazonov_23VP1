using OOP_CP_Sazonov_23VP1.model.entity;

namespace OOP_CP_Sazonov_23VP1.repository
{
    public interface IBookRepository
    {
        /// <summary>
        /// Сохранить книгу
        /// </summary>
        /// <param name="book"></param>
        /// <param name="authorIds"></param>
        /// <param name="genreIds"></param>
        /// <returns></returns>
        public Book? SaveBook(Book book, List<long> authorIds, List<long> genreIds);
        /// <summary>
        /// Получить книгу по идентификатору
        /// </summary>
        /// <param name="id">идентфикатор книги</param>
        /// <returns>объект типа Book, если книга найдена, иначе - null</returns>
        public Book? GetBookById(long id);
        /// <summary>
        /// Получить все книги из БД
        /// </summary>
        /// <param name="orderBy_value">Поле, по которому проводится сортировка</param>
        /// <param name="isAscending">Сортировка по возрастанию/по убыванию</param>
        /// <param name="filters">фильтры для поиска книг с определенными значениями полей</param>
        /// <returns>Пара "список книг - общее количество книг в БД (без фильтрации)"</returns>
        public KeyValuePair<List<Book>, int> GetAllBooks(string orderBy_value, bool isAscending, dto.BookFilterOptions filters);
        /// <summary>
        /// Связать книгу с автором
        /// </summary>
        /// <param name="book">Книга</param>
        /// <param name="author">Автор книги</param>
        public void AddAuthorship(Book book, Author author);
        /// <summary>
        /// Обновить данные книги
        /// </summary>
        /// <param name="book">Книга</param>
        /// <param name="authorIds">Идентификаторы авторов книги</param>
        /// <param name="genreIds">Идентификаторы жанров книги</param>
        /// <returns>Объект класса Book - книга с обновленными данными</returns>
        public Book UpdateBook(Book book, List<long> authorIds, List<long> genreIds);
        /// <summary>
        /// Удалить книгу
        /// </summary>
        /// <param name="book">Удаляемая книга</param>
        public void RemoveBook(Book book);
    }
}