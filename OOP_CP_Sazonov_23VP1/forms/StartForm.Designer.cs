namespace OOP_CP_Sazonov_23VP1.forms
{
    partial class StartForm
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
            mainTitle = new Label();
            descriptionPanel = new Panel();
            themeLabelBig = new Label();
            themeLabel = new Label();
            disciplineTitle = new Label();
            authorPanel = new Panel();
            studentLabel = new Label();
            startButton = new Button();
            descriptionPanel.SuspendLayout();
            authorPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.Dock = DockStyle.Top;
            mainTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mainTitle.ForeColor = Color.IndianRed;
            mainTitle.Location = new Point(0, 0);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new Size(283, 45);
            mainTitle.TabIndex = 0;
            mainTitle.Text = "Курсовая работа";
            // 
            // descriptionPanel
            // 
            descriptionPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionPanel.Controls.Add(themeLabelBig);
            descriptionPanel.Controls.Add(themeLabel);
            descriptionPanel.Controls.Add(disciplineTitle);
            descriptionPanel.Controls.Add(mainTitle);
            descriptionPanel.Location = new Point(12, 12);
            descriptionPanel.Name = "descriptionPanel";
            descriptionPanel.Size = new Size(784, 177);
            descriptionPanel.TabIndex = 1;
            // 
            // themeLabelBig
            // 
            themeLabelBig.Dock = DockStyle.Top;
            themeLabelBig.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            themeLabelBig.ForeColor = Color.IndianRed;
            themeLabelBig.Location = new Point(93, 70);
            themeLabelBig.Name = "themeLabelBig";
            themeLabelBig.Size = new Size(691, 99);
            themeLabelBig.TabIndex = 3;
            themeLabelBig.Text = "\"Разработка программы с использованием ООП. ИС Библиотека\"";
            themeLabelBig.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // themeLabel
            // 
            themeLabel.AutoSize = true;
            themeLabel.Dock = DockStyle.Left;
            themeLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            themeLabel.Location = new Point(0, 70);
            themeLabel.Name = "themeLabel";
            themeLabel.Size = new Size(93, 28);
            themeLabel.TabIndex = 2;
            themeLabel.Text = "по теме:";
            // 
            // disciplineTitle
            // 
            disciplineTitle.AutoSize = true;
            disciplineTitle.Dock = DockStyle.Top;
            disciplineTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            disciplineTitle.Location = new Point(0, 45);
            disciplineTitle.Margin = new Padding(0);
            disciplineTitle.Name = "disciplineTitle";
            disciplineTitle.Size = new Size(587, 25);
            disciplineTitle.TabIndex = 1;
            disciplineTitle.Text = "по дисциплине \"Объектно-ориентированное программирование\"";
            // 
            // authorPanel
            // 
            authorPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            authorPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            authorPanel.Controls.Add(studentLabel);
            authorPanel.Location = new Point(552, 215);
            authorPanel.Name = "authorPanel";
            authorPanel.Size = new Size(244, 150);
            authorPanel.TabIndex = 2;
            // 
            // studentLabel
            // 
            studentLabel.Dock = DockStyle.Fill;
            studentLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            studentLabel.Location = new Point(0, 0);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new Size(244, 150);
            studentLabel.TabIndex = 0;
            studentLabel.Text = "Выполнил: \r\nСтудент группы 23ВП1 Сазонов А.Н.";
            studentLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            startButton.BackColor = Color.Coral;
            startButton.Cursor = Cursors.Hand;
            startButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startButton.ForeColor = SystemColors.ActiveCaptionText;
            startButton.Location = new Point(12, 245);
            startButton.Name = "startButton";
            startButton.Size = new Size(283, 91);
            startButton.TabIndex = 3;
            startButton.Text = "Запуск";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 348);
            Controls.Add(startButton);
            Controls.Add(authorPanel);
            Controls.Add(descriptionPanel);
            Name = "StartForm";
            Text = "Стартовое окно";
            descriptionPanel.ResumeLayout(false);
            descriptionPanel.PerformLayout();
            authorPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label mainTitle;
        private Panel descriptionPanel;
        private Label disciplineTitle;
        private Label themeLabelBig;
        private Label themeLabel;
        private Panel authorPanel;
        private Label studentLabel;
        private Button startButton;
    }
}