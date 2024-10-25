using Entity;


namespace PrincipalUI
{
    public partial class Principal : Form
    {
        private Usuario _usuarioLogueado;
        public Principal()
        {
            InitializeComponent();
        }
        public Principal(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogueado = usuario;

            // Mostrar que usario esta conectado (Nombre) arriba a la izquierda
            lblNombreUsuario.Text = _usuarioLogueado.Nombre;

            // Verificar si el usuario es administrador
            ConfigurarInterfazSegunRol();


        }

        // Método para configurar la interfaz según el rol del usuario
        private void ConfigurarInterfazSegunRol()
        {
            if (_usuarioLogueado.EsAdministrador)
            {
                // Si el usuario es administrador, habilitamos todos los botones
                btnAgregarUsuario.Enabled = true;
                btnAsignarTarea.Enabled = true;
                btnVerTareas.Enabled = true;
            }
            else
            {
                // Si el usuario no es administrador, solo habilitamos el botón "Ver Tareas"
                btnAgregarUsuario.Enabled = false;
                btnAsignarTarea.Enabled = false;
                btnVerTareas.Enabled = true;
            }
        }


        // Metodo para abrir formularios en el panel central
        #region
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault(); // Busca en la coleccion el formulario
            // Si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            // Si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        #endregion

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            
            panelFormularios.Controls.Clear(); // Limpiar el panel

            // Obtener el sectorId del usuario logueado
            int sectorId = _usuarioLogueado.SectorId;

            // Crear una nueva instancia de AgregarUsuario
            txtModificarEmail formAgregarUsuario = new txtModificarEmail(sectorId)
            {
                Dock = DockStyle.Fill, // Hacer que el formulario ocupe todo el panel
                TopLevel = false,       // Permitir que el formulario se muestre dentro de otro control
                FormBorderStyle = FormBorderStyle.None // Quitar bordes del formulario
            };

            // Agregar el formulario al panel
            panelFormularios.Controls.Add(formAgregarUsuario);
            formAgregarUsuario.Show(); // Mostrar el formulario
        }



        private void btnAsignarTarea_Click(object sender, EventArgs e)
        {
            // Limpiar el panel
            panelFormularios.Controls.Clear();

            // Crear una nueva instancia de AsignarTarea y pasar el usuario logueado
            AsignarTarea formAsignarTarea = new AsignarTarea(_usuarioLogueado)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None
            };

            // Agregar el formulario al panel
            panelFormularios.Controls.Add(formAsignarTarea);
            formAsignarTarea.Show();
        }

        private void btnVerTareas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<VerTareas>(_usuarioLogueado);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            
            Application.Exit();       

        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormulario<MiForm>(Usuario usuarioLogueado) where MiForm : Form
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();

            // Si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = (Form)Activator.CreateInstance(typeof(MiForm), usuarioLogueado); // Pasar el usuario logueado
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario principal (Principal.cs)
            this.Hide();

            // Crear una nueva instancia del formulario de login
            Login.Login formLogin = new Login.Login();

            // Mostrar el formulario de login
            formLogin.Show();

            // Cerrar completamente el formulario principal 
            this.Close();
        }
    }
}
