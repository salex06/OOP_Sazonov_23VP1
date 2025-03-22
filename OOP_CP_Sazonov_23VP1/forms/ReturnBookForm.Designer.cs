namespace OOP_CP_Sazonov_23VP1.forms
{
    partial class ReturnBookForm
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
            returnBookDataPanel = new Panel();
            bookIdPanel = new Panel();
            bookIdNumericUpDown = new NumericUpDown();
            bookIdLabel = new Label();
            returnBookButtonsPanel = new Panel();
            returnBookButton = new Button();
            returnBookDataPanel.SuspendLayout();
            bookIdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookIdNumericUpDown).BeginInit();
            returnBookButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // returnBookDataPanel
            // 
            returnBookDataPanel.Controls.Add(bookIdPanel);
            returnBookDataPanel.Dock = DockStyle.Top;
            returnBookDataPanel.Location = new Point(0, 0);
            returnBookDataPanel.Name = "returnBookDataPanel";
            returnBookDataPanel.Padding = new Padding(10);
            returnBookDataPanel.Size = new Size(347, 103);
            returnBookDataPanel.TabIndex = 0;
            // 
            // bookIdPanel
            // 
            bookIdPanel.Controls.Add(bookIdNumericUpDown);
            bookIdPanel.Controls.Add(bookIdLabel);
            bookIdPanel.Dock = DockStyle.Fill;
            bookIdPanel.Location = new Point(10, 10);
            bookIdPanel.Name = "bookIdPanel";
            bookIdPanel.Size = new Size(327, 83);
            bookIdPanel.TabIndex = 1;
            // 
            // bookIdNumericUpDown
            // 
            bookIdNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bookIdNumericUpDown.Location = new Point(185, 27);
            bookIdNumericUpDown.Name = "bookIdNumericUpDown";
            bookIdNumericUpDown.Size = new Size(121, 31);
            bookIdNumericUpDown.TabIndex = 1;
            // 
            // bookIdLabel
            // 
            bookIdLabel.Dock = DockStyle.Left;
            bookIdLabel.Location = new Point(0, 0);
            bookIdLabel.Name = "bookIdLabel";
            bookIdLabel.Size = new Size(157, 83);
            bookIdLabel.TabIndex = 0;
            bookIdLabel.Text = "ID книги";
            bookIdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // returnBookButtonsPanel
            // 
            returnBookButtonsPanel.Controls.Add(returnBookButton);
            returnBookButtonsPanel.Dock = DockStyle.Bottom;
            returnBookButtonsPanel.Location = new Point(0, 115);
            returnBookButtonsPanel.Name = "returnBookButtonsPanel";
            returnBookButtonsPanel.Size = new Size(347, 52);
            returnBookButtonsPanel.TabIndex = 1;
            // 
            // returnBookButton
            // 
            returnBookButton.BackColor = Color.Coral;
            returnBookButton.Cursor = Cursors.Hand;
            returnBookButton.Dock = DockStyle.Fill;
            returnBookButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            returnBookButton.Location = new Point(0, 0);
            returnBookButton.Name = "returnBookButton";
            returnBookButton.Size = new Size(347, 52);
            returnBookButton.TabIndex = 4;
            returnBookButton.Text = "Вернуть книгу";
            returnBookButton.UseVisualStyleBackColor = false;
            returnBookButton.Click += returnBookButton_Click;
            // 
            // ReturnBookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(347, 167);
            Controls.Add(returnBookButtonsPanel);
            Controls.Add(returnBookDataPanel);
            Name = "ReturnBookForm";
            Text = "Возврат книги";
            returnBookDataPanel.ResumeLayout(false);
            bookIdPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bookIdNumericUpDown).EndInit();
            returnBookButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel returnBookDataPanel;
        private Panel bookIdPanel;
        private NumericUpDown bookIdNumericUpDown;
        private Label bookIdLabel;
        private Panel returnBookButtonsPanel;
        private Button returnBookButton;
    }
}