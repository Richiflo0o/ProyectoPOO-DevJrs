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
    public partial class FrmListadoUsuario : Form
    {
        public FrmListadoUsuario()
        {
            InitializeComponent();
        }

        private void DGVListadoUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrarListadoPerfil_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
