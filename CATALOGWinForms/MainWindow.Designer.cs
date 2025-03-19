namespace CATALOGWinForms
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitlu = new Label();
            labelDescriere = new Label();
            buttonProfesor = new Button();
            SuspendLayout();
            // 
            // labelTitlu
            // 
            labelTitlu.Dock = DockStyle.Top;
            labelTitlu.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelTitlu.Location = new Point(0, 0);
            labelTitlu.Name = "labelTitlu";
            labelTitlu.Padding = new Padding(10);
            labelTitlu.Size = new Size(800, 74);
            labelTitlu.TabIndex = 0;
            labelTitlu.Text = "Catalog";
            labelTitlu.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelDescriere
            // 
            labelDescriere.AutoSize = true;
            labelDescriere.Dock = DockStyle.Top;
            labelDescriere.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelDescriere.Location = new Point(0, 74);
            labelDescriere.Name = "labelDescriere";
            labelDescriere.Padding = new Padding(10);
            labelDescriere.Size = new Size(755, 48);
            labelDescriere.TabIndex = 1;
            labelDescriere.Text = "Acesta este un catalog digital care va permite vizualizarea elevilor dar și mediile lor.";
            labelDescriere.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonProfesor
            // 
            buttonProfesor.BackColor = Color.LightBlue;
            buttonProfesor.FlatStyle = FlatStyle.Flat;
            buttonProfesor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonProfesor.ForeColor = Color.Black;
            buttonProfesor.Location = new Point(292, 159);
            buttonProfesor.Name = "buttonProfesor";
            buttonProfesor.Size = new Size(200, 50);
            buttonProfesor.TabIndex = 2;
            buttonProfesor.Text = "Profesor";
            buttonProfesor.UseVisualStyleBackColor = false;
            buttonProfesor.Click += buttonProfesor_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonProfesor);
            Controls.Add(labelDescriere);
            Controls.Add(labelTitlu);
            Name = "MainWindow";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitlu;
        private Label labelDescriere;
        private Button buttonProfesor;
    }
}
