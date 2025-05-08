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
    /// Форма для удаления читателя из системы
    /// </summary>
    public partial class RemoveReaderForm : Form
    {
        private readonly ReaderService _service;
        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="service">Сервис, обрабатывающий сущности "Читатель"</param>
        public RemoveReaderForm(ReaderService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void removeReaderButton_Click(object sender, EventArgs e)
        {
            long id = (long) readerIdNumericUpDown.Value;

            if (_service.RemoveReader(id)) {
                MessageBox.Show("Пользователь удалён!", "Успех");
                Close();
                return;
            }
            MessageBox.Show("Пользователь не найден", "Ошибка");
        }
    }
}
