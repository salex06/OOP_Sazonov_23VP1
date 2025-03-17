using OOP_CP_Sazonov_23VP1.forms;
using OOP_CP_Sazonov_23VP1.tools.form_factories.add_book;
using OOP_CP_Sazonov_23VP1.tools.form_factories.edit_book;

namespace OOP_CP_Sazonov_23VP1
{
    public partial class MainLibraryForm : Form
    {
        private readonly IAddBookFormFactory _addBookFormFactory;
        private readonly IEditBookFormFactory _editBookFormFactory;

        public MainLibraryForm(IAddBookFormFactory addBookFormFactory, IEditBookFormFactory editBookFormFactory)
        {
            InitializeComponent();
            StartForm start = new StartForm();
            start.ShowDialog();
            _addBookFormFactory = addBookFormFactory;
            _editBookFormFactory = editBookFormFactory;
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm form = _addBookFormFactory.Create();
            form.ShowDialog();
        }

        private void removeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveBookForm form = new RemoveBookForm();
            form.ShowDialog();
        }

        private void giveOutBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiveOutABookForm form = new GiveOutABookForm();
            form.ShowDialog();
        }

        private void editBookInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBookInfoForm form = _editBookFormFactory.Create();
            form.ShowDialog();
        }

        private void addReadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReaderForm form = new AddReaderForm();
            form.ShowDialog();
        }

        private void removeReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveReaderForm form = new RemoveReaderForm();
            form.ShowDialog();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBookForm form = new ReturnBookForm();
            form.ShowDialog();
        }

        private void editReaderDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditReaderInfoForm form = new EditReaderInfoForm();
            form.ShowDialog();
        }
    }
}
