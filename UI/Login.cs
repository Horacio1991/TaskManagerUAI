using Entity;
using BLL;
using PrincipalUI;


namespace Login
{
    public partial class Login : Form
    {
        private UsuarioBLL _usuarioBll;
        public Login()
        {
            InitializeComponent();
            _usuarioBll = new UsuarioBLL();
        }
        // Configuraciones Esteticas del formulario
        #region
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = false;
                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion //Configuraciones esteticas del formulario

        private void btnLoggin_Click(object sender, EventArgs e)
        {
            
            string email = txtUser.Text;
            string password = txtPassword.Text;

            try
            { 
                Usuario usuario = _usuarioBll.ValidarUsuario(email, password);

                // Si el usuario NO es nulo es decir las credenciales son correctas
                if (usuario != null)
                {
                    // Verificamos si es administrador o no 
                    if (usuario.EsAdministrador)
                    {
                        // Se muestra el formulario principal (admin)
                        Principal principalForm = new Principal(usuario);
                        principalForm.Show();
                        this.Hide(); // Se esconde la ventana de login
                    }
                    else
                    {
                        // Mostramos el formulario principal (usuario simple)
                        Principal principalForm = new Principal(usuario);
                        principalForm.Show();
                        this.Hide(); // Ocultamos la ventana de login
                    }
                }
                else
                {
                    // Si las credenciales no son correctas, mostramos un mensaje de error
                    lblUserPasswordInvalid.Visible = true;
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
