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
using static System.Reflection.Metadata.BlobBuilder;

namespace OOP_CP_Sazonov_23VP1.forms
{
    public partial class ReaderReportForm : Form
    {
        private readonly ReaderService _readerService;
        public ReaderReportForm(ReaderService readerService)
        {
            InitializeComponent();
            _readerService = readerService;
        }

        private void ReaderReportForm_Load(object sender, EventArgs e)
        {
            List<Reader> readers = _readerService.GetAllReaders("ID", true, new dto.ReaderFilterOptions()).Key;

            Panel labelPanel = new Panel();
            labelPanel.Dock = DockStyle.Top;
            Label bookReportLabel = new Label();
            bookReportLabel.AutoSize = false;
            bookReportLabel.Dock = DockStyle.Fill;
            bookReportLabel.TextAlign = ContentAlignment.MiddleCenter;
            bookReportLabel.Text = "Отчёт о читателях";
            bookReportLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labelPanel.Controls.Add(bookReportLabel);

            Panel countReadersPanel = new Panel();
            countReadersPanel.Dock = DockStyle.Top;
            Label countReadersLabel = new Label();
            countReadersLabel.AutoSize = true;
            countReadersLabel.Dock = DockStyle.Left;
            countReadersLabel.TextAlign = ContentAlignment.MiddleCenter;
            countReadersLabel.Text = $"Количество читателей: {readers.Count}";
            countReadersPanel.Controls.Add(countReadersLabel);

            Panel readersWithBooksPanel = new Panel();
            readersWithBooksPanel.Dock = DockStyle.Top;
            Label readersWithBooksLabel = new Label();
            readersWithBooksLabel.AutoSize = true;
            readersWithBooksLabel.Dock = DockStyle.Left;
            readersWithBooksLabel.TextAlign = ContentAlignment.MiddleCenter;
            readersWithBooksLabel.Text = $"Количество читателей с книгами на руках: {readers.Where(src => src.Loans.Any(loan => loan.ReturnDate == null)).Count()}";
            readersWithBooksPanel.Controls.Add(readersWithBooksLabel);


            Panel debtorsPanel = new Panel();
            debtorsPanel.Dock = DockStyle.Top;
            Label debtorsLabel = new Label();
            debtorsLabel.AutoSize = true;
            debtorsLabel.Dock = DockStyle.Left;
            debtorsLabel.TextAlign = ContentAlignment.MiddleCenter;
            debtorsLabel.Text = $"Количество должников: {readers.Where(src => src.Loans.Any(loan => loan.ReturnDate == null && loan.DueDate < DateTime.Now)).Count()}";
            debtorsPanel.Controls.Add(debtorsLabel);

            Controls.Add(debtorsPanel);
            Controls.Add(readersWithBooksPanel);
            Controls.Add(countReadersPanel);
            Controls.Add(labelPanel);
        }
    }
}
