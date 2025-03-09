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
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace OOP_CP_Sazonov_23VP1.forms
{
    public partial class AddBookForm : Form
    {
        private readonly IAddAuthorFormFactory _addAuthorFormFactory;
        private readonly AuthorService _authorService;
        public AddBookForm(IAddAuthorFormFactory factory, AuthorService service)
        {
            InitializeComponent();
            _addAuthorFormFactory = factory;
            _authorService = service;
        }

        private void addBookNewAuthorButton_Click(object sender, EventArgs e)
        {
            NewAuthorForm form = _addAuthorFormFactory.Create();
            form.ShowDialog();
            AddBookForm_Load(sender, e);
        }

        private void addBookNewGenreButton_Click(object sender, EventArgs e)
        {
            AddGenreForm form = new AddGenreForm();
            form.ShowDialog();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            ClearListView(addAuthorsListView);

            List<Author> authors = _authorService.GetAllAuthors();
            addAuthorsListView.CheckBoxes = true;
            addAuthorsListView.View = View.Details;
            addAuthorsListView.FullRowSelect = true;
            addAuthorsListView.GridLines = true;
            addAuthorsListView.Columns.Add("Имя", 100);
            addAuthorsListView.Columns.Add("Дата рождения", 100);
            foreach (Author author in authors) {
                ListViewItem item = new ListViewItem(author.Name);
                item.SubItems.Add(author.Birthday.ToString());
                item.Tag = author.Id;
                addAuthorsListView.Items.Add(item);
            }

            ResizeListView(addAuthorsListView);
        }

        private void ClearListView(ListView view) {
            view.Columns.Clear();
            view.Items.Clear();
        }

        private void ResizeListView(ListView view) {
            int totalWidth = view.ClientSize.Width;
            int columnCount = view.Columns.Count;
            int columnWidth = totalWidth / columnCount;

            foreach (ColumnHeader column in view.Columns)
            {
                column.Width = columnWidth;
            }
        }
    }
}
