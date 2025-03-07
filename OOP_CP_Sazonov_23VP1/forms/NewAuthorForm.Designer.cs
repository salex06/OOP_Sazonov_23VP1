namespace OOP_CP_Sazonov_23VP1.forms
{
    partial class NewAuthorForm
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
            panel1 = new Panel();
            addAuthorButtonsPanel = new Panel();
            discardAddAuthorButton = new Button();
            saveNewAuthorButton = new Button();
            addAuthorNamePanel = new Panel();
            addAuthorNameLabel = new Label();
            addAuthorNameTextBox = new TextBox();
            editAuthorBirthdayPanel = new Panel();
            addAuthorBirthdayLabel = new Label();
            addAuthorsBirthdayTimePicker = new DateTimePicker();
            panel1.SuspendLayout();
            addAuthorButtonsPanel.SuspendLayout();
            addAuthorNamePanel.SuspendLayout();
            editAuthorBirthdayPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(editAuthorBirthdayPanel);
            panel1.Controls.Add(addAuthorNamePanel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 138);
            panel1.TabIndex = 0;
            // 
            // addAuthorButtonsPanel
            // 
            addAuthorButtonsPanel.Controls.Add(discardAddAuthorButton);
            addAuthorButtonsPanel.Controls.Add(saveNewAuthorButton);
            addAuthorButtonsPanel.Dock = DockStyle.Bottom;
            addAuthorButtonsPanel.Location = new Point(0, 163);
            addAuthorButtonsPanel.Name = "addAuthorButtonsPanel";
            addAuthorButtonsPanel.Size = new Size(370, 75);
            addAuthorButtonsPanel.TabIndex = 9;
            // 
            // discardAddAuthorButton
            // 
            discardAddAuthorButton.BackColor = Color.Coral;
            discardAddAuthorButton.Cursor = Cursors.Hand;
            discardAddAuthorButton.Dock = DockStyle.Left;
            discardAddAuthorButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            discardAddAuthorButton.Location = new Point(0, 0);
            discardAddAuthorButton.Name = "discardAddAuthorButton";
            discardAddAuthorButton.Size = new Size(145, 75);
            discardAddAuthorButton.TabIndex = 1;
            discardAddAuthorButton.Text = "Отмена";
            discardAddAuthorButton.UseVisualStyleBackColor = false;
            // 
            // saveNewAuthorButton
            // 
            saveNewAuthorButton.BackColor = Color.Coral;
            saveNewAuthorButton.Cursor = Cursors.Hand;
            saveNewAuthorButton.Dock = DockStyle.Right;
            saveNewAuthorButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveNewAuthorButton.Location = new Point(208, 0);
            saveNewAuthorButton.Name = "saveNewAuthorButton";
            saveNewAuthorButton.Size = new Size(162, 75);
            saveNewAuthorButton.TabIndex = 0;
            saveNewAuthorButton.Text = "Добавить";
            saveNewAuthorButton.UseVisualStyleBackColor = false;
            // 
            // addAuthorNamePanel
            // 
            addAuthorNamePanel.Controls.Add(addAuthorNameTextBox);
            addAuthorNamePanel.Controls.Add(addAuthorNameLabel);
            addAuthorNamePanel.Dock = DockStyle.Top;
            addAuthorNamePanel.Location = new Point(0, 0);
            addAuthorNamePanel.Name = "addAuthorNamePanel";
            addAuthorNamePanel.Size = new Size(370, 71);
            addAuthorNamePanel.TabIndex = 0;
            // 
            // addAuthorNameLabel
            // 
            addAuthorNameLabel.Dock = DockStyle.Left;
            addAuthorNameLabel.Location = new Point(0, 0);
            addAuthorNameLabel.Name = "addAuthorNameLabel";
            addAuthorNameLabel.Size = new Size(145, 71);
            addAuthorNameLabel.TabIndex = 0;
            addAuthorNameLabel.Text = "Имя автора";
            addAuthorNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addAuthorNameTextBox
            // 
            addAuthorNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addAuthorNameTextBox.Location = new Point(164, 20);
            addAuthorNameTextBox.Name = "addAuthorNameTextBox";
            addAuthorNameTextBox.Size = new Size(194, 31);
            addAuthorNameTextBox.TabIndex = 1;
            // 
            // editAuthorBirthdayPanel
            // 
            editAuthorBirthdayPanel.Controls.Add(addAuthorsBirthdayTimePicker);
            editAuthorBirthdayPanel.Controls.Add(addAuthorBirthdayLabel);
            editAuthorBirthdayPanel.Dock = DockStyle.Top;
            editAuthorBirthdayPanel.Location = new Point(0, 71);
            editAuthorBirthdayPanel.Name = "editAuthorBirthdayPanel";
            editAuthorBirthdayPanel.Size = new Size(370, 64);
            editAuthorBirthdayPanel.TabIndex = 1;
            // 
            // addAuthorBirthdayLabel
            // 
            addAuthorBirthdayLabel.Dock = DockStyle.Left;
            addAuthorBirthdayLabel.Location = new Point(0, 0);
            addAuthorBirthdayLabel.Name = "addAuthorBirthdayLabel";
            addAuthorBirthdayLabel.Size = new Size(145, 64);
            addAuthorBirthdayLabel.TabIndex = 0;
            addAuthorBirthdayLabel.Text = "Дата рождения";
            addAuthorBirthdayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addAuthorsBirthdayTimePicker
            // 
            addAuthorsBirthdayTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addAuthorsBirthdayTimePicker.Location = new Point(164, 15);
            addAuthorsBirthdayTimePicker.Name = "addAuthorsBirthdayTimePicker";
            addAuthorsBirthdayTimePicker.Size = new Size(194, 31);
            addAuthorsBirthdayTimePicker.TabIndex = 10;
            addAuthorsBirthdayTimePicker.Value = new DateTime(2025, 3, 7, 16, 57, 54, 0);
            // 
            // NewAuthorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(370, 238);
            Controls.Add(addAuthorButtonsPanel);
            Controls.Add(panel1);
            Name = "NewAuthorForm";
            Text = "Новый автор";
            panel1.ResumeLayout(false);
            addAuthorButtonsPanel.ResumeLayout(false);
            addAuthorNamePanel.ResumeLayout(false);
            addAuthorNamePanel.PerformLayout();
            editAuthorBirthdayPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel addAuthorButtonsPanel;
        private Button discardAddAuthorButton;
        private Button saveNewAuthorButton;
        private Panel addAuthorNamePanel;
        private Panel editAuthorBirthdayPanel;
        private DateTimePicker addAuthorsBirthdayTimePicker;
        private Label addAuthorBirthdayLabel;
        private TextBox addAuthorNameTextBox;
        private Label addAuthorNameLabel;
    }
}