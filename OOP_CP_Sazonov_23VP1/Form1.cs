using OOP_CP_Sazonov_23VP1.forms;

namespace OOP_CP_Sazonov_23VP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartForm start = new StartForm();
            start.ShowDialog();
        }
    }
}
