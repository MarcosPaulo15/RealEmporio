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
            débitosToolStripMenuItem = new ToolStripMenuItem();
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
            panMenu.Name = "panMenu";
            panMenu.Size = new Size(1370, 57);
            panMenu.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tlsInicio, clienteToolStripMenuItem, estoqueToolStripMenuItem, relatóriosToolStripMenuItem, vendaToolStripMenuItem, tlsAprovaFechamento, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1370, 46);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tlsInicio
            // 
            tlsInicio.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tlsInicio.ForeColor = Color.Black;
            tlsInicio.Name = "tlsInicio";
            tlsInicio.RightToLeft = RightToLeft.No;
            tlsInicio.Size = new Size(101, 42);
            tlsInicio.Text = "Inicio";
            tlsInicio.TextAlign = ContentAlignment.TopCenter;
            tlsInicio.Click += tlsInicio_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarNovoClienteToolStripMenuItem, verClientesToolStripMenuItem, débitosToolStripMenuItem });
            clienteToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clienteToolStripMenuItem.Margin = new Padding(105, 0, 0, 0);
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(120, 42);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // adicionarNovoClienteToolStripMenuItem
            // 
            adicionarNovoClienteToolStripMenuItem.Name = "adicionarNovoClienteToolStripMenuItem";
            adicionarNovoClienteToolStripMenuItem.Size = new Size(408, 46);
            adicionarNovoClienteToolStripMenuItem.Text = "Adicionar novo cliente";
            adicionarNovoClienteToolStripMenuItem.Click += adicionarNovoClienteToolStripMenuItem_Click;
            // 
            // verClientesToolStripMenuItem
            // 
            verClientesToolStripMenuItem.Name = "verClientesToolStripMenuItem";
            verClientesToolStripMenuItem.Size = new Size(408, 46);
            verClientesToolStripMenuItem.Text = "Ver Clientes";
            verClientesToolStripMenuItem.Click += verClientesToolStripMenuItem_Click;
            // 
            // débitosToolStripMenuItem
            // 
            débitosToolStripMenuItem.Name = "débitosToolStripMenuItem";
            débitosToolStripMenuItem.Size = new Size(408, 46);
            débitosToolStripMenuItem.Text = "Débitos";
            débitosToolStripMenuItem.Click += débitosToolStripMenuItem_Click;
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarProdutosToolStripMenuItem, entradaDeProdutosToolStripMenuItem });
            estoqueToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            estoqueToolStripMenuItem.Margin = new Padding(105, 0, 0, 0);
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(135, 42);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // registrarProdutosToolStripMenuItem
            // 
            registrarProdutosToolStripMenuItem.Name = "registrarProdutosToolStripMenuItem";
            registrarProdutosToolStripMenuItem.Size = new Size(367, 46);
            registrarProdutosToolStripMenuItem.Text = "Registrar produtos";
            registrarProdutosToolStripMenuItem.Click += registrarProdutosToolStripMenuItem_Click;
            // 
            // entradaDeProdutosToolStripMenuItem
            // 
            entradaDeProdutosToolStripMenuItem.Name = "entradaDeProdutosToolStripMenuItem";
            entradaDeProdutosToolStripMenuItem.Size = new Size(367, 46);
            entradaDeProdutosToolStripMenuItem.Text = "Visualizar Produtos";
            entradaDeProdutosToolStripMenuItem.Click += entradaDeProdutosToolStripMenuItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relatórioDeVendasToolStripMenuItem });
            relatóriosToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            relatóriosToolStripMenuItem.Margin = new Padding(105, 0, 0, 0);
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(159, 42);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            relatórioDeVendasToolStripMenuItem.Size = new Size(377, 46);
            relatórioDeVendasToolStripMenuItem.Text = "Relatório de Vendas";
            relatórioDeVendasToolStripMenuItem.Click += relatórioDeVendasToolStripMenuItem_Click;
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vendaToolStripMenuItem.Margin = new Padding(105, 0, 0, 0);
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(112, 42);
            vendaToolStripMenuItem.Text = "Venda";
            vendaToolStripMenuItem.Click += vendaToolStripMenuItem_Click;
            // 
            // tlsAprovaFechamento
            // 
            tlsAprovaFechamento.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tlsAprovaFechamento.Margin = new Padding(105, 0, 0, 0);
            tlsAprovaFechamento.Name = "tlsAprovaFechamento";
            tlsAprovaFechamento.Size = new Size(299, 42);
            tlsAprovaFechamento.Text = "Aprovar Fechamento";
            tlsAprovaFechamento.Click += tlsAprovaFechamento_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sairToolStripMenuItem.Margin = new Padding(105, 0, 0, 0);
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(80, 42);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // PanCentral
            // 
            PanCentral.Controls.Add(panUc);
            PanCentral.Controls.Add(panMenu);
            PanCentral.Dock = DockStyle.Fill;
            PanCentral.Location = new Point(0, 0);
            PanCentral.Name = "PanCentral";
            PanCentral.Size = new Size(1370, 725);
            PanCentral.TabIndex = 0;
            // 
            // panUc
            // 
            panUc.Controls.Add(lblUsuario);
            panUc.Controls.Add(pcLogo);
            panUc.Dock = DockStyle.Fill;
            panUc.Location = new Point(0, 57);
            panUc.Margin = new Padding(4, 5, 4, 5);
            panUc.Name = "panUc";
            panUc.Size = new Size(1370, 668);
            panUc.TabIndex = 3;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Dock = DockStyle.Right;
            lblUsuario.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(1307, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 28);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "label1";
            // 
            // pcLogo
            // 
            pcLogo.BackgroundImage = Properties.Resources.logoroyal;
            pcLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pcLogo.Dock = DockStyle.Fill;
            pcLogo.Location = new Point(0, 0);
            pcLogo.Margin = new Padding(4, 5, 4, 5);
            pcLogo.Name = "pcLogo";
            pcLogo.Size = new Size(1370, 668);
            pcLogo.TabIndex = 0;
            pcLogo.TabStop = false;
            // 
            // FoPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(1370, 725);
            Controls.Add(PanCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private ToolStripMenuItem débitosToolStripMenuItem;
    }
}