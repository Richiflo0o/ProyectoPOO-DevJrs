using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionGym
{
    public class csConectaSQL
    {
        public SqlConnection oCon;
        public SqlCommand oCom;
        public SqlDataReader oDR;
        public SqlDataAdapter oDA;
        public DataTable oDT;

        string Server;
        string Database;
        string Usuario;
        string Clave;

        public csConectaSQL()
        {
            Server = @"DESKTOP-ULDUU6I\SQLEXPRESS01";
            Database = "FitMaxDB2";
            Usuario = "sa";
            Clave = "1234";
        }

        public bool abrirConexion()
        {
            try
            {
                oCon = new SqlConnection($"Server={Server}; Database={Database}; User id={Usuario}; Password={Clave}");
                oCon.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool cerrarConexion()
        {
            try
            {
                if (oCon != null && oCon.State == ConnectionState.Open)
                    oCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool InsertarSocio(int idPersona, int idMembresia, decimal peso, decimal altura, string objetivo, DateTime fechaNacimiento)
        {
            try
            {
                if (abrirConexion())
                {
                    string query = "INSERT INTO Socios (IDPersona, IDMembresia, Peso, Altura, Objetivo, FechaNacimiento) " +
                                   "VALUES (@IDPersona, @IDMembresia, @Peso, @Altura, @Objetivo, @FechaNacimiento)";

                    oCom = new SqlCommand(query, oCon);
                    oCom.Parameters.AddWithValue("@IDPersona", idPersona);
                    oCom.Parameters.AddWithValue("@IDMembresia", idMembresia);
                    oCom.Parameters.AddWithValue("@Peso", peso);
                    oCom.Parameters.AddWithValue("@Altura", altura);
                    oCom.Parameters.AddWithValue("@Objetivo", objetivo);
                    oCom.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);

                    int filasAfectadas = oCom.ExecuteNonQuery();
                    cerrarConexion();

                    return filasAfectadas > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar socio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }

}

