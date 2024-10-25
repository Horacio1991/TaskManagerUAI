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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            cmbEmpleados = new ComboBox();
            txtTarea = new RichTextBox();
            dtpFechaLimite = new DateTimePicker();
            dgvTareas = new DataGridView();
            txtTituloTarea = new TextBox();
            btnAsignar = new Button();
            btnConfirmarTareas = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            SuspendLayout();
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.FlatStyle = FlatStyle.Flat;
            cmbEmpleados.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(15, 237);
            cmbEmpleados.Margin = new Padding(4, 3, 4, 3);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(320, 25);
            cmbEmpleados.TabIndex = 1;
            cmbEmpleados.Text = "USUARIOS";
            cmbEmpleados.SelectedIndexChanged += cmbEmpleados_SelectedIndexChanged_1;
            // 
            // txtTarea
            // 
            txtTarea.BorderStyle = BorderStyle.None;
            txtTarea.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTarea.Location = new Point(15, 302);
            txtTarea.Margin = new Padding(4, 3, 4, 3);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(321, 111);
            txtTarea.TabIndex = 3;
            txtTarea.Text = "Tarea a realizar";
            txtTarea.Enter += txtTarea_Enter;
            txtTarea.Leave += txtTarea_Leave;
            // 
            // dtpFechaLimite
            // 
            dtpFechaLimite.CalendarFont = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaLimite.Location = new Point(358, 237);
            dtpFechaLimite.Margin = new Padding(4, 3, 4, 3);
            dtpFechaLimite.Name = "dtpFechaLimite";
            dtpFechaLimite.Size = new Size(326, 23);
            dtpFechaLimite.TabIndex = 4;
            // 
            // dgvTareas
            // 
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTareas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTareas.BackgroundColor = SystemColors.Control;
            dgvTareas.BorderStyle = BorderStyle.None;
            dgvTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(102, 41, 56);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvTareas.DefaultCellStyle = dataGridViewCellStyle1;
            dgvTareas.GridColor = Color.FromArgb(102, 41, 56);
            dgvTareas.Location = new Point(0, 0);
            dgvTareas.Margin = new Padding(4, 3, 4, 3);
            dgvTareas.Name = "dgvTareas";
            dgvTareas.Size = new Size(699, 211);
            dgvTareas.TabIndex = 6;
            // 
            // txtTituloTarea
            // 
            txtTituloTarea.BorderStyle = BorderStyle.None;
            txtTituloTarea.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTituloTarea.Location = new Point(15, 272);
            txtTituloTarea.Margin = new Padding(4, 3, 4, 3);
            txtTituloTarea.Name = "txtTituloTarea";
            txtTituloTarea.Size = new Size(321, 19);
            txtTituloTarea.TabIndex = 2;
            txtTituloTarea.Text = "Título";
            txtTituloTarea.Enter += txtTituloTarea_Enter;
            txtTituloTarea.Leave += txtTituloTarea_Leave;
            // 
            // btnAsignar
            // 
            btnAsignar.BackColor = Color.FromArgb(102, 41, 56);
            btnAsignar.FlatStyle = FlatStyle.Flat;
            btnAsignar.ForeColor = SystemColors.Control;
            btnAsignar.Location = new Point(358, 329);
            btnAsignar.Margin = new Padding(4, 3, 4, 3);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(327, 46);
            btnAsignar.TabIndex = 5;
            btnAsignar.Text = "AGREGAR";
            btnAsignar.UseVisualStyleBackColor = false;
            btnAsignar.Click += btnAsignar_Click_1;
            // 
            // btnConfirmarTareas
            // 
            btnConfirmarTareas.BackColor = Color.FromArgb(102, 41, 56);
            btnConfirmarTareas.FlatStyle = FlatStyle.Flat;
            btnConfirmarTareas.ForeColor = SystemColors.Control;
            btnConfirmarTareas.Location = new Point(357, 381);
            btnConfirmarTareas.Margin = new Padding(4, 3, 4, 3);
            btnConfirmarTareas.Name = "btnConfirmarTareas";
            btnConfirmarTareas.Size = new Size(327, 46);
            btnConfirmarTareas.TabIndex = 7;
            btnConfirmarTareas.Text = "CONFIRMAR TAREAS";
            btnConfirmarTareas.UseVisualStyleBackColor = false;
            btnConfirmarTareas.Click += btnConfirmarTareas_Click;
            // 
            // AsignarTarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 485);
            Controls.Add(btnConfirmarTareas);
            Controls.Add(btnAsignar);
            Controls.Add(txtTituloTarea);
            Controls.Add(dgvTareas);
            Controls.Add(dtpFechaLimite);
            Controls.Add(txtTarea);
            Controls.Add(cmbEmpleados);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AsignarTarea";
            Text = "AsignarTarea";
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.RichTextBox txtTarea;
        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.TextBox txtTituloTarea;
        private System.Windows.Forms.Button btnAsignar;
        private Button btnConfirmarTareas;
    }
}