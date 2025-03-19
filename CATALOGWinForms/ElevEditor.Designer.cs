using CatalogBackEnd;

namespace CATALOGWinForms
{
    partial class ElevEditor : Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            buttonAdaugaNota = new Button();
            numericUpDownNota = new NumericUpDown();
            comboBoxMaterii = new ComboBox();
            panelRoz = new FlowLayoutPanel();
            flowLayoutPanelListaNote = new FlowLayoutPanel();
            labelMediaGenerala = new Label();
            labelNumeElev = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNota).BeginInit();
            panelRoz.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panelRoz);
            panel1.Controls.Add(labelMediaGenerala);
            panel1.Controls.Add(labelNumeElev);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Green;
            panel3.Controls.Add(buttonAdaugaNota);
            panel3.Controls.Add(numericUpDownNota);
            panel3.Controls.Add(comboBoxMaterii);
            panel3.Location = new Point(24, 360);
            panel3.Name = "panel3";
            panel3.Size = new Size(754, 87);
            panel3.TabIndex = 3;
            // 
            // buttonAdaugaNota
            // 
            buttonAdaugaNota.Location = new Point(513, 20);
            buttonAdaugaNota.Name = "buttonAdaugaNota";
            buttonAdaugaNota.Size = new Size(120, 30);
            buttonAdaugaNota.TabIndex = 2;
            buttonAdaugaNota.Text = "Adauga Nota";
            buttonAdaugaNota.UseVisualStyleBackColor = true;
            buttonAdaugaNota.Click += buttonAdaugaNota_Click;
            // 
            // numericUpDownNota
            // 
            numericUpDownNota.Location = new Point(261, 23);
            numericUpDownNota.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownNota.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownNota.Name = "numericUpDownNota";
            numericUpDownNota.Size = new Size(60, 27);
            numericUpDownNota.TabIndex = 1;
            numericUpDownNota.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboBoxMaterii
            // 
            comboBoxMaterii.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMaterii.FormattingEnabled = true;
            comboBoxMaterii.Location = new Point(55, 22);
            comboBoxMaterii.Name = "comboBoxMaterii";
            comboBoxMaterii.Size = new Size(200, 28);
            comboBoxMaterii.TabIndex = 0;
            // 
            // panelRoz
            // 
            panelRoz.AutoScroll = true;
            panelRoz.BackColor = Color.LightPink;
            panelRoz.Controls.Add(flowLayoutPanelListaNote);
            panelRoz.FlowDirection = FlowDirection.TopDown;
            panelRoz.Location = new Point(20, 73);
            panelRoz.Name = "panelRoz";
            panelRoz.Size = new Size(758, 274);
            panelRoz.TabIndex = 2;
            panelRoz.WrapContents = false;
            // 
            // flowLayoutPanelListaNote
            // 
            flowLayoutPanelListaNote.BackColor = Color.LightYellow;
            flowLayoutPanelListaNote.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelListaNote.Location = new Point(3, 3);
            flowLayoutPanelListaNote.Name = "flowLayoutPanelListaNote";
            flowLayoutPanelListaNote.Size = new Size(200, 30);
            flowLayoutPanelListaNote.TabIndex = 1;
            // 
            // labelMediaGenerala
            // 
            labelMediaGenerala.BackColor = Color.LightGray;
            labelMediaGenerala.BorderStyle = BorderStyle.FixedSingle;
            labelMediaGenerala.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelMediaGenerala.Location = new Point(458, 20);
            labelMediaGenerala.Name = "labelMediaGenerala";
            labelMediaGenerala.Size = new Size(300, 40);
            labelMediaGenerala.TabIndex = 1;
            labelMediaGenerala.Text = "Media Generala";
            labelMediaGenerala.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNumeElev
            // 
            labelNumeElev.BackColor = Color.LightGray;
            labelNumeElev.BorderStyle = BorderStyle.FixedSingle;
            labelNumeElev.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelNumeElev.Location = new Point(20, 20);
            labelNumeElev.Name = "labelNumeElev";
            labelNumeElev.Size = new Size(300, 40);
            labelNumeElev.TabIndex = 0;
            labelNumeElev.Text = "Nume Elev";
            labelNumeElev.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ElevEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Margin = new Padding(5, 1, 5, 1);
            Name = "ElevEditor";
            Text = "ElevEditor";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownNota).EndInit();
            panelRoz.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void NewMethod()
        {
            labelNumeElev.Click += OnElevClick;
        }

        private void OnElevClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion


        private Panel panel1;
        private Label labelMediaGenerala;
        private Label labelNumeElev;
        private Panel panel3;
        private FlowLayoutPanel panelRoz;
        private FlowLayoutPanel flowLayoutPanelListaNote;
        private ComboBox comboBoxMaterii;
        private NumericUpDown numericUpDownNota;
        private Button buttonAdaugaNota;
        //private MaterieControl materieControl1;
    }
}