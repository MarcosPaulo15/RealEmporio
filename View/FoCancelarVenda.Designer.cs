namespace EmporioRoyal.View
{
    partial class FoCancelarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoCancelarVenda));
            dgvCancelar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCancelar).BeginInit();
            SuspendLayout();
            // 
            // dgvCancelar
            // 
            dgvCancelar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCancelar.Dock = DockStyle.Fill;
            dgvCancelar.Location = new Point(0, 0);
            dgvCancelar.Name = "dgvCancelar";
            dgvCancelar.Size = new Size(462, 301);
            dgvCancelar.TabIndex = 0;
            dgvCancelar.CellContentClick += dgvCancelar_CellContentClick;
            dgvCancelar.KeyDown += dgvCancelar_KeyDown_1;
            // 
            // FoCancelarVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(462, 301);
            Controls.Add(dgvCancelar);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FoCancelarVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cancelar Venda";
            ((System.ComponentModel.ISupportInitialize)dgvCancelar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCancelar;
    }
}