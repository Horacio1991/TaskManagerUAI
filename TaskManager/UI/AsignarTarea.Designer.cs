namespace PrincipalUI
{
    partial class AsignarTarea
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.txtTarea = new System.Windows.Forms.RichTextBox();
            this.dtpFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.txtTituloTarea = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEmpleados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(13, 205);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(275, 25);
            this.cmbEmpleados.TabIndex = 1;
            this.cmbEmpleados.Text = "USUARIOS";
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged_1);
            // 
            // txtTarea
            // 
            this.txtTarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTarea.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarea.Location = new System.Drawing.Point(13, 262);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(275, 96);
            this.txtTarea.TabIndex = 3;
            this.txtTarea.Text = "Tarea a realizar";
            this.txtTarea.Enter += new System.EventHandler(this.txtTarea_Enter);
            this.txtTarea.Leave += new System.EventHandler(this.txtTarea_Leave);
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaLimite.Location = new System.Drawing.Point(307, 205);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(280, 20);
            this.dtpFechaLimite.TabIndex = 4;
            // 
            // dgvTareas
            // 
            this.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTareas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTareas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTareas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTareas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTareas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.dgvTareas.Location = new System.Drawing.Point(0, 0);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.Size = new System.Drawing.Size(599, 183);
            this.dgvTareas.TabIndex = 6;
            // 
            // txtTituloTarea
            // 
            this.txtTituloTarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTituloTarea.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloTarea.Location = new System.Drawing.Point(13, 236);
            this.txtTituloTarea.Name = "txtTituloTarea";
            this.txtTituloTarea.Size = new System.Drawing.Size(275, 19);
            this.txtTituloTarea.TabIndex = 2;
            this.txtTituloTarea.Text = "Título";
            this.txtTituloTarea.Enter += new System.EventHandler(this.txtTituloTarea_Enter);
            this.txtTituloTarea.Leave += new System.EventHandler(this.txtTituloTarea_Leave);
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAsignar.Location = new System.Drawing.Point(307, 285);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(280, 40);
            this.btnAsignar.TabIndex = 5;
            this.btnAsignar.Text = "AGREGAR";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click_1);
            // 
            // AsignarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 420);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.txtTituloTarea);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.dtpFechaLimite);
            this.Controls.Add(this.txtTarea);
            this.Controls.Add(this.cmbEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AsignarTarea";
            this.Text = "AsignarTarea";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.RichTextBox txtTarea;
        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.TextBox txtTituloTarea;
        private System.Windows.Forms.Button btnAsignar;
    }
}