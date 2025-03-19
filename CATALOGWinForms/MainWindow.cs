namespace CATALOGWinForms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void buttonProfesor_Click(object sender, EventArgs e)
        {
            EleviList eleviList = new EleviList();
            eleviList.Show();
            this.Hide();
        }
    }
}
