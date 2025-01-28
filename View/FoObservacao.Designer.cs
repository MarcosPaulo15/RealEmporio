namespace EmporioRoyal.View
{
    partial class FoObservacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoObservacao));
            panCentral = new Panel();
            txbObs = new TextBox();
            panCentral.SuspendLayout();
            SuspendLayout();
            // 
            // panCentral
            // 
            panCentral.Controls.Add(txbObs);
            panCentral.Dock = DockStyle.Fill;
            panCentral.Location = new Point(0, 0);
            panCentral.Name = "panCentral";
            panCentral.Size = new Size(579, 178);
            panCentral.TabIndex = 0;
            // 
            // txbObs
            // 
            txbObs.Dock = DockStyle.Fill;
            txbObs.Location = new Point(0, 0);
            txbObs.Multiline = true;
            txbObs.Name = "txbObs";
            txbObs.Size = new Size(579, 178);
            txbObs.TabIndex = 0;
            txbObs.KeyDown += txbObs_KeyDown;
            // 
            // FoObservacao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 178);
            Controls.Add(panCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FoObservacao";
            StartPosition = FormStartPosition.CenterScreen;
            panCentral.ResumeLayout(false);
            panCentral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panCentral;
        private TextBox txbObs;
    }
}