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
    public partial class ReturnBookForm : Form
    {
        private readonly LoanService _service;
        public ReturnBookForm(LoanService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            long bookId = (long)bookIdNumericUpDown.Value;
            try
            {
                _service.ReturnBook(bookId);
                MessageBox.Show("Книга возвращена!", "Успех");
                Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
