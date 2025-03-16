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
        string Cadena;
        public csConectaSQL()
        {
            Server = @"DDESKTOP-22RT09N\SQLEXPRESS";
            Database = "FitMaxBD";
            Usuario = "sa";
            Clave = "123456";
        }

        public csConectaSQL(string Server, string Database, string Usuario, string Clave)
        {
            this.Server = Server;
            this.Database = Database;
            this.Usuario = Usuario;
            this.Clave = Clave;
        }

        public bool abrirConexion()
        {
            oCon = new SqlConnection();
            try
            {
                oCon.ConnectionString = Cadena = "Server=" + Server + "; Database=" + Database + "; User id=" + Usuario.Trim() + "; Password=" + Clave;
                oCon.Open();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool cerrarConexion()
        {
            oCon.Close();
            return true;
        }

        public bool eliminarDatos(string Tabla, string Condicion)
        {
            try
            {
                abrirConexion();
                Cadena = "Delete " + Tabla + " where " + Condicion;
                oCom = new SqlCommand(Cadena, oCon);
                oCom.ExecuteNonQuery();
                cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool ModificarDatos(string cadena)
        {
            try
            {
                abrirConexion();
                oCom = new SqlCommand(cadena, oCon);
                oCom.ExecuteNonQuery();
                cerrarConexion();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }



        public bool insertarDatos(string Tabla, string Campos, string Datos)
        {
            abrirConexion();
            Cadena = "Insert into " + Tabla + " (" + Campos + ") values( " + Datos + ")";
            oCom = new SqlCommand(Cadena, oCon);
            oCom.ExecuteNonQuery();
            cerrarConexion();
            return true;
        }

        public bool ejecutarSQL(string Sentencia)
        {
            abrirConexion();
            oCom = new SqlCommand(Sentencia, oCon);
            oCom.ExecuteNonQuery();
            cerrarConexion();
            return true;
        }


        public int retornaValor(string Seleccion, string Tabla, string Condicion)
        {
            int temporal;
            abrirConexion();
            Cadena = "Select isnull(cast(" + Seleccion + " as int),0) from " + Tabla + " where " + Condicion;
            oCom = new SqlCommand(Cadena, oCon);
            oDR = oCom.ExecuteReader();
            oDR.Read();
            temporal = (int)oDR[0];
            oDR.Close();
            cerrarConexion();
            return temporal;
        }

        public String retornaCadena(string Seleccion, string Tabla, string Condicion)
        {
            string temporal;
            abrirConexion();
            Cadena = "Select isnull(cast(" + Seleccion + " as varchar(200)),'') from " + Tabla + " where " + Condicion;
            oCom = new SqlCommand(Cadena, oCon);
            oDR = oCom.ExecuteReader();

            if (oDR.Read())
            {
                temporal = (String)oDR[0];
            }
            else
            {
                temporal = "";
            }
            oDR.Close();
            cerrarConexion();
            return temporal;
        }

        public string retornaCadenaConsulta(string Consulta)
        {
            string temporal;
            abrirConexion();
            oCom = new SqlCommand(Consulta, oCon);
            oDR = oCom.ExecuteReader();
            oDR.Read();
            temporal = (string)oDR[0];
            oDR.Close();
            cerrarConexion();
            return temporal;
        }
        public int InsertarSocioYRetornarID(string Tabla, string Campos, string Datos)
        {
            int idGenerado = -1; // Variable para almacenar el ID generado
            try
            {
                abrirConexion();


                string queryInsert = $"INSERT INTO {Tabla} ({Campos}) VALUES ({Datos});";
                oCom = new SqlCommand(queryInsert, oCon);
                oCom.ExecuteNonQuery();


                string queryID = "SELECT SCOPE_IDENTITY();";
                oCom = new SqlCommand(queryID, oCon);
                oDR = oCom.ExecuteReader();

                if (oDR.Read())
                {
                    idGenerado = Convert.ToInt32(oDR[0]);
                }

                oDR.Close();
                cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return idGenerado;
        }



        public decimal retornaValorConsulta(string Consulta)
        {
            decimal temporal;
            abrirConexion();
            oCom = new SqlCommand(Consulta, oCon);
            oDR = oCom.ExecuteReader();
            oDR.Read();
            temporal = (decimal)oDR[0];
            oDR.Close();
            cerrarConexion();
            return temporal;
        }

        public DataTable retornaRegistros(string Sentencia)
        {
            try
            {
                if (Sentencia.Length > 0)
                {
                    abrirConexion();
                    oCom = new SqlCommand(Sentencia, oCon);
                    oDA = new SqlDataAdapter(oCom);
                    oDT = new DataTable();
                    oDA.Fill(oDT);
                    cerrarConexion();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return oDT;
        }
        public void LlenarComboBox(ComboBox cmb, string Seleccion, string Tabla)
        {
            try
            {
                abrirConexion();

                string Cadena = $"SELECT {Seleccion}  FROM {Tabla}";

                SqlCommand oCom = new SqlCommand(Cadena, oCon);
                SqlDataReader oDR = oCom.ExecuteReader();

                cmb.Items.Clear();

                while (oDR.Read())
                {
                    cmb.Items.Add(oDR[0].ToString());
                }

                oDR.Close();
                cerrarConexion();
            }
            catch
            {
                MessageBox.Show("Upsss algo salio mal vuelve a intentarlo");
            }
        }
        public bool ExisteCedula(string cedula)
        {
            bool existe = false;
            string query = $"SELECT COUNT(*) FROM Socio WHERE Cedula = '{cedula}'";

            try
            {
                abrirConexion();
                oCom = new SqlCommand(query, oCon);
                int count = (int)oCom.ExecuteScalar();
                existe = count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar la cédula: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cerrarConexion();
            }

            return existe;
        }
        public void CancelarPago(int idPago)

        {

            csConectaSQL conexion = new csConectaSQL();

            string condicion = $"IdPago = {idPago}"; // Cambia "IdPago" por el nombre real de la columna que identifica el pago

            string sentencia = $"UPDATE Pagos SET Estado = 'Cancelado' WHERE {condicion}"; // Cambia "Pagos" y "Estado" según tu estructura


            if (conexion.ModificarDatos(sentencia))

            {

                MessageBox.Show("Pago cancelado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else

            {

                MessageBox.Show("Error al cancelar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}

