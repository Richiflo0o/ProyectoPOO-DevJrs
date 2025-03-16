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
    public partial class FrmMembresia : Form
    {
        public FrmMembresia()
        {
            InitializeComponent();
        }

        private void PtbCerrarFrmMembresia_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
