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
    public partial class FrmVerListadoProductos : Form
    {
        private csConectaSQL conexion = new csConectaSQL();
        private string IdentificadorSistema = "";
        public FrmVerListadoProductos()
        {
            InitializeComponent();
        }
        private void btnModificarSocio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdentificadorSistema))
            {
                MessageBox.Show("Seleccione un producto para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmAgregarProductos frmEditar = new FrmAgregarProductos();
            frmEditar.ShowDialog();
            CargarProductos();
        }

        private void CargarProductos()
        {
            try
            {
                if (!conexion.abrirConexion())
                {
                    MessageBox.Show("Error al conectar con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"
            select 
            id_producto,
            Productos,
            categoria,
            descripcion,
            precio_unitario,
            cantidad 
              from Productos";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion.oCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DVGProductos.DataSource = dt;
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregarSocio_Click(object sender, EventArgs e)
        {
            FrmAgregarProductos agregar = new FrmAgregarProductos();
            agregar.Show();
            this.Hide();
        }

        private void DVGProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DVGProductos.Rows[e.RowIndex];

                IdentificadorSistema = row.Cells["id_producto"].Value.ToString();
            }
        }
    }
}
