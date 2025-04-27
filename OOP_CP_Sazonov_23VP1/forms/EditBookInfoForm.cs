using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.repository;
using OOP_CP_Sazonov_23VP1.service;
using OOP_CP_Sazonov_23VP1.tools.form_factories.add_author;
using OOP_CP_Sazonov_23VP1.tools.form_factories.add_genre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_CP_Sazonov_23VP1.forms
{
    /// <summary>
    /// Форма для изменения информации о книге в системе
    /// </summary>
    public partial class EditBookInfoForm : Form
    {
        private readonly IAddAuthorFormFactory _addAuthorFormFactory;
        private readonly IAddGenreFormFactory _addGenreFormFactory;
        private readonly AuthorService _authorService;
        private readonly GenreService _genreService;
        private readonly BookService _bookService;
        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="addAuthorFormFactory">фабрика для создания формы добавления автора</param>
        /// <param name="addGenreFormFactory">фабрика для создания формы добавления жанра</param>
        /// <param name="authorService">Сервис для обработки сущностей "Автор"</param>
        /// <param name="genreService">Сервис для обработки сущностей "Жанр"</param>
        /// <param name="bookService">Сервис для обработки сущностей "Книга"</param>
        public EditBookInfoForm(IAddAuthorFormFactory addAuthorFormFactory, IAddGenreFormFactory addGenreFormFactory,
            AuthorService authorService, GenreService genreService, BookService bookService)
        {
            InitializeComponent();
            _addAuthorFormFactory = addAuthorFormFactory;
            _addGenreFormFactory = addGenreFormFactory;
            _authorService = authorService;
            _genreService = genreService;
            _bookService = bookService;
        }

        /// <summary>
        /// Установить в поле editBookIdNumericUpDown значение
        /// переданного идентификатора
        /// </summary>
        /// <param name="bookId">Идентификатор книги</param>
        public void SetId(long? bookId) {
            if (bookId == null) {
                return;
            }
            editBookIdNumericUpDown.Value = (long)bookId;
        }

        private void addNewAuthorButton_Click(object sender, EventArgs e)
        {
            NewAuthorForm form = _addAuthorFormFactory.Create();
            form.ShowDialog();
        }

        private void newGenreButton_Click(object sender, EventArgs e)
        {
            AddGenreForm form = _addGenreFormFactory.Create();
            form.ShowDialog();
        }

        private void discardBookChangesButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editBookLoadDataButton_Click(object sender, EventArgs e)
        {
            long id = (long)editBookIdNumericUpDown.Value;
            
            Book? book = _bookService.getBookById(id);

            if (book == null)
            {
                MessageBox.Show("Книга не найдена!", "Ошибка");
                return;
            }

            editBookTitleTextBox.Text = book.Title;
            editDateOfPublishingNumericUpDown.Value = book.YearOfPublication;
            editPublisherTextBox.Text = book.Publisher;
            editIsbnTextBox.Text = book.ISBN;

            LoadAuthors(book.Authors);
            LoadGenres(book.Genres);
        }

        private void LoadAuthors(ICollection<Author> bookAuthors)
        {
            ClearListView(editAuthorsListView);

            List<Author> authors = _authorService.GetAllAuthors();
            editAuthorsListView.CheckBoxes = true;
            editAuthorsListView.View = View.Details;
            editAuthorsListView.FullRowSelect = true;
            editAuthorsListView.GridLines = true;
            editAuthorsListView.Columns.Add("Имя", 100);
            editAuthorsListView.Columns.Add("Дата рождения", 100);
            foreach (Author author in authors)
            {
                ListViewItem item = new ListViewItem(author.Name);
                item.SubItems.Add(author.Birthday.ToString());
                item.Tag = author.Id;
                item.Checked = bookAuthors.Contains(author);
                editAuthorsListView.Items.Add(item);
            }

            ResizeListView(editAuthorsListView);
        }

        private void LoadGenres(ICollection<Genre> bookGenres)
        {
            ClearListView(editGenresListView);

            List<Genre> genres = _genreService.GetAllGenres();
            editGenresListView.CheckBoxes = true;
            editGenresListView.View = View.Details;
            editGenresListView.FullRowSelect = true;
            editGenresListView.GridLines = true;
            editGenresListView.Columns.Add("Название", 100);
            foreach (Genre genre in genres)
            {
                ListViewItem item = new ListViewItem(genre.Name);
                item.Tag = genre.ID;
                item.Checked = bookGenres.Contains(genre);
                editGenresListView.Items.Add(item);
            }

            ResizeListView(editGenresListView);
        }

        private void ClearListView(ListView view)
        {
            view.Columns.Clear();
            view.Items.Clear();
        }

        private void ResizeListView(ListView view)
        {
            int totalWidth = view.ClientSize.Width;
            int columnCount = view.Columns.Count;
            int columnWidth = totalWidth / columnCount;

            foreach (ColumnHeader column in view.Columns)
            {
                column.Width = columnWidth;
            }
        }

        private void saveBookChangesButton_Click(object sender, EventArgs e)
        {
            long bookId = (long)editBookIdNumericUpDown.Value;
            string bookName = editBookTitleTextBox.Text;
            int yearOfPublishing = (int)editDateOfPublishingNumericUpDown.Value;
            string publisher = editPublisherTextBox.Text;
            string ISBN = editIsbnTextBox.Text;

            List<long> authorIds = new List<long>();
            foreach (ListViewItem item in editAuthorsListView.Items)
            {
                if (item.Checked && item.Tag != null)
                {
                    authorIds.Add((long)item.Tag);
                }
            }

            List<long> genreIds = new List<long>();
            foreach (ListViewItem item in editGenresListView.Items)
            {
                if (item.Checked && item.Tag != null)
                {
                    genreIds.Add((long)item.Tag);
                }
            }

            Book? book = _bookService.UpdateBook(bookId, bookName, yearOfPublishing, publisher, ISBN, authorIds, genreIds);

            if (book == null)
            {
                MessageBox.Show("Ошибка редактирования книги! Проверьте данные", "Ошибка");
                return;
            }

            MessageBox.Show("Данные книги изменены!", "Успех");
            Close();
        }
    }
}
