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
    public partial class EditBookInfoForm : Form
    {
        public EditBookInfoForm()
        {
            InitializeComponent();
        }

        private void addNewAuthorButton_Click(object sender, EventArgs e)
        {
            NewAuthorForm form = new NewAuthorForm();
            form.ShowDialog();
        }

        private void newGenreButton_Click(object sender, EventArgs e)
        {
            AddGenreForm form = new AddGenreForm();
            form.ShowDialog();
        }
    }
}
