using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_CP_Sazonov_23VP1.forms
{
    /// <summary>
    /// Стартовая форма. Используется для вывода информации о приложении
    /// </summary>
    public partial class StartForm : Form
    {
        /// <summary>
        /// Конструктор для формы по умолчанию
        /// </summary>
        public StartForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
