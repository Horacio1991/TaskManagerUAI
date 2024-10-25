using Entity;
using BLL;


namespace PrincipalUI
{

    public partial class txtModificarEmail : Form
    {

        private UsuarioBLL _usuarioBll;
        private int _sectorId; // ID del sector actual

        public txtModificarEmail(int sectorId)
        {
            InitializeComponent();
            _usuarioBll = new UsuarioBLL();
            _sectorId = sectorId;

            // Cargar usuarios al iniciar
            CargarUsuarios();
            dgvUsuarios.ReadOnly = true; // Hacer que la DataGridView sea de solo lectura
            dgvUsuarios.Columns["EsAdministrador"].ReadOnly = true; // Hacer que el checkbox no se pueda editar
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
        }

        private void CargarUsuarios()
        {
            var usuarios = _usuarioBll.ObtenerUsuariosPorSector(_sectorId);
            dgvUsuarios.DataSource = usuarios;

            // Configuración de columnas
            dgvUsuarios.Columns["UsuarioId"].Visible = false; // Ocultar ID
            dgvUsuarios.Columns["Password"].Visible = false; // Ocultar contraseña

            // Asegúrate de que las columnas Email y Nombre estén visibles
            dgvUsuarios.Columns["Nombre"].HeaderText = "Nombre";
            dgvUsuarios.Columns["Email"].HeaderText = "Email";
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
                Nombre = txtNombreAgregar.Text,
                Email = txtEmailAgregar.Text,
                Password = txtContraseñaAgregar.Text,
                EsAdministrador = false,
                SectorId = _sectorId
            };

            try
            {
                _usuarioBll.GuardarUsuarioEnMemoria(usuario);
                MessageBox.Show("Usuario guardado en memoria. Recuerda confirmar los cambios.");
                CargarUsuarios();
                txtNombreAgregar.Text = "NOMBRE";
                txtEmailAgregar.Text = "EMAIL";
                txtContraseñaAgregar.Text = "CONTRASEÑA";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            var nombrePlaceholder = "NOMBRE";
            var contraseñaPlaceholder = "CONTRASEÑA";

            // El correo siempre debe estar escrito
            string email = txtEmailModificar.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("El correo es obligatorio para modificar.");
                return;
            }

            // Si el campo de nombre es diferente al placeholder, lo consideramos válido
            string nombre = txtNombreModificar.Text != nombrePlaceholder ? txtNombreModificar.Text : null;

            // Si el campo de contraseña es diferente al placeholder, lo consideramos válido
            string contraseña = txtContraseñaModificar.Text != contraseñaPlaceholder ? txtContraseñaModificar.Text : null;

            // Crear el objeto usuario con los valores válidos
            var usuario = new Usuario
            {
                Email = email,
                Nombre = nombre,  // Solo se actualiza si es diferente del placeholder
                Password = contraseña // Solo se actualiza si es diferente del placeholder
            };

            try
            {
                _usuarioBll.ModificarUsuarioPorEmail(usuario);
                MessageBox.Show("Usuario modificado exitosamente.");
                CargarUsuarios(); // Recargar la lista de usuarios
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmailEliminar.Text))
            {
                try
                {
                    _usuarioBll.EliminarUsuarioConTareas(txtEmailEliminar.Text);
                    MessageBox.Show("Usuario y sus tareas eliminados exitosamente.");
                    CargarUsuarios(); // Recargar la lista de usuarios
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el email del usuario a eliminar.");
            }
        }

        private void dgvUsuarios_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                var selectedUser = (Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem;
                txtNombreModificar.Text = selectedUser.Nombre; // Para el campo de modificar usuario
                txtEmailModificar.Text = selectedUser.Email; // Para el campo de modificar usuario
                txtEmailEliminar.Text = selectedUser.Email; // Para el campo de eliminar usuario
            }
        }



        private void txtNombreAgregar_Enter(object sender, EventArgs e)
        {
            if (txtNombreAgregar.Text == "NOMBRE") txtNombreAgregar.Text = "";
        }

        private void txtEmailAgregar_Enter_1(object sender, EventArgs e)
        {
            if (txtEmailAgregar.Text == "EMAIL") txtEmailAgregar.Text = "";
        }

        private void txtContraseñaAgregar_Enter(object sender, EventArgs e)
        {
            if (txtContraseñaAgregar.Text == "CONTRASEÑA") txtContraseñaAgregar.Text = "";
        }

        private void txtNombreModificar_Enter(object sender, EventArgs e)
        {
            if (txtNombreModificar.Text == "NOMBRE") txtNombreModificar.Text = "";
        }

        private void txtEmailModificar_Enter(object sender, EventArgs e)
        {
            if (txtEmailModificar.Text == "EMAIL") txtEmailModificar.Text = "";
        }

        private void txtContraseñaModificar_Enter(object sender, EventArgs e)
        {
            if (txtContraseñaModificar.Text == "CONTRASEÑA") txtContraseñaModificar.Text = "";
        }

        private void txtEmailEliminar_Enter(object sender, EventArgs e)
        {
            if (txtEmailEliminar.Text == "EMAIL") txtEmailEliminar.Text = "";
        }

        private void txtNombreAgregar_Leave(object sender, EventArgs e)
        {
            if (txtNombreAgregar.Text == "") txtNombreAgregar.Text = "NOMBRE";
        }

        private void txtEmailAgregar_Leave(object sender, EventArgs e)
        {
            if (txtEmailAgregar.Text == "") txtEmailAgregar.Text = "EMAIL";
        }

        private void txtContraseñaAgregar_Leave(object sender, EventArgs e)
        {
            if (txtContraseñaAgregar.Text == "") txtContraseñaAgregar.Text = "CONTRASEÑA";
        }

        private void txtNombreModificar_Leave(object sender, EventArgs e)
        {
            if (txtNombreModificar.Text == "") txtNombreModificar.Text = "NOMBRE";
        }

        private void txtEmailModificar_Leave(object sender, EventArgs e)
        {
            if (txtEmailModificar.Text == "") txtEmailModificar.Text = "EMAIL";
        }

        private void txtContraseñaModificar_Leave(object sender, EventArgs e)
        {
            if (txtContraseñaModificar.Text == "") txtContraseñaModificar.Text = "CONTRASEÑA";
        }

        private void txtEmailEliminar_Leave(object sender, EventArgs e)
        {
            if (txtEmailEliminar.Text == "") txtEmailEliminar.Text = "EMAIL";
        }

        private void btnConfirmarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                _usuarioBll.ConfirmarUsuarios();
                MessageBox.Show("Usuarios confirmados en la base de datos.");
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al confirmar los cambios: " + ex.Message);
            }
        }
    }
}