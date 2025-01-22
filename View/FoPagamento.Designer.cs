namespace EmporioRoyal.View
{
    partial class FoPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoPagamento));
            panCentral = new Panel();
            panSubValues = new Panel();
            lblSubTotalVal = new Label();
            lblSubTotalTit = new Label();
            panel10 = new Panel();
            panTroco = new Panel();
            panTrocoLiq = new Panel();
            label3 = new Label();
            label7 = new Label();
            lblTotalTrocoTit = new Label();
            panTotalRecebido = new Panel();
            lblValTotalRecebido = new Label();
            label10 = new Label();
            lblTitTotalRecebido = new Label();
            panCentral.SuspendLayout();
            panSubValues.SuspendLayout();
            panTroco.SuspendLayout();
            panTrocoLiq.SuspendLayout();
            panTotalRecebido.SuspendLayout();
            SuspendLayout();
            // 
            // panCentral
            // 
            panCentral.Controls.Add(panTroco);
            panCentral.Controls.Add(panel10);
            panCentral.Controls.Add(panSubValues);
            panCentral.Dock = DockStyle.Fill;
            panCentral.Location = new Point(0, 0);
            panCentral.Name = "panCentral";
            panCentral.Size = new Size(642, 280);
            panCentral.TabIndex = 0;
            // 
            // panSubValues
            // 
            panSubValues.BackColor = Color.FromArgb(255, 192, 192);
            panSubValues.BorderStyle = BorderStyle.Fixed3D;
            panSubValues.Controls.Add(lblSubTotalVal);
            panSubValues.Controls.Add(lblSubTotalTit);
            panSubValues.Dock = DockStyle.Top;
            panSubValues.Location = new Point(0, 0);
            panSubValues.Name = "panSubValues";
            panSubValues.Size = new Size(642, 134);
            panSubValues.TabIndex = 15;
            // 
            // lblSubTotalVal
            // 
            lblSubTotalVal.AutoSize = true;
            lblSubTotalVal.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTotalVal.Location = new Point(343, 34);
            lblSubTotalVal.Name = "lblSubTotalVal";
            lblSubTotalVal.Size = new Size(224, 96);
            lblSubTotalVal.TabIndex = 1;
            lblSubTotalVal.Text = "00,00";
            // 
            // lblSubTotalTit
            // 
            lblSubTotalTit.AutoSize = true;
            lblSubTotalTit.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTotalTit.Location = new Point(3, 0);
            lblSubTotalTit.Name = "lblSubTotalTit";
            lblSubTotalTit.Size = new Size(241, 60);
            lblSubTotalTit.TabIndex = 0;
            lblSubTotalTit.Text = "SUBTOTAL";
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 134);
            panel10.Name = "panel10";
            panel10.Size = new Size(642, 15);
            panel10.TabIndex = 16;
            // 
            // panTroco
            // 
            panTroco.Controls.Add(panTrocoLiq);
            panTroco.Controls.Add(panTotalRecebido);
            panTroco.Dock = DockStyle.Top;
            panTroco.Location = new Point(0, 149);
            panTroco.Name = "panTroco";
            panTroco.Size = new Size(642, 124);
            panTroco.TabIndex = 17;
            // 
            // panTrocoLiq
            // 
            panTrocoLiq.BackColor = Color.FromArgb(255, 192, 192);
            panTrocoLiq.BorderStyle = BorderStyle.Fixed3D;
            panTrocoLiq.Controls.Add(label3);
            panTrocoLiq.Controls.Add(label7);
            panTrocoLiq.Controls.Add(lblTotalTrocoTit);
            panTrocoLiq.Dock = DockStyle.Right;
            panTrocoLiq.Location = new Point(324, 0);
            panTrocoLiq.Name = "panTrocoLiq";
            panTrocoLiq.Size = new Size(318, 124);
            panTrocoLiq.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(205, 61);
            label3.Name = "label3";
            label3.Size = new Size(89, 38);
            label3.TabIndex = 2;
            label3.Text = "00,00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(148, 61);
            label7.Name = "label7";
            label7.Size = new Size(51, 38);
            label7.TabIndex = 1;
            label7.Text = "R$";
            // 
            // lblTotalTrocoTit
            // 
            lblTotalTrocoTit.AutoSize = true;
            lblTotalTrocoTit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTrocoTit.Location = new Point(3, 1);
            lblTotalTrocoTit.Name = "lblTotalTrocoTit";
            lblTotalTrocoTit.Size = new Size(110, 38);
            lblTotalTrocoTit.TabIndex = 0;
            lblTotalTrocoTit.Text = "TROCO";
            // 
            // panTotalRecebido
            // 
            panTotalRecebido.BackColor = Color.FromArgb(255, 192, 192);
            panTotalRecebido.BorderStyle = BorderStyle.Fixed3D;
            panTotalRecebido.Controls.Add(lblValTotalRecebido);
            panTotalRecebido.Controls.Add(label10);
            panTotalRecebido.Controls.Add(lblTitTotalRecebido);
            panTotalRecebido.Dock = DockStyle.Left;
            panTotalRecebido.Location = new Point(0, 0);
            panTotalRecebido.Name = "panTotalRecebido";
            panTotalRecebido.Size = new Size(295, 124);
            panTotalRecebido.TabIndex = 0;
            // 
            // lblValTotalRecebido
            // 
            lblValTotalRecebido.AutoSize = true;
            lblValTotalRecebido.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValTotalRecebido.Location = new Point(196, 61);
            lblValTotalRecebido.Name = "lblValTotalRecebido";
            lblValTotalRecebido.Size = new Size(89, 38);
            lblValTotalRecebido.TabIndex = 2;
            lblValTotalRecebido.Text = "00,00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(139, 61);
            label10.Name = "label10";
            label10.Size = new Size(51, 38);
            label10.TabIndex = 1;
            label10.Text = "R$";
            // 
            // lblTitTotalRecebido
            // 
            lblTitTotalRecebido.AutoSize = true;
            lblTitTotalRecebido.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitTotalRecebido.Location = new Point(-2, -2);
            lblTitTotalRecebido.Name = "lblTitTotalRecebido";
            lblTitTotalRecebido.Size = new Size(242, 38);
            lblTitTotalRecebido.TabIndex = 0;
            lblTitTotalRecebido.Text = "TOTAL RECEBIDO";
            // 
            // FoPagamento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(642, 280);
            Controls.Add(panCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FoPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PAGAMENTO";
            WindowState = FormWindowState.Minimized;
            panCentral.ResumeLayout(false);
            panSubValues.ResumeLayout(false);
            panSubValues.PerformLayout();
            panTroco.ResumeLayout(false);
            panTrocoLiq.ResumeLayout(false);
            panTrocoLiq.PerformLayout();
            panTotalRecebido.ResumeLayout(false);
            panTotalRecebido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panCentral;
        private Panel panel10;
        private Panel panSubValues;
        private Label lblSubTotalVal;
        private Label lblSubTotalTit;
        private Panel panTroco;
        private Panel panTrocoLiq;
        private Label label3;
        private Label label7;
        private Label lblTotalTrocoTit;
        private Panel panTotalRecebido;
        private Label lblValTotalRecebido;
        private Label label10;
        private Label lblTitTotalRecebido;
    }
}