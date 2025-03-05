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
            panel1 = new Panel();
            giveBookReaderIdNumericUpDown = new NumericUpDown();
            giveBookReaderIdLabel = new Label();
            giveBookActions = new Panel();
            giveOutABookButton = new Button();
            checkGiveBookInfoButton = new Button();
            giveBookInfoTextBox = new RichTextBox();
            giveBookDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)giveBookIdNumericUpDown).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)giveBookReaderIdNumericUpDown).BeginInit();
            giveBookActions.SuspendLayout();
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
            giveBookIdNumericUpDown.Anchor = AnchorStyles.None;
            giveBookIdNumericUpDown.AutoSize = true;
            giveBookIdNumericUpDown.Location = new Point(346, 23);
            giveBookIdNumericUpDown.Name = "giveBookIdNumericUpDown";
            giveBookIdNumericUpDown.Size = new Size(180, 31);
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
            // panel1
            // 
            panel1.Controls.Add(giveBookReaderIdNumericUpDown);
            panel1.Controls.Add(giveBookReaderIdLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 57);
            panel1.TabIndex = 1;
            // 
            // giveBookReaderIdNumericUpDown
            // 
            giveBookReaderIdNumericUpDown.Anchor = AnchorStyles.None;
            giveBookReaderIdNumericUpDown.AutoSize = true;
            giveBookReaderIdNumericUpDown.Location = new Point(346, 14);
            giveBookReaderIdNumericUpDown.Name = "giveBookReaderIdNumericUpDown";
            giveBookReaderIdNumericUpDown.Size = new Size(180, 31);
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
            giveBookActions.Controls.Add(checkGiveBookInfoButton);
            giveBookActions.Dock = DockStyle.Bottom;
            giveBookActions.Location = new Point(0, 296);
            giveBookActions.Name = "giveBookActions";
            giveBookActions.Size = new Size(548, 65);
            giveBookActions.TabIndex = 2;
            // 
            // giveOutABookButton
            // 
            giveOutABookButton.AutoSize = true;
            giveOutABookButton.BackColor = Color.Coral;
            giveOutABookButton.Dock = DockStyle.Right;
            giveOutABookButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            giveOutABookButton.Location = new Point(372, 0);
            giveOutABookButton.Name = "giveOutABookButton";
            giveOutABookButton.Size = new Size(176, 65);
            giveOutABookButton.TabIndex = 0;
            giveOutABookButton.Text = "Выдать книгу";
            giveOutABookButton.UseVisualStyleBackColor = false;
            // 
            // checkGiveBookInfoButton
            // 
            checkGiveBookInfoButton.AutoSize = true;
            checkGiveBookInfoButton.BackColor = Color.Coral;
            checkGiveBookInfoButton.Dock = DockStyle.Left;
            checkGiveBookInfoButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkGiveBookInfoButton.Location = new Point(0, 0);
            checkGiveBookInfoButton.Name = "checkGiveBookInfoButton";
            checkGiveBookInfoButton.Size = new Size(240, 65);
            checkGiveBookInfoButton.TabIndex = 1;
            checkGiveBookInfoButton.Text = "Проверить данные";
            checkGiveBookInfoButton.UseVisualStyleBackColor = false;
            // 
            // giveBookInfoTextBox
            // 
            giveBookInfoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            giveBookInfoTextBox.Location = new Point(0, 145);
            giveBookInfoTextBox.Name = "giveBookInfoTextBox";
            giveBookInfoTextBox.ReadOnly = true;
            giveBookInfoTextBox.Size = new Size(238, 142);
            giveBookInfoTextBox.TabIndex = 3;
            giveBookInfoTextBox.Text = "";
            // 
            // GiveOutABookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(548, 361);
            Controls.Add(giveBookInfoTextBox);
            Controls.Add(giveBookActions);
            Controls.Add(panel1);
            Controls.Add(giveBookDataPanel);
            Name = "GiveOutABookForm";
            Text = "Выдать книгу";
            giveBookDataPanel.ResumeLayout(false);
            giveBookDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)giveBookIdNumericUpDown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)giveBookReaderIdNumericUpDown).EndInit();
            giveBookActions.ResumeLayout(false);
            giveBookActions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel giveBookDataPanel;
        private Label giveBookIdLabel;
        private NumericUpDown giveBookIdNumericUpDown;
        private Panel panel1;
        private NumericUpDown giveBookReaderIdNumericUpDown;
        private Label giveBookReaderIdLabel;
        private Panel giveBookActions;
        private Button giveOutABookButton;
        private Button checkGiveBookInfoButton;
        private RichTextBox giveBookInfoTextBox;
    }
}