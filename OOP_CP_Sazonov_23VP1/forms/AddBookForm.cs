using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_CP_Sazonov_23VP1.forms;
using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.service;
using OOP_CP_Sazonov_23VP1.tools.form_factories.add_author;
using OOP_CP_Sazonov_23VP1.tools.form_factories.add_genre;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace OOP_CP_Sazonov_23VP1.forms
{
    public partial class AddBookForm : Form
    {
        private readonly IAddAuthorFormFactory _addAuthorFormFactory;
        private readonly IAddGenreFormFactory _addGenreFormFactory;
        private readonly AuthorService _authorService;
        private readonly GenreService _genreService;
        private readonly BookService _bookService;
        public AddBookForm(IAddAuthorFormFactory authorFactory, IAddGenreFormFactory genreFactory, AuthorService service, GenreService genreService, BookService bookService)
        {
            InitializeComponent();
            _addAuthorFormFactory = authorFactory;
            _addGenreFormFactory = genreFactory;
            _authorService = service;
            _genreService = genreService;
            _bookService = bookService;
        }

        private void addBookNewAuthorButton_Click(object sender, EventArgs e)
        {
            NewAuthorForm form = _addAuthorFormFactory.Create();
            form.ShowDialog();
            LoadAuthors();
        }

        private void addBookNewGenreButton_Click(object sender, EventArgs e)
        {
            AddGenreForm form = _addGenreFormFactory.Create();
            form.ShowDialog();
            LoadGenres();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            LoadAuthors();
            LoadGenres();
        }

        private void LoadAuthors()
        {
            ClearListView(addAuthorsListView);

            List<Author> authors = _authorService.GetAllAuthors();
            addAuthorsListView.CheckBoxes = true;
            addAuthorsListView.View = View.Details;
            addAuthorsListView.FullRowSelect = true;
            addAuthorsListView.GridLines = true;
            addAuthorsListView.Columns.Add("Имя", 100);
            addAuthorsListView.Columns.Add("Дата рождения", 100);
            foreach (Author author in authors)
            {
                ListViewItem item = new ListViewItem(author.Name);
                item.SubItems.Add(author.Birthday.ToString());
                item.Tag = author.Id;
                addAuthorsListView.Items.Add(item);
            }

            ResizeListView(addAuthorsListView);
        }

        private void LoadGenres()
        {
            ClearListView(addGenresListView);

            List<Genre> genres = _genreService.GetAllGenres();
            addGenresListView.CheckBoxes = true;
            addGenresListView.View = View.Details;
            addGenresListView.FullRowSelect = true;
            addGenresListView.GridLines = true;
            addGenresListView.Columns.Add("Название", 100);
            foreach (Genre genre in genres)
            {
                ListViewItem item = new ListViewItem(genre.Name);
                item.Tag = genre.ID;
                addGenresListView.Items.Add(item);
            }

            ResizeListView(addGenresListView);
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

        private void discardAddBookButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveNewBookButton_Click(object sender, EventArgs e)
        {
            string bookName = addBookNameTextBox.Text;
            int yearOfPublishing = (int)addDateOfPublishingNumericUpDown.Value;
            string publisher = addPublisherTextBox.Text;
            string ISBN = addIsbnTextBox.Text;

            Book? savedBook = _bookService.saveBook(bookName, yearOfPublishing, publisher, ISBN);

            MessageBox.Show("Книга добавлена!", "Успех");
            Close();
        }
    }
}
