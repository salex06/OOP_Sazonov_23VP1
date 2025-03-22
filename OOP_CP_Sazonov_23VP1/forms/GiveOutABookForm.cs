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
    public partial class GiveOutABookForm : Form
    {
        private readonly LoanService _loanService;
        public GiveOutABookForm(LoanService loanService)
        {
            InitializeComponent();
            giveOutBookDueDateTimePicker.MinDate = DateTime.Now;
            _loanService = loanService;
        }

        private void giveOutABookButton_Click(object sender, EventArgs e)
        {
            long bookId = (long)giveBookIdNumericUpDown.Value;
            long readerId = (long)giveBookReaderIdNumericUpDown.Value;
            DateTime dueDate = giveOutBookDueDateTimePicker.Value;

            try
            {
                _loanService.LendBook(readerId, bookId, dueDate);
                MessageBox.Show("Книга успешно выдана!", "Успех");
                Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
