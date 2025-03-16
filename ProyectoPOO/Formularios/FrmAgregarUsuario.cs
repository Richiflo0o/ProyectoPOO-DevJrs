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
    public partial class FrmAgregarUsuario : Form
    {
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void BtnSiguienteTab_Click(object sender, EventArgs e)
        {
            try
            {
                csConectaSQL conexion = new csConectaSQL();

                int idPersona = Convert.ToInt32(TXTID.Text); // Suponiendo que la cédula es el IDPersona
                int idMembresia = Convert.ToInt32(CmboxCantonSocio.Text);
                decimal peso = Convert.ToDecimal(TxtPeso.Text);
                decimal altura = Convert.ToDecimal(TxtAltura.Text);
                string objetivo = cmbObjetivo.SelectedItem.ToString();
                DateTime fechaNacimiento = DTFNacimientoSocio.Value;

                bool resultado = conexion.InsertarSocio(idPersona, idMembresia, peso, altura, objetivo, fechaNacimiento);

                if (resultado)
                {
                    MessageBox.Show("Socio agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar el socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtEmailSocio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
