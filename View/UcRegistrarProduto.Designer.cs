namespace EmporioRoyal.View
{
    partial class UcRegistrarProduto
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
            panButton = new Panel();
            btnClose = new Button();
            btnConfirmar = new Button();
            panLayout = new Panel();
            panel6 = new Panel();
            panel11 = new Panel();
            lblUnd = new Label();
            cmbUn = new ComboBox();
            panel10 = new Panel();
            panel9 = new Panel();
            qtdAtual = new Label();
            txbQtdAtual = new TextBox();
            panel8 = new Panel();
            panel7 = new Panel();
            lblQtd = new Label();
            txbQtd = new TextBox();
            pan2 = new Panel();
            panel5 = new Panel();
            lblPorcentagem = new Label();
            txbPorcentagem = new TextBox();
            panel4 = new Panel();
            panel3 = new Panel();
            lblQuantidade = new Label();
            txbPreco = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            lblValor = new Label();
            txbPrecoCusto = new TextBox();
            pan1 = new Panel();
            lblCodigo = new Label();
            txbCodigo = new TextBox();
            lblNome = new Label();
            txbNome = new TextBox();
            txbDescricao = new TextBox();
            lblDescricao = new Label();
            panTitulo = new Panel();
            lblTitulo = new Label();
            panCentral.SuspendLayout();
            panButton.SuspendLayout();
            panLayout.SuspendLayout();
            panel6.SuspendLayout();
            panel11.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            pan2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            pan1.SuspendLayout();
            panTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // panCentral
            // 
            panCentral.BackColor = Color.FromArgb(255, 128, 128);
            panCentral.Controls.Add(panButton);
            panCentral.Controls.Add(panLayout);
            panCentral.Controls.Add(panTitulo);
            panCentral.Dock = DockStyle.Fill;
            panCentral.Location = new Point(0, 0);
            panCentral.Name = "panCentral";
            panCentral.Size = new Size(1533, 804);
            panCentral.TabIndex = 0;
            // 
            // panButton
            // 
            panButton.Controls.Add(btnClose);
            panButton.Controls.Add(btnConfirmar);
            panButton.Dock = DockStyle.Bottom;
            panButton.Location = new Point(0, 654);
            panButton.Name = "panButton";
            panButton.Size = new Size(1533, 150);
            panButton.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(1197, 45);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 1;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(1390, 45);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 34);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // panLayout
            // 
            panLayout.BorderStyle = BorderStyle.FixedSingle;
            panLayout.Controls.Add(panel6);
            panLayout.Controls.Add(pan2);
            panLayout.Controls.Add(pan1);
            panLayout.Controls.Add(txbDescricao);
            panLayout.Controls.Add(lblDescricao);
            panLayout.Dock = DockStyle.Fill;
            panLayout.Location = new Point(0, 113);
            panLayout.Name = "panLayout";
            panLayout.Size = new Size(1533, 691);
            panLayout.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(panel11);
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 194);
            panel6.Name = "panel6";
            panel6.Size = new Size(1531, 116);
            panel6.TabIndex = 16;
            // 
            // panel11
            // 
            panel11.Controls.Add(lblUnd);
            panel11.Controls.Add(cmbUn);
            panel11.Dock = DockStyle.Left;
            panel11.Location = new Point(869, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(354, 114);
            panel11.TabIndex = 4;
            // 
            // lblUnd
            // 
            lblUnd.AutoSize = true;
            lblUnd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnd.Location = new Point(20, 44);
            lblUnd.Name = "lblUnd";
            lblUnd.Size = new Size(190, 32);
            lblUnd.TabIndex = 12;
            lblUnd.Text = "Tipo de Medida:";
            // 
            // cmbUn
            // 
            cmbUn.FormattingEnabled = true;
            cmbUn.Location = new Point(233, 47);
            cmbUn.Name = "cmbUn";
            cmbUn.Size = new Size(101, 33);
            cmbUn.TabIndex = 13;
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(819, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(50, 114);
            panel10.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.Controls.Add(qtdAtual);
            panel9.Controls.Add(txbQtdAtual);
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(449, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(370, 114);
            panel9.TabIndex = 2;
            // 
            // qtdAtual
            // 
            qtdAtual.AutoSize = true;
            qtdAtual.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qtdAtual.Location = new Point(6, 44);
            qtdAtual.Name = "qtdAtual";
            qtdAtual.Size = new Size(220, 32);
            qtdAtual.TabIndex = 14;
            qtdAtual.Text = "Quantidade Atual: ";
            // 
            // txbQtdAtual
            // 
            txbQtdAtual.Location = new Point(225, 47);
            txbQtdAtual.Name = "txbQtdAtual";
            txbQtdAtual.Size = new Size(116, 31);
            txbQtdAtual.TabIndex = 15;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(380, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(69, 114);
            panel8.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(lblQtd);
            panel7.Controls.Add(txbQtd);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(380, 114);
            panel7.TabIndex = 0;
            // 
            // lblQtd
            // 
            lblQtd.AutoSize = true;
            lblQtd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQtd.Location = new Point(3, 44);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new Size(244, 32);
            lblQtd.TabIndex = 8;
            lblQtd.Text = "Quantidade Minima: ";
            // 
            // txbQtd
            // 
            txbQtd.Location = new Point(253, 47);
            txbQtd.Name = "txbQtd";
            txbQtd.Size = new Size(116, 31);
            txbQtd.TabIndex = 9;
            txbQtd.KeyPress += textBox1_KeyPress;
            // 
            // pan2
            // 
            pan2.BorderStyle = BorderStyle.FixedSingle;
            pan2.Controls.Add(panel5);
            pan2.Controls.Add(panel4);
            pan2.Controls.Add(panel3);
            pan2.Controls.Add(panel2);
            pan2.Controls.Add(panel1);
            pan2.Dock = DockStyle.Top;
            pan2.Location = new Point(0, 94);
            pan2.Name = "pan2";
            pan2.Size = new Size(1531, 100);
            pan2.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblPorcentagem);
            panel5.Controls.Add(txbPorcentagem);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(766, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(457, 98);
            panel5.TabIndex = 20;
            // 
            // lblPorcentagem
            // 
            lblPorcentagem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPorcentagem.AutoSize = true;
            lblPorcentagem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorcentagem.Location = new Point(6, 36);
            lblPorcentagem.Name = "lblPorcentagem";
            lblPorcentagem.Size = new Size(265, 32);
            lblPorcentagem.TabIndex = 8;
            lblPorcentagem.Text = "Porcentagem de Lucro:";
            // 
            // txbPorcentagem
            // 
            txbPorcentagem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txbPorcentagem.Location = new Point(277, 41);
            txbPorcentagem.Name = "txbPorcentagem";
            txbPorcentagem.Size = new Size(116, 31);
            txbPorcentagem.TabIndex = 9;
            txbPorcentagem.KeyPress += txbPorcentagem_KeyPress;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(716, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(50, 98);
            panel4.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblQuantidade);
            panel3.Controls.Add(txbPreco);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(416, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 98);
            panel3.TabIndex = 18;
            // 
            // lblQuantidade
            // 
            lblQuantidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidade.Location = new Point(6, 36);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(76, 32);
            lblQuantidade.TabIndex = 4;
            lblQuantidade.Text = "Valor:";
            // 
            // txbPreco
            // 
            txbPreco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txbPreco.Location = new Point(88, 41);
            txbPreco.Name = "txbPreco";
            txbPreco.Size = new Size(116, 31);
            txbPreco.TabIndex = 5;
            txbPreco.KeyPress += textBox3_KeyPress;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(347, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(69, 98);
            panel2.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblValor);
            panel1.Controls.Add(txbPrecoCusto);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 98);
            panel1.TabIndex = 16;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(3, 38);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(184, 32);
            lblValor.TabIndex = 6;
            lblValor.Text = "Preço de Custo:";
            // 
            // txbPrecoCusto
            // 
            txbPrecoCusto.Location = new Point(193, 39);
            txbPrecoCusto.Name = "txbPrecoCusto";
            txbPrecoCusto.Size = new Size(116, 31);
            txbPrecoCusto.TabIndex = 7;
            txbPrecoCusto.KeyPress += textBox1_KeyPress_1;
            // 
            // pan1
            // 
            pan1.BorderStyle = BorderStyle.FixedSingle;
            pan1.Controls.Add(lblCodigo);
            pan1.Controls.Add(txbCodigo);
            pan1.Controls.Add(lblNome);
            pan1.Controls.Add(txbNome);
            pan1.Dock = DockStyle.Top;
            pan1.Location = new Point(0, 0);
            pan1.Name = "pan1";
            pan1.Size = new Size(1531, 94);
            pan1.TabIndex = 10;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(19, 28);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(97, 32);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            // 
            // txbCodigo
            // 
            txbCodigo.Location = new Point(133, 31);
            txbCodigo.Name = "txbCodigo";
            txbCodigo.Size = new Size(526, 31);
            txbCodigo.TabIndex = 1;
            txbCodigo.KeyPress += txbCodigo_KeyPress;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(762, 28);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(86, 32);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome:";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(889, 31);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(526, 31);
            txbNome.TabIndex = 3;
            // 
            // txbDescricao
            // 
            txbDescricao.Location = new Point(176, 339);
            txbDescricao.Multiline = true;
            txbDescricao.Name = "txbDescricao";
            txbDescricao.Size = new Size(469, 144);
            txbDescricao.TabIndex = 7;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(19, 397);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(124, 32);
            lblDescricao.TabIndex = 6;
            lblDescricao.Text = "Descrição:";
            // 
            // panTitulo
            // 
            panTitulo.BorderStyle = BorderStyle.Fixed3D;
            panTitulo.Controls.Add(lblTitulo);
            panTitulo.Dock = DockStyle.Top;
            panTitulo.Location = new Point(0, 0);
            panTitulo.Name = "panTitulo";
            panTitulo.Size = new Size(1533, 113);
            panTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(607, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(503, 65);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Produtos";
            // 
            // UcRegistrarProduto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panCentral);
            Name = "UcRegistrarProduto";
            Size = new Size(1533, 804);
            panCentral.ResumeLayout(false);
            panButton.ResumeLayout(false);
            panLayout.ResumeLayout(false);
            panLayout.PerformLayout();
            panel6.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            pan2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pan1.ResumeLayout(false);
            pan1.PerformLayout();
            panTitulo.ResumeLayout(false);
            panTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panCentral;
        private Panel panTitulo;
        private Label lblTitulo;
        private Panel panButton;
        private Panel panLayout;
        private Label lblCodigo;
        private TextBox txbPreco;
        private Label lblQuantidade;
        private TextBox txbNome;
        private Label lblNome;
        private TextBox txbCodigo;
        private TextBox txbDescricao;
        private Label lblDescricao;
        private Button btnClose;
        private Button btnConfirmar;
        private TextBox txbQtd;
        private Label lblQtd;
        private Panel pan1;
        private Panel pan2;
        private Label lblPorcentagem;
        private TextBox txbPorcentagem;
        private Label lblValor;
        private TextBox txbPrecoCusto;
        private ComboBox cmbUn;
        private Label lblUnd;
        private TextBox txbQtdAtual;
        private Label qtdAtual;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel6;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
    }
}
