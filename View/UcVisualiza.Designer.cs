namespace EmporioRoyal.View
{
    partial class UcVisualiza
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
            panTitulo = new Panel();
            lblTitulo = new Label();
            panCentral.SuspendLayout();
            panButton.SuspendLayout();
            panLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            panTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // panCentral
            // 
            panCentral.BackColor = Color.FromArgb(255, 128, 128);
            panCentral.Controls.Add(panButton);
            panCentral.Controls.Add(panLista);
            panCentral.Controls.Add(panTitulo);
            panCentral.Dock = DockStyle.Fill;
            panCentral.Location = new Point(0, 0);
            panCentral.Name = "panCentral";
            panCentral.Size = new Size(1542, 807);
            panCentral.TabIndex = 0;
            // 
            // panButton
            // 
            panButton.Controls.Add(btnFechar);
            panButton.Dock = DockStyle.Bottom;
            panButton.Location = new Point(0, 634);
            panButton.Name = "panButton";
            panButton.Size = new Size(1542, 173);
            panButton.TabIndex = 2;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFechar.Location = new Point(1334, 23);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(177, 54);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // panLista
            // 
            panLista.Controls.Add(dgvLista);
            panLista.Dock = DockStyle.Fill;
            panLista.Location = new Point(0, 151);
            panLista.Name = "panLista";
            panLista.Size = new Size(1542, 656);
            panLista.TabIndex = 1;
            // 
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Dock = DockStyle.Fill;
            dgvLista.Location = new Point(0, 0);
            dgvLista.Name = "dgvLista";
            dgvLista.RowHeadersWidth = 62;
            dgvLista.Size = new Size(1542, 656);
            dgvLista.TabIndex = 0;
            // 
            // panTitulo
            // 
            panTitulo.Controls.Add(lblTitulo);
            panTitulo.Dock = DockStyle.Top;
            panTitulo.Location = new Point(0, 0);
            panTitulo.Name = "panTitulo";
            panTitulo.Size = new Size(1542, 151);
            panTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(635, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(438, 65);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Visualizar Clientes";
            // 
            // UcVisualiza
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panCentral);
            Name = "UcVisualiza";
            Size = new Size(1542, 807);
            panCentral.ResumeLayout(false);
            panButton.ResumeLayout(false);
            panLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            panTitulo.ResumeLayout(false);
            panTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panCentral;
        private Panel panTitulo;
        private Label lblTitulo;
        private Panel panButton;
        private Button btnFechar;
        private Panel panLista;
        private DataGridView dgvLista;
    }
}
