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
    /// Форма для удаления книги из системы
    /// </summary>
    public partial class RemoveBookForm : Form
    {
        private readonly BookService _bookService;
        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="bookService">Сервис, обрабатывающий сущности "Книга"</param>
        public RemoveBookForm(BookService bookService)
        {
            InitializeComponent();
            _bookService = bookService;
        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            long bookId = (long) deleteBookIdNumericUpDown.Value;

            if (_bookService.RemoveBook(bookId))
            {
                MessageBox.Show("Книга удалена!", "Успех");
                Close();
            }
            else {
                MessageBox.Show("Ошибка при удалении книги! Проверьте данные", "Ошибка");
            }
        }
    }
}
