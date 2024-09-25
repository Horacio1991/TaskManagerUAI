using Entity;
using BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrincipalUI
{
    public partial class VerTareas : Form
    {
        private TareaBLL _tareaBLL;
        private Usuario _usuarioLogueado;
        public VerTareas(Usuario usuarioLogueado)
        {
            InitializeComponent();
            _tareaBLL = new TareaBLL();
            _usuarioLogueado = usuarioLogueado;

            CargarTareas();
            
        }

        // Cargar las tareas según el tipo de usuario
        private void CargarTareas()
        {
            List<Tarea> tareas;

            if (_usuarioLogueado.EsAdministrador)
            {
                tareas = _tareaBLL.ObtenerTareasPorSector(_usuarioLogueado.SectorId);
            }
            else
            {
                tareas = _tareaBLL.ObtenerTareasPorEmpleado(_usuarioLogueado.UsuarioId);
            }

            // Columnas visibles en el DataGridView
            dgvTareasAsignadas.DataSource = tareas;

            dgvTareasAsignadas.Columns["TareaId"].Visible = false;
            dgvTareasAsignadas.Columns["EstadoTareaId"].Visible = false;
            dgvTareasAsignadas.Columns["UsuarioId"].Visible = false;

            // Asegurarse de que se manejen los valores nulos correctamente
            dgvTareasAsignadas.Columns["FechaFinalizacion"].DefaultCellStyle.NullValue = "Sin finalizar";

            // Mostrar solo las columnas necesarias
            dgvTareasAsignadas.Columns["Titulo"].Visible = true;
            dgvTareasAsignadas.Columns["Descripcion"].Visible = true;
            dgvTareasAsignadas.Columns["FechaSolicitada"].Visible = true;
            dgvTareasAsignadas.Columns["FechaEsperadaFinalizacion"].Visible = true;
            dgvTareasAsignadas.Columns["FechaFinalizacion"].Visible = true;

            // Configurar ComboBox
            if (tareas != null && tareas.Count > 0)
            {
                cmbTareasAsignadas.DataSource = tareas;
                cmbTareasAsignadas.DisplayMember = "Titulo";
                cmbTareasAsignadas.ValueMember = "TareaId";
                cmbTareasAsignadas.SelectedIndex = -1; // No seleccionar nada al principio
            }
            else
            {
                cmbTareasAsignadas.DataSource = null;
            }

            // Reactivar el evento SelectedIndexChanged
            cmbTareasAsignadas.SelectedIndexChanged += cmbTareasAsignadas_SelectedIndexChanged;

        }




        // Completar la tarea seleccionada
        private void btnCompletarTarea_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvTareasAsignadas.SelectedRows.Count > 0)
                {
                    int tareaId = (int)dgvTareasAsignadas.SelectedRows[0].Cells["TareaId"].Value;
                    _tareaBLL.CompletarTarea(tareaId);
                    MessageBox.Show("Tarea completada.");
                    CargarTareas();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una tarea.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTareasAsignadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTareasAsignadas.SelectedValue != null && cmbTareasAsignadas.SelectedValue != DBNull.Value)
            {
                if (int.TryParse(cmbTareasAsignadas.SelectedValue.ToString(), out int tareaIdSeleccionada))
                {
                    // Buscar la fila correspondiente en el DataGridView y seleccionarla
                    foreach (DataGridViewRow row in dgvTareasAsignadas.Rows)
                    {
                        if ((int)row.Cells["TareaId"].Value == tareaIdSeleccionada)
                        {
                            row.Selected = true;  // Seleccionar la fila en el DataGridView
                            dgvTareasAsignadas.FirstDisplayedScrollingRowIndex = row.Index;  // Asegurarse de que la fila esté visible
                            break;
                        }
                    }
                }
               
            }
        }
    }
}
