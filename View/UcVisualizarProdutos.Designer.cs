namespace EmporioRoyal.View
{
    partial class UcVisualizarProdutos
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
            btnFechar = new Button();
            panLista = new Panel();
            dgvLista = new DataGridView();
            panTitle = new Panel();
            label1 = new Label();
            panCentral.SuspendLayout();
            panButton.SuspendLayout();
            panLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            panTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panCentral
            // 
            panCentral.BackColor = Color.FromArgb(255, 128, 128);
            panCentral.Controls.Add(panButton);
            panCentral.Controls.Add(panLista);
            panCentral.Controls.Add(panTitle);
            panCentral.Dock = DockStyle.Fill;
            panCentral.Location = new Point(0, 0);
            panCentral.Name = "panCentral";
            panCentral.Size = new Size(1904, 803);
            panCentral.TabIndex = 0;
            // 
            // panButton
            // 
            panButton.Anchor = AnchorStyles.Bottom;
            panButton.BackColor = Color.Transparent;
            panButton.Controls.Add(btnFechar);
            panButton.Location = new Point(0, 635);
            panButton.Name = "panButton";
            panButton.Size = new Size(1904, 168);
            panButton.TabIndex = 2;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFechar.Location = new Point(1722, 40);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(135, 42);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // panLista
            // 
            panLista.BackColor = Color.Transparent;
            panLista.Controls.Add(dgvLista);
            panLista.Dock = DockStyle.Fill;
            panLista.Location = new Point(0, 150);
            panLista.Name = "panLista";
            panLista.Size = new Size(1904, 653);
            panLista.TabIndex = 1;
            // 
            // dgvLista
            // 
            dgvLista.Anchor = AnchorStyles.Top;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(0, 0);
            dgvLista.Name = "dgvLista";
            dgvLista.RowHeadersWidth = 62;
            dgvLista.Size = new Size(1904, 653);
            dgvLista.TabIndex = 0;
            dgvLista.CellFormatting += dgvLista_CellFormatting;
            dgvLista.CellMouseEnter += dgvLista_CellMouseEnter;
            dgvLista.CellMouseLeave += dgvLista_CellMouseLeave;
            // 
            // panTitle
            // 
            panTitle.BackColor = Color.Transparent;
            panTitle.Controls.Add(label1);
            panTitle.Dock = DockStyle.Top;
            panTitle.Location = new Point(0, 0);
            panTitle.Name = "panTitle";
            panTitle.Size = new Size(1904, 150);
            panTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(827, 39);
            label1.Name = "label1";
            label1.Size = new Size(233, 65);
            label1.TabIndex = 0;
            label1.Text = "Produtos";
            // 
            // UcVisualizarProdutos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panCentral);
            Name = "UcVisualizarProdutos";
            Size = new Size(1904, 803);
            panCentral.ResumeLayout(false);
            panButton.ResumeLayout(false);
            panLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            panTitle.ResumeLayout(false);
            panTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panCentral;
        private Panel panTitle;
        private Label label1;
        private Panel panButton;
        private Button btnFechar;
        private Panel panLista;
        private DataGridView dgvLista;
    }
}
