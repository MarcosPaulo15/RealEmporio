namespace EmporioRoyal.View
{
    partial class FoMessagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoMessagem));
            panCentral = new Panel();
            dgvQtdMin = new DataGridView();
            panTitle = new Panel();
            lblTitle = new Label();
            panCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQtdMin).BeginInit();
            panTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panCentral
            // 
            panCentral.BackColor = Color.FromArgb(255, 192, 192);
            panCentral.Controls.Add(dgvQtdMin);
            panCentral.Controls.Add(panTitle);
            panCentral.Dock = DockStyle.Fill;
            panCentral.Location = new Point(0, 0);
            panCentral.Name = "panCentral";
            panCentral.Size = new Size(522, 419);
            panCentral.TabIndex = 0;
            // 
            // dgvQtdMin
            // 
            dgvQtdMin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQtdMin.Dock = DockStyle.Fill;
            dgvQtdMin.Location = new Point(0, 81);
            dgvQtdMin.Name = "dgvQtdMin";
            dgvQtdMin.RowHeadersWidth = 62;
            dgvQtdMin.Size = new Size(522, 338);
            dgvQtdMin.TabIndex = 1;
            // 
            // panTitle
            // 
            panTitle.Controls.Add(lblTitle);
            panTitle.Dock = DockStyle.Top;
            panTitle.Location = new Point(0, 0);
            panTitle.Name = "panTitle";
            panTitle.Size = new Size(522, 81);
            panTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(3, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(450, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PRODUTOS COM QUANTIDADE BAIXA";
            // 
            // FoMessagem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 419);
            Controls.Add(panCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FoMessagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FoMessagem";
            panCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQtdMin).EndInit();
            panTitle.ResumeLayout(false);
            panTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panCentral;
        private DataGridView dgvQtdMin;
        private Panel panTitle;
        private Label lblTitle;
    }
}