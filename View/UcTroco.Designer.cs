namespace EmporioRoyal.View
{
    partial class UcTroco
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panTroco = new Panel();
            panTrocoLiq = new Panel();
            lblTroco = new Label();
            label7 = new Label();
            lblTotalTrocoTit = new Label();
            panTotalRecebido = new Panel();
            txbTotal = new TextBox();
            lblTitTotalRecebido = new Label();
            panTroco.SuspendLayout();
            panTrocoLiq.SuspendLayout();
            panTotalRecebido.SuspendLayout();
            SuspendLayout();
            // 
            // panTroco
            // 
            panTroco.Controls.Add(panTrocoLiq);
            panTroco.Controls.Add(panTotalRecebido);
            panTroco.Dock = DockStyle.Top;
            panTroco.Location = new Point(0, 0);
            panTroco.Name = "panTroco";
            panTroco.Size = new Size(713, 129);
            panTroco.TabIndex = 18;
            // 
            // panTrocoLiq
            // 
            panTrocoLiq.BackColor = Color.FromArgb(255, 192, 192);
            panTrocoLiq.BorderStyle = BorderStyle.Fixed3D;
            panTrocoLiq.Controls.Add(lblTroco);
            panTrocoLiq.Controls.Add(label7);
            panTrocoLiq.Controls.Add(lblTotalTrocoTit);
            panTrocoLiq.Dock = DockStyle.Right;
            panTrocoLiq.Location = new Point(395, 0);
            panTrocoLiq.Name = "panTrocoLiq";
            panTrocoLiq.Size = new Size(318, 129);
            panTrocoLiq.TabIndex = 2;
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTroco.Location = new Point(205, 61);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(89, 38);
            lblTroco.TabIndex = 2;
            lblTroco.Text = "00,00";
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
            panTotalRecebido.Controls.Add(txbTotal);
            panTotalRecebido.Controls.Add(lblTitTotalRecebido);
            panTotalRecebido.Dock = DockStyle.Left;
            panTotalRecebido.Location = new Point(0, 0);
            panTotalRecebido.Name = "panTotalRecebido";
            panTotalRecebido.Size = new Size(295, 129);
            panTotalRecebido.TabIndex = 0;
            // 
            // txbTotal
            // 
            txbTotal.Location = new Point(137, 69);
            txbTotal.Name = "txbTotal";
            txbTotal.Size = new Size(126, 31);
            txbTotal.TabIndex = 1;
            txbTotal.KeyDown += textBox1_KeyDown;
            txbTotal.KeyPress += textBox1_KeyPress;
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
            // UcTroco
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            Controls.Add(panTroco);
            Name = "UcTroco";
            Size = new Size(713, 134);
            panTroco.ResumeLayout(false);
            panTrocoLiq.ResumeLayout(false);
            panTrocoLiq.PerformLayout();
            panTotalRecebido.ResumeLayout(false);
            panTotalRecebido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panTroco;
        private Panel panTrocoLiq;
        private Label lblTroco;
        private Label label7;
        private Label lblTotalTrocoTit;
        private Panel panTotalRecebido;
        private TextBox txbTotal;
        private Label lblTitTotalRecebido;
    }
}
