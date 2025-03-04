namespace OOP_CP_Sazonov_23VP1.forms
{
    partial class RemoveBookForm
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
            deleteFormLabel = new Label();
            deleteBookIdNumericUpDown = new NumericUpDown();
            deleteBookButton = new Button();
            textBox1 = new TextBox();
            deleteExtraPanel = new Panel();
            deleteFormPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)deleteBookIdNumericUpDown).BeginInit();
            deleteExtraPanel.SuspendLayout();
            deleteFormPanel.SuspendLayout();
            SuspendLayout();
            // 
            // deleteFormLabel
            // 
            deleteFormLabel.Dock = DockStyle.Left;
            deleteFormLabel.Location = new Point(0, 0);
            deleteFormLabel.Name = "deleteFormLabel";
            deleteFormLabel.Size = new Size(268, 75);
            deleteFormLabel.TabIndex = 0;
            deleteFormLabel.Text = "Введите ID книги для удаления:";
            deleteFormLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deleteBookIdNumericUpDown
            // 
            deleteBookIdNumericUpDown.Anchor = AnchorStyles.None;
            deleteBookIdNumericUpDown.AutoSize = true;
            deleteBookIdNumericUpDown.Location = new Point(321, 23);
            deleteBookIdNumericUpDown.Name = "deleteBookIdNumericUpDown";
            deleteBookIdNumericUpDown.Size = new Size(180, 31);
            deleteBookIdNumericUpDown.TabIndex = 1;
            // 
            // deleteBookButton
            // 
            deleteBookButton.AutoSize = true;
            deleteBookButton.BackColor = Color.Coral;
            deleteBookButton.Dock = DockStyle.Right;
            deleteBookButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteBookButton.Location = new Point(372, 0);
            deleteBookButton.Name = "deleteBookButton";
            deleteBookButton.Size = new Size(191, 60);
            deleteBookButton.TabIndex = 0;
            deleteBookButton.Text = "Удалить книгу";
            deleteBookButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(-85, 17);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(378, 31);
            textBox1.TabIndex = 1;
            // 
            // deleteExtraPanel
            // 
            deleteExtraPanel.Controls.Add(textBox1);
            deleteExtraPanel.Controls.Add(deleteBookButton);
            deleteExtraPanel.Dock = DockStyle.Bottom;
            deleteExtraPanel.Location = new Point(0, 107);
            deleteExtraPanel.Name = "deleteExtraPanel";
            deleteExtraPanel.Size = new Size(563, 60);
            deleteExtraPanel.TabIndex = 1;
            // 
            // deleteFormPanel
            // 
            deleteFormPanel.Controls.Add(deleteBookIdNumericUpDown);
            deleteFormPanel.Controls.Add(deleteFormLabel);
            deleteFormPanel.Dock = DockStyle.Top;
            deleteFormPanel.Location = new Point(0, 0);
            deleteFormPanel.Name = "deleteFormPanel";
            deleteFormPanel.Size = new Size(563, 75);
            deleteFormPanel.TabIndex = 0;
            // 
            // RemoveBookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(563, 167);
            Controls.Add(deleteExtraPanel);
            Controls.Add(deleteFormPanel);
            Name = "RemoveBookForm";
            Text = "Удаление книги";
            ((System.ComponentModel.ISupportInitialize)deleteBookIdNumericUpDown).EndInit();
            deleteExtraPanel.ResumeLayout(false);
            deleteExtraPanel.PerformLayout();
            deleteFormPanel.ResumeLayout(false);
            deleteFormPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private NumericUpDown deleteBookIdNumericUpDown;
        private Label deleteFormLabel;
        private Button deleteBookButton;
        private TextBox textBox1;
        private Panel deleteExtraPanel;
        private Panel deleteFormPanel;
    }
}