using AplicacionGym;
using AplicacionGym.Clases.Formularios;
using ProyectoPOO.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOO.Formularios
{
    public partial class FrmAgregarProductos : Form
    {
        csConectaSQL conSQL = new csConectaSQL();
        gProductos gProductos;
        string cadena;
        public FrmAgregarProductos()
        {
            InitializeComponent();
        }

        private void FrmAgregarProductos_Load(object sender, EventArgs e)
        {

        }

        private void PtbCerrarFormularioAgregarProductos_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtprecioProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonGuardarAgregarProducto_Click(object sender, EventArgs e)
        {
            gProductos = new gProductos();
            cadena =
                "'" + TxtCodigoProducto.Text +
                "','" + TxtNombreProducto.Text +
                "','" + cmbCategoria.Text +
                "','" + TxtDescripcionProductos.Text +
                "','" + TxtprecioProducto.Text +
                "','" + txtcantidadProducto.Text +
                "'";
            gProductos.IngresarUsuario("Productos", "id_producto, producto, categoria, descripcion, precio_unitario,cantidad", cadena);
        }
    }
}
