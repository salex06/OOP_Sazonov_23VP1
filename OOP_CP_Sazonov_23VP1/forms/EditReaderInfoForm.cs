using OOP_CP_Sazonov_23VP1.model.entity;
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
    public partial class EditReaderInfoForm : Form
    {
        private readonly ReaderService _service;
        public EditReaderInfoForm(ReaderService service)
        {
            InitializeComponent();
            _service = service;
        }

        public void SetReaderId(long readerId) {
            editReaderIdNumericUpDown.Value = readerId;
        }

        private void loadReaderInfoButton_Click(object sender, EventArgs e)
        {
            long id = (long)editReaderIdNumericUpDown.Value;
            Reader? reader = _service.GetReaderById(id);
            if (reader == null)
            {
                MessageBox.Show("Пользователь не найден", "Ошибка");
                return;
            }
            editReaderIdNumericUpDown.Tag = id;
            editReaderNameTextBox.Text = reader.Name;
            editPhoneNumberTextBox.Text = reader.PhoneNumber;
            editReaderAddressTextBox.Text = reader.Address;
        }

        private void discardEditReaderInfoButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveReaderChangesButton_Click(object sender, EventArgs e)
        {
            if (editReaderIdNumericUpDown.Tag == null) {
                MessageBox.Show("Выберите читателя!", "Ошибка");
                return;
            }
            long id = (long)editReaderIdNumericUpDown.Value;
            string name = editReaderNameTextBox.Text;
            string phoneNumber = editPhoneNumberTextBox.Text;
            string address = editReaderAddressTextBox.Text;

            if (_service.UpdateReader(id, name, phoneNumber, address) != null) {
                MessageBox.Show("Данные читателя изменены", "Успех");
                editReaderIdNumericUpDown.Tag = null;
                Close();
                return;
            }

            MessageBox.Show("Не удалось обновить данные читателя", "Ошибка");
        }
    }
}
