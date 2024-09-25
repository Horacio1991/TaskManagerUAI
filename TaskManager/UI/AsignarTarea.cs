using Entity;
using BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PrincipalUI
{
    public partial class AsignarTarea : Form
    {
        private TareaBLL _tareaBLL;
        private UsuarioBLL _usuarioBLL;
        private Usuario _usuarioLogueado;
        public AsignarTarea(Usuario usuarioLogueado)
        {
            InitializeComponent();
            _tareaBLL = new TareaBLL();
            _usuarioBLL = new UsuarioBLL();
            _usuarioLogueado = usuarioLogueado;
            CargarEmpleados();
            CargarTareasDelEmpleado();
            dgvTareas.Columns["TareaId"].Visible = false;
            dgvTareas.Columns["UsuarioId"].Visible = false;
            dgvTareas.Columns["EstadoTareaId"].Visible = false;
            dgvTareas.Columns["FechaFinalizacion"].Visible = false;

        }

        // Cargar los empleados no administradores del mismo sector que el administrador logueado
        private void CargarEmpleados()
        {
            try
            {
                // Obtén el SectorId del usuario logueado
                int sectorId = _usuarioLogueado.SectorId; 
                List<Usuario> empleados = _usuarioBLL.ObtenerUsuariosPorSector(sectorId); // Llama al método con el SectorId

                // Verifica si se encontraron empleados
                if (empleados != null && empleados.Count > 0)
                {
                    cmbEmpleados.DataSource = empleados;
                    cmbEmpleados.DisplayMember = "Nombre";
                    cmbEmpleados.ValueMember = "UsuarioId";
                }
                else
                {
                    MessageBox.Show("No se encontraron empleados en su sector.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Evento al seleccionar un empleado en el ComboBox
        private void cmbEmpleados_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CargarTareasDelEmpleado();
        }

        // Cargar las tareas del empleado seleccionado en el DataGridView
        private void CargarTareasDelEmpleado()
        {
            try
            {
                if (cmbEmpleados.SelectedValue != null && int.TryParse(cmbEmpleados.SelectedValue.ToString(), out int empleadoId))
                {
                    List<Tarea> tareas = _tareaBLL.ObtenerTareasPorEmpleado(empleadoId);

                    if (tareas != null)
                    {
                        dgvTareas.DataSource = tareas;
                        // Configura el DataGridView para mostrar solo las columnas necesarias
                        dgvTareas.Columns["TareaId"].Visible = false;
                        dgvTareas.Columns["UsuarioId"].Visible = false;
                        dgvTareas.Columns["EstadoTareaId"].Visible = false;
                        dgvTareas.Columns["FechaFinalizacion"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tareas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsignar_Click_1(object sender, EventArgs e)
        {
            AsignarTareaEmpleado();
            txtTituloTarea.Text = "Título";
            txtTarea.Text = "Tarea a realizar";
        }
      

        // Asignar una nueva tarea al empleado seleccionado
        private void AsignarTareaEmpleado()
        {
            try
            {
                int empleadoId = Convert.ToInt32(cmbEmpleados.SelectedValue); // ID del empleado seleccionado
                string tituloTarea = txtTituloTarea.Text; 
                string descripcionTarea = txtTarea.Text; 
                DateTime fechaLimite = dtpFechaLimite.Value; 

                // Validaciones de campos
                if (string.IsNullOrEmpty(tituloTarea))
                {
                    MessageBox.Show("El título de la tarea no puede estar vacío.");
                    return;
                }

                if (string.IsNullOrEmpty(descripcionTarea))
                {
                    MessageBox.Show("La descripción de la tarea no puede estar vacía.");
                    return;
                }

                // Llama al método AsignarTarea de la bll
                _tareaBLL.AsignarTarea(empleadoId, tituloTarea, descripcionTarea, fechaLimite);

                MessageBox.Show("Tarea asignada exitosamente.");

                // Actualiza el DataGridView llamando al método que carga las tareas del empleado
                CargarTareasEmpleado(empleadoId); // Llama al método que actualiza el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar tarea: " + ex.Message);
            }
        }

        private void CargarTareasEmpleado(int empleadoId)
        {
            try
            {
                // Método en TareaBLL que devuelve una lista de tareas del empleado
                List<Tarea> listaTareas = _tareaBLL.ObtenerTareasPorEmpleado(empleadoId);

                // Asigna la lista de tareas al DataGridView
                dgvTareas.DataSource = listaTareas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tareas: " + ex.Message);
            }
        }

        private void txtTituloTarea_Enter(object sender, EventArgs e)
        {
            if (txtTituloTarea.Text == "Título")
            {
                txtTituloTarea.Text = "";
                txtTituloTarea.ForeColor = Color.Black;
            }
        }

        private void txtTituloTarea_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTituloTarea.Text))
            {
                txtTituloTarea.Text = "Título";
                txtTituloTarea.ForeColor = Color.Gray;
            }
        }

        private void txtTarea_Enter(object sender, EventArgs e)
        {
            if (txtTarea.Text == "Tarea a realizar")
            {
                txtTarea.Text = "";
                txtTarea.ForeColor = Color.Black;
            }
        }

        private void txtTarea_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTarea.Text))
            {
                txtTarea.Text = "Tarea a realizar";
                txtTarea.ForeColor = Color.Gray;
            }
        }

        
    }
}
