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
    public partial class GiveOutABookForm : Form
    {
        private readonly LoanService _loanService;
        private readonly ReaderService _readerService;
        public GiveOutABookForm(LoanService loanService, ReaderService readerService)
        {
            InitializeComponent();
            giveOutBookDueDateTimePicker.MinDate = DateTime.Now;
            _loanService = loanService;
            _readerService = readerService;
        }

        public void setBookId(long bookId) {
            giveBookIdNumericUpDown.Value = bookId;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void GiveOutABookForm_Load(object sender, EventArgs e)
        {
            List<Reader> readers = _readerService.GetAllReaders("ID", true, new dto.ReaderFilterOptions());

            foreach (Reader reader in readers)
            {
                AddReaderToTable(reader);
            }
        }

        private void AddReaderToTable(Reader reader)
        {
            long id = reader.ID;
            string name = reader.Name;
            string phone = reader.PhoneNumber;
            string address = reader.Address;

            availableReadersDataGridView.Rows.Add([
                id, name,
                phone, address,
                ]);
        }

        private void availableReadersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long readerId = (long) availableReadersDataGridView.Rows[e.RowIndex].Cells[0].Value;
            giveBookReaderIdNumericUpDown.Value = readerId;
        }
    }
}
