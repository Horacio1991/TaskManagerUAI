namespace Login
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            btnLoggin = new Button();
            btnClose = new PictureBox();
            btnMinimise = new PictureBox();
            lblUserPasswordInvalid = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimise).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(102, 41, 56);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 381);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 118);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(292, 163);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.WhiteSmoke;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(357, 99);
            txtUser.Margin = new Padding(4, 3, 4, 3);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(476, 26);
            txtUser.TabIndex = 2;
            txtUser.Text = "USUARIO";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(357, 164);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(476, 26);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "CONTRASEÑA";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(538, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 33);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // btnLoggin
            // 
            btnLoggin.BackColor = Color.FromArgb(142, 81, 96);
            btnLoggin.FlatAppearance.BorderSize = 0;
            btnLoggin.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 20, 28);
            btnLoggin.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 41, 56);
            btnLoggin.FlatStyle = FlatStyle.Flat;
            btnLoggin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoggin.ForeColor = SystemColors.Control;
            btnLoggin.Location = new Point(357, 273);
            btnLoggin.Margin = new Padding(4, 3, 4, 3);
            btnLoggin.Name = "btnLoggin";
            btnLoggin.Size = new Size(476, 46);
            btnLoggin.TabIndex = 1;
            btnLoggin.Text = "ACCEDER";
            btnLoggin.UseVisualStyleBackColor = false;
            btnLoggin.Click += btnLoggin_Click;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(888, 12);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(18, 17);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 7;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimise
            // 
            btnMinimise.Image = (Image)resources.GetObject("btnMinimise.Image");
            btnMinimise.Location = new Point(862, 12);
            btnMinimise.Margin = new Padding(4, 3, 4, 3);
            btnMinimise.Name = "btnMinimise";
            btnMinimise.Size = new Size(18, 17);
            btnMinimise.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimise.TabIndex = 8;
            btnMinimise.TabStop = false;
            btnMinimise.Click += btnMinimise_Click;
            // 
            // lblUserPasswordInvalid
            // 
            lblUserPasswordInvalid.AutoSize = true;
            lblUserPasswordInvalid.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserPasswordInvalid.ForeColor = Color.FromArgb(142, 81, 96);
            lblUserPasswordInvalid.Location = new Point(352, 336);
            lblUserPasswordInvalid.Margin = new Padding(4, 0, 4, 0);
            lblUserPasswordInvalid.Name = "lblUserPasswordInvalid";
            lblUserPasswordInvalid.Size = new Size(231, 20);
            lblUserPasswordInvalid.TabIndex = 9;
            lblUserPasswordInvalid.Text = "Usuario o Contraseña Inválido";
            lblUserPasswordInvalid.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 381);
            Controls.Add(lblUserPasswordInvalid);
            Controls.Add(btnMinimise);
            Controls.Add(btnClose);
            Controls.Add(btnLoggin);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimise).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoggin;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimise;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblUserPasswordInvalid;
    }
}

