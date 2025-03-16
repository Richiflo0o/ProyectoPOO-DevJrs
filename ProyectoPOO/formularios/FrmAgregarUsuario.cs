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
            string nombre = TxtNombreSocio.Text.Trim();
            string apellido = TxtApellidoSocio.Text.Trim();
            string cedula = TxtCedulaSocio.Text.Trim();
            DateTime fechaNacimiento = DTFNacimientoSocio.Value;
            decimal peso;
            decimal altura;

            // Validaciones
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(cedula) ||
                !decimal.TryParse(TxtPesoSocio.Text, out peso) || !decimal.TryParse(TxtAlturaSocio.Text, out altura) ||
                string.IsNullOrEmpty(CmboxSexoSocio.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(TxtTelefonoSocio.Text) ||
                string.IsNullOrEmpty(TxtNDomicilioSocio.Text) ||
                string.IsNullOrEmpty(TxtEmailSocio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar formato de email
            if (!IsValidEmail(TxtEmailSocio.Text))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

            // Inserción en la base de datos
            try
            {
                using (SqlConnection conexion = new SqlConnection(@"Server=DESKTOP-ULDUU6I\SQLEXPRESS01;Database=FitMaxDB2;User =sa;Password=1234;"))
                {
                    string query = @"
            INSERT INTO Socioss (Imagen, Nombre, Apellido, Cedula, FechaNacimiento, Peso, Genero, Telefono, Altura, Objetivo, IdMembresia, Domicilio, Email)
            VALUES (@Imagen, @Nombre, @Apellido, @Cedula, @FechaNacimiento, @Peso, @Genero, @Telefono, @Altura, @Objetivo, @IdMembresia, @Domicilio, @Email)";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Imagen", imagen);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Apellido", apellido);
                        cmd.Parameters.AddWithValue("@Cedula", cedula);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                        cmd.Parameters.AddWithValue("@Peso", peso);
                        cmd.Parameters.AddWithValue("@Genero", CmboxSexoSocio.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Telefono", TxtTelefonoSocio.Text.Trim());
                        cmd.Parameters.AddWithValue("@Altura", altura);
                        cmd.Parameters.AddWithValue("@Objetivo", cmbObjetivo.Text.Trim());
                        cmd.Parameters.AddWithValue("@IdMembresia", Convert.ToInt32(CmboxCantonSocio.SelectedValue));
                        cmd.Parameters.AddWithValue("@Domicilio", TxtNDomicilioSocio.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", TxtEmailSocio.Text.Trim());

                        conexion.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                // Mensaje de éxito
                MessageBox.Show("Socio agregado exitosamente.");
                this.Close  ();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al agregar el socio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para validar el formato del correo electrónico
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        

        private void TxtEmailSocio_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureSeleccionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog SeleccionarFotoCarpetas = new OpenFileDialog
            {
                Filter = "Imagenes |*.jpg; *.png",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                Title = "Seleccionar Imagen"
            };

            if (SeleccionarFotoCarpetas.ShowDialog() == DialogResult.OK)
            {
                PictureBoxFotoSocio.Image = Image.FromFile(SeleccionarFotoCarpetas.FileName);
            }
        }

        private void PtbCerrarFormularioAgregarSocio_Click(object sender, EventArgs e)
        {
            this.Close  ();
        }
    }
}
