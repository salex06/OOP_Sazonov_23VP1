using OOP_CP_Sazonov_23VP1.forms;
using OOP_CP_Sazonov_23VP1.tools.form_factories.add_book;
using OOP_CP_Sazonov_23VP1.tools.form_factories.add_reader;
using OOP_CP_Sazonov_23VP1.tools.form_factories.edit_book;
using OOP_CP_Sazonov_23VP1.tools.form_factories.edit_reader;
using OOP_CP_Sazonov_23VP1.tools.form_factories.lend_book;
using OOP_CP_Sazonov_23VP1.tools.form_factories.remove_book;
using OOP_CP_Sazonov_23VP1.tools.form_factories.remove_reader;

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

        public MainLibraryForm(IAddBookFormFactory addBookFormFactory, IEditBookFormFactory editBookFormFactory, 
            IRemoveBookFormFactory removeBookFormFactory, IAddReaderFormFactory addReaderFormFactory,
            IRemoveReaderFormFactory removeReaderFormFactory, IEditReaderInfoFormFactory editReaderInfoFormFactory,
            ILendBookFormFactory lendBookFormFactory)
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
            ReturnBookForm form = new ReturnBookForm();
            form.ShowDialog();
        }

        private void editReaderDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditReaderInfoForm form = _editReaderInfoFormFactory.Create();
            form.ShowDialog();
        }
    }
}
