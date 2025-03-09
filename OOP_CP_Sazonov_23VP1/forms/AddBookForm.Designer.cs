namespace OOP_CP_Sazonov_23VP1.forms
{
    partial class AddBookForm
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
            addGenresPanel = new Panel();
            addBookNewGenreButton = new Button();
            addGenresListView = new ListView();
            addGenresLabel = new Label();
            addAuthorsPanel = new Panel();
            addBookNewAuthorButton = new Button();
            addAuthorsListView = new ListView();
            addAuthorsLabel = new Label();
            addMainBookSettingsPanel = new Panel();
            addIsbnPanel = new Panel();
            addIsbnTextBox = new TextBox();
            addIsbnLabel = new Label();
            addPublisherPanel = new Panel();
            addPublisherTextBox = new TextBox();
            addPublisherLabel = new Label();
            addDateOfPublishingPanel = new Panel();
            addDateOfPublishingNumericUpDown = new NumericUpDown();
            editDateOfPublishingLabel = new Label();
            addBookNamePanel = new Panel();
            addBookNameTextBox = new TextBox();
            addBookNameLabel = new Label();
            addMainSettingsLabel = new Label();
            addActionsPanel = new Panel();
            discardAddBookButton = new Button();
            saveNewBookButton = new Button();
            addGenresPanel.SuspendLayout();
            addAuthorsPanel.SuspendLayout();
            addMainBookSettingsPanel.SuspendLayout();
            addIsbnPanel.SuspendLayout();
            addPublisherPanel.SuspendLayout();
            addDateOfPublishingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addDateOfPublishingNumericUpDown).BeginInit();
            addBookNamePanel.SuspendLayout();
            addActionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addGenresPanel
            // 
            addGenresPanel.Controls.Add(addBookNewGenreButton);
            addGenresPanel.Controls.Add(addGenresListView);
            addGenresPanel.Controls.Add(addGenresLabel);
            addGenresPanel.Dock = DockStyle.Top;
            addGenresPanel.Location = new Point(0, 541);
            addGenresPanel.Name = "addGenresPanel";
            addGenresPanel.Padding = new Padding(10);
            addGenresPanel.Size = new Size(510, 298);
            addGenresPanel.TabIndex = 11;
            // 
            // addBookNewGenreButton
            // 
            addBookNewGenreButton.BackColor = Color.LightSalmon;
            addBookNewGenreButton.Cursor = Cursors.Hand;
            addBookNewGenreButton.Dock = DockStyle.Bottom;
            addBookNewGenreButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addBookNewGenreButton.Location = new Point(10, 232);
            addBookNewGenreButton.Name = "addBookNewGenreButton";
            addBookNewGenreButton.Size = new Size(490, 56);
            addBookNewGenreButton.TabIndex = 0;
            addBookNewGenreButton.Text = "Новый жанр...";
            addBookNewGenreButton.UseVisualStyleBackColor = false;
            addBookNewGenreButton.Click += addBookNewGenreButton_Click;
            // 
            // addGenresListView
            // 
            addGenresListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addGenresListView.Location = new Point(13, 68);
            addGenresListView.Name = "addGenresListView";
            addGenresListView.Size = new Size(484, 158);
            addGenresListView.TabIndex = 1;
            addGenresListView.UseCompatibleStateImageBehavior = false;
            // 
            // addGenresLabel
            // 
            addGenresLabel.Dock = DockStyle.Top;
            addGenresLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            addGenresLabel.Location = new Point(10, 10);
            addGenresLabel.Name = "addGenresLabel";
            addGenresLabel.Size = new Size(490, 25);
            addGenresLabel.TabIndex = 0;
            addGenresLabel.Text = "Жанры";
            addGenresLabel.TextAlign = ContentAlignment.MiddleCenter;
            addGenresLabel.UseMnemonic = false;
            // 
            // addAuthorsPanel
            // 
            addAuthorsPanel.Controls.Add(addBookNewAuthorButton);
            addAuthorsPanel.Controls.Add(addAuthorsListView);
            addAuthorsPanel.Controls.Add(addAuthorsLabel);
            addAuthorsPanel.Dock = DockStyle.Top;
            addAuthorsPanel.Location = new Point(0, 295);
            addAuthorsPanel.Name = "addAuthorsPanel";
            addAuthorsPanel.Padding = new Padding(10);
            addAuthorsPanel.Size = new Size(510, 246);
            addAuthorsPanel.TabIndex = 10;
            // 
            // addBookNewAuthorButton
            // 
            addBookNewAuthorButton.BackColor = Color.LightSalmon;
            addBookNewAuthorButton.Cursor = Cursors.Hand;
            addBookNewAuthorButton.Dock = DockStyle.Bottom;
            addBookNewAuthorButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addBookNewAuthorButton.Location = new Point(10, 180);
            addBookNewAuthorButton.Name = "addBookNewAuthorButton";
            addBookNewAuthorButton.Size = new Size(490, 56);
            addBookNewAuthorButton.TabIndex = 0;
            addBookNewAuthorButton.Text = "Новый автор...";
            addBookNewAuthorButton.UseVisualStyleBackColor = false;
            addBookNewAuthorButton.Click += addBookNewAuthorButton_Click;
            // 
            // addAuthorsListView
            // 
            addAuthorsListView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addAuthorsListView.Location = new Point(13, 38);
            addAuthorsListView.Name = "addAuthorsListView";
            addAuthorsListView.Size = new Size(484, 129);
            addAuthorsListView.TabIndex = 1;
            addAuthorsListView.UseCompatibleStateImageBehavior = false;
            // 
            // addAuthorsLabel
            // 
            addAuthorsLabel.Dock = DockStyle.Top;
            addAuthorsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            addAuthorsLabel.Location = new Point(10, 10);
            addAuthorsLabel.Name = "addAuthorsLabel";
            addAuthorsLabel.Size = new Size(490, 25);
            addAuthorsLabel.TabIndex = 0;
            addAuthorsLabel.Text = "Авторы книги";
            addAuthorsLabel.TextAlign = ContentAlignment.MiddleCenter;
            addAuthorsLabel.UseMnemonic = false;
            // 
            // addMainBookSettingsPanel
            // 
            addMainBookSettingsPanel.Controls.Add(addIsbnPanel);
            addMainBookSettingsPanel.Controls.Add(addPublisherPanel);
            addMainBookSettingsPanel.Controls.Add(addDateOfPublishingPanel);
            addMainBookSettingsPanel.Controls.Add(addBookNamePanel);
            addMainBookSettingsPanel.Controls.Add(addMainSettingsLabel);
            addMainBookSettingsPanel.Dock = DockStyle.Top;
            addMainBookSettingsPanel.Location = new Point(0, 0);
            addMainBookSettingsPanel.Name = "addMainBookSettingsPanel";
            addMainBookSettingsPanel.Padding = new Padding(10);
            addMainBookSettingsPanel.Size = new Size(510, 295);
            addMainBookSettingsPanel.TabIndex = 9;
            // 
            // addIsbnPanel
            // 
            addIsbnPanel.Controls.Add(addIsbnTextBox);
            addIsbnPanel.Controls.Add(addIsbnLabel);
            addIsbnPanel.Dock = DockStyle.Top;
            addIsbnPanel.Location = new Point(10, 224);
            addIsbnPanel.Name = "addIsbnPanel";
            addIsbnPanel.Size = new Size(490, 63);
            addIsbnPanel.TabIndex = 7;
            // 
            // addIsbnTextBox
            // 
            addIsbnTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addIsbnTextBox.Location = new Point(166, 16);
            addIsbnTextBox.Name = "addIsbnTextBox";
            addIsbnTextBox.Size = new Size(321, 31);
            addIsbnTextBox.TabIndex = 1;
            // 
            // addIsbnLabel
            // 
            addIsbnLabel.Dock = DockStyle.Left;
            addIsbnLabel.Location = new Point(0, 0);
            addIsbnLabel.Name = "addIsbnLabel";
            addIsbnLabel.Size = new Size(160, 63);
            addIsbnLabel.TabIndex = 0;
            addIsbnLabel.Text = "Издательство";
            addIsbnLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addPublisherPanel
            // 
            addPublisherPanel.Controls.Add(addPublisherTextBox);
            addPublisherPanel.Controls.Add(addPublisherLabel);
            addPublisherPanel.Dock = DockStyle.Top;
            addPublisherPanel.Location = new Point(10, 161);
            addPublisherPanel.Name = "addPublisherPanel";
            addPublisherPanel.Size = new Size(490, 63);
            addPublisherPanel.TabIndex = 6;
            // 
            // addPublisherTextBox
            // 
            addPublisherTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addPublisherTextBox.Location = new Point(166, 16);
            addPublisherTextBox.Name = "addPublisherTextBox";
            addPublisherTextBox.Size = new Size(321, 31);
            addPublisherTextBox.TabIndex = 1;
            // 
            // addPublisherLabel
            // 
            addPublisherLabel.Dock = DockStyle.Left;
            addPublisherLabel.Location = new Point(0, 0);
            addPublisherLabel.Name = "addPublisherLabel";
            addPublisherLabel.Size = new Size(160, 63);
            addPublisherLabel.TabIndex = 0;
            addPublisherLabel.Text = "Издательство";
            addPublisherLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addDateOfPublishingPanel
            // 
            addDateOfPublishingPanel.Controls.Add(addDateOfPublishingNumericUpDown);
            addDateOfPublishingPanel.Controls.Add(editDateOfPublishingLabel);
            addDateOfPublishingPanel.Dock = DockStyle.Top;
            addDateOfPublishingPanel.Location = new Point(10, 98);
            addDateOfPublishingPanel.Name = "addDateOfPublishingPanel";
            addDateOfPublishingPanel.Size = new Size(490, 63);
            addDateOfPublishingPanel.TabIndex = 5;
            // 
            // addDateOfPublishingNumericUpDown
            // 
            addDateOfPublishingNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addDateOfPublishingNumericUpDown.Location = new Point(166, 17);
            addDateOfPublishingNumericUpDown.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            addDateOfPublishingNumericUpDown.Name = "addDateOfPublishingNumericUpDown";
            addDateOfPublishingNumericUpDown.Size = new Size(321, 31);
            addDateOfPublishingNumericUpDown.TabIndex = 1;
            // 
            // editDateOfPublishingLabel
            // 
            editDateOfPublishingLabel.Dock = DockStyle.Left;
            editDateOfPublishingLabel.Location = new Point(0, 0);
            editDateOfPublishingLabel.Name = "editDateOfPublishingLabel";
            editDateOfPublishingLabel.Size = new Size(160, 63);
            editDateOfPublishingLabel.TabIndex = 0;
            editDateOfPublishingLabel.Text = "Дата выхода";
            editDateOfPublishingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addBookNamePanel
            // 
            addBookNamePanel.Controls.Add(addBookNameTextBox);
            addBookNamePanel.Controls.Add(addBookNameLabel);
            addBookNamePanel.Dock = DockStyle.Top;
            addBookNamePanel.Location = new Point(10, 35);
            addBookNamePanel.Name = "addBookNamePanel";
            addBookNamePanel.Size = new Size(490, 63);
            addBookNamePanel.TabIndex = 4;
            // 
            // addBookNameTextBox
            // 
            addBookNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addBookNameTextBox.Location = new Point(166, 16);
            addBookNameTextBox.Name = "addBookNameTextBox";
            addBookNameTextBox.Size = new Size(321, 31);
            addBookNameTextBox.TabIndex = 1;
            // 
            // addBookNameLabel
            // 
            addBookNameLabel.Dock = DockStyle.Left;
            addBookNameLabel.Location = new Point(0, 0);
            addBookNameLabel.Name = "addBookNameLabel";
            addBookNameLabel.Size = new Size(160, 63);
            addBookNameLabel.TabIndex = 0;
            addBookNameLabel.Text = "Названиие книги ";
            addBookNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addMainSettingsLabel
            // 
            addMainSettingsLabel.Dock = DockStyle.Top;
            addMainSettingsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            addMainSettingsLabel.Location = new Point(10, 10);
            addMainSettingsLabel.Name = "addMainSettingsLabel";
            addMainSettingsLabel.Size = new Size(490, 25);
            addMainSettingsLabel.TabIndex = 0;
            addMainSettingsLabel.Text = "Основная информация";
            addMainSettingsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addActionsPanel
            // 
            addActionsPanel.Controls.Add(discardAddBookButton);
            addActionsPanel.Controls.Add(saveNewBookButton);
            addActionsPanel.Dock = DockStyle.Bottom;
            addActionsPanel.Location = new Point(0, 957);
            addActionsPanel.Name = "addActionsPanel";
            addActionsPanel.Size = new Size(510, 75);
            addActionsPanel.TabIndex = 8;
            // 
            // discardAddBookButton
            // 
            discardAddBookButton.BackColor = Color.Coral;
            discardAddBookButton.Cursor = Cursors.Hand;
            discardAddBookButton.Dock = DockStyle.Left;
            discardAddBookButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            discardAddBookButton.Location = new Point(0, 0);
            discardAddBookButton.Name = "discardAddBookButton";
            discardAddBookButton.Size = new Size(145, 75);
            discardAddBookButton.TabIndex = 1;
            discardAddBookButton.Text = "Отмена";
            discardAddBookButton.UseVisualStyleBackColor = false;
            // 
            // saveNewBookButton
            // 
            saveNewBookButton.BackColor = Color.Coral;
            saveNewBookButton.Cursor = Cursors.Hand;
            saveNewBookButton.Dock = DockStyle.Right;
            saveNewBookButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveNewBookButton.Location = new Point(348, 0);
            saveNewBookButton.Name = "saveNewBookButton";
            saveNewBookButton.Size = new Size(162, 75);
            saveNewBookButton.TabIndex = 0;
            saveNewBookButton.Text = "Добавить";
            saveNewBookButton.UseVisualStyleBackColor = false;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(510, 1032);
            Controls.Add(addGenresPanel);
            Controls.Add(addAuthorsPanel);
            Controls.Add(addMainBookSettingsPanel);
            Controls.Add(addActionsPanel);
            Name = "AddBookForm";
            Text = "Добавление книги";
            Load += AddBookForm_Load;
            addGenresPanel.ResumeLayout(false);
            addAuthorsPanel.ResumeLayout(false);
            addMainBookSettingsPanel.ResumeLayout(false);
            addIsbnPanel.ResumeLayout(false);
            addIsbnPanel.PerformLayout();
            addPublisherPanel.ResumeLayout(false);
            addPublisherPanel.PerformLayout();
            addDateOfPublishingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)addDateOfPublishingNumericUpDown).EndInit();
            addBookNamePanel.ResumeLayout(false);
            addBookNamePanel.PerformLayout();
            addActionsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel addGenresPanel;
        private Button addBookNewGenreButton;
        private ListView addGenresListView;
        private Label addGenresLabel;
        private Panel addAuthorsPanel;
        private Button addBookNewAuthorButton;
        private ListView addAuthorsListView;
        private Label addAuthorsLabel;
        private Panel addMainBookSettingsPanel;
        private Panel addIsbnPanel;
        private TextBox addIsbnTextBox;
        private Label addIsbnLabel;
        private Panel addPublisherPanel;
        private TextBox addPublisherTextBox;
        private Label addPublisherLabel;
        private Panel addDateOfPublishingPanel;
        private NumericUpDown addDateOfPublishingNumericUpDown;
        private Label editDateOfPublishingLabel;
        private Panel addBookNamePanel;
        private TextBox addBookNameTextBox;
        private Label addBookNameLabel;
        private Label addMainSettingsLabel;
        private Panel addActionsPanel;
        private Button discardAddBookButton;
        private Button saveNewBookButton;
    }
}