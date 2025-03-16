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

    }

}

