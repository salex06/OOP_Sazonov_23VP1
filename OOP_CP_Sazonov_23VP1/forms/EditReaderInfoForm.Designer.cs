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
            editReaderInfoButtonsPanel = new Panel();
            saveReaderChangesButton = new Button();
            discardEditReaderInfoButton = new Button();
            editReaderIdPanel = new Panel();
            loadReaderInfoButton = new Button();
            editReaderIdNumericUpDown = new NumericUpDown();
            editReaderIdLabel = new Label();
            editReaderSettingsPanel = new Panel();
            editReaderAddressPanel = new Panel();
            editReaderAddressTextBox = new TextBox();
            editReaderAddressLabel = new Label();
            editReaderPhonePanel = new Panel();
            editPhoneNumberTextBox = new TextBox();
            editReaderPhoneLabel = new Label();
            editReaderNamePanel = new Panel();
            editReaderNameTextBox = new TextBox();
            editReaderNameLabel = new Label();
            editReaderInfoButtonsPanel.SuspendLayout();
            editReaderIdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)editReaderIdNumericUpDown).BeginInit();
            editReaderSettingsPanel.SuspendLayout();
            editReaderAddressPanel.SuspendLayout();
            editReaderPhonePanel.SuspendLayout();
            editReaderNamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // editReaderInfoButtonsPanel
            // 
            editReaderInfoButtonsPanel.Controls.Add(saveReaderChangesButton);
            editReaderInfoButtonsPanel.Controls.Add(discardEditReaderInfoButton);
            editReaderInfoButtonsPanel.Dock = DockStyle.Bottom;
            editReaderInfoButtonsPanel.Location = new Point(0, 357);
            editReaderInfoButtonsPanel.Name = "editReaderInfoButtonsPanel";
            editReaderInfoButtonsPanel.Size = new Size(404, 66);
            editReaderInfoButtonsPanel.TabIndex = 1;
            // 
            // saveReaderChangesButton
            // 
            saveReaderChangesButton.BackColor = Color.Coral;
            saveReaderChangesButton.Cursor = Cursors.Hand;
            saveReaderChangesButton.Dock = DockStyle.Right;
            saveReaderChangesButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveReaderChangesButton.Location = new Point(242, 0);
            saveReaderChangesButton.Name = "saveReaderChangesButton";
            saveReaderChangesButton.Size = new Size(162, 66);
            saveReaderChangesButton.TabIndex = 3;
            saveReaderChangesButton.Text = "Сохранить изменения";
            saveReaderChangesButton.UseVisualStyleBackColor = false;
            saveReaderChangesButton.Click += saveReaderChangesButton_Click;
            // 
            // discardEditReaderInfoButton
            // 
            discardEditReaderInfoButton.BackColor = Color.Coral;
            discardEditReaderInfoButton.Cursor = Cursors.Hand;
            discardEditReaderInfoButton.Dock = DockStyle.Left;
            discardEditReaderInfoButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            discardEditReaderInfoButton.Location = new Point(0, 0);
            discardEditReaderInfoButton.Name = "discardEditReaderInfoButton";
            discardEditReaderInfoButton.Size = new Size(142, 66);
            discardEditReaderInfoButton.TabIndex = 2;
            discardEditReaderInfoButton.Text = "Отменить изменения";
            discardEditReaderInfoButton.UseVisualStyleBackColor = false;
            discardEditReaderInfoButton.Click += discardEditReaderInfoButton_Click;
            // 
            // editReaderIdPanel
            // 
            editReaderIdPanel.Controls.Add(loadReaderInfoButton);
            editReaderIdPanel.Controls.Add(editReaderIdNumericUpDown);
            editReaderIdPanel.Controls.Add(editReaderIdLabel);
            editReaderIdPanel.Dock = DockStyle.Top;
            editReaderIdPanel.Location = new Point(0, 0);
            editReaderIdPanel.Name = "editReaderIdPanel";
            editReaderIdPanel.Size = new Size(404, 121);
            editReaderIdPanel.TabIndex = 2;
            // 
            // loadReaderInfoButton
            // 
            loadReaderInfoButton.BackColor = Color.LightSalmon;
            loadReaderInfoButton.Cursor = Cursors.Hand;
            loadReaderInfoButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loadReaderInfoButton.Location = new Point(206, 55);
            loadReaderInfoButton.Name = "loadReaderInfoButton";
            loadReaderInfoButton.Size = new Size(185, 60);
            loadReaderInfoButton.TabIndex = 4;
            loadReaderInfoButton.Text = "Загрузить данные читателя";
            loadReaderInfoButton.UseVisualStyleBackColor = false;
            loadReaderInfoButton.Click += loadReaderInfoButton_Click;
            // 
            // editReaderIdNumericUpDown
            // 
            editReaderIdNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editReaderIdNumericUpDown.Location = new Point(206, 18);
            editReaderIdNumericUpDown.Name = "editReaderIdNumericUpDown";
            editReaderIdNumericUpDown.Size = new Size(185, 31);
            editReaderIdNumericUpDown.TabIndex = 1;
            // 
            // editReaderIdLabel
            // 
            editReaderIdLabel.Dock = DockStyle.Left;
            editReaderIdLabel.Location = new Point(0, 0);
            editReaderIdLabel.Name = "editReaderIdLabel";
            editReaderIdLabel.Size = new Size(213, 121);
            editReaderIdLabel.TabIndex = 0;
            editReaderIdLabel.Text = "ID читателя";
            editReaderIdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editReaderSettingsPanel
            // 
            editReaderSettingsPanel.Controls.Add(editReaderAddressPanel);
            editReaderSettingsPanel.Controls.Add(editReaderPhonePanel);
            editReaderSettingsPanel.Controls.Add(editReaderNamePanel);
            editReaderSettingsPanel.Dock = DockStyle.Top;
            editReaderSettingsPanel.Location = new Point(0, 121);
            editReaderSettingsPanel.Name = "editReaderSettingsPanel";
            editReaderSettingsPanel.Padding = new Padding(10);
            editReaderSettingsPanel.Size = new Size(404, 190);
            editReaderSettingsPanel.TabIndex = 3;
            // 
            // editReaderAddressPanel
            // 
            editReaderAddressPanel.Controls.Add(editReaderAddressTextBox);
            editReaderAddressPanel.Controls.Add(editReaderAddressLabel);
            editReaderAddressPanel.Dock = DockStyle.Top;
            editReaderAddressPanel.Location = new Point(10, 108);
            editReaderAddressPanel.Name = "editReaderAddressPanel";
            editReaderAddressPanel.Size = new Size(384, 71);
            editReaderAddressPanel.TabIndex = 2;
            // 
            // editReaderAddressTextBox
            // 
            editReaderAddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editReaderAddressTextBox.Location = new Point(209, 9);
            editReaderAddressTextBox.Multiline = true;
            editReaderAddressTextBox.Name = "editReaderAddressTextBox";
            editReaderAddressTextBox.Size = new Size(172, 56);
            editReaderAddressTextBox.TabIndex = 1;
            // 
            // editReaderAddressLabel
            // 
            editReaderAddressLabel.Dock = DockStyle.Left;
            editReaderAddressLabel.Location = new Point(0, 0);
            editReaderAddressLabel.Name = "editReaderAddressLabel";
            editReaderAddressLabel.Size = new Size(203, 71);
            editReaderAddressLabel.TabIndex = 0;
            editReaderAddressLabel.Text = "Адрес";
            editReaderAddressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editReaderPhonePanel
            // 
            editReaderPhonePanel.Controls.Add(editPhoneNumberTextBox);
            editReaderPhonePanel.Controls.Add(editReaderPhoneLabel);
            editReaderPhonePanel.Dock = DockStyle.Top;
            editReaderPhonePanel.Location = new Point(10, 59);
            editReaderPhonePanel.Name = "editReaderPhonePanel";
            editReaderPhonePanel.Size = new Size(384, 49);
            editReaderPhonePanel.TabIndex = 1;
            // 
            // editPhoneNumberTextBox
            // 
            editPhoneNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editPhoneNumberTextBox.Location = new Point(209, 9);
            editPhoneNumberTextBox.Name = "editPhoneNumberTextBox";
            editPhoneNumberTextBox.Size = new Size(172, 31);
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
            // editReaderNamePanel
            // 
            editReaderNamePanel.Controls.Add(editReaderNameTextBox);
            editReaderNamePanel.Controls.Add(editReaderNameLabel);
            editReaderNamePanel.Dock = DockStyle.Top;
            editReaderNamePanel.Location = new Point(10, 10);
            editReaderNamePanel.Name = "editReaderNamePanel";
            editReaderNamePanel.Size = new Size(384, 49);
            editReaderNamePanel.TabIndex = 0;
            // 
            // editReaderNameTextBox
            // 
            editReaderNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editReaderNameTextBox.Location = new Point(209, 9);
            editReaderNameTextBox.Name = "editReaderNameTextBox";
            editReaderNameTextBox.Size = new Size(172, 31);
            editReaderNameTextBox.TabIndex = 1;
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
            // EditReaderInfoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(404, 423);
            Controls.Add(editReaderSettingsPanel);
            Controls.Add(editReaderIdPanel);
            Controls.Add(editReaderInfoButtonsPanel);
            Name = "EditReaderInfoForm";
            Text = "Редактирование информации";
            editReaderInfoButtonsPanel.ResumeLayout(false);
            editReaderIdPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)editReaderIdNumericUpDown).EndInit();
            editReaderSettingsPanel.ResumeLayout(false);
            editReaderAddressPanel.ResumeLayout(false);
            editReaderAddressPanel.PerformLayout();
            editReaderPhonePanel.ResumeLayout(false);
            editReaderPhonePanel.PerformLayout();
            editReaderNamePanel.ResumeLayout(false);
            editReaderNamePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel editReaderInfoButtonsPanel;
        private Button discardEditReaderInfoButton;
        private Button saveReaderChangesButton;
        private Panel editReaderIdPanel;
        private NumericUpDown editReaderIdNumericUpDown;
        private Label editReaderIdLabel;
        private Panel editReaderSettingsPanel;
        private Panel editReaderAddressPanel;
        private TextBox editReaderAddressTextBox;
        private Label editReaderAddressLabel;
        private Panel editReaderPhonePanel;
        private TextBox editPhoneNumberTextBox;
        private Label editReaderPhoneLabel;
        private Panel editReaderNamePanel;
        private TextBox editReaderNameTextBox;
        private Label editReaderNameLabel;
        private Button loadReaderInfoButton;
    }
}