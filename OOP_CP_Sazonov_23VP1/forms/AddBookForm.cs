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

namespace OOP_CP_Sazonov_23VP1.forms
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void addBookNewAuthorButton_Click(object sender, EventArgs e)
        {
            NewAuthorForm form = new NewAuthorForm();
            form.ShowDialog();
        }

        private void addBookNewGenreButton_Click(object sender, EventArgs e)
        {
            AddGenreForm form = new AddGenreForm();
            form.ShowDialog();
        }
    }
}
