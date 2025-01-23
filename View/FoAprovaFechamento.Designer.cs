namespace EmporioRoyal.View
{
    partial class FoAprovaFechamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoAprovaFechamento));
            panTitulo = new Panel();
            lblTitulo = new Label();
            dgvAprova = new DataGridView();
            panTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAprova).BeginInit();
            SuspendLayout();
            // 
            // panTitulo
            // 
            panTitulo.Controls.Add(lblTitulo);
            panTitulo.Dock = DockStyle.Top;
            panTitulo.Location = new Point(0, 0);
            panTitulo.Name = "panTitulo";
            panTitulo.Size = new Size(800, 73);
            panTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(98, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(639, 54);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "APROVA FECHAMENTO DE CAIXA";
            // 
            // dgvAprova
            // 
            dgvAprova.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAprova.Dock = DockStyle.Fill;
            dgvAprova.Location = new Point(0, 73);
            dgvAprova.Name = "dgvAprova";
            dgvAprova.RowHeadersWidth = 62;
            dgvAprova.Size = new Size(800, 377);
            dgvAprova.TabIndex = 1;
            // 
            // FoAprovaFechamento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvAprova);
            Controls.Add(panTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FoAprovaFechamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "APROVAR FECHAMENTO";
            TopMost = true;
            WindowState = FormWindowState.Minimized;
            panTitulo.ResumeLayout(false);
            panTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAprova).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panTitulo;
        private Label lblTitulo;
        private DataGridView dgvAprova;
    }
}