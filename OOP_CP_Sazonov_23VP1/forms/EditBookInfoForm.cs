using OOP_CP_Sazonov_23VP1.tools.form_factories.add_author;
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
        private readonly IAddAuthorFormFactory _addAuthorFormFactory;
        public EditBookInfoForm(IAddAuthorFormFactory factory)
        {
            InitializeComponent();
            _addAuthorFormFactory = factory;
        }

        private void addNewAuthorButton_Click(object sender, EventArgs e)
        {
            NewAuthorForm form = _addAuthorFormFactory.Create();
            form.ShowDialog();
        }

        private void newGenreButton_Click(object sender, EventArgs e)
        {
            //AddGenreForm form = new AddGenreForm();
            //form.ShowDialog();
        }
    }
}
