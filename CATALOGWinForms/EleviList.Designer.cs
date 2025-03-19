using CatalogBackEnd;
namespace CATALOGWinForms
{
    partial class EleviList : Form
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
        /// 



        //protected virtual void OnElevClick(object sender, EventArgs e)
        //{
        //    StudentClick?.Invoke(this, EventArgs.Empty);
        //}
        private void InitializeComponent()
        {
            flowLayoutPanelElevi = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanelElevi
            // 
            flowLayoutPanelElevi.AutoScroll = true;
            flowLayoutPanelElevi.BackColor = Color.LightBlue;
            flowLayoutPanelElevi.Dock = DockStyle.Fill;
            flowLayoutPanelElevi.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelElevi.Location = new Point(0, 0);
            flowLayoutPanelElevi.Name = "flowLayoutPanelElevi";
            flowLayoutPanelElevi.Size = new Size(715, 450);
            flowLayoutPanelElevi.TabIndex = 0;
            // 
            // EleviList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 450);
            Controls.Add(flowLayoutPanelElevi);
            Name = "EleviList";
            Text = "EleviList";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelElevi;

        public object StudentClick { get; private set; }
    }
}