using OOP_CP_Sazonov_23VP1.forms;
using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.service;
using OOP_CP_Sazonov_23VP1.tools.form_factories.add_book;
using OOP_CP_Sazonov_23VP1.tools.form_factories.add_reader;
using OOP_CP_Sazonov_23VP1.tools.form_factories.edit_book;
using OOP_CP_Sazonov_23VP1.tools.form_factories.edit_reader;
using OOP_CP_Sazonov_23VP1.tools.form_factories.lend_book;
using OOP_CP_Sazonov_23VP1.tools.form_factories.remove_book;
using OOP_CP_Sazonov_23VP1.tools.form_factories.remove_reader;
using OOP_CP_Sazonov_23VP1.tools.form_factories.return_book;
using System.Windows.Forms;

namespace OOP_CP_Sazonov_23VP1
{
    public partial class MainLibraryForm : Form
    {
        private readonly IAddBookFormFactory _addBookFormFactory;
        private readonly IEditBookFormFactory _editBookFormFactory;
        private readonly IRemoveBookFormFactory _removeBookFormFactory;
        private readonly IAddReaderFormFactory _addReaderFormFactory;
        private readonly IRemoveReaderFormFactory _removeReaderFormFactory;
        private readonly IEditReaderInfoFormFactory _editReaderInfoFormFactory;
        private readonly ILendBookFormFactory _lendBookFormFactory;
        private readonly IReturnBookFormFactory _returnBookFormFactory;
        private readonly BookService _bookService;

        public MainLibraryForm(IAddBookFormFactory addBookFormFactory, IEditBookFormFactory editBookFormFactory,
            IRemoveBookFormFactory removeBookFormFactory, IAddReaderFormFactory addReaderFormFactory,
            IRemoveReaderFormFactory removeReaderFormFactory, IEditReaderInfoFormFactory editReaderInfoFormFactory,
            ILendBookFormFactory lendBookFormFactory, IReturnBookFormFactory returnBookFormFactory, 
            BookService bookService)
        {
            InitializeComponent();
            StartForm start = new StartForm();
            start.ShowDialog();
            _addBookFormFactory = addBookFormFactory;
            _editBookFormFactory = editBookFormFactory;
            _removeBookFormFactory = removeBookFormFactory;
            _addReaderFormFactory = addReaderFormFactory;
            _removeReaderFormFactory = removeReaderFormFactory;
            _editReaderInfoFormFactory = editReaderInfoFormFactory;
            _lendBookFormFactory = lendBookFormFactory;
            _returnBookFormFactory = returnBookFormFactory;
            _bookService = bookService;

            booksReviewDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm form = _addBookFormFactory.Create();
            form.ShowDialog();
        }

        private void removeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveBookForm form = _removeBookFormFactory.Create();
            form.ShowDialog();
        }

        private void giveOutBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiveOutABookForm form = _lendBookFormFactory.Create();
            form.ShowDialog();
        }

        private void editBookInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBookInfoForm form = _editBookFormFactory.Create();
            form.ShowDialog();
        }

        private void addReadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReaderForm form = _addReaderFormFactory.Create();
            form.ShowDialog();
        }

        private void removeReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveReaderForm form = _removeReaderFormFactory.Create();
            form.ShowDialog();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBookForm form = _returnBookFormFactory.Create();
            form.ShowDialog();
        }

        private void editReaderDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditReaderInfoForm form = _editReaderInfoFormFactory.Create();
            form.ShowDialog();
        }

        private void findBookButton_Click(object sender, EventArgs e)
        {
            ClearTable(booksReviewDataGridView);
            List<Book> books = _bookService.getAllBooks();
            foreach (Book book in books)
            {
                AddBookToTable(book);
            }
        }

        private void ClearTable(DataGridView table)
        {
            table.Rows.Clear();
        }

        private void AddBookToTable(Book book)
        {
            long id = book.Id;
            string title = book.Title;
            int yearOfPublication = book.YearOfPublication;
            string authors = String.Join(", ", book.Authors.Select(i => i.Name).ToList());
            string genres = String.Join(", ", book.Genres.Select(i => i.Name).ToList());
            string publisher = book.Publisher;
            string ISBN = book.ISBN;
            Loan? activeLoan = book.Loans.SingleOrDefault(i => i.ReturnDate == null);
            long? readerId = null;
            DateOnly? dueTime = null;
            if (activeLoan != null)
            {
                readerId = activeLoan.ReaderId;
                dueTime = DateOnly.FromDateTime(activeLoan.DueDate.Date);
            }

            booksReviewDataGridView.Rows.Add([
                id, title, 
                yearOfPublication, authors, 
                genres, publisher, 
                ISBN, readerId?.ToString() ?? "-", 
                dueTime?.ToString() ?? "-"
            ]);
        }

    }
}
