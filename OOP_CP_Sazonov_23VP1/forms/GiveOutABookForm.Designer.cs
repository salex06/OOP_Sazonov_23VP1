namespace OOP_CP_Sazonov_23VP1.forms
{
    partial class GiveOutABookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            giveBookDataPanel = new Panel();
            giveBookIdNumericUpDown = new NumericUpDown();
            giveBookIdLabel = new Label();
            giveOutBookReaderIdPanel = new Panel();
            giveBookReaderIdNumericUpDown = new NumericUpDown();
            giveBookReaderIdLabel = new Label();
            giveBookActions = new Panel();
            giveOutABookButton = new Button();
            giveOutBookDueDatePanel = new Panel();
            giveOutBookDueDateTimePicker = new DateTimePicker();
            giveOutBookDueDateLabel = new Label();
            availableReadersDataGridView = new DataGridView();
            readerId = new DataGridViewTextBoxColumn();
            readerName = new DataGridViewTextBoxColumn();
            phoneNumber = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            availableReadersPanel = new Panel();
            availableReadersLabel = new Label();
            giveBookDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)giveBookIdNumericUpDown).BeginInit();
            giveOutBookReaderIdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)giveBookReaderIdNumericUpDown).BeginInit();
            giveBookActions.SuspendLayout();
            giveOutBookDueDatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)availableReadersDataGridView).BeginInit();
            availableReadersPanel.SuspendLayout();
            SuspendLayout();
            // 
            // giveBookDataPanel
            // 
            giveBookDataPanel.Controls.Add(giveBookIdNumericUpDown);
            giveBookDataPanel.Controls.Add(giveBookIdLabel);
            giveBookDataPanel.Dock = DockStyle.Top;
            giveBookDataPanel.Location = new Point(0, 0);
            giveBookDataPanel.Name = "giveBookDataPanel";
            giveBookDataPanel.Size = new Size(548, 75);
            giveBookDataPanel.TabIndex = 0;
            // 
            // giveBookIdNumericUpDown
            // 
            giveBookIdNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            giveBookIdNumericUpDown.Location = new Point(346, 23);
            giveBookIdNumericUpDown.Name = "giveBookIdNumericUpDown";
            giveBookIdNumericUpDown.Size = new Size(190, 31);
            giveBookIdNumericUpDown.TabIndex = 1;
            // 
            // giveBookIdLabel
            // 
            giveBookIdLabel.Dock = DockStyle.Left;
            giveBookIdLabel.Location = new Point(0, 0);
            giveBookIdLabel.Name = "giveBookIdLabel";
            giveBookIdLabel.Size = new Size(330, 75);
            giveBookIdLabel.TabIndex = 0;
            giveBookIdLabel.Text = "Введите Id книги для выдачи:";
            giveBookIdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // giveOutBookReaderIdPanel
            // 
            giveOutBookReaderIdPanel.Controls.Add(giveBookReaderIdNumericUpDown);
            giveOutBookReaderIdPanel.Controls.Add(giveBookReaderIdLabel);
            giveOutBookReaderIdPanel.Dock = DockStyle.Top;
            giveOutBookReaderIdPanel.Location = new Point(0, 75);
            giveOutBookReaderIdPanel.Name = "giveOutBookReaderIdPanel";
            giveOutBookReaderIdPanel.Size = new Size(548, 57);
            giveOutBookReaderIdPanel.TabIndex = 1;
            // 
            // giveBookReaderIdNumericUpDown
            // 
            giveBookReaderIdNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            giveBookReaderIdNumericUpDown.Location = new Point(346, 14);
            giveBookReaderIdNumericUpDown.Name = "giveBookReaderIdNumericUpDown";
            giveBookReaderIdNumericUpDown.Size = new Size(190, 31);
            giveBookReaderIdNumericUpDown.TabIndex = 2;
            // 
            // giveBookReaderIdLabel
            // 
            giveBookReaderIdLabel.Dock = DockStyle.Left;
            giveBookReaderIdLabel.Location = new Point(0, 0);
            giveBookReaderIdLabel.Name = "giveBookReaderIdLabel";
            giveBookReaderIdLabel.Size = new Size(330, 57);
            giveBookReaderIdLabel.TabIndex = 1;
            giveBookReaderIdLabel.Text = "Введите Id читателя:";
            giveBookReaderIdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // giveBookActions
            // 
            giveBookActions.Controls.Add(giveOutABookButton);
            giveBookActions.Dock = DockStyle.Bottom;
            giveBookActions.Location = new Point(0, 546);
            giveBookActions.Name = "giveBookActions";
            giveBookActions.Size = new Size(548, 65);
            giveBookActions.TabIndex = 2;
            // 
            // giveOutABookButton
            // 
            giveOutABookButton.AutoSize = true;
            giveOutABookButton.BackColor = Color.Coral;
            giveOutABookButton.Dock = DockStyle.Fill;
            giveOutABookButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            giveOutABookButton.Location = new Point(0, 0);
            giveOutABookButton.Name = "giveOutABookButton";
            giveOutABookButton.Size = new Size(548, 65);
            giveOutABookButton.TabIndex = 0;
            giveOutABookButton.Text = "Выдать книгу";
            giveOutABookButton.UseVisualStyleBackColor = false;
            giveOutABookButton.Click += giveOutABookButton_Click;
            // 
            // giveOutBookDueDatePanel
            // 
            giveOutBookDueDatePanel.Controls.Add(giveOutBookDueDateTimePicker);
            giveOutBookDueDatePanel.Controls.Add(giveOutBookDueDateLabel);
            giveOutBookDueDatePanel.Dock = DockStyle.Top;
            giveOutBookDueDatePanel.Location = new Point(0, 132);
            giveOutBookDueDatePanel.Name = "giveOutBookDueDatePanel";
            giveOutBookDueDatePanel.Size = new Size(548, 57);
            giveOutBookDueDatePanel.TabIndex = 3;
            // 
            // giveOutBookDueDateTimePicker
            // 
            giveOutBookDueDateTimePicker.Location = new Point(346, 11);
            giveOutBookDueDateTimePicker.MinDate = new DateTime(2025, 3, 22, 0, 0, 0, 0);
            giveOutBookDueDateTimePicker.Name = "giveOutBookDueDateTimePicker";
            giveOutBookDueDateTimePicker.Size = new Size(190, 31);
            giveOutBookDueDateTimePicker.TabIndex = 2;
            // 
            // giveOutBookDueDateLabel
            // 
            giveOutBookDueDateLabel.Dock = DockStyle.Left;
            giveOutBookDueDateLabel.Location = new Point(0, 0);
            giveOutBookDueDateLabel.Name = "giveOutBookDueDateLabel";
            giveOutBookDueDateLabel.Size = new Size(330, 57);
            giveOutBookDueDateLabel.TabIndex = 1;
            giveOutBookDueDateLabel.Text = "Срок выдачи";
            giveOutBookDueDateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // availableReadersDataGridView
            // 
            availableReadersDataGridView.AllowUserToAddRows = false;
            availableReadersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            availableReadersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            availableReadersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            availableReadersDataGridView.Columns.AddRange(new DataGridViewColumn[] { readerId, readerName, phoneNumber, address });
            availableReadersDataGridView.Location = new Point(0, 41);
            availableReadersDataGridView.Name = "availableReadersDataGridView";
            availableReadersDataGridView.RowHeadersVisible = false;
            availableReadersDataGridView.RowHeadersWidth = 62;
            availableReadersDataGridView.Size = new Size(545, 229);
            availableReadersDataGridView.TabIndex = 4;
            availableReadersDataGridView.CellClick += availableReadersDataGridView_CellClick;
            // 
            // readerId
            // 
            readerId.HeaderText = "ID";
            readerId.MinimumWidth = 8;
            readerId.Name = "readerId";
            // 
            // readerName
            // 
            readerName.HeaderText = "ФИО";
            readerName.MinimumWidth = 8;
            readerName.Name = "readerName";
            // 
            // phoneNumber
            // 
            phoneNumber.HeaderText = "Номер телефона";
            phoneNumber.MinimumWidth = 8;
            phoneNumber.Name = "phoneNumber";
            // 
            // address
            // 
            address.HeaderText = "Адрес";
            address.MinimumWidth = 8;
            address.Name = "address";
            // 
            // availableReadersPanel
            // 
            availableReadersPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            availableReadersPanel.Controls.Add(availableReadersDataGridView);
            availableReadersPanel.Controls.Add(availableReadersLabel);
            availableReadersPanel.Location = new Point(0, 195);
            availableReadersPanel.Name = "availableReadersPanel";
            availableReadersPanel.Size = new Size(548, 273);
            availableReadersPanel.TabIndex = 5;
            // 
            // availableReadersLabel
            // 
            availableReadersLabel.Dock = DockStyle.Top;
            availableReadersLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            availableReadersLabel.Location = new Point(0, 0);
            availableReadersLabel.Name = "availableReadersLabel";
            availableReadersLabel.Size = new Size(548, 38);
            availableReadersLabel.TabIndex = 0;
            availableReadersLabel.Text = "Читатели";
            availableReadersLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GiveOutABookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(548, 611);
            Controls.Add(availableReadersPanel);
            Controls.Add(giveOutBookDueDatePanel);
            Controls.Add(giveBookActions);
            Controls.Add(giveOutBookReaderIdPanel);
            Controls.Add(giveBookDataPanel);
            Name = "GiveOutABookForm";
            Text = "Выдать книгу";
            Load += GiveOutABookForm_Load;
            giveBookDataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)giveBookIdNumericUpDown).EndInit();
            giveOutBookReaderIdPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)giveBookReaderIdNumericUpDown).EndInit();
            giveBookActions.ResumeLayout(false);
            giveBookActions.PerformLayout();
            giveOutBookDueDatePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)availableReadersDataGridView).EndInit();
            availableReadersPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel giveBookDataPanel;
        private Label giveBookIdLabel;
        private NumericUpDown giveBookIdNumericUpDown;
        private Panel giveOutBookReaderIdPanel;
        private NumericUpDown giveBookReaderIdNumericUpDown;
        private Label giveBookReaderIdLabel;
        private Panel giveBookActions;
        private Button giveOutABookButton;
        private Panel giveOutBookDueDatePanel;
        private DateTimePicker giveOutBookDueDateTimePicker;
        private Label giveOutBookDueDateLabel;
        private DataGridView availableReadersDataGridView;
        private Panel availableReadersPanel;
        private Label availableReadersLabel;
        private DataGridViewTextBoxColumn readerId;
        private DataGridViewTextBoxColumn readerName;
        private DataGridViewTextBoxColumn phoneNumber;
        private DataGridViewTextBoxColumn address;
    }
}