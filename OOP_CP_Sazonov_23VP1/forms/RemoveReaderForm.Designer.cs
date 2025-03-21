namespace OOP_CP_Sazonov_23VP1.forms
{
    partial class RemoveReaderForm
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
            readerInfoPanel = new Panel();
            readerIdNumericUpDown = new NumericUpDown();
            readerIdLabel = new Label();
            removeReaderButtonsPanel = new Panel();
            removeReaderButton = new Button();
            readerInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readerIdNumericUpDown).BeginInit();
            removeReaderButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // readerInfoPanel
            // 
            readerInfoPanel.Controls.Add(readerIdNumericUpDown);
            readerInfoPanel.Controls.Add(readerIdLabel);
            readerInfoPanel.Dock = DockStyle.Top;
            readerInfoPanel.Location = new Point(0, 0);
            readerInfoPanel.Name = "readerInfoPanel";
            readerInfoPanel.Size = new Size(333, 125);
            readerInfoPanel.TabIndex = 0;
            // 
            // readerIdNumericUpDown
            // 
            readerIdNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            readerIdNumericUpDown.Location = new Point(173, 48);
            readerIdNumericUpDown.Name = "readerIdNumericUpDown";
            readerIdNumericUpDown.Size = new Size(148, 31);
            readerIdNumericUpDown.TabIndex = 1;
            // 
            // readerIdLabel
            // 
            readerIdLabel.Dock = DockStyle.Left;
            readerIdLabel.Location = new Point(0, 0);
            readerIdLabel.Name = "readerIdLabel";
            readerIdLabel.Size = new Size(161, 125);
            readerIdLabel.TabIndex = 0;
            readerIdLabel.Text = "ID читателя";
            readerIdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // removeReaderButtonsPanel
            // 
            removeReaderButtonsPanel.Controls.Add(removeReaderButton);
            removeReaderButtonsPanel.Dock = DockStyle.Fill;
            removeReaderButtonsPanel.Location = new Point(0, 125);
            removeReaderButtonsPanel.Name = "removeReaderButtonsPanel";
            removeReaderButtonsPanel.Size = new Size(333, 60);
            removeReaderButtonsPanel.TabIndex = 1;
            // 
            // removeReaderButton
            // 
            removeReaderButton.BackColor = Color.Coral;
            removeReaderButton.Cursor = Cursors.Hand;
            removeReaderButton.Dock = DockStyle.Fill;
            removeReaderButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            removeReaderButton.Location = new Point(0, 0);
            removeReaderButton.Name = "removeReaderButton";
            removeReaderButton.Size = new Size(333, 60);
            removeReaderButton.TabIndex = 4;
            removeReaderButton.Text = "Удалить";
            removeReaderButton.UseVisualStyleBackColor = false;
            removeReaderButton.Click += removeReaderButton_Click;
            // 
            // RemoveReaderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(333, 185);
            Controls.Add(removeReaderButtonsPanel);
            Controls.Add(readerInfoPanel);
            Name = "RemoveReaderForm";
            Text = "Удаление читателя";
            readerInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)readerIdNumericUpDown).EndInit();
            removeReaderButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel readerInfoPanel;
        private NumericUpDown readerIdNumericUpDown;
        private Label readerIdLabel;
        private Panel removeReaderButtonsPanel;
        private Button removeReaderButton;
    }
}