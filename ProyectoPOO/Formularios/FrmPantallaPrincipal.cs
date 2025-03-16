using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionGym;

namespace ProyectoPOO.Formularios
{
    public partial class FrmPantallaPrincipal : Form
    {
        private string tipoUsuario; 

        public FrmPantallaPrincipal(string tipoUsuario)
        {
            InitializeComponent();
            this.tipoUsuario = tipoUsuario; 
            ConfigurarInterfaz(); 
        }

        public FrmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            FrmControlAcceso controlAcceso = new FrmControlAcceso();
            AbrirFormulariosHijas(controlAcceso);
        }
        //
        //
        //
        private void PtbCerrarFormularioPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
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
        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //
        //
        //
        private void tsmiListaDeUsuarios_Click(object sender, EventArgs e)
        {
            FrmAgregarPerfil agregarPerfil = new FrmAgregarPerfil();
            agregarPerfil.TopLevel = false;
            agregarPerfil.FormBorderStyle = FormBorderStyle.None;
            agregarPerfil.Dock = DockStyle.Fill;
            pciContenedor.Controls.Clear();
            AbrirFormulariosHijas(agregarPerfil);
        }

        private void tsmiListadoDeUsuarios_Click(object sender, EventArgs e)
        {
            FrmListadoUsuario listadousaurio = new FrmListadoUsuario();
            listadousaurio.Show();
            this.Hide();
        }
        private void ConfigurarInterfaz()
        {
            if (tipoUsuario == "Usuario")
            {
                tsmiPerfilUsuarios.Visible = false;
                tsmiUsuarios.Visible = false;
                tsmiEstadisticas.Visible = false;
            }
            else if (tipoUsuario == "Administrador")
            {

            }
        }
        //
        //Paner Interfaces
        //
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
                Formularios.FormBorderStyle = FormBorderStyle.None;
                this.pciContenedor.Controls.Add(Formularios);
                this.pciContenedor.Tag = Formularios;
                Formularios.Show();
            }
        }

        private void pciContenedor_Paint(object sender, PaintEventArgs e)
        {
            if (this.pciContenedor.Controls.Count == 0)
            {
                FrmControlAcceso ControlAccesoVer = new FrmControlAcceso();
                pciContenedor.Controls.Clear();
                AbrirFormulariosHijas(ControlAccesoVer);
            }
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario agregarusario = new FrmAgregarUsuario();
            agregarusario.TopLevel = false;
            agregarusario.FormBorderStyle = FormBorderStyle.None;
            agregarusario.Dock = DockStyle.Fill;
            pciContenedor.Controls.Clear();
            AbrirFormulariosHijas(agregarusario);

        }

        private void tsmiNuevoInstructor_Click(object sender, EventArgs e)
        {
            FrmNuevoInstructor VerFormularioNuevoInstructor = new FrmNuevoInstructor();
            VerFormularioNuevoInstructor.TopLevel = false;
            VerFormularioNuevoInstructor.FormBorderStyle = FormBorderStyle.None;
            VerFormularioNuevoInstructor.Dock = DockStyle.Fill;
            pciContenedor.Controls.Clear();
            AbrirFormulariosHijas(VerFormularioNuevoInstructor);
        }
    }
}


