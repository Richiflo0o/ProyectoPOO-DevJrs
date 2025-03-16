using AplicacionGym;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;


namespace ProyectoPOO.Formularios
{
    public partial class FrmLogin : Form

    {
        private csConectaSQL conexion = new csConectaSQL();
        private string tipoUsuario = "";

        public FrmLogin()
        {
            InitializeComponent();
            lblMensajeError.Visible = false; 


        }

        private void PtbCerrarInicioSesion_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioLogin.Text.Trim();
            string contrasena = txtContraseñaLogin.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                lblMensajeError.Text = "Ingrese usuario y contraseña.";
                lblMensajeError.Visible = true;
                return;
            }

            
            string contrasenaHash = HashPassword(contrasena);

            
            if (ValidarUsuario(usuario, contrasenaHash, out tipoUsuario))
            {
                MessageBox.Show($"Bienvenido, {usuario}. Rol: {tipoUsuario}", "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                FrmPantallaPrincipal pantallaPrincipal = new FrmPantallaPrincipal(tipoUsuario);
                pantallaPrincipal.Show();
                this.Hide(); 
            }
            else
            {
                lblMensajeError.Text = "Usuario o contraseña incorrectos.";
                lblMensajeError.Visible = true;
            }

        }
        private bool ValidarUsuario(string usuario, string contrasena, out string tipoUsuario)
        {
            tipoUsuario = "";

            try
            {
                if (!conexion.abrirConexion())
                {
                    MessageBox.Show("Error al conectar con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string query = @"
                    SELECT tu.tipo 
                    FROM Usuarios u
                    INNER JOIN Tipos_Usuario tu ON u.id_tipo_usuario = tu.id_tipo_usuario
                    WHERE u.usuario = @usuario AND u.contrasena = @contrasena";

                using (SqlCommand cmd = new SqlCommand(query, conexion.oCon))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null)
                    {
                        tipoUsuario = resultado.ToString();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrarConexion();
            }

            return false;
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
