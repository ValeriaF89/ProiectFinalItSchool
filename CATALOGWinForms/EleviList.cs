using CatalogBackEnd;
using static CatalogBackEnd.StudentFactory;

namespace CATALOGWinForms
{
    public partial class EleviList : Form
    {
        public EleviList()
        {
            InitializeComponent();

            LoadStudenti();
         
        }
        private void LoadStudenti()
        {
            flowLayoutPanelElevi.FlowDirection = FlowDirection.TopDown;
            // Lista prestabilita de elevi din backend 
            List<Student> catalog = StudentFactory.student;  

            // Iteram prin elevi si adaugam un control ElevControl pentru fiecare
            foreach (Student student in catalog)
            {
                // Calculam media generala a elevului
                double media = CalculaMediaElevului(student);

                // Calculam situatia elevului
                string situatie = media >= 5 ? "Promovat" : "Corigent";

                // Creeaza un control ElevControl pentru acest elev si adauga-l in FlowLayoutPanel
                ElevControl elevControl = new ElevControl(student.Name, situatie, media);
                flowLayoutPanelElevi.Controls.Add(elevControl);
            }
        }

        // Metoda care calculeaza media unui elev
        private double CalculaMediaElevului(Student elev)
        {
            int totalNote = 0;
            int totalMaterii = 0;

            foreach (List<int> materie in elev.Note.Values)
            {
                totalNote += materie.Sum();
                totalMaterii += materie.Count;
            }

            return totalMaterii > 0 ? totalNote / (double)totalMaterii : 0;
        }

    }
}
