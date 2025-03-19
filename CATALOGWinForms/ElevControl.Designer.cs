using CatalogBackEnd;
namespace CATALOGWinForms
{
    public partial class ElevControl : UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            labelMediaGenerala = new Label();
            labelNumeElev = new Label();
            labelSituatie = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Pink;
            panel1.Controls.Add(labelMediaGenerala);
            panel1.Controls.Add(labelNumeElev);
            panel1.Controls.Add(labelSituatie);
            panel1.Location = new Point(8, 20);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(657, 40);
            panel1.TabIndex = 3;
            // 
            // labelMediaGenerala
            // 
            labelMediaGenerala.BackColor = Color.LightYellow;
            labelMediaGenerala.BorderStyle = BorderStyle.FixedSingle;
            labelMediaGenerala.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelMediaGenerala.Location = new Point(442, 5);
            labelMediaGenerala.Margin = new Padding(10, 5, 10, 5);
            labelMediaGenerala.Name = "labelMediaGenerala";
            labelMediaGenerala.Size = new Size(200, 30);
            labelMediaGenerala.TabIndex = 2;
            labelMediaGenerala.Text = "Media Generala";
            labelMediaGenerala.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNumeElev
            // 
            labelNumeElev.BackColor = Color.LightYellow;
            labelNumeElev.BorderStyle = BorderStyle.FixedSingle;
            labelNumeElev.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelNumeElev.Location = new Point(139, 5);
            labelNumeElev.Margin = new Padding(10, 5, 10, 5);
            labelNumeElev.Name = "labelNumeElev";
            labelNumeElev.Size = new Size(300, 30);
            labelNumeElev.TabIndex = 1;
            labelNumeElev.Text = "Nume Elev";
            labelNumeElev.TextAlign = ContentAlignment.MiddleLeft;
            labelNumeElev.Click += OnElevClick;
            // 
            // labelSituatie
            // 
            labelSituatie.BackColor = Color.LightYellow;
            labelSituatie.BorderStyle = BorderStyle.FixedSingle;
            labelSituatie.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelSituatie.Location = new Point(8, 5);
            labelSituatie.Margin = new Padding(10, 5, 10, 5);
            labelSituatie.Name = "labelSituatie";
            labelSituatie.Size = new Size(125, 30);
            labelSituatie.TabIndex = 0;
            labelSituatie.Text = "Situatie";
            labelSituatie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ElevControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "ElevControl";
            Size = new Size(686, 78);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        //private Label label3;
        //private Label label2;
        private Label labelSituatie;
        private Label labelNumeElev;
        private Label labelMediaGenerala;
       
        //public ElevControl(string numeElev, string situatie, double mediaGenerala)
        //{
        //    InitializeComponent();

        //    labelNumeElev.Text = numeElev;
        //    labelSituatie.Text = situatie;
        //    labelMediaGenerala.Text = mediaGenerala.ToString("F2");
        //    labelNumeElev.Click += (sender, e) => OnElevClick(sender, e);
        //}
 
        protected virtual void OnElevClick(object sender, EventArgs e)
        {
            ElevClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
