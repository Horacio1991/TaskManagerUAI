namespace PrincipalUI
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            panel1 = new Panel();
            btnMinimise = new PictureBox();
            btnClose = new PictureBox();
            panel2 = new Panel();
            btnLogout = new Label();
            lblNombreUsuario = new Label();
            btnVerTareas = new Button();
            btnAsignarTarea = new Button();
            btnAgregarUsuario = new Button();
            panelFormularios = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimise).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(102, 41, 56);
            panel1.Controls.Add(btnMinimise);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 35);
            panel1.TabIndex = 0;
            // 
            // btnMinimise
            // 
            btnMinimise.BackColor = Color.White;
            btnMinimise.Cursor = Cursors.Hand;
            btnMinimise.Image = (Image)resources.GetObject("btnMinimise.Image");
            btnMinimise.Location = new Point(887, 8);
            btnMinimise.Margin = new Padding(4, 3, 4, 3);
            btnMinimise.Name = "btnMinimise";
            btnMinimise.Size = new Size(16, 16);
            btnMinimise.SizeMode = PictureBoxSizeMode.AutoSize;
            btnMinimise.TabIndex = 2;
            btnMinimise.TabStop = false;
            btnMinimise.Click += btnMinimise_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(912, 8);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(16, 16);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 2;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(66, 26, 36);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(lblNombreUsuario);
            panel2.Controls.Add(btnVerTareas);
            panel2.Controls.Add(btnAsignarTarea);
            panel2.Controls.Add(btnAgregarUsuario);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 35);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 484);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.AutoSize = true;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(103, 455);
            btnLogout.Margin = new Padding(4, 0, 4, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(107, 17);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "       Cerrar Sesión";
            btnLogout.Click += btnLogout_Click;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreUsuario.ForeColor = SystemColors.Control;
            lblNombreUsuario.Location = new Point(15, 8);
            lblNombreUsuario.Margin = new Padding(4, 0, 4, 0);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(53, 20);
            lblNombreUsuario.TabIndex = 3;
            lblNombreUsuario.Text = "label1";
            // 
            // btnVerTareas
            // 
            btnVerTareas.BackColor = Color.FromArgb(230, 230, 230);
            btnVerTareas.Cursor = Cursors.Hand;
            btnVerTareas.FlatAppearance.BorderSize = 0;
            btnVerTareas.FlatAppearance.MouseDownBackColor = Color.FromArgb(170, 170, 170);
            btnVerTareas.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnVerTareas.FlatStyle = FlatStyle.Flat;
            btnVerTareas.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerTareas.Image = (Image)resources.GetObject("btnVerTareas.Image");
            btnVerTareas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerTareas.Location = new Point(4, 239);
            btnVerTareas.Margin = new Padding(4, 3, 4, 3);
            btnVerTareas.Name = "btnVerTareas";
            btnVerTareas.Size = new Size(229, 45);
            btnVerTareas.TabIndex = 2;
            btnVerTareas.Text = "Ver Tareas";
            btnVerTareas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVerTareas.UseVisualStyleBackColor = false;
            btnVerTareas.Click += btnVerTareas_Click;
            // 
            // btnAsignarTarea
            // 
            btnAsignarTarea.BackColor = Color.FromArgb(230, 230, 230);
            btnAsignarTarea.Cursor = Cursors.Hand;
            btnAsignarTarea.FlatAppearance.BorderSize = 0;
            btnAsignarTarea.FlatAppearance.MouseDownBackColor = Color.FromArgb(170, 170, 170);
            btnAsignarTarea.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnAsignarTarea.FlatStyle = FlatStyle.Flat;
            btnAsignarTarea.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsignarTarea.Image = (Image)resources.GetObject("btnAsignarTarea.Image");
            btnAsignarTarea.ImageAlign = ContentAlignment.MiddleLeft;
            btnAsignarTarea.Location = new Point(4, 152);
            btnAsignarTarea.Margin = new Padding(4, 3, 4, 3);
            btnAsignarTarea.Name = "btnAsignarTarea";
            btnAsignarTarea.Size = new Size(229, 45);
            btnAsignarTarea.TabIndex = 1;
            btnAsignarTarea.Text = "Asignar Tareas";
            btnAsignarTarea.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAsignarTarea.UseVisualStyleBackColor = false;
            btnAsignarTarea.Click += btnAsignarTarea_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = Color.FromArgb(230, 230, 230);
            btnAgregarUsuario.Cursor = Cursors.Hand;
            btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            btnAgregarUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(170, 170, 170);
            btnAgregarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnAgregarUsuario.FlatStyle = FlatStyle.Flat;
            btnAgregarUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarUsuario.Image = (Image)resources.GetObject("btnAgregarUsuario.Image");
            btnAgregarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarUsuario.Location = new Point(4, 73);
            btnAgregarUsuario.Margin = new Padding(4, 3, 4, 3);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(229, 45);
            btnAgregarUsuario.TabIndex = 0;
            btnAgregarUsuario.Text = "Agregar Usuarios";
            btnAgregarUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // panelFormularios
            // 
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(234, 35);
            panelFormularios.Margin = new Padding(4, 3, 4, 3);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(699, 484);
            panelFormularios.TabIndex = 2;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(panelFormularios);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimise).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAsignarTarea;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnVerTareas;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimise;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label btnLogout;
    }
}

