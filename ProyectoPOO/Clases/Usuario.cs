using AplicacionGym;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOO.Clases
{
   public class Usuario
    {
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }

        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Estado { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string TipoUsuario { get; set; }

        private csConectaSQL conexion = new csConectaSQL();

        public bool CrearUsuario()
        {
            try
            {
                if (!conexion.abrirConexion())
                {
                    MessageBox.Show("Error al abrir la conexión a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                int idPersona = -1;
                int idTipoUsuario = -1;

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexion.oCon;
                    cmd.Transaction = conexion.oCon.BeginTransaction();

                    try
                    {
                       
                        cmd.CommandText = @"
                            INSERT INTO Personas (identificacion, nombres ,apellido ,direccion ,correo, telefono, estado) 
                            VALUES (@identificacion, @nombres, @apellido, @direccion, @correo, @telefono, @estado);
                            SELECT @id_persona = SCOPE_IDENTITY();";

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@identificacion", Identificacion);
                        cmd.Parameters.AddWithValue("@nombres", Nombres);
                        cmd.Parameters.AddWithValue("@apellido", Apellido);
                        cmd.Parameters.AddWithValue("@direccion", Apellido);
                        cmd.Parameters.AddWithValue("@correo", Correo);
                        cmd.Parameters.AddWithValue("@telefono", Telefono);
                        cmd.Parameters.AddWithValue("@estado", Estado);
                        cmd.Parameters.Add(new SqlParameter("@id_persona", SqlDbType.Int) { Direction = ParameterDirection.Output });

                        cmd.ExecuteNonQuery();
                        idPersona = Convert.ToInt32(cmd.Parameters["@id_persona"].Value);

                        if (idPersona <= 0)
                        {
                            throw new Exception("No se pudo obtener el ID de la persona.");
                        }

                        
                        cmd.CommandText = "SELECT id_tipo_usuario FROM Tipos_Usuario WHERE tipo = @tipo_usuario;";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@tipo_usuario", TipoUsuario);

                        object tipoUsuarioResult = cmd.ExecuteScalar();
                        if (tipoUsuarioResult != null)
                        {
                            idTipoUsuario = Convert.ToInt32(tipoUsuarioResult);
                        }
                        else
                        {
                            cmd.CommandText = @"
                                INSERT INTO Tipos_Usuario (tipo, descripcion) 
                                VALUES (@tipo_usuario, 'Usuario del sistema');
                                SELECT SCOPE_IDENTITY();";

                            idTipoUsuario = Convert.ToInt32(cmd.ExecuteScalar());

                            if (idTipoUsuario <= 0)
                            {
                                throw new Exception("No se pudo obtener el ID del tipo de usuario.");
                            }
                        }

                        cmd.CommandText = @"
                            INSERT INTO Usuarios (id_persona, usuario, contrasena, id_tipo_usuario) 
                            VALUES (@id_persona, @usuario, @contrasena, @id_tipo_usuario);";

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id_persona", idPersona);
                        cmd.Parameters.AddWithValue("@usuario", NombreUsuario);
                        cmd.Parameters.AddWithValue("@contrasena", HashPassword(Contrasena));
                        cmd.Parameters.AddWithValue("@id_tipo_usuario", idTipoUsuario);

                        cmd.ExecuteNonQuery();

                      
                        cmd.Transaction.Commit();
                        conexion.cerrarConexion();

                        MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        conexion.cerrarConexion();
                        MessageBox.Show("Error al registrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        public bool EditarUsuario()
        {
            try
            {
                if (!conexion.abrirConexion())
                {
                    MessageBox.Show("Error al conectar con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string query = @"
                    UPDATE Personas 
                    SET nombres = @nombres, apellido = @apellido, telefono = @telefono, correo = @correo
                    WHERE identificacion = @identificacion;

                    UPDATE Usuarios 
                    SET usuario = @usuario, contrasena = @contrasena
                    WHERE id_persona = (SELECT id_persona FROM Personas WHERE identificacion = @identificacion)";

                using (SqlCommand cmd = new SqlCommand(query, conexion.oCon))
                {
                    cmd.Parameters.AddWithValue("@identificacion", Identificacion);
                    cmd.Parameters.AddWithValue("@nombres", Nombres);
                    cmd.Parameters.AddWithValue("@apellido", Apellido);
                    cmd.Parameters.AddWithValue("@telefono", Telefono);
                    cmd.Parameters.AddWithValue("@correo", Correo);
                    cmd.Parameters.AddWithValue("@usuario", NombreUsuario);
                    cmd.Parameters.AddWithValue("@contrasena", Contrasena);

                    cmd.ExecuteNonQuery();
                }

                conexion.cerrarConexion();
                MessageBox.Show("Usuario actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
