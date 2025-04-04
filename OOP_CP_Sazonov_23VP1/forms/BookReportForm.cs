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
    public partial class BookReportForm : Form
    {
        private readonly BookService _bookService;
        public BookReportForm(BookService bookService)
        {
            InitializeComponent();
            _bookService = bookService;
        }

        private void BookReportForm_Load(object sender, EventArgs e)
        {
            List<Book> books = _bookService.getAllBooks("Id", true, new dto.BookFilterOptions()).Key;
            Panel labelPanel = new Panel();
            labelPanel.Dock = DockStyle.Top;
            Label bookReportLabel = new Label();
            bookReportLabel.AutoSize = false;
            bookReportLabel.Dock = DockStyle.Fill;
            bookReportLabel.TextAlign = ContentAlignment.MiddleCenter;
            bookReportLabel.Text = "Отчёт о книгах";
            bookReportLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labelPanel.Controls.Add(bookReportLabel);
           

            Panel countBooksPanel = new Panel();
            countBooksPanel.Dock = DockStyle.Top;
            Label countBookLabel = new Label();
            countBookLabel.AutoSize = true;
            countBookLabel.Dock = DockStyle.Left;
            countBookLabel.TextAlign = ContentAlignment.MiddleCenter;
            countBookLabel.Text = $"Количество книг: {books.Count}";
            countBooksPanel.Controls.Add(countBookLabel);

            Panel issuedBooksCountPanel = new Panel();
            issuedBooksCountPanel.Dock = DockStyle.Top;
            Label issuedBookLabel = new Label();
            issuedBookLabel.AutoSize = true;
            issuedBookLabel.Dock = DockStyle.Left;
            issuedBookLabel.TextAlign = ContentAlignment.MiddleCenter;
            issuedBookLabel.Text = $"Выдано книг в данный момент: {books.Where(src => src.Loans.Any(loan => loan.ReturnDate == null)).Count()}";
            issuedBooksCountPanel.Controls.Add(issuedBookLabel);


            Panel notIssuedBooksCountPanel = new Panel();
            notIssuedBooksCountPanel.Dock = DockStyle.Top;
            Label notIssuedBookLabel = new Label();
            notIssuedBookLabel.AutoSize = true;
            notIssuedBookLabel.Dock = DockStyle.Left;
            notIssuedBookLabel.TextAlign = ContentAlignment.MiddleCenter;
            notIssuedBookLabel.Text = $"Количество книг в библиотеке в данный момент: {books.Where(src => !src.Loans.Any(loan => loan.ReturnDate == null)).Count()}";
            notIssuedBooksCountPanel.Controls.Add(notIssuedBookLabel);

            Panel delayedBooksCountPanel = new Panel();
            delayedBooksCountPanel.Dock = DockStyle.Top;
            Label delayedBookLabel = new Label();
            delayedBookLabel.AutoSize = true;
            delayedBookLabel.Dock = DockStyle.Left;
            delayedBookLabel.TextAlign = ContentAlignment.MiddleCenter;
            delayedBookLabel.Text = $"Количество книг, срок сдачи которых прошел: {books.Where(src => !src.Loans.Any(loan => loan.ReturnDate == null && loan.DueDate < DateTime.Now)).Count()}";
            delayedBooksCountPanel.Controls.Add(delayedBookLabel);

            Controls.Add(delayedBooksCountPanel);
            Controls.Add(notIssuedBooksCountPanel);
            Controls.Add(issuedBooksCountPanel);
            Controls.Add(countBooksPanel);
            Controls.Add(labelPanel);
        }
    }
}
