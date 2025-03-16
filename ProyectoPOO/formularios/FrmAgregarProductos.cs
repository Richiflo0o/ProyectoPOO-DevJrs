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
            // Validación para el campo Precio
            decimal precio;
            if (!decimal.TryParse(TxtprecioProducto.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Por favor ingrese un precio válido (número decimal positivo).");
                return; // Si la validación falla, salir del método
            }

            // Validación para que el precio tenga hasta dos decimales
            if (precio != Math.Round(precio, 2))
            {
                MessageBox.Show("El precio debe tener como máximo dos decimales.");
                return; // Si la validación falla, salir del método
            }

            // Si las validaciones son correctas, proceder con la inserción
            gProductos = new gProductos();
            cadena =
                "'" + TxtCodigoProducto.Text +
                "','" + TxtNombreProducto.Text +
                "','" + cmbCategoria.Text +
                "','" + TxtDescripcionProductos.Text +
                "','" + TxtprecioProducto.Text +
                "','" + txtcantidadProducto.Text +
                "'";

            gProductos.IngresarUsuario("Productos", "id_producto, producto, categoria, descripcion, precio_unitario,cantidad,estado = DEFAULT", cadena);
        }
    }
}
