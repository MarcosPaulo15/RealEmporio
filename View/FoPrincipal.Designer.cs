namespace EmporioRoyal.View
{
    partial class FoPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoPrincipal));
            panMenu = new Panel();
            menuStrip1 = new MenuStrip();
            tlsInicio = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            adicionarNovoClienteToolStripMenuItem = new ToolStripMenuItem();
            verClientesToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            registrarProdutosToolStripMenuItem = new ToolStripMenuItem();
            entradaDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeVendasToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            tlsAprovaFechamento = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            PanCentral = new Panel();
            panUc = new Panel();
            lblUsuario = new Label();
            pcLogo = new PictureBox();
            panMenu.SuspendLayout();
            menuStrip1.SuspendLayout();
            PanCentral.SuspendLayout();
            panUc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcLogo).BeginInit();
            SuspendLayout();
            // 
            // panMenu
            // 
            panMenu.BackColor = Color.FromArgb(255, 192, 192);
            panMenu.Controls.Add(menuStrip1);
            panMenu.Dock = DockStyle.Top;
            panMenu.Location = new Point(0, 0);
            panMenu.Margin = new Padding(2);
            panMenu.Name = "panMenu";
            panMenu.Size = new Size(959, 34);
            panMenu.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tlsInicio, clienteToolStripMenuItem, estoqueToolStripMenuItem, relatóriosToolStripMenuItem, vendaToolStripMenuItem, tlsAprovaFechamento, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(959, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tlsInicio
            // 
            tlsInicio.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tlsInicio.ForeColor = Color.Black;
            tlsInicio.Name = "tlsInicio";
            tlsInicio.RightToLeft = RightToLeft.No;
            tlsInicio.Size = new Size(71, 29);
            tlsInicio.Text = "Inicio";
            tlsInicio.TextAlign = ContentAlignment.TopCenter;
            tlsInicio.Click += tlsInicio_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarNovoClienteToolStripMenuItem, verClientesToolStripMenuItem });
            clienteToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clienteToolStripMenuItem.Margin = new Padding(105, 0, 0, 0);
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(84, 29);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // adicionarNovoClienteToolStripMenuItem
            // 
            adicionarNovoClienteToolStripMenuItem.Name = "adicionarNovoClienteToolStripMenuItem";
            adicionarNovoClienteToolStripMenuItem.Size = new Size(276, 30);
            adicionarNovoClienteToolStripMenuItem.Text = "Adicionar novo cliente";
            adicionarNovoClienteToolStripMenuItem.Click += adicionarNovoClienteToolStripMenuItem_Click;
            // 
            // verClientesToolStripMenuItem
            // 
            verClientesToolStripMenuItem.Name = "verClientesToolStripMenuItem";
            verClientesToolStripMenuItem.Size = new Size(276, 30);
            verClientesToolStripMenuItem.Text = "Ver Clientes";
            verClientesToolStripMenuItem.Click += verClientesToolStripMenuItem_Click;
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarProdutosToolStripMenuItem, entradaDeProdutosToolStripMenuItem });
            estoqueToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            estoqueToolStripMenuItem.Margin = new Padding(105, 0, 0, 0);
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(92, 29);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // registrarProdutosToolStripMenuItem
            // 
            registrarProdutosToolStripMenuItem.Name = "registrarProdutosToolStripMenuItem";
            registrarProdutosToolStripMenuItem.Size = new Size(248, 30);
            registrarProdutosToolStripMenuItem.Text = "Registrar produtos";
            registrarProdutosToolStripMenuItem.Click += registrarProdutosToolStripMenuItem_Click;
            // 
            // entradaDeProdutosToolStripMenuItem
            // 
            entradaDeProdutosToolStripMenuItem.Name = "entradaDeProdutosToolStripMenuItem";
            entradaDeProdutosToolStripMenuItem.Size = new Size(248, 30);
            entradaDeProdutosToolStripMenuItem.Text = "Visualizar Produtos";
            entradaDeProdutosToolStripMenuItem.Click += entradaDeProdutosToolStripMenuItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relatórioDeVendasToolStripMenuItem });
            relatóriosToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            relatóriosToolStripMenuItem.Margin = new Padding(105, 0, 0, 0);
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(109, 29);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            relatórioDeVendasToolStripMenuItem.Size = new Size(253, 30);
            relatórioDeVendasToolStripMenuItem.Text = "Relatório de Vendas";
            relatórioDeVendasToolStripMenuItem.Click += relatórioDeVendasToolStripMenuItem_Click;
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vendaToolStripMenuItem.Margin = new Padding(105, 0, 0, 0);
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(77, 29);
            vendaToolStripMenuItem.Text = "Venda";
            vendaToolStripMenuItem.Click += vendaToolStripMenuItem_Click;
            // 
            // tlsAprovaFechamento
            // 
            tlsAprovaFechamento.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tlsAprovaFechamento.Margin = new Padding(105, 0, 0, 0);
            tlsAprovaFechamento.Name = "tlsAprovaFechamento";
            tlsAprovaFechamento.Size = new Size(204, 29);
            tlsAprovaFechamento.Text = "Aprovar Fechamento";
            tlsAprovaFechamento.Click += tlsAprovaFechamento_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sairToolStripMenuItem.Margin = new Padding(105, 0, 0, 0);
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(56, 29);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // PanCentral
            // 
            PanCentral.Controls.Add(panUc);
            PanCentral.Controls.Add(panMenu);
            PanCentral.Dock = DockStyle.Fill;
            PanCentral.Location = new Point(0, 0);
            PanCentral.Margin = new Padding(2);
            PanCentral.Name = "PanCentral";
            PanCentral.Size = new Size(959, 435);
            PanCentral.TabIndex = 0;
            // 
            // panUc
            // 
            panUc.Controls.Add(lblUsuario);
            panUc.Controls.Add(pcLogo);
            panUc.Dock = DockStyle.Fill;
            panUc.Location = new Point(0, 34);
            panUc.Name = "panUc";
            panUc.Size = new Size(959, 401);
            panUc.TabIndex = 3;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Dock = DockStyle.Right;
            lblUsuario.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(914, 0);
            lblUsuario.Margin = new Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(45, 19);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "label1";
            // 
            // pcLogo
            // 
            pcLogo.BackgroundImage = Properties.Resources.logoroyal;
            pcLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pcLogo.Dock = DockStyle.Fill;
            pcLogo.Location = new Point(0, 0);
            pcLogo.Name = "pcLogo";
            pcLogo.Size = new Size(959, 401);
            pcLogo.TabIndex = 0;
            pcLogo.TabStop = false;
            // 
            // FoPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(959, 435);
            Controls.Add(PanCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FoPrincipal";
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            panMenu.ResumeLayout(false);
            panMenu.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            PanCentral.ResumeLayout(false);
            panUc.ResumeLayout(false);
            panUc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panMenu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem adicionarNovoClienteToolStripMenuItem;
        private ToolStripMenuItem verClientesToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem registrarProdutosToolStripMenuItem;
        private ToolStripMenuItem entradaDeProdutosToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Panel PanCentral;
        private Panel panUc;
        private PictureBox pcLogo;
        private ToolStripMenuItem tlsInicio;
        private Label lblUsuario;
        private ToolStripMenuItem tlsAprovaFechamento;
    }
}