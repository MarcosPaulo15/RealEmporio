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
            clienteToolStripMenuItem = new ToolStripMenuItem();
            adicionarNovoClienteToolStripMenuItem = new ToolStripMenuItem();
            verClientesToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            registrarProdutosToolStripMenuItem = new ToolStripMenuItem();
            entradaDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeVendasToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            PanCentral = new Panel();
            panUc = new Panel();
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
            panMenu.Size = new Size(1370, 52);
            panMenu.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, estoqueToolStripMenuItem, relatóriosToolStripMenuItem, vendaToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1370, 46);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarNovoClienteToolStripMenuItem, verClientesToolStripMenuItem });
            clienteToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarProdutosToolStripMenuItem, entradaDeProdutosToolStripMenuItem });
            estoqueToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            estoqueToolStripMenuItem.Margin = new Padding(165, 0, 0, 0);
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(135, 42);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // registrarProdutosToolStripMenuItem
            // 
            registrarProdutosToolStripMenuItem.Name = "registrarProdutosToolStripMenuItem";
            registrarProdutosToolStripMenuItem.Size = new Size(385, 46);
            registrarProdutosToolStripMenuItem.Text = "Registrar produtos";
            // 
            // entradaDeProdutosToolStripMenuItem
            // 
            entradaDeProdutosToolStripMenuItem.Name = "entradaDeProdutosToolStripMenuItem";
            entradaDeProdutosToolStripMenuItem.Size = new Size(385, 46);
            entradaDeProdutosToolStripMenuItem.Text = "Entrada de Produtos";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relatórioDeVendasToolStripMenuItem });
            relatóriosToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            relatóriosToolStripMenuItem.Margin = new Padding(165, 0, 0, 0);
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(159, 42);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            relatórioDeVendasToolStripMenuItem.Size = new Size(377, 46);
            relatórioDeVendasToolStripMenuItem.Text = "Relatório de Vendas";
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vendaToolStripMenuItem.Margin = new Padding(165, 0, 0, 0);
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(112, 42);
            vendaToolStripMenuItem.Text = "Venda";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sairToolStripMenuItem.Margin = new Padding(165, 0, 0, 0);
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(80, 42);
            sairToolStripMenuItem.Text = "Sair";
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
            panUc.Controls.Add(pcLogo);
            panUc.Dock = DockStyle.Fill;
            panUc.Location = new Point(0, 52);
            panUc.Margin = new Padding(4, 5, 4, 5);
            panUc.Name = "panUc";
            panUc.Size = new Size(1370, 673);
            panUc.TabIndex = 3;
            // 
            // pcLogo
            // 
            pcLogo.BackgroundImage = Properties.Resources.logoroyal;
            pcLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pcLogo.Dock = DockStyle.Fill;
            pcLogo.Location = new Point(0, 0);
            pcLogo.Margin = new Padding(4, 5, 4, 5);
            pcLogo.Name = "pcLogo";
            pcLogo.Size = new Size(1370, 673);
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
    }
}