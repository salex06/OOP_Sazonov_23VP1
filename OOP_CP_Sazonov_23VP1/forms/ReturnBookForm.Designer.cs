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
            numericUpDown1 = new NumericUpDown();
            bookIdLabel = new Label();
            readerIdPanel = new Panel();
            readerIdNumericUpDown = new NumericUpDown();
            readerIdLabel = new Label();
            returnBookButtonsPanel = new Panel();
            returnBookButton = new Button();
            returnBookDataPanel.SuspendLayout();
            bookIdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            readerIdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readerIdNumericUpDown).BeginInit();
            returnBookButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // returnBookDataPanel
            // 
            returnBookDataPanel.Controls.Add(bookIdPanel);
            returnBookDataPanel.Controls.Add(readerIdPanel);
            returnBookDataPanel.Dock = DockStyle.Top;
            returnBookDataPanel.Location = new Point(0, 0);
            returnBookDataPanel.Name = "returnBookDataPanel";
            returnBookDataPanel.Padding = new Padding(10);
            returnBookDataPanel.Size = new Size(347, 119);
            returnBookDataPanel.TabIndex = 0;
            // 
            // bookIdPanel
            // 
            bookIdPanel.Controls.Add(numericUpDown1);
            bookIdPanel.Controls.Add(bookIdLabel);
            bookIdPanel.Dock = DockStyle.Fill;
            bookIdPanel.Location = new Point(10, 56);
            bookIdPanel.Name = "bookIdPanel";
            bookIdPanel.Size = new Size(327, 53);
            bookIdPanel.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown1.Location = new Point(182, 15);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(121, 31);
            numericUpDown1.TabIndex = 1;
            // 
            // bookIdLabel
            // 
            bookIdLabel.Dock = DockStyle.Left;
            bookIdLabel.Location = new Point(0, 0);
            bookIdLabel.Name = "bookIdLabel";
            bookIdLabel.Size = new Size(157, 53);
            bookIdLabel.TabIndex = 0;
            bookIdLabel.Text = "ID книги";
            bookIdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // readerIdPanel
            // 
            readerIdPanel.Controls.Add(readerIdNumericUpDown);
            readerIdPanel.Controls.Add(readerIdLabel);
            readerIdPanel.Dock = DockStyle.Top;
            readerIdPanel.Location = new Point(10, 10);
            readerIdPanel.Name = "readerIdPanel";
            readerIdPanel.Size = new Size(327, 46);
            readerIdPanel.TabIndex = 0;
            // 
            // readerIdNumericUpDown
            // 
            readerIdNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            readerIdNumericUpDown.Location = new Point(183, 9);
            readerIdNumericUpDown.Name = "readerIdNumericUpDown";
            readerIdNumericUpDown.Size = new Size(120, 31);
            readerIdNumericUpDown.TabIndex = 1;
            // 
            // readerIdLabel
            // 
            readerIdLabel.Dock = DockStyle.Left;
            readerIdLabel.Location = new Point(0, 0);
            readerIdLabel.Name = "readerIdLabel";
            readerIdLabel.Size = new Size(157, 46);
            readerIdLabel.TabIndex = 0;
            readerIdLabel.Text = "ID читателя";
            readerIdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // returnBookButtonsPanel
            // 
            returnBookButtonsPanel.Controls.Add(returnBookButton);
            returnBookButtonsPanel.Dock = DockStyle.Bottom;
            returnBookButtonsPanel.Location = new Point(0, 150);
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
            // 
            // ReturnBookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(347, 202);
            Controls.Add(returnBookButtonsPanel);
            Controls.Add(returnBookDataPanel);
            Name = "ReturnBookForm";
            Text = "Возврат книги";
            returnBookDataPanel.ResumeLayout(false);
            bookIdPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            readerIdPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)readerIdNumericUpDown).EndInit();
            returnBookButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel returnBookDataPanel;
        private Panel readerIdPanel;
        private Label readerIdLabel;
        private Panel bookIdPanel;
        private NumericUpDown numericUpDown1;
        private Label bookIdLabel;
        private NumericUpDown readerIdNumericUpDown;
        private Panel returnBookButtonsPanel;
        private Button returnBookButton;
    }
}