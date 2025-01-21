namespace EmporioRoyal.View
{
    partial class UcNovoCliente
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
            panel1 = new Panel();
            lblTitle = new Label();
            lblNome = new Label();
            txbNome = new TextBox();
            lblTelefone = new Label();
            txbTelefone = new TextBox();
            lblEndereco = new Label();
            txbEnd = new TextBox();
            lblBairro = new Label();
            txbBairro = new TextBox();
            lblWhats = new Label();
            ckbWhats = new CheckBox();
            lblAtivo = new Label();
            ckbAtivo = new CheckBox();
            btnCancel = new Button();
            btnConfirmar = new Button();
            panCentral = new Panel();
            panTotal = new Panel();
            panel1.SuspendLayout();
            panCentral.SuspendLayout();
            panTotal.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1590, 141);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(770, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(344, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Registro de Clientes";
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.None;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(604, 132);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(86, 32);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(709, 135);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(620, 31);
            txbNome.TabIndex = 2;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(604, 225);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(112, 32);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone:";
            // 
            // txbTelefone
            // 
            txbTelefone.Location = new Point(723, 228);
            txbTelefone.MaxLength = 12;
            txbTelefone.Name = "txbTelefone";
            txbTelefone.Size = new Size(255, 31);
            txbTelefone.TabIndex = 4;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(604, 317);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(120, 32);
            lblEndereco.TabIndex = 5;
            lblEndereco.Text = "Endereço:";
            // 
            // txbEnd
            // 
            txbEnd.Location = new Point(723, 320);
            txbEnd.MaxLength = 2000;
            txbEnd.Name = "txbEnd";
            txbEnd.Size = new Size(605, 31);
            txbEnd.TabIndex = 6;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBairro.Location = new Point(604, 408);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(86, 32);
            lblBairro.TabIndex = 7;
            lblBairro.Text = "Bairro:";
            // 
            // txbBairro
            // 
            txbBairro.Location = new Point(723, 412);
            txbBairro.MaxLength = 2000;
            txbBairro.Name = "txbBairro";
            txbBairro.Size = new Size(605, 31);
            txbBairro.TabIndex = 8;
            // 
            // lblWhats
            // 
            lblWhats.AutoSize = true;
            lblWhats.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWhats.Location = new Point(1027, 225);
            lblWhats.Name = "lblWhats";
            lblWhats.Size = new Size(147, 32);
            lblWhats.TabIndex = 9;
            lblWhats.Text = "Whats App: ";
            // 
            // ckbWhats
            // 
            ckbWhats.AutoSize = true;
            ckbWhats.Location = new Point(1190, 237);
            ckbWhats.Name = "ckbWhats";
            ckbWhats.Size = new Size(22, 21);
            ckbWhats.TabIndex = 10;
            ckbWhats.UseVisualStyleBackColor = true;
            // 
            // lblAtivo
            // 
            lblAtivo.AutoSize = true;
            lblAtivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAtivo.Location = new Point(604, 488);
            lblAtivo.Name = "lblAtivo";
            lblAtivo.Size = new Size(77, 32);
            lblAtivo.TabIndex = 11;
            lblAtivo.Text = "Ativo:";
            // 
            // ckbAtivo
            // 
            ckbAtivo.AutoSize = true;
            ckbAtivo.Location = new Point(723, 498);
            ckbAtivo.Name = "ckbAtivo";
            ckbAtivo.Size = new Size(22, 21);
            ckbAtivo.TabIndex = 12;
            ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(604, 653);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 63);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Lime;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(867, 653);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(153, 63);
            btnConfirmar.TabIndex = 14;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // panCentral
            // 
            panCentral.BackColor = Color.Transparent;
            panCentral.Controls.Add(btnConfirmar);
            panCentral.Controls.Add(btnCancel);
            panCentral.Controls.Add(ckbAtivo);
            panCentral.Controls.Add(lblAtivo);
            panCentral.Controls.Add(ckbWhats);
            panCentral.Controls.Add(lblWhats);
            panCentral.Controls.Add(txbBairro);
            panCentral.Controls.Add(lblBairro);
            panCentral.Controls.Add(txbEnd);
            panCentral.Controls.Add(lblEndereco);
            panCentral.Controls.Add(txbTelefone);
            panCentral.Controls.Add(lblTelefone);
            panCentral.Controls.Add(txbNome);
            panCentral.Controls.Add(lblNome);
            panCentral.Dock = DockStyle.Fill;
            panCentral.Location = new Point(0, 141);
            panCentral.Name = "panCentral";
            panCentral.Size = new Size(1590, 1037);
            panCentral.TabIndex = 0;
            // 
            // panTotal
            // 
            panTotal.Controls.Add(panCentral);
            panTotal.Controls.Add(panel1);
            panTotal.Dock = DockStyle.Fill;
            panTotal.Location = new Point(0, 0);
            panTotal.Margin = new Padding(4, 5, 4, 5);
            panTotal.Name = "panTotal";
            panTotal.Size = new Size(1590, 1178);
            panTotal.TabIndex = 1;
            // 
            // UcNovoCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            Controls.Add(panTotal);
            Name = "UcNovoCliente";
            Size = new Size(1590, 1178);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panCentral.ResumeLayout(false);
            panCentral.PerformLayout();
            panTotal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Label lblNome;
        private TextBox txbNome;
        private Label lblTelefone;
        private TextBox txbTelefone;
        private Label lblEndereco;
        private TextBox txbEnd;
        private Label lblBairro;
        private TextBox txbBairro;
        private Label lblWhats;
        private CheckBox ckbWhats;
        private Label lblAtivo;
        private CheckBox ckbAtivo;
        private Button btnCancel;
        private Button btnConfirmar;
        private Panel panCentral;
        private Panel panTotal;
    }
}
