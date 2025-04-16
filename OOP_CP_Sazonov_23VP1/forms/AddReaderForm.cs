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
    /// Форма для добавления читателя в систему
    /// </summary>
    public partial class AddReaderForm : Form
    {
        private readonly ReaderService _service;
        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="service">Сервис, отвечающий за выполнение бизнес-логики для сущностей "Читатель"</param>
        public AddReaderForm(ReaderService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void discardAddReaderButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveNewReaderButton_Click(object sender, EventArgs e)
        {
            string readerName = readerNameTextBox.Text;
            string phoneNumber = readerPhoneTextBox.Text;
            string address = readerAddressTextBox.Text;

            _service.SaveReader(readerName, phoneNumber, address);

            MessageBox.Show("Читатель добавлен", "Успех");
            Close();
        }
    }
}
