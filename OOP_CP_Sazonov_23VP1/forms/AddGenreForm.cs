using OOP_CP_Sazonov_23VP1.service;
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
    public partial class AddGenreForm : Form
    {
        private readonly GenreService _genreService;
        public AddGenreForm(GenreService genreService)
        {
            InitializeComponent();
            _genreService = genreService;
        }

        private void discardAddGenreButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveNewGenreButton_Click(object sender, EventArgs e)
        {
            try
            {
                string genreName = addGenreNameTextBox.Text;

                _genreService.SaveGenre(genreName);

                MessageBox.Show($"Жанр {genreName} успешно сохранен!", "Успех");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }
    }
}
