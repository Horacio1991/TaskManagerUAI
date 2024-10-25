namespace PrincipalUI
{
    partial class VerTareas
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
            this.dgvTareasAsignadas = new System.Windows.Forms.DataGridView();
            this.cmbTareasAsignadas = new System.Windows.Forms.ComboBox();
            this.btnCompletarTarea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareasAsignadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTareasAsignadas
            // 
            this.dgvTareasAsignadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTareasAsignadas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTareasAsignadas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTareasAsignadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTareasAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTareasAsignadas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTareasAsignadas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.dgvTareasAsignadas.Location = new System.Drawing.Point(0, 1);
            this.dgvTareasAsignadas.Name = "dgvTareasAsignadas";
            this.dgvTareasAsignadas.Size = new System.Drawing.Size(599, 220);
            this.dgvTareasAsignadas.TabIndex = 7;
            // 
            // cmbTareasAsignadas
            // 
            this.cmbTareasAsignadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTareasAsignadas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTareasAsignadas.FormattingEnabled = true;
            this.cmbTareasAsignadas.Location = new System.Drawing.Point(12, 248);
            this.cmbTareasAsignadas.Name = "cmbTareasAsignadas";
            this.cmbTareasAsignadas.Size = new System.Drawing.Size(275, 25);
            this.cmbTareasAsignadas.TabIndex = 9;
            this.cmbTareasAsignadas.SelectedIndexChanged += new System.EventHandler(this.cmbTareasAsignadas_SelectedIndexChanged);
            // 
            // btnCompletarTarea
            // 
            this.btnCompletarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.btnCompletarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletarTarea.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCompletarTarea.Location = new System.Drawing.Point(12, 296);
            this.btnCompletarTarea.Name = "btnCompletarTarea";
            this.btnCompletarTarea.Size = new System.Drawing.Size(275, 40);
            this.btnCompletarTarea.TabIndex = 10;
            this.btnCompletarTarea.Text = "COMPLETAR";
            this.btnCompletarTarea.UseVisualStyleBackColor = false;
            this.btnCompletarTarea.Click += new System.EventHandler(this.btnCompletarTarea_Click_1);
            // 
            // VerTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 420);
            this.Controls.Add(this.btnCompletarTarea);
            this.Controls.Add(this.cmbTareasAsignadas);
            this.Controls.Add(this.dgvTareasAsignadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerTareas";
            this.Text = "VerTareas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareasAsignadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTareasAsignadas;
        private System.Windows.Forms.ComboBox cmbTareasAsignadas;
        private System.Windows.Forms.Button btnCompletarTarea;
    }
}