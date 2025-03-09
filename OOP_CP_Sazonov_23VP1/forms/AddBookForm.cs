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
using OOP_CP_Sazonov_23VP1.tools.form_factories.add_author;

namespace OOP_CP_Sazonov_23VP1.forms
{
    public partial class AddBookForm : Form
    {
        private readonly IAddAuthorFormFactory _addAuthorFormFactory;
        public AddBookForm(IAddAuthorFormFactory factory)
        {
            InitializeComponent();
            _addAuthorFormFactory = factory;
        }

        private void addBookNewAuthorButton_Click(object sender, EventArgs e)
        {
            NewAuthorForm form = _addAuthorFormFactory.Create();
            form.ShowDialog();
        }

        private void addBookNewGenreButton_Click(object sender, EventArgs e)
        {
            AddGenreForm form = new AddGenreForm();
            form.ShowDialog();
        }
    }
}
