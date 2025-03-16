using AplicacionGym.Clases;
using ProyectoPOO.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionGym
{
    public partial class FrmListadoPerFilUsuario : Form
    {
        csConectaSQL conectar = new csConectaSQL();
        gUsuarios gUsuario = new gUsuarios();
        private int tp = 0;
        public FrmListadoPerFilUsuario()
        {
            InitializeComponent();
        }
        private void txtFiltroPerfil_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtFiltroPerfil.Text.Length > 0)
                {
                    switch (cmbFiltroPerfil.Text)
                    {
                        case "Nombre":
                            DGVListadoPerfilUsuario.DataSource = conectar.retornaRegistros("Select PUsuarioID,Nombre,Apellido,Telefono,Email,PerfilUsuario from PerfilesUsuarios where Nombre like '" + txtFiltroPerfil.Text + "%'");
                            break;
                        case "Apellido":
                            DGVListadoPerfilUsuario.DataSource = conectar.retornaRegistros("Select PUsuarioID,Nombre,Apellido,Telefono,Email,PerfilUsuario from PerfilesUsuarios where Apellido like '" + txtFiltroPerfil.Text + "%'");
                            break;
                        case "ID de Usuario":
                            DGVListadoPerfilUsuario.DataSource = conectar.retornaRegistros("Select PUsuarioID,Nombre,Apellido,Telefono,Email,PerfilUsuario from PerfilesUsuarios where UsuarioID like '" + txtFiltroPerfil.Text + "%'");
                            break;
                        case "Correo":
                            DGVListadoPerfilUsuario.DataSource = conectar.retornaRegistros("Select PUsuarioID,Nombre,Apellido,Telefono,Email,PerfilUsuario from PerfilesUsuarios where Email like '" + txtFiltroPerfil.Text + "%'");
                            break;
                    }
                }
                if (txtFiltroPerfil.Text.Length == 0)
                {
                    DGVListadoPerfilUsuario.DataSource = conectar.retornaRegistros("Select PUsuarioID,Nombre,Apellido,Telefono,Email,PerfilUsuario from PerfilesUsuarios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void btnEliminarPerfil_Click(object sender, EventArgs e)
        {
            if (DGVListadoPerfilUsuario.RowCount > 0)
            {
                DialogResult opc = MessageBox.Show(this, "Se eliminará la fila "
                    + DGVListadoPerfilUsuario.CurrentRow.Index + ", que pertenece al Usuario "
                    + DGVListadoPerfilUsuario[0, DGVListadoPerfilUsuario.CurrentRow.Index].Value.ToString(), "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opc == DialogResult.Yes)
                {
                    gUsuario.EliminarUsuario("PerfilesUsuarios", "Nombre='" + DGVListadoPerfilUsuario[1, DGVListadoPerfilUsuario.CurrentRow.Index].Value.ToString() + "'");
                    DGVListadoPerfilUsuario.DataSource = conectar.retornaRegistros("Select PUsuarioID,Nombre,Apellido,Telefono,Email,PerfilUsuario from PerfilesUsuarios");
                }
            }
        }
        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            if (DGVListadoPerfilUsuario.SelectedRows.Count > 0) 
            {
                int filaIndex = DGVListadoPerfilUsuario.CurrentRow.Index; 
                int tp = 0;
                FrmAgregarPerfil ModificarRegistroUsuario = new FrmAgregarPerfil();
                this.AddOwnedForm(ModificarRegistroUsuario);
                ModificarRegistroUsuario.tp = 1;

                if (DGVListadoPerfilUsuario.Columns.Count >= 9)
                {
                    ModificarRegistroUsuario.LabelNuevoUsuario.Font = new Font("Impact", 15.75F);
                    ModificarRegistroUsuario.LabelNuevoUsuario.Text = "MODIFICAR USUARIO";
                    ModificarRegistroUsuario.TxtBoxNombreUsuario.Text = DGVListadoPerfilUsuario[1, filaIndex].Value?.ToString() ?? "";
                    ModificarRegistroUsuario.TxtBoxApellidoUsuario.Text = DGVListadoPerfilUsuario[2, filaIndex].Value?.ToString() ?? "";
                    ModificarRegistroUsuario.TxtBoxTelefonoUsuario.Text = DGVListadoPerfilUsuario[3, filaIndex].Value?.ToString() ?? "";
                    ModificarRegistroUsuario.TxtBoxDomicilioUsuario.Text = DGVListadoPerfilUsuario[4, filaIndex].Value?.ToString() ?? "";
                    ModificarRegistroUsuario.TxtBoxUsuarioUsuario.Text = DGVListadoPerfilUsuario[5, filaIndex].Value?.ToString() ?? "";
                    ModificarRegistroUsuario.TxtBoxMailUsuario.Text = DGVListadoPerfilUsuario[6, filaIndex].Value?.ToString() ?? "";
                    ModificarRegistroUsuario.TxtBoxContraseñaUsuario.Text = DGVListadoPerfilUsuario[7, filaIndex].Value?.ToString() ?? "";
                    ModificarRegistroUsuario.ComboBoxPerfilUsuario.Text = DGVListadoPerfilUsuario[8, filaIndex].Value?.ToString() ?? "";
                    ModificarRegistroUsuario.lbldondevaelid.Text = DGVListadoPerfilUsuario[0, filaIndex].Value?.ToString() ?? "";

                    ModificarRegistroUsuario.Show();
                }
                else
                {
                    MessageBox.Show("Error: La estructura de la tabla no coincide con los datos esperados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAñadirPerfil_Click(object sender, EventArgs e)
        {
            int tp = 0;
            FrmAgregarPerfil VerFormularioAgregarPerfil = new FrmAgregarPerfil();
            this.AddOwnedForm(VerFormularioAgregarPerfil);
            VerFormularioAgregarPerfil.tp = tp;
            VerFormularioAgregarPerfil.Show();
        }
        private void btnCerrarListadoPerfil_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ListadoUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                // Configurar el estilo del DataGridView a "Times New Roman"
                DGVListadoPerfilUsuario.DefaultCellStyle.Font = new Font("Times New Roman", 12);
                DGVListadoPerfilUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajustar columnas

                // Cargar los datos en el DataGridView
                DGVListadoPerfilUsuario.DataSource = conectar.retornaRegistros("SELECT PUsuarioID, Nombre, Apellido, Telefono, Email, PerfilUsuario FROM PerfilesUsuarios");
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void DGVListadoPerfilUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DGVListadoPerfilUsuario.ClearSelection();

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DGVListadoPerfilUsuario.CurrentCell = DGVListadoPerfilUsuario.Rows[e.RowIndex].Cells[e.ColumnIndex];
                DGVListadoPerfilUsuario.CurrentCell.Selected = true;
            }
        }

        private void DGVListadoPerfilUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}