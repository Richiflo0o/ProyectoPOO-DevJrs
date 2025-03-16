using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
         
            // Recolectar datos del formulario
            string nombre = TxtNombreSocio.Text;
            string apellido = TxtApellidoSocio.Text;
            string cedula = TxtCedulaSocio.Text;
            DateTime fechaNacimiento = DTFNacimientoSocio.Value;
            decimal peso = Convert.ToDecimal(TxtPeso.Text);
            string genero = CmboxSexoSocio.SelectedItem.ToString();
            string telefono = TxtTelefonoSocio.Text;
            decimal altura = Convert.ToDecimal(TxtAltura.Text);
            string objetivo = cmbObjetivo.Text;
            int idMembresia = Convert.ToInt32(CmboxCantonSocio.SelectedValue);
            string domicilio = TxtNDomicilioSocio.Text;
            string email = TxtEmailSocio.Text;

            // Manejo de la imagen
            byte[] imagen = null;
            if (PictureBoxFotoSocio.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    PictureBoxFotoSocio.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imagen = ms.ToArray();
                }
            }
            using (SqlConnection conexion = new SqlConnection(@"Server=DESKTOP-ULDUU6I\SQLEXPRESS01;Database=FitMaxDB2;User  Id=sa;Password=1234;"))
            {
                string query = @"
            INSERT INTO Socios (Imagen, Nombre, Apellido, Cedula, FechaNacimiento, Peso, Genero, Telefono, Altura, Objetivo, IdMembresia, Domicilio, Email)
            VALUES (@Imagen, @Nombre, @Apellido, @Cedula, @FechaNacimiento, @Peso, @Genero, @Telefono, @Altura, @Objetivo, @IdMembresia, @Domicilio, @Email)";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Imagen", imagen);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@Cedula", cedula);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    cmd.Parameters.AddWithValue("@Peso", peso);
                    cmd.Parameters.AddWithValue("@Genero", genero);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@Altura", altura);
                    cmd.Parameters.AddWithValue("@Objetivo", objetivo);
                    cmd.Parameters.AddWithValue("@IdMembresia", idMembresia);
                    cmd.Parameters.AddWithValue("@Domicilio", domicilio);
                    cmd.Parameters.AddWithValue("@Email", email);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            // Mensaje de éxito
            MessageBox.Show("Socio agregado exitosamente.");
        
        }

        private void TxtEmailSocio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
