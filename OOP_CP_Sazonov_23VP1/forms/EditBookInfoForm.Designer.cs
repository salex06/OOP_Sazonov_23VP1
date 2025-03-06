namespace OOP_CP_Sazonov_23VP1.forms
{
    partial class EditBookInfoForm
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
            editActionsPanel = new Panel();
            discardBookChangesButton = new Button();
            saveBookChangesButton = new Button();
            editBookPanel = new Panel();
            editBookIdLabel = new Label();
            editBookIdNumericUpDown = new NumericUpDown();
            editGenresPanel = new Panel();
            newGenreButton = new Button();
            editGenresListView = new ListView();
            editGenresLabel = new Label();
            editAuthorsPanel = new Panel();
            addNewAuthorButton = new Button();
            editAuthorsListView = new ListView();
            editAuthorsLabel = new Label();
            mainBookSettingsPanel = new Panel();
            editIsbnPanel = new Panel();
            editIsbnTextBox = new TextBox();
            editIsbnLabel = new Label();
            editPublisherPanel = new Panel();
            editPublisherTextBox = new TextBox();
            editPublisherLabel = new Label();
            editDateOfPublishingPanel = new Panel();
            editDateOfPublishingNumericUpDown = new NumericUpDown();
            editDateOfPublishingLabel = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            editBookNameLabel = new Label();
            editMainSettingsLabel = new Label();
            editActionsPanel.SuspendLayout();
            editBookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)editBookIdNumericUpDown).BeginInit();
            editGenresPanel.SuspendLayout();
            editAuthorsPanel.SuspendLayout();
            mainBookSettingsPanel.SuspendLayout();
            editIsbnPanel.SuspendLayout();
            editPublisherPanel.SuspendLayout();
            editDateOfPublishingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)editDateOfPublishingNumericUpDown).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // editActionsPanel
            // 
            editActionsPanel.Controls.Add(discardBookChangesButton);
            editActionsPanel.Controls.Add(saveBookChangesButton);
            editActionsPanel.Dock = DockStyle.Bottom;
            editActionsPanel.Location = new Point(0, 993);
            editActionsPanel.Name = "editActionsPanel";
            editActionsPanel.Size = new Size(428, 75);
            editActionsPanel.TabIndex = 3;
            // 
            // discardBookChangesButton
            // 
            discardBookChangesButton.BackColor = Color.Coral;
            discardBookChangesButton.Cursor = Cursors.Hand;
            discardBookChangesButton.Dock = DockStyle.Left;
            discardBookChangesButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            discardBookChangesButton.Location = new Point(0, 0);
            discardBookChangesButton.Name = "discardBookChangesButton";
            discardBookChangesButton.Size = new Size(145, 75);
            discardBookChangesButton.TabIndex = 1;
            discardBookChangesButton.Text = "Отменить изменения";
            discardBookChangesButton.UseVisualStyleBackColor = false;
            // 
            // saveBookChangesButton
            // 
            saveBookChangesButton.BackColor = Color.Coral;
            saveBookChangesButton.Cursor = Cursors.Hand;
            saveBookChangesButton.Dock = DockStyle.Right;
            saveBookChangesButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveBookChangesButton.Location = new Point(266, 0);
            saveBookChangesButton.Name = "saveBookChangesButton";
            saveBookChangesButton.Size = new Size(162, 75);
            saveBookChangesButton.TabIndex = 0;
            saveBookChangesButton.Text = "Сохранить изменения";
            saveBookChangesButton.UseVisualStyleBackColor = false;
            // 
            // editBookPanel
            // 
            editBookPanel.Controls.Add(editBookIdNumericUpDown);
            editBookPanel.Controls.Add(editBookIdLabel);
            editBookPanel.Dock = DockStyle.Top;
            editBookPanel.Location = new Point(0, 0);
            editBookPanel.Name = "editBookPanel";
            editBookPanel.Size = new Size(428, 83);
            editBookPanel.TabIndex = 4;
            // 
            // editBookIdLabel
            // 
            editBookIdLabel.Dock = DockStyle.Left;
            editBookIdLabel.Location = new Point(0, 0);
            editBookIdLabel.Name = "editBookIdLabel";
            editBookIdLabel.Size = new Size(170, 83);
            editBookIdLabel.TabIndex = 0;
            editBookIdLabel.Text = "ID книги:";
            editBookIdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editBookIdNumericUpDown
            // 
            editBookIdNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editBookIdNumericUpDown.Location = new Point(176, 27);
            editBookIdNumericUpDown.Name = "editBookIdNumericUpDown";
            editBookIdNumericUpDown.Size = new Size(239, 31);
            editBookIdNumericUpDown.TabIndex = 1;
            // 
            // editGenresPanel
            // 
            editGenresPanel.Controls.Add(newGenreButton);
            editGenresPanel.Controls.Add(editGenresListView);
            editGenresPanel.Controls.Add(editGenresLabel);
            editGenresPanel.Dock = DockStyle.Top;
            editGenresPanel.Location = new Point(0, 617);
            editGenresPanel.Name = "editGenresPanel";
            editGenresPanel.Padding = new Padding(10);
            editGenresPanel.Size = new Size(428, 298);
            editGenresPanel.TabIndex = 7;
            // 
            // newGenreButton
            // 
            newGenreButton.BackColor = Color.LightSalmon;
            newGenreButton.Cursor = Cursors.Hand;
            newGenreButton.Dock = DockStyle.Bottom;
            newGenreButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            newGenreButton.Location = new Point(10, 232);
            newGenreButton.Name = "newGenreButton";
            newGenreButton.Size = new Size(408, 56);
            newGenreButton.TabIndex = 0;
            newGenreButton.Text = "Новый жанр...";
            newGenreButton.UseVisualStyleBackColor = false;
            // 
            // editGenresListView
            // 
            editGenresListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            editGenresListView.Location = new Point(13, 58);
            editGenresListView.Name = "editGenresListView";
            editGenresListView.Size = new Size(402, 168);
            editGenresListView.TabIndex = 1;
            editGenresListView.UseCompatibleStateImageBehavior = false;
            // 
            // editGenresLabel
            // 
            editGenresLabel.Dock = DockStyle.Top;
            editGenresLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            editGenresLabel.Location = new Point(10, 10);
            editGenresLabel.Name = "editGenresLabel";
            editGenresLabel.Size = new Size(408, 25);
            editGenresLabel.TabIndex = 0;
            editGenresLabel.Text = "Редактирование жанров книги";
            editGenresLabel.TextAlign = ContentAlignment.MiddleCenter;
            editGenresLabel.UseMnemonic = false;
            // 
            // editAuthorsPanel
            // 
            editAuthorsPanel.Controls.Add(addNewAuthorButton);
            editAuthorsPanel.Controls.Add(editAuthorsListView);
            editAuthorsPanel.Controls.Add(editAuthorsLabel);
            editAuthorsPanel.Dock = DockStyle.Top;
            editAuthorsPanel.Location = new Point(0, 378);
            editAuthorsPanel.Name = "editAuthorsPanel";
            editAuthorsPanel.Padding = new Padding(10);
            editAuthorsPanel.Size = new Size(428, 239);
            editAuthorsPanel.TabIndex = 6;
            // 
            // addNewAuthorButton
            // 
            addNewAuthorButton.BackColor = Color.LightSalmon;
            addNewAuthorButton.Cursor = Cursors.Hand;
            addNewAuthorButton.Dock = DockStyle.Bottom;
            addNewAuthorButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addNewAuthorButton.Location = new Point(10, 173);
            addNewAuthorButton.Name = "addNewAuthorButton";
            addNewAuthorButton.Size = new Size(408, 56);
            addNewAuthorButton.TabIndex = 0;
            addNewAuthorButton.Text = "Новый автор...";
            addNewAuthorButton.UseVisualStyleBackColor = false;
            // 
            // editAuthorsListView
            // 
            editAuthorsListView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editAuthorsListView.Location = new Point(13, 62);
            editAuthorsListView.Name = "editAuthorsListView";
            editAuthorsListView.Size = new Size(402, 105);
            editAuthorsListView.TabIndex = 1;
            editAuthorsListView.UseCompatibleStateImageBehavior = false;
            // 
            // editAuthorsLabel
            // 
            editAuthorsLabel.Dock = DockStyle.Top;
            editAuthorsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            editAuthorsLabel.Location = new Point(10, 10);
            editAuthorsLabel.Name = "editAuthorsLabel";
            editAuthorsLabel.Size = new Size(408, 25);
            editAuthorsLabel.TabIndex = 0;
            editAuthorsLabel.Text = "Редактирование авторов книги";
            editAuthorsLabel.TextAlign = ContentAlignment.MiddleCenter;
            editAuthorsLabel.UseMnemonic = false;
            // 
            // mainBookSettingsPanel
            // 
            mainBookSettingsPanel.Controls.Add(editIsbnPanel);
            mainBookSettingsPanel.Controls.Add(editPublisherPanel);
            mainBookSettingsPanel.Controls.Add(editDateOfPublishingPanel);
            mainBookSettingsPanel.Controls.Add(panel2);
            mainBookSettingsPanel.Controls.Add(editMainSettingsLabel);
            mainBookSettingsPanel.Dock = DockStyle.Top;
            mainBookSettingsPanel.Location = new Point(0, 83);
            mainBookSettingsPanel.Name = "mainBookSettingsPanel";
            mainBookSettingsPanel.Padding = new Padding(10);
            mainBookSettingsPanel.Size = new Size(428, 295);
            mainBookSettingsPanel.TabIndex = 5;
            // 
            // editIsbnPanel
            // 
            editIsbnPanel.Controls.Add(editIsbnTextBox);
            editIsbnPanel.Controls.Add(editIsbnLabel);
            editIsbnPanel.Dock = DockStyle.Top;
            editIsbnPanel.Location = new Point(10, 224);
            editIsbnPanel.Name = "editIsbnPanel";
            editIsbnPanel.Size = new Size(408, 63);
            editIsbnPanel.TabIndex = 7;
            // 
            // editIsbnTextBox
            // 
            editIsbnTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editIsbnTextBox.Location = new Point(166, 16);
            editIsbnTextBox.Name = "editIsbnTextBox";
            editIsbnTextBox.Size = new Size(239, 31);
            editIsbnTextBox.TabIndex = 1;
            // 
            // editIsbnLabel
            // 
            editIsbnLabel.Dock = DockStyle.Left;
            editIsbnLabel.Location = new Point(0, 0);
            editIsbnLabel.Name = "editIsbnLabel";
            editIsbnLabel.Size = new Size(160, 63);
            editIsbnLabel.TabIndex = 0;
            editIsbnLabel.Text = "Издательство";
            editIsbnLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editPublisherPanel
            // 
            editPublisherPanel.Controls.Add(editPublisherTextBox);
            editPublisherPanel.Controls.Add(editPublisherLabel);
            editPublisherPanel.Dock = DockStyle.Top;
            editPublisherPanel.Location = new Point(10, 161);
            editPublisherPanel.Name = "editPublisherPanel";
            editPublisherPanel.Size = new Size(408, 63);
            editPublisherPanel.TabIndex = 6;
            // 
            // editPublisherTextBox
            // 
            editPublisherTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editPublisherTextBox.Location = new Point(166, 16);
            editPublisherTextBox.Name = "editPublisherTextBox";
            editPublisherTextBox.Size = new Size(239, 31);
            editPublisherTextBox.TabIndex = 1;
            // 
            // editPublisherLabel
            // 
            editPublisherLabel.Dock = DockStyle.Left;
            editPublisherLabel.Location = new Point(0, 0);
            editPublisherLabel.Name = "editPublisherLabel";
            editPublisherLabel.Size = new Size(160, 63);
            editPublisherLabel.TabIndex = 0;
            editPublisherLabel.Text = "Издательство";
            editPublisherLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editDateOfPublishingPanel
            // 
            editDateOfPublishingPanel.Controls.Add(editDateOfPublishingNumericUpDown);
            editDateOfPublishingPanel.Controls.Add(editDateOfPublishingLabel);
            editDateOfPublishingPanel.Dock = DockStyle.Top;
            editDateOfPublishingPanel.Location = new Point(10, 98);
            editDateOfPublishingPanel.Name = "editDateOfPublishingPanel";
            editDateOfPublishingPanel.Size = new Size(408, 63);
            editDateOfPublishingPanel.TabIndex = 5;
            // 
            // editDateOfPublishingNumericUpDown
            // 
            editDateOfPublishingNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editDateOfPublishingNumericUpDown.Location = new Point(166, 17);
            editDateOfPublishingNumericUpDown.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            editDateOfPublishingNumericUpDown.Name = "editDateOfPublishingNumericUpDown";
            editDateOfPublishingNumericUpDown.Size = new Size(239, 31);
            editDateOfPublishingNumericUpDown.TabIndex = 1;
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
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(editBookNameLabel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 63);
            panel2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(166, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 31);
            textBox1.TabIndex = 1;
            // 
            // editBookNameLabel
            // 
            editBookNameLabel.Dock = DockStyle.Left;
            editBookNameLabel.Location = new Point(0, 0);
            editBookNameLabel.Name = "editBookNameLabel";
            editBookNameLabel.Size = new Size(160, 63);
            editBookNameLabel.TabIndex = 0;
            editBookNameLabel.Text = "Названиие книги ";
            editBookNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editMainSettingsLabel
            // 
            editMainSettingsLabel.Dock = DockStyle.Top;
            editMainSettingsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            editMainSettingsLabel.Location = new Point(10, 10);
            editMainSettingsLabel.Name = "editMainSettingsLabel";
            editMainSettingsLabel.Size = new Size(408, 25);
            editMainSettingsLabel.TabIndex = 0;
            editMainSettingsLabel.Text = "Редактирование основной информации";
            editMainSettingsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditBookInfoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(428, 1068);
            Controls.Add(editGenresPanel);
            Controls.Add(editAuthorsPanel);
            Controls.Add(mainBookSettingsPanel);
            Controls.Add(editBookPanel);
            Controls.Add(editActionsPanel);
            Name = "EditBookInfoForm";
            Text = "Редактирование";
            editActionsPanel.ResumeLayout(false);
            editBookPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)editBookIdNumericUpDown).EndInit();
            editGenresPanel.ResumeLayout(false);
            editAuthorsPanel.ResumeLayout(false);
            mainBookSettingsPanel.ResumeLayout(false);
            editIsbnPanel.ResumeLayout(false);
            editIsbnPanel.PerformLayout();
            editPublisherPanel.ResumeLayout(false);
            editPublisherPanel.PerformLayout();
            editDateOfPublishingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)editDateOfPublishingNumericUpDown).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel editActionsPanel;
        private Button discardBookChangesButton;
        private Button saveBookChangesButton;
        private Panel editBookPanel;
        private NumericUpDown editBookIdNumericUpDown;
        private Label editBookIdLabel;
        private Panel editGenresPanel;
        private Button newGenreButton;
        private ListView editGenresListView;
        private Label editGenresLabel;
        private Panel editAuthorsPanel;
        private Button addNewAuthorButton;
        private ListView editAuthorsListView;
        private Label editAuthorsLabel;
        private Panel mainBookSettingsPanel;
        private Panel editIsbnPanel;
        private TextBox editIsbnTextBox;
        private Label editIsbnLabel;
        private Panel editPublisherPanel;
        private TextBox editPublisherTextBox;
        private Label editPublisherLabel;
        private Panel editDateOfPublishingPanel;
        private NumericUpDown editDateOfPublishingNumericUpDown;
        private Label editDateOfPublishingLabel;
        private Panel panel2;
        private TextBox textBox1;
        private Label editBookNameLabel;
        private Label editMainSettingsLabel;
    }
}