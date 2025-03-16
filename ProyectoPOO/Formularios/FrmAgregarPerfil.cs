using AplicacionGym;
using ProyectoPOO.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOO.Formularios
{
    public partial class FrmAgregarPerfil : Form
    {
        private cUsuarios objUsuario;
        private bool esEdicion = false;
        public FrmAgregarPerfil()
        {
            InitializeComponent();
            objUsuario = new cUsuarios();
        }
        public FrmAgregarPerfil(string identificacion)
        {
            InitializeComponent();
            objUsuario = new cUsuarios();
            objUsuario.Identificacion = identificacion;
            esEdicion = true;
            CargarDatosUsuario();
            CambiarTextoEdicion();
        }
        private void CambiarTextoEdicion()
        {
            LabelNuevoUsuario.Text = "EDITAR USUARIO";  
            ButtonGuardarAgregarUsuario.Text = "EDITAR";  
        }
        private void CargarDatosUsuario()
        {
            try
            {
                if (!string.IsNullOrEmpty(objUsuario.Identificacion))
                {
                    csConectaSQL conexion = new csConectaSQL();

                    if (!conexion.abrirConexion())
                    {
                        MessageBox.Show("Error al conectar con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = @"
                SELECT 
                    p.identificacion, 
                    p.nombres, 
                    p.apellido, 
                    p.telefono, 
                    p.direccion, 
                    p.correo, 
                    u.usuario, 
                    u.contrasena,
                    tu.tipo AS tipo_usuario  -- 🔹 Agregamos el tipo de usuario
                FROM Usuarios U
                INNER JOIN Personas P ON P.id_persona = U.id_persona
                INNER JOIN Tipos_Usuario TU ON U.id_tipo_usuario = TU.id_tipo_usuario
                WHERE p.identificacion = @identificacion";

                    using (SqlCommand cmd = new SqlCommand(query, conexion.oCon))
                    {
                        cmd.Parameters.AddWithValue("@identificacion", objUsuario.Identificacion);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            TxtBoxIdentifiacion.Text = reader["identificacion"].ToString();
                            TxtBoxNombreUsuario.Text = reader["nombres"].ToString();
                            TxtBoxApellidoUsuario.Text = reader["apellido"].ToString();
                            TxtBoxTelefonoUsuario.Text = reader["telefono"].ToString();
                            TxtBoxMailUsuario.Text = reader["correo"].ToString();
                            TxtBoxDomicilioUsuario.Text = reader["direccion"].ToString();
                            TxtBoxUsuarioUsuario.Text = reader["usuario"].ToString();  
                            TxtBoxContraseñaUsuario.Text = reader["contrasena"].ToString();
                            ComboBoxPerfilUsuario.SelectedItem = reader["tipo_usuario"].ToString(); 
                        }
                        reader.Close();
                    }

                    conexion.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PtbCerrarFormularioAgregarUsuario_Click(object sender, EventArgs e)
        {
            FrmPantallaPrincipal regresar = new FrmPantallaPrincipal();
            regresar.Show();
            this.Hide();

        }

        private void ButtonGuardarAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (esEdicion)
            {
                EditarUsuario();
            }
            else
            {
                CrearUsuario();
            }
        }
        private void CrearUsuario()
        {
            cUsuarios nuevoUsuario = new cUsuarios
            {
                Identificacion = TxtBoxIdentifiacion.Text,
                Nombres = TxtBoxNombreUsuario.Text,
                Apellido = TxtBoxApellidoUsuario.Text,
                Direccion = TxtBoxDomicilioUsuario.Text,
                Correo = TxtBoxMailUsuario.Text,
                Telefono = TxtBoxTelefonoUsuario.Text,
                Estado = "Activo",
                NombreUsuario = TxtBoxUsuarioUsuario.Text,
                Contrasena = TxtBoxContraseñaUsuario.Text,
                TipoUsuario = ComboBoxPerfilUsuario.SelectedItem?.ToString() ?? "Usuario"
            };

            if (nuevoUsuario.CrearUsuario())
            {
                MessageBox.Show("Usuario agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarUsuario()
        {
            objUsuario.Nombres = TxtBoxNombreUsuario.Text;
            objUsuario.Apellido = TxtBoxApellidoUsuario.Text;
            objUsuario.Telefono = TxtBoxTelefonoUsuario.Text;
            objUsuario.Direccion = TxtBoxDomicilioUsuario.Text;
            objUsuario.Correo = TxtBoxMailUsuario.Text;
            objUsuario.NombreUsuario = TxtBoxUsuarioUsuario.Text;
            objUsuario.Contrasena = TxtBoxContraseñaUsuario.Text;

            if (objUsuario.EditarUsuario())
            {
                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void FrmAgregarPerfil_Load(object sender, EventArgs e)
        {

        }

        private void TxtBoxIdentifiacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
