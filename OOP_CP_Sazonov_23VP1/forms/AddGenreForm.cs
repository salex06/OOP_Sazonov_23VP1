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
    /// <summary>
    /// Форма для сохранения нового жанра в систему
    /// </summary>
    public partial class AddGenreForm : Form
    {
        private readonly GenreService _genreService;
        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="genreService">Сервис, отвечающий за выполнение бизнес-логики для сущности "Жанр"</param>
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
