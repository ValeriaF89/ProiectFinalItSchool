using CatalogBackEnd;
namespace CATALOGWinForms
{
    partial class MaterieControl : UserControl
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1Materie = new Label();
            flowLayoutPanelNote = new FlowLayoutPanel();
            flowLayoutPanelPrezenta = new FlowLayoutPanel();
            labelMedie = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            this.Size = new Size(750, 50); 
            this.Margin = new Padding(5, 2, 5, 2); 
            this.AutoSize = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1Materie);
            flowLayoutPanel1.Controls.Add(flowLayoutPanelNote);
            flowLayoutPanel1.Controls.Add(flowLayoutPanelPrezenta);
            flowLayoutPanel1.Controls.Add(labelMedie);
            flowLayoutPanel1.Location = new Point(9, 32);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(889, 228);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1Materie
            // 
            label1Materie.BackColor = Color.Gray;
            label1Materie.BorderStyle = BorderStyle.FixedSingle;
            label1Materie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1Materie.Location = new Point(5, 5);
            label1Materie.Margin = new Padding(5);
            label1Materie.Name = "label1Materie";
            label1Materie.Size = new Size(150, 30);
            label1Materie.TabIndex = 0;
            label1Materie.Text = "Materie";
            // 
            // flowLayoutPanelNote
            // 
            flowLayoutPanelNote.AutoScroll = true;
            flowLayoutPanelNote.BackColor = Color.LightYellow;
            flowLayoutPanelNote.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelNote.Location = new Point(163, 3);
            flowLayoutPanelNote.Name = "flowLayoutPanelNote";
            flowLayoutPanelNote.Padding = new Padding(5);
            flowLayoutPanelNote.Size = new Size(200, 40);
            flowLayoutPanelNote.TabIndex = 1;
            // 
            // flowLayoutPanelPrezenta
            // 
            flowLayoutPanelPrezenta.AutoScroll = true;
            flowLayoutPanelPrezenta.BackColor = Color.LightYellow;
            flowLayoutPanelPrezenta.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelPrezenta.Location = new Point(369, 3);
            flowLayoutPanelPrezenta.Name = "flowLayoutPanelPrezenta";
            flowLayoutPanelPrezenta.Padding = new Padding(5);
            flowLayoutPanelPrezenta.Size = new Size(150, 40);
            flowLayoutPanelPrezenta.TabIndex = 3;
            // 
            // labelMedie
            // 
            labelMedie.AutoSize = true;
            labelMedie.BackColor = Color.Gray;
            labelMedie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelMedie.Location = new Point(527, 5);
            labelMedie.Margin = new Padding(5);
            labelMedie.Name = "labelMedie";
            labelMedie.Size = new Size(67, 28);
            labelMedie.TabIndex = 2;
            labelMedie.Text = "Medie";
            labelMedie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MaterieControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "MaterieControl";
            Size = new Size(1003, 352);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1Materie;
        private FlowLayoutPanel flowLayoutPanelNote;
        private Label labelMedie;
        private FlowLayoutPanel flowLayoutPanelPrezenta;
    }
}
