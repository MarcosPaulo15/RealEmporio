namespace EmporioRoyal.View
{
    partial class FoPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoPerfil));
            panCentral = new Panel();
            pcLogo = new PictureBox();
            panLegendas = new Panel();
            lblUsuario = new Label();
            lblNovaCompra = new Label();
            lblFechamento = new Label();
            panCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcLogo).BeginInit();
            panLegendas.SuspendLayout();
            SuspendLayout();
            // 
            // panCentral
            // 
            panCentral.Controls.Add(pcLogo);
            panCentral.Controls.Add(panLegendas);
            panCentral.Dock = DockStyle.Fill;
            panCentral.Location = new Point(0, 0);
            panCentral.Name = "panCentral";
            panCentral.Size = new Size(1311, 660);
            panCentral.TabIndex = 0;
            // 
            // pcLogo
            // 
            pcLogo.BackgroundImage = (Image)resources.GetObject("pcLogo.BackgroundImage");
            pcLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pcLogo.Dock = DockStyle.Fill;
            pcLogo.Location = new Point(0, 111);
            pcLogo.Name = "pcLogo";
            pcLogo.Size = new Size(1311, 549);
            pcLogo.TabIndex = 1;
            pcLogo.TabStop = false;
            // 
            // panLegendas
            // 
            panLegendas.Controls.Add(lblFechamento);
            panLegendas.Controls.Add(lblUsuario);
            panLegendas.Controls.Add(lblNovaCompra);
            panLegendas.Dock = DockStyle.Top;
            panLegendas.Location = new Point(0, 0);
            panLegendas.Name = "panLegendas";
            panLegendas.Size = new Size(1311, 111);
            panLegendas.TabIndex = 0;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(1214, 10);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(76, 32);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "label1";
            // 
            // lblNovaCompra
            // 
            lblNovaCompra.AutoSize = true;
            lblNovaCompra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNovaCompra.Location = new Point(12, 10);
            lblNovaCompra.Name = "lblNovaCompra";
            lblNovaCompra.Size = new Size(283, 32);
            lblNovaCompra.TabIndex = 0;
            lblNovaCompra.Text = "F1 - TELA DE COMPRAS";
            // 
            // lblFechamento
            // 
            lblFechamento.AutoSize = true;
            lblFechamento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechamento.Location = new Point(12, 64);
            lblFechamento.Name = "lblFechamento";
            lblFechamento.Size = new Size(357, 32);
            lblFechamento.TabIndex = 2;
            lblFechamento.Text = "F12 - FECHAMENTO DE CAIXA";
            // 
            // FoPerfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(1311, 660);
            Controls.Add(panCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FoPerfil";
            Text = "FoPerfil";
            WindowState = FormWindowState.Maximized;
            KeyDown += FoPerfil_KeyDown;
            panCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcLogo).EndInit();
            panLegendas.ResumeLayout(false);
            panLegendas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panCentral;
        private PictureBox pcLogo;
        private Panel panLegendas;
        private Label lblNovaCompra;
        private Label lblUsuario;
        private Label lblFechamento;
    }
}