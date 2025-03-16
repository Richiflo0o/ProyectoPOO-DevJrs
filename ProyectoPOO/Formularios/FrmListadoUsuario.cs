using AplicacionGym;
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
    public partial class FrmListadoUsuario : Form
    {
        private csConectaSQL conexion = new csConectaSQL();
        private string identificacionSeleccionada = "";


        public FrmListadoUsuario()
        {
            InitializeComponent();
        }

        private void DGVListadoUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAgregarSocio_Click(object sender, EventArgs e)
        {
            FrmAgregarPerfil agregar = new FrmAgregarPerfil();
            agregar.Show();
            this.Hide();
        }

        private void FrmListadoUsuario_Load(object sender, EventArgs e)

        {
            this.WindowState = FormWindowState.Maximized; 

            CargarUsuarios();

        }
        private void CargarUsuarios()
        {
            try
            {
                if (!conexion.abrirConexion())
                {
                    MessageBox.Show("Error al conectar con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"
            SELECT 
                p.identificacion AS 'Identificación', 
                p.nombres AS 'Nombres', 
                p.apellido AS 'Apellido', 
                p.direccion AS 'Dirección',
                p.telefono AS 'Teléfono', 
                p.correo AS 'Correo', 
                u.usuario AS 'Usuario', 
                u.contrasena AS 'Contraseña',
                tu.tipo AS 'Perfil de Usuario'  
            FROM Usuarios U
            INNER JOIN Personas P ON P.id_persona = U.id_persona
            INNER JOIN Tipos_Usuario TU ON U.id_tipo_usuario = TU.id_tipo_usuario;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion.oCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DGVListadoUsuarios.DataSource = dt;
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarListadoPerfil_Click(object sender, EventArgs e)
        {
            FrmPantallaPrincipal regresar = new FrmPantallaPrincipal("Usuario");
            regresar.Show();
            this.Hide();
        }

        private void btnModificarSocio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(identificacionSeleccionada))
            {
                MessageBox.Show("Seleccione un usuario para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmAgregarPerfil    frmEditar = new FrmAgregarPerfil(identificacionSeleccionada);
            frmEditar.ShowDialog();
            CargarUsuarios();
        }

        private void DGVListadoUsuarios_Click(object sender, EventArgs e)
        {
            
        }

        private void DGVListadoUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)

        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVListadoUsuarios.Rows[e.RowIndex];

                identificacionSeleccionada = row.Cells["Identificación"].Value.ToString();
            }

        }
    }
}
