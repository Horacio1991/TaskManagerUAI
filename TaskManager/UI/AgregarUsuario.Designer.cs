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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtNombreAgregar = new System.Windows.Forms.TextBox();
            this.txtEmailAgregar = new System.Windows.Forms.TextBox();
            this.txtContraseñaAgregar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseñaModificar = new System.Windows.Forms.TextBox();
            this.txtEmailModificar = new System.Windows.Forms.TextBox();
            this.txtNombreModificar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(0, -1);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(599, 180);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged_1);
            // 
            // txtNombreAgregar
            // 
            this.txtNombreAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAgregar.Location = new System.Drawing.Point(36, 234);
            this.txtNombreAgregar.Name = "txtNombreAgregar";
            this.txtNombreAgregar.Size = new System.Drawing.Size(143, 16);
            this.txtNombreAgregar.TabIndex = 1;
            this.txtNombreAgregar.Text = "NOMBRE";
            this.txtNombreAgregar.Enter += new System.EventHandler(this.txtNombreAgregar_Enter);
            this.txtNombreAgregar.Leave += new System.EventHandler(this.txtNombreAgregar_Leave);
            // 
            // txtEmailAgregar
            // 
            this.txtEmailAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAgregar.Location = new System.Drawing.Point(36, 260);
            this.txtEmailAgregar.Name = "txtEmailAgregar";
            this.txtEmailAgregar.Size = new System.Drawing.Size(143, 16);
            this.txtEmailAgregar.TabIndex = 2;
            this.txtEmailAgregar.Text = "EMAIL";
            this.txtEmailAgregar.Enter += new System.EventHandler(this.txtEmailAgregar_Enter_1);
            this.txtEmailAgregar.Leave += new System.EventHandler(this.txtEmailAgregar_Leave);
            // 
            // txtContraseñaAgregar
            // 
            this.txtContraseñaAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseñaAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaAgregar.Location = new System.Drawing.Point(36, 286);
            this.txtContraseñaAgregar.Name = "txtContraseñaAgregar";
            this.txtContraseñaAgregar.Size = new System.Drawing.Size(143, 16);
            this.txtContraseñaAgregar.TabIndex = 3;
            this.txtContraseñaAgregar.Text = "CONTRASEÑA";
            this.txtContraseñaAgregar.Enter += new System.EventHandler(this.txtContraseñaAgregar_Enter);
            this.txtContraseñaAgregar.Leave += new System.EventHandler(this.txtContraseñaAgregar_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agregar Usuario";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(21, 312);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(158, 36);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Location = new System.Drawing.Point(219, 312);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(158, 36);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Modificar Usuario";
            // 
            // txtContraseñaModificar
            // 
            this.txtContraseñaModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseñaModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaModificar.Location = new System.Drawing.Point(234, 286);
            this.txtContraseñaModificar.Name = "txtContraseñaModificar";
            this.txtContraseñaModificar.Size = new System.Drawing.Size(143, 16);
            this.txtContraseñaModificar.TabIndex = 8;
            this.txtContraseñaModificar.Text = "CONTRASEÑA";
            this.txtContraseñaModificar.Enter += new System.EventHandler(this.txtContraseñaModificar_Enter);
            this.txtContraseñaModificar.Leave += new System.EventHandler(this.txtContraseñaModificar_Leave);
            // 
            // txtEmailModificar
            // 
            this.txtEmailModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailModificar.Location = new System.Drawing.Point(234, 260);
            this.txtEmailModificar.Name = "txtEmailModificar";
            this.txtEmailModificar.Size = new System.Drawing.Size(143, 16);
            this.txtEmailModificar.TabIndex = 7;
            this.txtEmailModificar.Text = "EMAIL";
            this.txtEmailModificar.Enter += new System.EventHandler(this.txtEmailModificar_Enter);
            this.txtEmailModificar.Leave += new System.EventHandler(this.txtEmailModificar_Leave);
            // 
            // txtNombreModificar
            // 
            this.txtNombreModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreModificar.Location = new System.Drawing.Point(234, 234);
            this.txtNombreModificar.Name = "txtNombreModificar";
            this.txtNombreModificar.Size = new System.Drawing.Size(143, 16);
            this.txtNombreModificar.TabIndex = 6;
            this.txtNombreModificar.Text = "NOMBRE";
            this.txtNombreModificar.Enter += new System.EventHandler(this.txtNombreModificar_Enter);
            this.txtNombreModificar.Leave += new System.EventHandler(this.txtNombreModificar_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Eliminar Usuario";
            // 
            // txtEmailEliminar
            // 
            this.txtEmailEliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailEliminar.Location = new System.Drawing.Point(419, 234);
            this.txtEmailEliminar.Name = "txtEmailEliminar";
            this.txtEmailEliminar.Size = new System.Drawing.Size(143, 16);
            this.txtEmailEliminar.TabIndex = 12;
            this.txtEmailEliminar.Text = "EMAIL";
            this.txtEmailEliminar.Enter += new System.EventHandler(this.txtEmailEliminar_Enter);
            this.txtEmailEliminar.Leave += new System.EventHandler(this.txtEmailEliminar_Leave);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(419, 312);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 36);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // txtModificarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 420);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtEmailEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContraseñaModificar);
            this.Controls.Add(this.txtEmailModificar);
            this.Controls.Add(this.txtNombreModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseñaAgregar);
            this.Controls.Add(this.txtEmailAgregar);
            this.Controls.Add(this.txtNombreAgregar);
            this.Controls.Add(this.dgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "txtModificarEmail";
            this.Text = "AgregarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}