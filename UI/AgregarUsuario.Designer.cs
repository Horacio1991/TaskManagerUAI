namespace PrincipalUI
{
    partial class txtModificarEmail
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvUsuarios = new DataGridView();
            txtNombreAgregar = new TextBox();
            txtEmailAgregar = new TextBox();
            txtContraseñaAgregar = new TextBox();
            label1 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            label2 = new Label();
            txtContraseñaModificar = new TextBox();
            txtEmailModificar = new TextBox();
            txtNombreModificar = new TextBox();
            label3 = new Label();
            txtEmailEliminar = new TextBox();
            btnEliminar = new Button();
            btnConfirmarCambios = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsuarios.BackgroundColor = SystemColors.Control;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(102, 41, 56);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.GridColor = Color.FromArgb(102, 41, 56);
            dgvUsuarios.Location = new Point(0, -1);
            dgvUsuarios.Margin = new Padding(4, 3, 4, 3);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(699, 208);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged_1;
            // 
            // txtNombreAgregar
            // 
            txtNombreAgregar.BorderStyle = BorderStyle.None;
            txtNombreAgregar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreAgregar.Location = new Point(42, 270);
            txtNombreAgregar.Margin = new Padding(4, 3, 4, 3);
            txtNombreAgregar.Name = "txtNombreAgregar";
            txtNombreAgregar.Size = new Size(167, 16);
            txtNombreAgregar.TabIndex = 1;
            txtNombreAgregar.Text = "NOMBRE";
            txtNombreAgregar.Enter += txtNombreAgregar_Enter;
            txtNombreAgregar.Leave += txtNombreAgregar_Leave;
            // 
            // txtEmailAgregar
            // 
            txtEmailAgregar.BorderStyle = BorderStyle.None;
            txtEmailAgregar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailAgregar.Location = new Point(42, 300);
            txtEmailAgregar.Margin = new Padding(4, 3, 4, 3);
            txtEmailAgregar.Name = "txtEmailAgregar";
            txtEmailAgregar.Size = new Size(167, 16);
            txtEmailAgregar.TabIndex = 2;
            txtEmailAgregar.Text = "EMAIL";
            txtEmailAgregar.Enter += txtEmailAgregar_Enter_1;
            txtEmailAgregar.Leave += txtEmailAgregar_Leave;
            // 
            // txtContraseñaAgregar
            // 
            txtContraseñaAgregar.BorderStyle = BorderStyle.None;
            txtContraseñaAgregar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseñaAgregar.Location = new Point(42, 330);
            txtContraseñaAgregar.Margin = new Padding(4, 3, 4, 3);
            txtContraseñaAgregar.Name = "txtContraseñaAgregar";
            txtContraseñaAgregar.Size = new Size(167, 16);
            txtContraseñaAgregar.TabIndex = 3;
            txtContraseñaAgregar.Text = "CONTRASEÑA";
            txtContraseñaAgregar.Enter += txtContraseñaAgregar_Enter;
            txtContraseñaAgregar.Leave += txtContraseñaAgregar_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 240);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 4;
            label1.Text = "Agregar Usuario";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(102, 41, 56);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(24, 360);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(184, 42);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(102, 41, 56);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = SystemColors.Control;
            btnModificar.Location = new Point(255, 360);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(184, 42);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(252, 240);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 9;
            label2.Text = "Modificar Usuario";
            // 
            // txtContraseñaModificar
            // 
            txtContraseñaModificar.BorderStyle = BorderStyle.None;
            txtContraseñaModificar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseñaModificar.Location = new Point(273, 330);
            txtContraseñaModificar.Margin = new Padding(4, 3, 4, 3);
            txtContraseñaModificar.Name = "txtContraseñaModificar";
            txtContraseñaModificar.Size = new Size(167, 16);
            txtContraseñaModificar.TabIndex = 8;
            txtContraseñaModificar.Text = "CONTRASEÑA";
            txtContraseñaModificar.Enter += txtContraseñaModificar_Enter;
            txtContraseñaModificar.Leave += txtContraseñaModificar_Leave;
            // 
            // txtEmailModificar
            // 
            txtEmailModificar.BorderStyle = BorderStyle.None;
            txtEmailModificar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailModificar.Location = new Point(273, 300);
            txtEmailModificar.Margin = new Padding(4, 3, 4, 3);
            txtEmailModificar.Name = "txtEmailModificar";
            txtEmailModificar.Size = new Size(167, 16);
            txtEmailModificar.TabIndex = 7;
            txtEmailModificar.Text = "EMAIL";
            txtEmailModificar.Enter += txtEmailModificar_Enter;
            txtEmailModificar.Leave += txtEmailModificar_Leave;
            // 
            // txtNombreModificar
            // 
            txtNombreModificar.BorderStyle = BorderStyle.None;
            txtNombreModificar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreModificar.Location = new Point(273, 270);
            txtNombreModificar.Margin = new Padding(4, 3, 4, 3);
            txtNombreModificar.Name = "txtNombreModificar";
            txtNombreModificar.Size = new Size(167, 16);
            txtNombreModificar.TabIndex = 6;
            txtNombreModificar.Text = "NOMBRE";
            txtNombreModificar.Enter += txtNombreModificar_Enter;
            txtNombreModificar.Leave += txtNombreModificar_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(485, 240);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 11;
            label3.Text = "Eliminar Usuario";
            // 
            // txtEmailEliminar
            // 
            txtEmailEliminar.BorderStyle = BorderStyle.None;
            txtEmailEliminar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailEliminar.Location = new Point(489, 270);
            txtEmailEliminar.Margin = new Padding(4, 3, 4, 3);
            txtEmailEliminar.Name = "txtEmailEliminar";
            txtEmailEliminar.Size = new Size(167, 16);
            txtEmailEliminar.TabIndex = 12;
            txtEmailEliminar.Text = "EMAIL";
            txtEmailEliminar.Enter += txtEmailEliminar_Enter;
            txtEmailEliminar.Leave += txtEmailEliminar_Leave;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(102, 41, 56);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(489, 360);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(184, 42);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnConfirmarCambios
            // 
            btnConfirmarCambios.BackColor = Color.FromArgb(102, 41, 56);
            btnConfirmarCambios.FlatStyle = FlatStyle.Flat;
            btnConfirmarCambios.ForeColor = SystemColors.Control;
            btnConfirmarCambios.Location = new Point(24, 431);
            btnConfirmarCambios.Margin = new Padding(4, 3, 4, 3);
            btnConfirmarCambios.Name = "btnConfirmarCambios";
            btnConfirmarCambios.Size = new Size(185, 42);
            btnConfirmarCambios.TabIndex = 14;
            btnConfirmarCambios.Text = "CONFIRMAR CAMBIOS";
            btnConfirmarCambios.UseVisualStyleBackColor = false;
            btnConfirmarCambios.Click += btnConfirmarCambios_Click;
            // 
            // txtModificarEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 485);
            Controls.Add(btnConfirmarCambios);
            Controls.Add(btnEliminar);
            Controls.Add(txtEmailEliminar);
            Controls.Add(label3);
            Controls.Add(btnModificar);
            Controls.Add(label2);
            Controls.Add(txtContraseñaModificar);
            Controls.Add(txtEmailModificar);
            Controls.Add(txtNombreModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(txtContraseñaAgregar);
            Controls.Add(txtEmailAgregar);
            Controls.Add(txtNombreAgregar);
            Controls.Add(dgvUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "txtModificarEmail";
            Text = "AgregarUsuario";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox txtNombreAgregar;
        private System.Windows.Forms.TextBox txtEmailAgregar;
        private System.Windows.Forms.TextBox txtContraseñaAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseñaModificar;
        private System.Windows.Forms.TextBox txtEmailModificar;
        private System.Windows.Forms.TextBox txtNombreModificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private Button btnConfirmarCambios;
    }
}