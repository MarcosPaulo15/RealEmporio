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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcRelVendas));
            panCentral = new Panel();
            panConclusões = new Panel();
            panel2 = new Panel();
            lblTotal = new Label();
            panRel = new Panel();
            lblDinheiro = new Label();
            lblTotalCard = new Label();
            lblPix = new Label();
            panel1 = new Panel();
            panLista = new Panel();
            dgvRelatorio = new DataGridView();
            panFiltro = new Panel();
            panel6 = new Panel();
            btnSearch = new Button();
            panel5 = new Panel();
            dtpDataFim = new DateTimePicker();
            lblDataFim = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            lblDataInicio = new Label();
            dtpData = new DateTimePicker();
            panTitulo = new Panel();
            lblTitulo = new Label();
            panCentral.SuspendLayout();
            panConclusões.SuspendLayout();
            panel2.SuspendLayout();
            panRel.SuspendLayout();
            panLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            panFiltro.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
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
            panCentral.Size = new Size(1200, 818);
            panCentral.TabIndex = 0;
            // 
            // panConclusões
            // 
            panConclusões.Controls.Add(panel2);
            panConclusões.Controls.Add(panRel);
            panConclusões.Controls.Add(panel1);
            panConclusões.Dock = DockStyle.Top;
            panConclusões.Location = new Point(0, 643);
            panConclusões.Name = "panConclusões";
            panConclusões.Size = new Size(1200, 175);
            panConclusões.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTotal);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(900, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 146);
            panel2.TabIndex = 6;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Dock = DockStyle.Right;
            lblTotal.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(222, 0);
            lblTotal.Margin = new Padding(166, 0, 3, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(78, 38);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total";
            // 
            // panRel
            // 
            panRel.Controls.Add(lblDinheiro);
            panRel.Controls.Add(lblTotalCard);
            panRel.Controls.Add(lblPix);
            panRel.Dock = DockStyle.Left;
            panRel.Location = new Point(0, 29);
            panRel.Name = "panRel";
            panRel.Size = new Size(414, 146);
            panRel.TabIndex = 4;
            // 
            // lblDinheiro
            // 
            lblDinheiro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDinheiro.AutoSize = true;
            lblDinheiro.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDinheiro.Location = new Point(9, 5);
            lblDinheiro.Name = "lblDinheiro";
            lblDinheiro.Size = new Size(125, 38);
            lblDinheiro.TabIndex = 0;
            lblDinheiro.Text = "Dinheiro";
            // 
            // lblTotalCard
            // 
            lblTotalCard.AutoSize = true;
            lblTotalCard.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCard.Location = new Point(9, 59);
            lblTotalCard.Margin = new Padding(266, 0, 3, 0);
            lblTotalCard.Name = "lblTotalCard";
            lblTotalCard.Size = new Size(102, 38);
            lblTotalCard.TabIndex = 1;
            lblTotalCard.Text = "Cartão";
            // 
            // lblPix
            // 
            lblPix.AutoSize = true;
            lblPix.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPix.Location = new Point(9, 105);
            lblPix.Margin = new Padding(166, 0, 3, 0);
            lblPix.Name = "lblPix";
            lblPix.Size = new Size(54, 38);
            lblPix.TabIndex = 2;
            lblPix.Text = "Pix";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 29);
            panel1.TabIndex = 5;
            // 
            // panLista
            // 
            panLista.Controls.Add(dgvRelatorio);
            panLista.Dock = DockStyle.Top;
            panLista.Location = new Point(0, 163);
            panLista.Name = "panLista";
            panLista.Size = new Size(1200, 480);
            panLista.TabIndex = 4;
            // 
            // dgvRelatorio
            // 
            dgvRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorio.Dock = DockStyle.Top;
            dgvRelatorio.Location = new Point(0, 0);
            dgvRelatorio.Name = "dgvRelatorio";
            dgvRelatorio.RowHeadersWidth = 62;
            dgvRelatorio.Size = new Size(1200, 480);
            dgvRelatorio.TabIndex = 0;
            // 
            // panFiltro
            // 
            panFiltro.Controls.Add(panel6);
            panFiltro.Controls.Add(panel5);
            panFiltro.Controls.Add(panel4);
            panFiltro.Controls.Add(panel3);
            panFiltro.Dock = DockStyle.Top;
            panFiltro.Location = new Point(0, 115);
            panFiltro.Name = "panFiltro";
            panFiltro.Size = new Size(1200, 48);
            panFiltro.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnSearch);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(938, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(56, 48);
            panel6.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(224, 224, 224);
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.Location = new Point(3, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(46, 34);
            btnSearch.TabIndex = 0;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(dtpDataFim);
            panel5.Controls.Add(lblDataFim);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(500, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(438, 48);
            panel5.TabIndex = 5;
            // 
            // dtpDataFim
            // 
            dtpDataFim.Location = new Point(107, 6);
            dtpDataFim.Name = "dtpDataFim";
            dtpDataFim.Size = new Size(300, 31);
            dtpDataFim.TabIndex = 3;
            // 
            // lblDataFim
            // 
            lblDataFim.AutoSize = true;
            lblDataFim.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataFim.Location = new Point(3, 6);
            lblDataFim.Name = "lblDataFim";
            lblDataFim.Size = new Size(98, 25);
            lblDataFim.TabIndex = 2;
            lblDataFim.Text = "Data Final:";
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(434, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(66, 48);
            panel4.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblDataInicio);
            panel3.Controls.Add(dtpData);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(434, 48);
            panel3.TabIndex = 3;
            // 
            // lblDataInicio
            // 
            lblDataInicio.AutoSize = true;
            lblDataInicio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataInicio.Location = new Point(0, 6);
            lblDataInicio.Name = "lblDataInicio";
            lblDataInicio.Size = new Size(104, 25);
            lblDataInicio.TabIndex = 1;
            lblDataInicio.Text = "Data Inicio:";
            // 
            // dtpData
            // 
            dtpData.Location = new Point(110, 6);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(300, 31);
            dtpData.TabIndex = 0;
            dtpData.Value = new DateTime(2025, 1, 23, 0, 0, 0, 0);
            // 
            // panTitulo
            // 
            panTitulo.Controls.Add(lblTitulo);
            panTitulo.Dock = DockStyle.Top;
            panTitulo.Location = new Point(0, 0);
            panTitulo.Name = "panTitulo";
            panTitulo.Size = new Size(1200, 115);
            panTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(9, 22);
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
            Size = new Size(1200, 818);
            panCentral.ResumeLayout(false);
            panConclusões.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panRel.ResumeLayout(false);
            panRel.PerformLayout();
            panLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            panFiltro.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Panel panRel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private DateTimePicker dtpDataFim;
        private Label lblDataFim;
        private Panel panel4;
        private Panel panel3;
        private Label lblDataInicio;
        private Panel panel6;
        private Button btnSearch;
    }
}
