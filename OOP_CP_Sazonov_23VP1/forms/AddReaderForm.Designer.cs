namespace OOP_CP_Sazonov_23VP1.forms
{
    partial class AddReaderForm
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
            addReaderLabel = new Label();
            addClientInfoPanel = new Panel();
            readerNamePanel = new Panel();
            readerNameLabel = new Label();
            readerNameTextBox = new TextBox();
            readerPhonePanel = new Panel();
            readerPhoneLabel = new Label();
            readerPhoneTextBox = new TextBox();
            readerAddressPanel = new Panel();
            readerAddressLabel = new Label();
            readerAddressTextBox = new TextBox();
            addReaderButtonsPanel = new Panel();
            discardAddReaderButton = new Button();
            saveNewReaderButton = new Button();
            addClientInfoPanel.SuspendLayout();
            readerNamePanel.SuspendLayout();
            readerPhonePanel.SuspendLayout();
            readerAddressPanel.SuspendLayout();
            addReaderButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addReaderLabel
            // 
            addReaderLabel.Dock = DockStyle.Top;
            addReaderLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addReaderLabel.Location = new Point(0, 0);
            addReaderLabel.Name = "addReaderLabel";
            addReaderLabel.Size = new Size(502, 47);
            addReaderLabel.TabIndex = 0;
            addReaderLabel.Text = "Добавление читателя";
            addReaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addClientInfoPanel
            // 
            addClientInfoPanel.Controls.Add(readerAddressPanel);
            addClientInfoPanel.Controls.Add(readerPhonePanel);
            addClientInfoPanel.Controls.Add(readerNamePanel);
            addClientInfoPanel.Dock = DockStyle.Top;
            addClientInfoPanel.Location = new Point(0, 47);
            addClientInfoPanel.Name = "addClientInfoPanel";
            addClientInfoPanel.Size = new Size(502, 191);
            addClientInfoPanel.TabIndex = 1;
            // 
            // readerNamePanel
            // 
            readerNamePanel.Controls.Add(readerNameTextBox);
            readerNamePanel.Controls.Add(readerNameLabel);
            readerNamePanel.Dock = DockStyle.Top;
            readerNamePanel.Location = new Point(0, 0);
            readerNamePanel.Name = "readerNamePanel";
            readerNamePanel.Size = new Size(502, 41);
            readerNamePanel.TabIndex = 0;
            // 
            // readerNameLabel
            // 
            readerNameLabel.Dock = DockStyle.Left;
            readerNameLabel.Location = new Point(0, 0);
            readerNameLabel.Name = "readerNameLabel";
            readerNameLabel.Size = new Size(212, 41);
            readerNameLabel.TabIndex = 0;
            readerNameLabel.Text = "ФИО читателя";
            readerNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // readerNameTextBox
            // 
            readerNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            readerNameTextBox.Location = new Point(243, 5);
            readerNameTextBox.Name = "readerNameTextBox";
            readerNameTextBox.Size = new Size(247, 31);
            readerNameTextBox.TabIndex = 1;
            // 
            // readerPhonePanel
            // 
            readerPhonePanel.Controls.Add(readerPhoneTextBox);
            readerPhonePanel.Controls.Add(readerPhoneLabel);
            readerPhonePanel.Dock = DockStyle.Top;
            readerPhonePanel.Location = new Point(0, 41);
            readerPhonePanel.Name = "readerPhonePanel";
            readerPhonePanel.Size = new Size(502, 47);
            readerPhonePanel.TabIndex = 1;
            // 
            // readerPhoneLabel
            // 
            readerPhoneLabel.Dock = DockStyle.Left;
            readerPhoneLabel.Location = new Point(0, 0);
            readerPhoneLabel.Name = "readerPhoneLabel";
            readerPhoneLabel.Size = new Size(212, 47);
            readerPhoneLabel.TabIndex = 0;
            readerPhoneLabel.Text = "Номер телефона";
            readerPhoneLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // readerPhoneTextBox
            // 
            readerPhoneTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            readerPhoneTextBox.Location = new Point(243, 8);
            readerPhoneTextBox.Name = "readerPhoneTextBox";
            readerPhoneTextBox.Size = new Size(247, 31);
            readerPhoneTextBox.TabIndex = 1;
            // 
            // readerAddressPanel
            // 
            readerAddressPanel.Controls.Add(readerAddressTextBox);
            readerAddressPanel.Controls.Add(readerAddressLabel);
            readerAddressPanel.Dock = DockStyle.Fill;
            readerAddressPanel.Location = new Point(0, 88);
            readerAddressPanel.Name = "readerAddressPanel";
            readerAddressPanel.Size = new Size(502, 103);
            readerAddressPanel.TabIndex = 2;
            // 
            // readerAddressLabel
            // 
            readerAddressLabel.Dock = DockStyle.Left;
            readerAddressLabel.Location = new Point(0, 0);
            readerAddressLabel.Name = "readerAddressLabel";
            readerAddressLabel.Size = new Size(212, 103);
            readerAddressLabel.TabIndex = 0;
            readerAddressLabel.Text = "Адрес";
            readerAddressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // readerAddressTextBox
            // 
            readerAddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            readerAddressTextBox.Location = new Point(243, 16);
            readerAddressTextBox.Multiline = true;
            readerAddressTextBox.Name = "readerAddressTextBox";
            readerAddressTextBox.Size = new Size(247, 69);
            readerAddressTextBox.TabIndex = 1;
            // 
            // addReaderButtonsPanel
            // 
            addReaderButtonsPanel.Controls.Add(saveNewReaderButton);
            addReaderButtonsPanel.Controls.Add(discardAddReaderButton);
            addReaderButtonsPanel.Dock = DockStyle.Bottom;
            addReaderButtonsPanel.Location = new Point(0, 277);
            addReaderButtonsPanel.Name = "addReaderButtonsPanel";
            addReaderButtonsPanel.Size = new Size(502, 70);
            addReaderButtonsPanel.TabIndex = 2;
            // 
            // discardAddReaderButton
            // 
            discardAddReaderButton.BackColor = Color.Coral;
            discardAddReaderButton.Cursor = Cursors.Hand;
            discardAddReaderButton.Dock = DockStyle.Left;
            discardAddReaderButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            discardAddReaderButton.Location = new Point(0, 0);
            discardAddReaderButton.Name = "discardAddReaderButton";
            discardAddReaderButton.Size = new Size(106, 70);
            discardAddReaderButton.TabIndex = 2;
            discardAddReaderButton.Text = "Отмена";
            discardAddReaderButton.UseVisualStyleBackColor = false;
            // 
            // saveNewReaderButton
            // 
            saveNewReaderButton.BackColor = Color.Coral;
            saveNewReaderButton.Cursor = Cursors.Hand;
            saveNewReaderButton.Dock = DockStyle.Right;
            saveNewReaderButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveNewReaderButton.Location = new Point(340, 0);
            saveNewReaderButton.Name = "saveNewReaderButton";
            saveNewReaderButton.Size = new Size(162, 70);
            saveNewReaderButton.TabIndex = 3;
            saveNewReaderButton.Text = "Сохранить";
            saveNewReaderButton.UseVisualStyleBackColor = false;
            // 
            // AddReaderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(502, 347);
            Controls.Add(addReaderButtonsPanel);
            Controls.Add(addClientInfoPanel);
            Controls.Add(addReaderLabel);
            Name = "AddReaderForm";
            Text = "Новый читатель";
            addClientInfoPanel.ResumeLayout(false);
            readerNamePanel.ResumeLayout(false);
            readerNamePanel.PerformLayout();
            readerPhonePanel.ResumeLayout(false);
            readerPhonePanel.PerformLayout();
            readerAddressPanel.ResumeLayout(false);
            readerAddressPanel.PerformLayout();
            addReaderButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label addReaderLabel;
        private Panel addClientInfoPanel;
        private Panel readerNamePanel;
        private TextBox readerNameTextBox;
        private Label readerNameLabel;
        private Panel readerPhonePanel;
        private Panel readerAddressPanel;
        private TextBox readerAddressTextBox;
        private Label readerAddressLabel;
        private TextBox readerPhoneTextBox;
        private Label readerPhoneLabel;
        private Panel addReaderButtonsPanel;
        private Button discardAddReaderButton;
        private Button saveNewReaderButton;
    }
}