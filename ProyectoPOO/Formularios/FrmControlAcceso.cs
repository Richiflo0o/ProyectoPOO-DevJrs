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
    public partial class FrmControlAcceso : Form
    {
        public FrmControlAcceso()
        {
            InitializeComponent();
        }
        private void FrmControlAcceso_Load(object sender, EventArgs e)
        {

        }
        private void FechaHoraHoy_Tick(object sender, EventArgs e)
        {
            LabelHoraHoy.Text = DateTime.Now.ToString("HH:mm:ss");
            LabelFechaHoy.Text = DateTime.Now.ToShortDateString();
        }
    }
}
