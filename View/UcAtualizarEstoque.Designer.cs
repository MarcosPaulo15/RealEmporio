namespace EmporioRoyal.View
{
    partial class UcAtualizarEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcAtualizarEstoque));
            panCentral = new Panel();
            dgvLista = new DataGridView();
            panBusca = new Panel();
            btnSearch = new Button();
            txbProduto = new TextBox();
            lblProduto = new Label();
            panel1 = new Panel();
            panTitulo = new Panel();
            lblTitulo = new Label();
            panCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            panBusca.SuspendLayout();
            panTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // panCentral
            // 
            panCentral.BackColor = Color.FromArgb(255, 128, 128);
            panCentral.Controls.Add(dgvLista);
            panCentral.Controls.Add(panBusca);
            panCentral.Controls.Add(panel1);
            panCentral.Controls.Add(panTitulo);
            panCentral.Dock = DockStyle.Fill;
            panCentral.Location = new Point(0, 0);
            panCentral.Name = "panCentral";
            panCentral.Size = new Size(1743, 687);
            panCentral.TabIndex = 0;
            // 
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Dock = DockStyle.Fill;
            dgvLista.Location = new Point(0, 214);
            dgvLista.Name = "dgvLista";
            dgvLista.RowHeadersWidth = 62;
            dgvLista.Size = new Size(1743, 473);
            dgvLista.TabIndex = 3;
            dgvLista.CellContentClick += dgvLista_CellContentClick;
            // 
            // panBusca
            // 
            panBusca.Controls.Add(btnSearch);
            panBusca.Controls.Add(txbProduto);
            panBusca.Controls.Add(lblProduto);
            panBusca.Dock = DockStyle.Top;
            panBusca.Location = new Point(0, 116);
            panBusca.Name = "panBusca";
            panBusca.Size = new Size(1743, 98);
            panBusca.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.Location = new Point(553, -3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(59, 34);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txbProduto
            // 
            txbProduto.Dock = DockStyle.Left;
            txbProduto.Location = new Point(115, 0);
            txbProduto.Name = "txbProduto";
            txbProduto.Size = new Size(432, 31);
            txbProduto.TabIndex = 1;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Dock = DockStyle.Left;
            lblProduto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProduto.Location = new Point(0, 0);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(115, 32);
            lblProduto.TabIndex = 0;
            lblProduto.Text = "Produto:";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(1743, 36);
            panel1.TabIndex = 1;
            // 
            // panTitulo
            // 
            panTitulo.Controls.Add(lblTitulo);
            panTitulo.Dock = DockStyle.Top;
            panTitulo.Location = new Point(0, 0);
            panTitulo.Name = "panTitulo";
            panTitulo.Size = new Size(1743, 80);
            panTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(388, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Atualizar Estoque";
            // 
            // UcAtualizarEstoque
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panCentral);
            Name = "UcAtualizarEstoque";
            Size = new Size(1743, 687);
            panCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            panBusca.ResumeLayout(false);
            panBusca.PerformLayout();
            panTitulo.ResumeLayout(false);
            panTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panCentral;
        private DataGridView dgvLista;
        private Panel panBusca;
        private Panel panel1;
        private Panel panTitulo;
        private Label lblTitulo;
        private Button btnSearch;
        private TextBox txbProduto;
        private Label lblProduto;
    }
}
