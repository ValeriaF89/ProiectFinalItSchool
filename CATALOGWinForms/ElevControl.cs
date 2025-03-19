using CatalogBackEnd;

namespace CATALOGWinForms
{
    public partial class ElevControl : UserControl
    {
        private string numeElev;
        public event EventHandler ElevClick;

        public ElevControl(string numeElev, string situatie, double mediaGenerala)
        {
            InitializeComponent();
            this.numeElev = numeElev;
            labelNumeElev.Text = numeElev;
            labelSituatie.Text = situatie;
            labelMediaGenerala.Text = mediaGenerala.ToString("F2");

            // Adăugăm evenimentul de click pentru UserControl și pentru labelNumeElev
            this.Click += ElevControl_Click;
            labelNumeElev.Click += ElevControl_Click;

        }
        private void ElevControl_Click(object sender, EventArgs e)
        {
            ElevEditor editor = new ElevEditor(
        this.labelNumeElev.Text,    // Numele elevului
        this.labelSituatie.Text,    // Situația (ex: "Promovat" / "Corigent")
        double.Parse(this.labelMediaGenerala.Text) // Media generală (convertită din string)
    );

            editor.ShowDialog();
        }

    }
}

