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
            panCentral = new Panel();
            panel1 = new Panel();
            lblTitle = new Label();
            lblNome = new Label();
            txbNome = new TextBox();
            txbTelefone = new TextBox();
            lblTelefone = new Label();
            textBox1 = new TextBox();
            lblEndereco = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            lblWhats = new Label();
            ckbWhats = new CheckBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            btnCancel = new Button();
            btnConfirmar = new Button();
            panCentral.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panCentral
            // 
            panCentral.BackColor = Color.White;
            panCentral.Controls.Add(btnConfirmar);
            panCentral.Controls.Add(btnCancel);
            panCentral.Controls.Add(checkBox1);
            panCentral.Controls.Add(label2);
            panCentral.Controls.Add(ckbWhats);
            panCentral.Controls.Add(lblWhats);
            panCentral.Controls.Add(textBox2);
            panCentral.Controls.Add(label1);
            panCentral.Controls.Add(textBox1);
            panCentral.Controls.Add(lblEndereco);
            panCentral.Controls.Add(txbTelefone);
            panCentral.Controls.Add(lblTelefone);
            panCentral.Controls.Add(txbNome);
            panCentral.Controls.Add(lblNome);
            panCentral.Controls.Add(panel1);
            panCentral.Dock = DockStyle.Fill;
            panCentral.Location = new Point(0, 0);
            panCentral.Name = "panCentral";
            panCentral.Size = new Size(1528, 802);
            panCentral.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1528, 78);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(569, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(344, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Registro de Clientes";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(69, 160);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(86, 32);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(173, 163);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(620, 31);
            txbNome.TabIndex = 2;
            // 
            // txbTelefone
            // 
            txbTelefone.Location = new Point(187, 257);
            txbTelefone.MaxLength = 12;
            txbTelefone.Name = "txbTelefone";
            txbTelefone.Size = new Size(256, 31);
            txbTelefone.TabIndex = 4;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(69, 254);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(112, 32);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(187, 348);
            textBox1.MaxLength = 12;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(606, 31);
            textBox1.TabIndex = 6;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(69, 345);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(120, 32);
            lblEndereco.TabIndex = 5;
            lblEndereco.Text = "Endereço:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(187, 440);
            textBox2.MaxLength = 12;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(606, 31);
            textBox2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 437);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 7;
            label1.Text = "Bairro:";
            // 
            // lblWhats
            // 
            lblWhats.AutoSize = true;
            lblWhats.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWhats.Location = new Point(492, 254);
            lblWhats.Name = "lblWhats";
            lblWhats.Size = new Size(147, 32);
            lblWhats.TabIndex = 9;
            lblWhats.Text = "Whats App: ";
            // 
            // ckbWhats
            // 
            ckbWhats.AutoSize = true;
            ckbWhats.Location = new Point(654, 265);
            ckbWhats.Name = "ckbWhats";
            ckbWhats.Size = new Size(22, 21);
            ckbWhats.TabIndex = 10;
            ckbWhats.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(187, 527);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 12;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 516);
            label2.Name = "label2";
            label2.Size = new Size(77, 32);
            label2.TabIndex = 11;
            label2.Text = "Ativo:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(69, 681);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Lime;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(331, 681);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(141, 34);
            btnConfirmar.TabIndex = 14;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // UcNovoCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panCentral);
            Name = "UcNovoCliente";
            Size = new Size(1528, 802);
            panCentral.ResumeLayout(false);
            panCentral.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panCentral;
        private Panel panel1;
        private TextBox txbTelefone;
        private Label lblTelefone;
        private TextBox txbNome;
        private Label lblNome;
        private Label lblTitle;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label lblEndereco;
        private Button btnConfirmar;
        private Button btnCancel;
        private CheckBox checkBox1;
        private Label label2;
        private CheckBox ckbWhats;
        private Label lblWhats;
    }
}
