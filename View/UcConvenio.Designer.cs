namespace EmporioRoyal.View
{
    partial class UcConvenio
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
            cmbCliente = new ComboBox();
            lblCliente = new Label();
            panCentral.SuspendLayout();
            SuspendLayout();
            // 
            // panCentral
            // 
            panCentral.BackColor = Color.FromArgb(255, 128, 128);
            panCentral.Controls.Add(cmbCliente);
            panCentral.Controls.Add(lblCliente);
            panCentral.Dock = DockStyle.Fill;
            panCentral.Location = new Point(0, 0);
            panCentral.Name = "panCentral";
            panCentral.Size = new Size(634, 141);
            panCentral.TabIndex = 0;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(40, 74);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(547, 33);
            cmbCliente.TabIndex = 1;
            cmbCliente.KeyDown += cmbCliente_KeyDown;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(40, 17);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(132, 45);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // UcConvenio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panCentral);
            Name = "UcConvenio";
            Size = new Size(634, 141);
            panCentral.ResumeLayout(false);
            panCentral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panCentral;
        private ComboBox cmbCliente;
        private Label lblCliente;
    }
}
