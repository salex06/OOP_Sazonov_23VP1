namespace OOP_CP_Sazonov_23VP1.forms
{
    partial class AddGenreForm
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
            addGenreInfoPanel = new Panel();
            label1 = new Label();
            addGenreNameTextBox = new TextBox();
            addGenreButtonsPanel = new Panel();
            discardAddGenreButton = new Button();
            saveNewGenreButton = new Button();
            addGenreInfoPanel.SuspendLayout();
            addGenreButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addGenreInfoPanel
            // 
            addGenreInfoPanel.Controls.Add(addGenreNameTextBox);
            addGenreInfoPanel.Controls.Add(label1);
            addGenreInfoPanel.Dock = DockStyle.Top;
            addGenreInfoPanel.Location = new Point(0, 0);
            addGenreInfoPanel.Name = "addGenreInfoPanel";
            addGenreInfoPanel.Size = new Size(393, 60);
            addGenreInfoPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 60);
            label1.TabIndex = 0;
            label1.Text = "Название жанра";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addGenreNameTextBox
            // 
            addGenreNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addGenreNameTextBox.Location = new Point(197, 15);
            addGenreNameTextBox.Name = "addGenreNameTextBox";
            addGenreNameTextBox.Size = new Size(184, 31);
            addGenreNameTextBox.TabIndex = 1;
            // 
            // addGenreButtonsPanel
            // 
            addGenreButtonsPanel.Controls.Add(discardAddGenreButton);
            addGenreButtonsPanel.Controls.Add(saveNewGenreButton);
            addGenreButtonsPanel.Dock = DockStyle.Bottom;
            addGenreButtonsPanel.Location = new Point(0, 77);
            addGenreButtonsPanel.Name = "addGenreButtonsPanel";
            addGenreButtonsPanel.Size = new Size(393, 75);
            addGenreButtonsPanel.TabIndex = 9;
            // 
            // discardAddGenreButton
            // 
            discardAddGenreButton.BackColor = Color.Coral;
            discardAddGenreButton.Cursor = Cursors.Hand;
            discardAddGenreButton.Dock = DockStyle.Left;
            discardAddGenreButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            discardAddGenreButton.Location = new Point(0, 0);
            discardAddGenreButton.Name = "discardAddGenreButton";
            discardAddGenreButton.Size = new Size(145, 75);
            discardAddGenreButton.TabIndex = 1;
            discardAddGenreButton.Text = "Отмена";
            discardAddGenreButton.UseVisualStyleBackColor = false;
            // 
            // saveNewGenreButton
            // 
            saveNewGenreButton.BackColor = Color.Coral;
            saveNewGenreButton.Cursor = Cursors.Hand;
            saveNewGenreButton.Dock = DockStyle.Right;
            saveNewGenreButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveNewGenreButton.Location = new Point(231, 0);
            saveNewGenreButton.Name = "saveNewGenreButton";
            saveNewGenreButton.Size = new Size(162, 75);
            saveNewGenreButton.TabIndex = 0;
            saveNewGenreButton.Text = "Добавить";
            saveNewGenreButton.UseVisualStyleBackColor = false;
            // 
            // AddGenreForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(393, 152);
            Controls.Add(addGenreButtonsPanel);
            Controls.Add(addGenreInfoPanel);
            Name = "AddGenreForm";
            Text = "Новый жанр";
            addGenreInfoPanel.ResumeLayout(false);
            addGenreInfoPanel.PerformLayout();
            addGenreButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel addGenreInfoPanel;
        private Label label1;
        private TextBox addGenreNameTextBox;
        private Panel addGenreButtonsPanel;
        private Button discardAddGenreButton;
        private Button saveNewGenreButton;
    }
}