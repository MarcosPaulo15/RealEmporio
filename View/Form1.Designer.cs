namespace EmporioRoyal
{
    partial class FoLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoLogin));
            panTotal = new Panel();
            btnConfirm = new Button();
            lblTitle = new Label();
            txbPassword = new TextBox();
            lblPassword = new Label();
            txbUser = new TextBox();
            lblLogin = new Label();
            panTotal.SuspendLayout();
            SuspendLayout();
            // 
            // panTotal
            // 
            panTotal.Controls.Add(btnConfirm);
            panTotal.Controls.Add(lblTitle);
            panTotal.Controls.Add(txbPassword);
            panTotal.Controls.Add(lblPassword);
            panTotal.Controls.Add(txbUser);
            panTotal.Controls.Add(lblLogin);
            panTotal.Dock = DockStyle.Fill;
            panTotal.Location = new Point(0, 0);
            panTotal.Margin = new Padding(4);
            panTotal.Name = "panTotal";
            panTotal.Size = new Size(530, 513);
            panTotal.TabIndex = 0;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(179, 396);
            btnConfirm.Margin = new Padding(4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(146, 38);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Entrar";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(179, 53);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(114, 48);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Login";
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(162, 277);
            txbPassword.Margin = new Padding(4);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(276, 37);
            txbPassword.TabIndex = 3;
            txbPassword.KeyDown += txbPassword_KeyDown;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(53, 280);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(81, 30);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Senha:";
            // 
            // txbUser
            // 
            txbUser.Location = new Point(162, 188);
            txbUser.Margin = new Padding(4);
            txbUser.Name = "txbUser";
            txbUser.Size = new Size(276, 37);
            txbUser.TabIndex = 1;
            txbUser.KeyDown += txbUser_KeyDown;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(53, 191);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(98, 30);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Usuario:";
            // 
            // FoLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(530, 513);
            Controls.Add(panTotal);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FoLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Royal Emporio";
            panTotal.ResumeLayout(false);
            panTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panTotal;
        private Button btnConfirm;
        private Label lblTitle;
        private TextBox txbPassword;
        private Label lblPassword;
        private TextBox txbUser;
        private Label lblLogin;
    }
}
