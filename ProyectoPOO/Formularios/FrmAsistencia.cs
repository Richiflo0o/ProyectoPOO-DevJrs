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
    public partial class FrmAsistencia : Form
    {
        csConectaSQL sQL= new csConectaSQL();
        public FrmAsistencia()
        {
            InitializeComponent();
        }
        private void FrmAsistencia_Load(object sender, EventArgs e)
        {
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBuscador_KeyUp(object sender, KeyEventArgs e)
        {
        }
    }
}
