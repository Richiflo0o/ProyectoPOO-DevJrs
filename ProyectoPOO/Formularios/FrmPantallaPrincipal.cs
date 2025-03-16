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
    public partial class FrmPantallaPrincipal : Form
    {
        public FrmPantallaPrincipal()
        {
            InitializeComponent();
        }
        private void AbrirFormulariosHijas(object formulariosHijos)
        {
            if (formulariosHijos == null)
                return;

            if (this.pciContenedor.Controls.Count > 0)
            {
                this.pciContenedor.Controls.RemoveAt(0);
            }

            Form Formularios = formulariosHijos as Form;
            if (Formularios != null)
            {
                Formularios.TopLevel = false;
                Formularios.Dock = DockStyle.Fill;
                this.pciContenedor.Controls.Add(Formularios);
                this.pciContenedor.Tag = Formularios;
                Formularios.Show();
            }
        }

        private void FrmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            FrmControlAcceso ControlAccesoVer = new FrmControlAcceso();
            ControlAccesoVer.TopLevel = false;
            ControlAccesoVer.FormBorderStyle = FormBorderStyle.None;
            ControlAccesoVer.Dock = DockStyle.Fill;
            AbrirFormulariosHijas(ControlAccesoVer);
        }
        //Panel de Control
        private void ptbMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void PtbCerrarFormularioPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
