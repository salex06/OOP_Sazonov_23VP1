using OOP_CP_Sazonov_23VP1.repository;
using OOP_CP_Sazonov_23VP1.service;
using OOP_CP_Sazonov_23VP1.model.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace OOP_CP_Sazonov_23VP1.forms
{
    public partial class NewAuthorForm : Form
    {
        private readonly AuthorService _authorService;
        public NewAuthorForm(AuthorService service)
        {
            InitializeComponent();
            _authorService = service;
        }

        private void discardAddAuthorButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveNewAuthorButton_Click(object sender, EventArgs e)
        {
            try
            {
                string authorName = addAuthorNameTextBox.Text;
                DateTime birthday = addAuthorsBirthdayTimePicker.Value.Date;

                _authorService.SaveAuthor(authorName, birthday);

                MessageBox.Show($"Автор {authorName} успешно сохранен!", "Успех");
                Close();
            }
            catch (Exception ex) {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }
    }
}
