using OOP_CP_Sazonov_23VP1.context;
using OOP_CP_Sazonov_23VP1.dto;
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
using static System.Reflection.Metadata.BlobBuilder;

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
        private readonly LoanService _loanService;
        private readonly BookService _bookService;
        private readonly ReaderService _readerService;
        private readonly AuthorService _authorService;
        private readonly GenreService _genreService;
        private readonly ReportService _reportService;
        private readonly ContextService _contextService;

        public MainLibraryForm(IAddBookFormFactory addBookFormFactory, IEditBookFormFactory editBookFormFactory,
            IRemoveBookFormFactory removeBookFormFactory, IAddReaderFormFactory addReaderFormFactory,
            IRemoveReaderFormFactory removeReaderFormFactory, IEditReaderInfoFormFactory editReaderInfoFormFactory,
            ILendBookFormFactory lendBookFormFactory, IReturnBookFormFactory returnBookFormFactory,
            BookService bookService, ReaderService readerService, AuthorService authorService, GenreService genreService,
            LoanService loanService, ReportService reportService, ContextService contextService)
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
            _readerService = readerService;
            _authorService = authorService;
            _genreService = genreService;
            _loanService = loanService;
            _reportService = reportService;
            _contextService = contextService;

            booksReviewDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm form = _addBookFormFactory.Create();
            form.ShowDialog();
            ReloadAuthorAndGenreList();
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
            ReloadAuthorAndGenreList();
        }

        private void ReloadAuthorAndGenreList()
        {
            authorNameComboBox.Items.Clear();
            List<string> authors = _authorService.GetAllAuthors().ConvertAll(src => src.Name);
            authorNameComboBox.Items.Add("");
            foreach (string authorName in authors)
            {
                authorNameComboBox.Items.Add(authorName);
            }

            genreComboBox.Items.Clear();
            List<string> genres = _genreService.GetAllGenres().ConvertAll(src => src.Name);
            genreComboBox.Items.Add("");
            foreach (string genreName in genres)
            {
                genreComboBox.Items.Add(genreName);
            }
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

            string orderBy_Value = "Id";
            foreach (RadioButton button in orderByPanel.Controls.OfType<RadioButton>())
            {
                if (button.Checked && button.Tag != null)
                {
                    orderBy_Value = (string)button.Tag;
                }
            }

            bool isAscendingOrder = (ascendingOrder.Checked ? true : false);

            string? title = string.IsNullOrEmpty(bookNameSelectTextBox.Text) ? null : bookNameSelectTextBox.Text;
            int? yearOfPublication = bookPublishingDateNumericUpDown.Value == 0 ? null : (int)bookPublishingDateNumericUpDown.Value;
            string? author = string.IsNullOrEmpty(authorNameComboBox.Text) ? null : authorNameComboBox.Text;
            string? genre = string.IsNullOrEmpty(genreComboBox.Text) ? null : genreComboBox.Text;
            string? isbn = string.IsNullOrEmpty(isbnValueTextBox.Text) ? null : isbnValueTextBox.Text;
            string? publisher = string.IsNullOrEmpty(bookPublisherNameTextBox.Text) ? null : bookPublisherNameTextBox.Text;

            BookFilterOptions filters = new BookFilterOptions
            {
                Title = title,
                YearOfPublication = yearOfPublication,
                Author = author,
                Genre = genre,
                ISBN = isbn,
                Publisher = publisher
            };

            KeyValuePair<List<Book>, int> books = _bookService.getAllBooks(orderBy_Value, isAscendingOrder, filters);
            foreach (Book book in books.Key)
            {
                AddBookToTable(book);
            }

            queryResultLabel.Visible = true;
            queryResultLabel.Text = $"Выбрано {books.Key.Count} записей из {books.Value}";
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

            int index = booksReviewDataGridView.Rows.Add([
                id, title,
                yearOfPublication, authors,
                genres, publisher,
                ISBN, readerId?.ToString() ?? "-",
                dueTime?.ToString() ?? "-"
            ]);

            DataGridViewRow row = booksReviewDataGridView.Rows[index];
            row.ContextMenuStrip = booksContextMenuStrip;
            row.Tag = id;
        }

        private void findReadersButton_Click(object sender, EventArgs e)
        {
            ClearTable(readersPreviewDataGridView);

            string orderBy_Value = "Id";
            foreach (RadioButton button in fieldOrderPanel.Controls.OfType<RadioButton>())
            {
                if (button.Checked && button.Tag != null)
                {
                    orderBy_Value = (string)button.Tag;
                }
            }

            string? name = string.IsNullOrEmpty(readerNameTextBox.Text) ? null : readerNameTextBox.Text;
            string? phone = string.IsNullOrEmpty(readerPhoneNumberTextBox.Text) ? null : readerPhoneNumberTextBox.Text;
            string? address = string.IsNullOrEmpty(readerAddressTextBox.Text) ? null : readerAddressTextBox.Text;
            bool? debtor = (isDebtorComboBox.Text == "Не важно") ? null : isDebtorComboBox.Text == "Да";

            ReaderFilterOptions filters = new ReaderFilterOptions
            {
                Name = name,
                PhoneNumber = phone,
                Address = address,
                isDebtor = debtor
            };

            bool isAscendingOrder = (ascendingReaderOrder.Checked ? true : false);

            KeyValuePair<List<Reader>, int> readers = _readerService.GetAllReaders(orderBy_Value, isAscendingOrder, filters);
            foreach (Reader reader in readers.Key)
            {
                AddReaderToTable(reader);
            }

            readerQueryResultLabel.Visible = true;
            readerQueryResultLabel.Text = $"Выбрано {readers.Key.Count} записей из {readers.Value}";
        }

        private void AddReaderToTable(Reader reader)
        {
            long id = reader.ID;
            string name = reader.Name;
            string phone = reader.PhoneNumber;
            string address = reader.Address;
            bool isDebtor = reader.Loans.Any(src => src.ReturnDate == null && src.DueDate < DateTime.Now);

            int index = readersPreviewDataGridView.Rows.Add([
                id, name,
                phone, address,
                isDebtor ? "Да" : "Нет"
                ]);

            DataGridViewRow row = readersPreviewDataGridView.Rows[index];
            row.ContextMenuStrip = readersContextMenuStrip;
            row.Tag = id;
        }

        private void MainLibraryForm_Load(object sender, EventArgs e)
        {
            List<string> authors = _authorService.GetAllAuthors().ConvertAll(src => src.Name);
            authorNameComboBox.Items.Add("");
            foreach (string authorName in authors)
            {
                authorNameComboBox.Items.Add(authorName);
            }

            List<string> genres = _genreService.GetAllGenres().ConvertAll(src => src.Name);
            genreComboBox.Items.Add("");
            foreach (string genreName in genres)
            {
                genreComboBox.Items.Add(genreName);
            }
        }

        private void bookReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _reportService.CreateBookReport();
        }

        private void readerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _reportService.CreateReaderReport();
        }

        private void debtorReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _reportService.CreateDebtorsReport();
        }

        private void removeBookContextStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView? dataGridView = (DataGridView)booksContextMenuStrip.SourceControl;
            if (dataGridView == null)
            {
                return;
            }

            int selectedRowIndex = dataGridView.CurrentCell.RowIndex;
            long? bookId = (long)dataGridView.Rows[selectedRowIndex].Tag;

            if (bookId != null && _bookService.RemoveBook((long)bookId))
            {
                MessageBox.Show("Книга удалена!", "Успех");
                dataGridView.Rows.RemoveAt(selectedRowIndex);
            }
            else
            {
                MessageBox.Show("Ошибка при удалении книги! Проверьте данные", "Ошибка");
            }
        }

        private void editBookContextStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBookInfoForm form = _editBookFormFactory.Create();
            DataGridView? dataGridView = (DataGridView)booksContextMenuStrip.SourceControl;
            if (dataGridView == null)
            {
                return;
            }

            int selectedRowIndex = dataGridView.CurrentCell.RowIndex;
            long? bookId = (long)dataGridView.Rows[selectedRowIndex].Tag;
            form.SetId(bookId);
            form.ShowDialog();
        }

        private void returnBookContextStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditBookInfoForm form = _editBookFormFactory.Create();
            DataGridView? dataGridView = (DataGridView)booksContextMenuStrip.SourceControl;
            if (dataGridView == null)
            {
                return;
            }

            int selectedRowIndex = dataGridView.CurrentCell.RowIndex;
            long? bookId = (long)dataGridView.Rows[selectedRowIndex].Tag;
            try
            {
                _loanService.ReturnBook((long)bookId);
                MessageBox.Show("Книга возвращена!", "Успех");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void giveOutBookContextStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView? dataGridView = (DataGridView)booksContextMenuStrip.SourceControl;
            if (dataGridView == null)
            {
                return;
            }

            int selectedRowIndex = dataGridView.CurrentCell.RowIndex;
            long? bookId = (long)dataGridView.Rows[selectedRowIndex].Tag;
            if (bookId == null) return;


            GiveOutABookForm form = _lendBookFormFactory.Create();
            form.setBookId((long)bookId);
            form.ShowDialog();
        }

        private void removeReaderContextStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView? dataGridView = (DataGridView)readersContextMenuStrip.SourceControl;
            if (dataGridView == null)
            {
                return;
            }

            int selectedRowIndex = dataGridView.CurrentCell.RowIndex;
            long? readerId = (long)dataGridView.Rows[selectedRowIndex].Tag;

            if (readerId != null && _readerService.RemoveReader((long)readerId))
            {
                MessageBox.Show("Читатель удален!", "Успех");
                dataGridView.Rows.RemoveAt(selectedRowIndex);
            }
            else
            {
                MessageBox.Show("Ошибка при удалении читателя! Проверьте данные", "Ошибка");
            }
        }

        private void editReaderContextStripMenuItem_Click(object sender, EventArgs e)
        {
            EditReaderInfoForm form = _editReaderInfoFormFactory.Create();
            DataGridView? dataGridView = (DataGridView)readersContextMenuStrip.SourceControl;
            if (dataGridView == null)
            {
                return;
            }

            int selectedRowIndex = dataGridView.CurrentCell.RowIndex;
            long? readerId = (long)dataGridView.Rows[selectedRowIndex].Tag;
            form.SetReaderId((long)readerId);
            form.ShowDialog();
        }

        private void clearDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите очистить базу данных?",
                "Очистка базы данных",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "SQLite Database Files (*.db;*.sqlite;*.s3db)|*.db;*.sqlite;*.s3db|All files (*.*)|*.*";
                saveFileDialog.Title = "Выберите место для сохранения резервной копии базы данных";
                saveFileDialog.DefaultExt = "db";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string destinationPath = saveFileDialog.FileName;
                        _contextService.SaveDatabase(destinationPath);
                        MessageBox.Show("Резервная копия базы данных успешно создана.", "Информация");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при создании резервной копии базы данных: {ex.Message}", "Ошибка");
                    }
                }
                _contextService.ClearDatabase();
                MessageBox.Show(
                    "Текущая база данных успешно очищена",
                    "Очистка базы данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                     MessageBoxDefaultButton.Button1
                    );
            }
        }

        private void saveDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "SQLite Database Files (*.db;*.sqlite;*.s3db)|*.db;*.sqlite;*.s3db|All files (*.*)|*.*";
            saveFileDialog.Title = "Выберите место для сохранения базы данных";
            saveFileDialog.DefaultExt = "db";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string destinationPath = saveFileDialog.FileName;
                    _contextService.SaveDatabase(destinationPath);
                    MessageBox.Show("База данных успешно сохранена.", "Информация");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении базы данных: {ex.Message}", "Ошибка");
                }
            }
        }
    }
}
