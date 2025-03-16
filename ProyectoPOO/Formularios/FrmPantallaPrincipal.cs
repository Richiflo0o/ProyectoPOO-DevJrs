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
        private string tipoUsuario; 

        public FrmPantallaPrincipal(string tipoUsuario)
        {
            InitializeComponent();
            this.tipoUsuario = tipoUsuario; 
            ConfigurarInterfaz(); 
        }
        private void PtbCerrarFormularioPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiListaDeUsuarios_Click(object sender, EventArgs e)
        {
            FrmAgregarPerfil crearperfil = new FrmAgregarPerfil();
            crearperfil.Show();
            this.Hide();
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
        }
}
