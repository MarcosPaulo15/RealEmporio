namespace EmporioRoyal.View
{
    partial class UcVerClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcVerClientes));
            panCentral = new Panel();
            dgvDebitos = new DataGridView();
            panel1 = new Panel();
            panSearch = new Panel();
            lblValor = new Label();
            txbValor = new TextBox();
            btnSearch = new Button();
            txbSearch = new TextBox();
            lblSearch = new Label();
            panTitulo = new Panel();
            label1 = new Label();
            panCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDebitos).BeginInit();
            panSearch.SuspendLayout();
            panTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // panCentral
            // 
            panCentral.BackColor = Color.FromArgb(255, 128, 128);
            panCentral.Controls.Add(dgvDebitos);
            panCentral.Controls.Add(panel1);
            panCentral.Controls.Add(panSearch);
            panCentral.Controls.Add(panTitulo);
            panCentral.Dock = DockStyle.Fill;
            panCentral.Location = new Point(0, 0);
            panCentral.Name = "panCentral";
            panCentral.Size = new Size(1757, 722);
            panCentral.TabIndex = 0;
            // 
            // dgvDebitos
            // 
            dgvDebitos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDebitos.Dock = DockStyle.Fill;
            dgvDebitos.Location = new Point(0, 188);
            dgvDebitos.Name = "dgvDebitos";
            dgvDebitos.RowHeadersWidth = 62;
            dgvDebitos.Size = new Size(1757, 534);
            dgvDebitos.TabIndex = 2;
            dgvDebitos.CellContentClick += dgvDebitos_CellContentClick;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(1757, 26);
            panel1.TabIndex = 3;
            // 
            // panSearch
            // 
            panSearch.Controls.Add(lblValor);
            panSearch.Controls.Add(txbValor);
            panSearch.Controls.Add(btnSearch);
            panSearch.Controls.Add(txbSearch);
            panSearch.Controls.Add(lblSearch);
            panSearch.Dock = DockStyle.Top;
            panSearch.Location = new Point(0, 104);
            panSearch.Name = "panSearch";
            panSearch.Size = new Size(1757, 58);
            panSearch.TabIndex = 1;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(840, 22);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(72, 25);
            lblValor.TabIndex = 4;
            lblValor.Text = "VALOR:";
            lblValor.Visible = false;
            // 
            // txbValor
            // 
            txbValor.Location = new Point(931, 19);
            txbValor.Margin = new Padding(3, 3, 3, 45);
            txbValor.Name = "txbValor";
            txbValor.Size = new Size(118, 31);
            txbValor.TabIndex = 3;
            txbValor.Visible = false;
            txbValor.KeyDown += txbValor_KeyDown;
            txbValor.KeyPress += txbValor_KeyPress;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(224, 224, 224);
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.Location = new Point(693, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(46, 33);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txbSearch
            // 
            txbSearch.Location = new Point(189, 16);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(481, 31);
            txbSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Left;
            lblSearch.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(0, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(195, 48);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Pesquisar: ";
            // 
            // panTitulo
            // 
            panTitulo.Controls.Add(label1);
            panTitulo.Dock = DockStyle.Top;
            panTitulo.Location = new Point(0, 0);
            panTitulo.Name = "panTitulo";
            panTitulo.Size = new Size(1757, 104);
            panTitulo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(510, 65);
            label1.TabIndex = 0;
            label1.Text = "DÉBITOS PENDENTES";
            // 
            // UcVerClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panCentral);
            Name = "UcVerClientes";
            Size = new Size(1757, 722);
            panCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDebitos).EndInit();
            panSearch.ResumeLayout(false);
            panSearch.PerformLayout();
            panTitulo.ResumeLayout(false);
            panTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panCentral;
        private Panel panel1;
        private DataGridView dgvDebitos;
        private Panel panSearch;
        private Button btnSearch;
        private TextBox txbSearch;
        private Label lblSearch;
        private Panel panTitulo;
        private Label label1;
        private TextBox txbValor;
        private Label lblValor;
    }
}
