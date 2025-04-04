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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_CP_Sazonov_23VP1.forms
{
    public partial class DebtorsReportForm : Form
    {
        private readonly ReaderService _readerService;
        public DebtorsReportForm(ReaderService readerService)
        {
            InitializeComponent();
            _readerService = readerService;
        }

        private void DebtorsReportForm_Load(object sender, EventArgs e)
        {
            List<Reader> debtors = _readerService.GetAllReaders("ID", true, new dto.ReaderFilterOptions()).Key
                .Where(reader => reader.Loans.Any(loan => loan.ReturnDate == null && loan.DueDate < DateTime.Now)).ToList();

            Panel labelPanel = new Panel();
            labelPanel.Dock = DockStyle.Top;
            Label debtorReportLabel = new Label();
            debtorReportLabel.AutoSize = false;
            debtorReportLabel.Dock = DockStyle.Fill;
            debtorReportLabel.TextAlign = ContentAlignment.MiddleCenter;
            debtorReportLabel.Text = "Отчёт о должниках";
            debtorReportLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labelPanel.Controls.Add(debtorReportLabel);

            foreach (Reader debtor in debtors) {
                Panel debtorPanel = new Panel();
                debtorPanel.Dock = DockStyle.Top;
                Label debtorInfo = new Label();
                debtorInfo.AutoSize = true;
                debtorInfo.Dock = DockStyle.Left;
                debtorInfo.Text = $"""
                    Читатель: {debtor.Name} (ID: {debtor.ID}).
                        Номер телефона: {debtor.PhoneNumber}. 
                        Адрес: {debtor.Address}.
                    """;
                debtorPanel.Controls.Add(debtorInfo);
                Controls.Add(debtorPanel);
            }

            Controls.Add(labelPanel);
        }
    }
}
