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
            txbQtd = new TextBox();
            lblQtd = new Label();
            txbDescricao = new TextBox();
            lblDescricao = new Label();
            txbPreco = new TextBox();
            lblQuantidade = new Label();
            txbNome = new TextBox();
            lblNome = new Label();
            txbCodigo = new TextBox();
            lblCodigo = new Label();
            panTitulo = new Panel();
            lblTitulo = new Label();
            panCentral.SuspendLayout();
            panButton.SuspendLayout();
            panLayout.SuspendLayout();
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
            panLayout.Controls.Add(txbQtd);
            panLayout.Controls.Add(lblQtd);
            panLayout.Controls.Add(txbDescricao);
            panLayout.Controls.Add(lblDescricao);
            panLayout.Controls.Add(txbPreco);
            panLayout.Controls.Add(lblQuantidade);
            panLayout.Controls.Add(txbNome);
            panLayout.Controls.Add(lblNome);
            panLayout.Controls.Add(txbCodigo);
            panLayout.Controls.Add(lblCodigo);
            panLayout.Dock = DockStyle.Fill;
            panLayout.Location = new Point(0, 113);
            panLayout.Name = "panLayout";
            panLayout.Size = new Size(1533, 691);
            panLayout.TabIndex = 1;
            // 
            // txbQtd
            // 
            txbQtd.Location = new Point(1081, 194);
            txbQtd.Name = "txbQtd";
            txbQtd.Size = new Size(116, 31);
            txbQtd.TabIndex = 9;
            txbQtd.KeyPress += textBox1_KeyPress;
            // 
            // lblQtd
            // 
            lblQtd.AutoSize = true;
            lblQtd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQtd.Location = new Point(831, 188);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new Size(244, 32);
            lblQtd.TabIndex = 8;
            lblQtd.Text = "Quantidade Minima: ";
            // 
            // txbDescricao
            // 
            txbDescricao.Location = new Point(46, 317);
            txbDescricao.Multiline = true;
            txbDescricao.Name = "txbDescricao";
            txbDescricao.Size = new Size(1431, 204);
            txbDescricao.TabIndex = 7;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(46, 265);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(124, 32);
            lblDescricao.TabIndex = 6;
            lblDescricao.Text = "Descrição:";
            // 
            // txbPreco
            // 
            txbPreco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txbPreco.Location = new Point(923, 94);
            txbPreco.Name = "txbPreco";
            txbPreco.Size = new Size(116, 31);
            txbPreco.TabIndex = 5;
            txbPreco.KeyPress += textBox3_KeyPress;
            // 
            // lblQuantidade
            // 
            lblQuantidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidade.Location = new Point(841, 95);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(76, 32);
            lblQuantidade.TabIndex = 4;
            lblQuantidade.Text = "Valor:";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(161, 191);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(526, 31);
            txbNome.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(46, 191);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(86, 32);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome:";
            // 
            // txbCodigo
            // 
            txbCodigo.Location = new Point(161, 97);
            txbCodigo.Name = "txbCodigo";
            txbCodigo.Size = new Size(526, 31);
            txbCodigo.TabIndex = 1;
            txbCodigo.KeyPress += txbCodigo_KeyPress;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(46, 94);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(97, 32);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            // 
            // panTitulo
            // 
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
            lblTitulo.Location = new Point(609, 24);
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
    }
}
