using OOP_CP_Sazonov_23VP1.forms;

namespace OOP_CP_Sazonov_23VP1
{
    public partial class MainLibraryForm : Form
    {
        public MainLibraryForm()
        {
            InitializeComponent();
            StartForm start = new StartForm();
            start.ShowDialog();
        }

        private void findAndSortReaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
