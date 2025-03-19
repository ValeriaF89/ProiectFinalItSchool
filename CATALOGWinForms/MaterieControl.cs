

namespace CATALOGWinForms
{
    public partial class MaterieControl : UserControl
    {
        private List<int> note = new List<int>(); // lista de note prestabilita
        private int prezenta = 0; // prezenta
        private Label labelPrezenta;
        private Button buttonPlus;
        private Button buttonMinus;
        public MaterieControl()
        {
            InitializeComponent();
            InitializePrezentaControls();
        }
        public void SetMaterie(string materie, List<int> noteInitiale)
        {
            label1Materie.Text = materie;
            note = noteInitiale ?? new List<int>();
            UpdateNote();
            UpdateMedia();
        }
        private void InitializePrezentaControls()
        {
            // afisare prezenta
            labelPrezenta = new Label
            {
                Text = prezenta.ToString(),
                Size = new Size(40, 30),
                TextAlign = ContentAlignment.MiddleCenter,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };
            flowLayoutPanelPrezenta.Controls.Add(labelPrezenta);

            // Btn "+"
            buttonPlus = new Button
            {
                Text = "+",
                Size = new Size(30, 30),
                BackColor = Color.LightGreen
            };
            buttonPlus.Click += ButtonPlus_Click;
            flowLayoutPanelPrezenta.Controls.Add(buttonPlus);

            // Btn "-"
            buttonMinus = new Button
            {
                Text = "-",
                Size = new Size(30, 30),
                BackColor = Color.LightCoral
            };
            buttonMinus.Click += ButtonMinus_Click;
            flowLayoutPanelPrezenta.Controls.Add(buttonMinus);
        }

        // lista prestabilita de note
        private void UpdateNote()
        {
            flowLayoutPanelNote.Controls.Clear();
            foreach (var nota in note)
            {
                Label labelNota = new Label
                {
                    Text = nota.ToString(),
                    Size = new Size(30, 30),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };
                flowLayoutPanelNote.Controls.Add(labelNota);
            }
        }

        // media per materie
        private void UpdateMedia()
        {
            if (note.Count > 0)
            {
                double media = note.Average();
                labelMedie.Text = $"Medie: {media:F2}";
            }
            else
            {
                labelMedie.Text = "Medie: -";
            }
        }

        // Butonul "+" → Crește prezența
        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            prezenta++;
            labelPrezenta.Text = prezenta.ToString();
        }

        // Butonul "-" → Scade prezența (minim 0)
        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (prezenta > 0)
            {
                prezenta--;
                labelPrezenta.Text = prezenta.ToString();
            }
        }
       
    }
}
