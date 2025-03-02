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
    public partial class StartForm : Form
    {
        /// <summary>
        /// Конструктор для формы по умолчанию
        /// </summary>
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Закрыть окно при нажатии на кнопку "Запуск"
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Параметры события</param>
        private void startButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
