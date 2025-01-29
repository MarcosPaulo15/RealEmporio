namespace EmporioRoyal.View
{
    partial class UcRelDebitoConvenio
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
            panDgv = new Panel();
            panel4 = new Panel();
            lblTotal = new Label();
            lblContasFechadas = new Label();
            lblContasAbertas = new Label();
            dgvLista = new DataGridView();
            panel3 = new Panel();
            panel2 = new Panel();
            cmbStatus = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            panTitle = new Panel();
            lblTitulo = new Label();
            panCentral.SuspendLayout();
            panDgv.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            panel2.SuspendLayout();
            panTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panCentral
            // 
            panCentral.BackColor = Color.FromArgb(255, 128, 128);
            panCentral.Controls.Add(panDgv);
            panCentral.Controls.Add(panel3);
            panCentral.Controls.Add(panel2);
            panCentral.Controls.Add(panel1);
            panCentral.Controls.Add(panTitle);
            panCentral.Dock = DockStyle.Fill;
            panCentral.Location = new Point(0, 0);
            panCentral.Name = "panCentral";
            panCentral.Size = new Size(1399, 723);
            panCentral.TabIndex = 0;
            // 
            // panDgv
            // 
            panDgv.Controls.Add(panel4);
            panDgv.Controls.Add(dgvLista);
            panDgv.Dock = DockStyle.Fill;
            panDgv.Location = new Point(0, 196);
            panDgv.Name = "panDgv";
            panDgv.Size = new Size(1399, 527);
            panDgv.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblTotal);
            panel4.Controls.Add(lblContasFechadas);
            panel4.Controls.Add(lblContasAbertas);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 351);
            panel4.Name = "panel4";
            panel4.Size = new Size(1399, 173);
            panel4.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(33, 126);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(67, 32);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total";
            // 
            // lblContasFechadas
            // 
            lblContasFechadas.AutoSize = true;
            lblContasFechadas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContasFechadas.Location = new Point(33, 74);
            lblContasFechadas.Name = "lblContasFechadas";
            lblContasFechadas.Size = new Size(196, 32);
            lblContasFechadas.TabIndex = 1;
            lblContasFechadas.Text = "Contas Fechadas";
            // 
            // lblContasAbertas
            // 
            lblContasAbertas.AutoSize = true;
            lblContasAbertas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContasAbertas.Location = new Point(33, 18);
            lblContasAbertas.Name = "lblContasAbertas";
            lblContasAbertas.Size = new Size(181, 32);
            lblContasAbertas.TabIndex = 0;
            lblContasAbertas.Text = "Contas Abertas";
            // 
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Dock = DockStyle.Top;
            dgvLista.Location = new Point(0, 0);
            dgvLista.Name = "dgvLista";
            dgvLista.RowHeadersWidth = 62;
            dgvLista.Size = new Size(1399, 351);
            dgvLista.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(1399, 25);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbStatus);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(1399, 73);
            panel2.TabIndex = 2;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(112, 24);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(227, 33);
            cmbStatus.TabIndex = 1;
            cmbStatus.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 24);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 0;
            label1.Text = "Filtrar:";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(1399, 26);
            panel1.TabIndex = 1;
            // 
            // panTitle
            // 
            panTitle.Controls.Add(lblTitulo);
            panTitle.Dock = DockStyle.Top;
            panTitle.Location = new Point(0, 0);
            panTitle.Name = "panTitle";
            panTitle.Size = new Size(1399, 72);
            panTitle.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(820, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "RELATÓRIO DÉBITOS DOS CONVÊNIOS";
            // 
            // UcRelDebitoConvenio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panCentral);
            Name = "UcRelDebitoConvenio";
            Size = new Size(1399, 723);
            panCentral.ResumeLayout(false);
            panDgv.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panTitle.ResumeLayout(false);
            panTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panCentral;
        private Panel panel2;
        private Panel panel1;
        private Panel panTitle;
        private Label lblTitulo;
        private Label label1;
        private Panel panDgv;
        private DataGridView dgvLista;
        private Panel panel3;
        private Panel panel4;
        private Label lblContasAbertas;
        private Label lblTotal;
        private Label lblContasFechadas;
        private ComboBox cmbStatus;
    }
}
