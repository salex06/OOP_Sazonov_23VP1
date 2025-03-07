namespace OOP_CP_Sazonov_23VP1.forms
{
    partial class EditReaderInfoForm
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
            editReaderSettingsPanel = new Panel();
            editReaderNamePanel = new Panel();
            textBox1 = new TextBox();
            editReaderNameLabel = new Label();
            editReaderPhonePanel = new Panel();
            editPhoneNumberTextBox = new TextBox();
            editReaderPhoneLabel = new Label();
            editReaderAddressPanel = new Panel();
            editReaderAddressTextBox = new TextBox();
            editReaderAddressLabel = new Label();
            editReaderInfoButtonsPanel = new Panel();
            discardAddBookButton = new Button();
            saveNewBookButton = new Button();
            editReaderSettingsPanel.SuspendLayout();
            editReaderNamePanel.SuspendLayout();
            editReaderPhonePanel.SuspendLayout();
            editReaderAddressPanel.SuspendLayout();
            editReaderInfoButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // editReaderSettingsPanel
            // 
            editReaderSettingsPanel.Controls.Add(editReaderAddressPanel);
            editReaderSettingsPanel.Controls.Add(editReaderPhonePanel);
            editReaderSettingsPanel.Controls.Add(editReaderNamePanel);
            editReaderSettingsPanel.Dock = DockStyle.Top;
            editReaderSettingsPanel.Location = new Point(0, 0);
            editReaderSettingsPanel.Name = "editReaderSettingsPanel";
            editReaderSettingsPanel.Padding = new Padding(10);
            editReaderSettingsPanel.Size = new Size(442, 181);
            editReaderSettingsPanel.TabIndex = 0;
            // 
            // editReaderNamePanel
            // 
            editReaderNamePanel.Controls.Add(textBox1);
            editReaderNamePanel.Controls.Add(editReaderNameLabel);
            editReaderNamePanel.Dock = DockStyle.Top;
            editReaderNamePanel.Location = new Point(10, 10);
            editReaderNamePanel.Name = "editReaderNamePanel";
            editReaderNamePanel.Size = new Size(422, 49);
            editReaderNamePanel.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(209, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 31);
            textBox1.TabIndex = 1;
            // 
            // editReaderNameLabel
            // 
            editReaderNameLabel.Dock = DockStyle.Left;
            editReaderNameLabel.Location = new Point(0, 0);
            editReaderNameLabel.Name = "editReaderNameLabel";
            editReaderNameLabel.Size = new Size(203, 49);
            editReaderNameLabel.TabIndex = 0;
            editReaderNameLabel.Text = "ФИО читателя";
            editReaderNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editReaderPhonePanel
            // 
            editReaderPhonePanel.Controls.Add(editPhoneNumberTextBox);
            editReaderPhonePanel.Controls.Add(editReaderPhoneLabel);
            editReaderPhonePanel.Dock = DockStyle.Top;
            editReaderPhonePanel.Location = new Point(10, 59);
            editReaderPhonePanel.Name = "editReaderPhonePanel";
            editReaderPhonePanel.Size = new Size(422, 49);
            editReaderPhonePanel.TabIndex = 1;
            // 
            // editPhoneNumberTextBox
            // 
            editPhoneNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editPhoneNumberTextBox.Location = new Point(209, 9);
            editPhoneNumberTextBox.Name = "editPhoneNumberTextBox";
            editPhoneNumberTextBox.Size = new Size(210, 31);
            editPhoneNumberTextBox.TabIndex = 1;
            // 
            // editReaderPhoneLabel
            // 
            editReaderPhoneLabel.Dock = DockStyle.Left;
            editReaderPhoneLabel.Location = new Point(0, 0);
            editReaderPhoneLabel.Name = "editReaderPhoneLabel";
            editReaderPhoneLabel.Size = new Size(203, 49);
            editReaderPhoneLabel.TabIndex = 0;
            editReaderPhoneLabel.Text = "Номер телефона";
            editReaderPhoneLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editReaderAddressPanel
            // 
            editReaderAddressPanel.Controls.Add(editReaderAddressTextBox);
            editReaderAddressPanel.Controls.Add(editReaderAddressLabel);
            editReaderAddressPanel.Dock = DockStyle.Top;
            editReaderAddressPanel.Location = new Point(10, 108);
            editReaderAddressPanel.Name = "editReaderAddressPanel";
            editReaderAddressPanel.Size = new Size(422, 49);
            editReaderAddressPanel.TabIndex = 2;
            // 
            // editReaderAddressTextBox
            // 
            editReaderAddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editReaderAddressTextBox.Location = new Point(209, 9);
            editReaderAddressTextBox.Name = "editReaderAddressTextBox";
            editReaderAddressTextBox.Size = new Size(210, 31);
            editReaderAddressTextBox.TabIndex = 1;
            // 
            // editReaderAddressLabel
            // 
            editReaderAddressLabel.Dock = DockStyle.Left;
            editReaderAddressLabel.Location = new Point(0, 0);
            editReaderAddressLabel.Name = "editReaderAddressLabel";
            editReaderAddressLabel.Size = new Size(203, 49);
            editReaderAddressLabel.TabIndex = 0;
            editReaderAddressLabel.Text = "Адрес";
            editReaderAddressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editReaderInfoButtonsPanel
            // 
            editReaderInfoButtonsPanel.Controls.Add(saveNewBookButton);
            editReaderInfoButtonsPanel.Controls.Add(discardAddBookButton);
            editReaderInfoButtonsPanel.Dock = DockStyle.Bottom;
            editReaderInfoButtonsPanel.Location = new Point(0, 225);
            editReaderInfoButtonsPanel.Name = "editReaderInfoButtonsPanel";
            editReaderInfoButtonsPanel.Size = new Size(442, 66);
            editReaderInfoButtonsPanel.TabIndex = 1;
            // 
            // discardAddBookButton
            // 
            discardAddBookButton.BackColor = Color.Coral;
            discardAddBookButton.Cursor = Cursors.Hand;
            discardAddBookButton.Dock = DockStyle.Left;
            discardAddBookButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            discardAddBookButton.Location = new Point(0, 0);
            discardAddBookButton.Name = "discardAddBookButton";
            discardAddBookButton.Size = new Size(142, 66);
            discardAddBookButton.TabIndex = 2;
            discardAddBookButton.Text = "Отменить изменения";
            discardAddBookButton.UseVisualStyleBackColor = false;
            // 
            // saveNewBookButton
            // 
            saveNewBookButton.BackColor = Color.Coral;
            saveNewBookButton.Cursor = Cursors.Hand;
            saveNewBookButton.Dock = DockStyle.Right;
            saveNewBookButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveNewBookButton.Location = new Point(280, 0);
            saveNewBookButton.Name = "saveNewBookButton";
            saveNewBookButton.Size = new Size(162, 66);
            saveNewBookButton.TabIndex = 3;
            saveNewBookButton.Text = "Сохранить изменения";
            saveNewBookButton.UseVisualStyleBackColor = false;
            // 
            // EditReaderInfoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(442, 291);
            Controls.Add(editReaderInfoButtonsPanel);
            Controls.Add(editReaderSettingsPanel);
            Name = "EditReaderInfoForm";
            Text = "Редактирование информации";
            editReaderSettingsPanel.ResumeLayout(false);
            editReaderNamePanel.ResumeLayout(false);
            editReaderNamePanel.PerformLayout();
            editReaderPhonePanel.ResumeLayout(false);
            editReaderPhonePanel.PerformLayout();
            editReaderAddressPanel.ResumeLayout(false);
            editReaderAddressPanel.PerformLayout();
            editReaderInfoButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel editReaderSettingsPanel;
        private Panel editReaderNamePanel;
        private TextBox textBox1;
        private Label editReaderNameLabel;
        private Panel editReaderAddressPanel;
        private TextBox editReaderAddressTextBox;
        private Label editReaderAddressLabel;
        private Panel editReaderPhonePanel;
        private TextBox editPhoneNumberTextBox;
        private Label editReaderPhoneLabel;
        private Panel editReaderInfoButtonsPanel;
        private Button discardAddBookButton;
        private Button saveNewBookButton;
    }
}