using CatalogBackEnd;
using static CatalogBackEnd.StudentFactory;

namespace CATALOGWinForms
{
    public partial class ElevEditor : Form
    {
        private string numeElev;
        private string situatie;
        private double mediaGenerala;
        public ElevEditor(string numeElev, string situatie, double mediaGenerala)
        {
            InitializeComponent();


  
            this.numeElev = numeElev;
            this.situatie = situatie;
            this.mediaGenerala = mediaGenerala;

            
            this.Text = $"Editare: {numeElev}";

            
            labelNumeElev.Text = numeElev;
            
            labelMediaGenerala.Text = mediaGenerala.ToString("F2");
            PopuleazaComboBoxMaterii();
            flowLayoutPanelListaNote.Controls.Clear();
            PopuleazaNota();
        }
        public class Materie
        {
            public string Nume { get; set; }  
            public List<int> Note { get; set; }  

           
  
        }
        private void PopuleazaComboBoxMaterii()
        {
            comboBoxMaterii.Items.Clear();

            // Cauta elevul selectat
            Student elev = StudentFactory.student.FirstOrDefault(s => s.Name == numeElev);

            if (elev == null) return;

            // Adauga materiile în ComboBox
            foreach (var materie in elev.Note.Keys)
            {
                comboBoxMaterii.Items.Add(materie);
            }

            if (comboBoxMaterii.Items.Count > 0)
                comboBoxMaterii.SelectedIndex = 0; // Selecteaza prima materie
        }
        private void PopuleazaNota()
        {
            // Cauta elevul selectat in lista din StudentFactory
            Student elev = StudentFactory.student.FirstOrDefault(s => s.Name == numeElev);

            if (elev == null)
            {
                MessageBox.Show("Elevul nu a fost găsit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            panelRoz.Controls.Clear();

            // Iterează prin materiile elevului și adauga MaterieControl pentru fiecare materie
            foreach (var materie in elev.Note)
            {
                MaterieControl materieControl = new MaterieControl();
                materieControl.SetMaterie(materie.Key, materie.Value);
                materieControl.Margin = new Padding(5, 2, 5, 2);
                panelRoz.Controls.Add(materieControl);
            } 
        }
        private void buttonAdaugaNota_Click(object sender, EventArgs e)
        {
            if (comboBoxMaterii.SelectedItem == null)
            {
                MessageBox.Show("Selectează o materie!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string materieSelectata = comboBoxMaterii.SelectedItem.ToString();
            int nota = (int)numericUpDownNota.Value;

            // cauta elevul selectat
            Student elev = StudentFactory.student.FirstOrDefault(s => s.Name == numeElev);

            if (elev != null && elev.Note.ContainsKey(materieSelectata))
            {
                elev.Note[materieSelectata].Add(nota);
                MessageBox.Show($"Nota {nota} a fost adăugată la {materieSelectata}!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
                PopuleazaNota();
            }
        }
    }





        
    
}
