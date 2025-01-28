namespace EmporioRoyal.View
{
    partial class FoAcertarFracionado
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
            panCentral = new Panel();
            txbValor = new TextBox();
            panCentral.SuspendLayout();
            SuspendLayout();
            // 
            // panCentral
            // 
            panCentral.Controls.Add(txbValor);
            panCentral.Dock = DockStyle.Fill;
            panCentral.Location = new Point(0, 0);
            panCentral.Name = "panCentral";
            panCentral.Size = new Size(308, 51);
            panCentral.TabIndex = 0;
            // 
            // txbValor
            // 
            txbValor.Location = new Point(12, 12);
            txbValor.Name = "txbValor";
            txbValor.Size = new Size(292, 31);
            txbValor.TabIndex = 0;
            txbValor.KeyDown += txbValor_KeyDown;
            txbValor.KeyPress += txbValor_KeyPress;
            // 
            // FoAcertarFracionado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 51);
            Controls.Add(panCentral);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FoAcertarFracionado";
            panCentral.ResumeLayout(false);
            panCentral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panCentral;
        private TextBox txbValor;
    }
}