namespace EmporioRoyal.View
{
    partial class UcRelVendas
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
            panCentral = new Panel();
            panConclusões = new Panel();
            lblTotal = new Label();
            lblPix = new Label();
            lblTotalCard = new Label();
            lblDinheiro = new Label();
            panLista = new Panel();
            dgvRelatorio = new DataGridView();
            panFiltro = new Panel();
            dtpData = new DateTimePicker();
            panTitulo = new Panel();
            lblTitulo = new Label();
            panCentral.SuspendLayout();
            panConclusões.SuspendLayout();
            panLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            panFiltro.SuspendLayout();
            panTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // panCentral
            // 
            panCentral.BackColor = Color.Transparent;
            panCentral.Controls.Add(panConclusões);
            panCentral.Controls.Add(panLista);
            panCentral.Controls.Add(panFiltro);
            panCentral.Controls.Add(panTitulo);
            panCentral.Dock = DockStyle.Fill;
            panCentral.Location = new Point(0, 0);
            panCentral.Name = "panCentral";
            panCentral.Size = new Size(1328, 731);
            panCentral.TabIndex = 0;
            // 
            // panConclusões
            // 
            panConclusões.Controls.Add(lblTotal);
            panConclusões.Controls.Add(lblPix);
            panConclusões.Controls.Add(lblTotalCard);
            panConclusões.Controls.Add(lblDinheiro);
            panConclusões.Dock = DockStyle.Top;
            panConclusões.Location = new Point(0, 628);
            panConclusões.Name = "panConclusões";
            panConclusões.Size = new Size(1328, 142);
            panConclusões.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(399, 82);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(78, 38);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total";
            // 
            // lblPix
            // 
            lblPix.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPix.AutoSize = true;
            lblPix.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPix.Location = new Point(399, 29);
            lblPix.Name = "lblPix";
            lblPix.Size = new Size(54, 38);
            lblPix.TabIndex = 2;
            lblPix.Text = "Pix";
            // 
            // lblTotalCard
            // 
            lblTotalCard.AutoSize = true;
            lblTotalCard.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCard.Location = new Point(21, 82);
            lblTotalCard.Name = "lblTotalCard";
            lblTotalCard.Size = new Size(102, 38);
            lblTotalCard.TabIndex = 1;
            lblTotalCard.Text = "Cartão";
            // 
            // lblDinheiro
            // 
            lblDinheiro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDinheiro.AutoSize = true;
            lblDinheiro.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDinheiro.Location = new Point(21, 20);
            lblDinheiro.Name = "lblDinheiro";
            lblDinheiro.Size = new Size(125, 38);
            lblDinheiro.TabIndex = 0;
            lblDinheiro.Text = "Dinheiro";
            // 
            // panLista
            // 
            panLista.Controls.Add(dgvRelatorio);
            panLista.Dock = DockStyle.Top;
            panLista.Location = new Point(0, 163);
            panLista.Name = "panLista";
            panLista.Size = new Size(1328, 465);
            panLista.TabIndex = 4;
            // 
            // dgvRelatorio
            // 
            dgvRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorio.Dock = DockStyle.Fill;
            dgvRelatorio.Location = new Point(0, 0);
            dgvRelatorio.Name = "dgvRelatorio";
            dgvRelatorio.RowHeadersWidth = 62;
            dgvRelatorio.Size = new Size(1328, 465);
            dgvRelatorio.TabIndex = 0;
            // 
            // panFiltro
            // 
            panFiltro.Controls.Add(dtpData);
            panFiltro.Dock = DockStyle.Top;
            panFiltro.Location = new Point(0, 115);
            panFiltro.Name = "panFiltro";
            panFiltro.Size = new Size(1328, 48);
            panFiltro.TabIndex = 1;
            // 
            // dtpData
            // 
            dtpData.Dock = DockStyle.Left;
            dtpData.Location = new Point(0, 0);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(300, 31);
            dtpData.TabIndex = 0;
            dtpData.Value = new DateTime(2025, 1, 23, 0, 0, 0, 0);
            dtpData.ValueChanged += dtpData_ValueChanged;
            // 
            // panTitulo
            // 
            panTitulo.Controls.Add(lblTitulo);
            panTitulo.Dock = DockStyle.Top;
            panTitulo.Location = new Point(0, 0);
            panTitulo.Name = "panTitulo";
            panTitulo.Size = new Size(1328, 115);
            panTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(8, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(469, 54);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "RELATÓRIO DE VENDAS";
            // 
            // UcRelVendas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            Controls.Add(panCentral);
            Name = "UcRelVendas";
            Size = new Size(1328, 731);
            panCentral.ResumeLayout(false);
            panConclusões.ResumeLayout(false);
            panConclusões.PerformLayout();
            panLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            panFiltro.ResumeLayout(false);
            panTitulo.ResumeLayout(false);
            panTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panCentral;
        private Panel panFiltro;
        private DateTimePicker dtpData;
        private Panel panTitulo;
        private Label lblTitulo;
        private Panel panConclusões;
        private Label lblTotalCard;
        private Label lblDinheiro;
        private Label lblTotal;
        private Label lblPix;
        private Panel panLista;
        private DataGridView dgvRelatorio;
    }
}
